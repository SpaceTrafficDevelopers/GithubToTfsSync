using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibGit2Sharp;
using System.Diagnostics;
using System.IO;

namespace SpaceTraffic.GithubToTfsSync
{
    /// <summary>
    /// GitSync handles mirroring from remote Git repository to local repository.
    /// 
    /// The synchronization has to be triggered from external source, such as web hook.
    /// </summary>
    public class GitSync
    {
        /// <summary>
        /// Path to the local mirror cache repository.
        /// </summary>
        private String cacheRepositoryPath;

        /// <summary>
        /// Configuration of remotes - source and target repositories.
        /// </summary>
        private MirrorConfiguration mirrorConfiguration;

        /// <summary>
        /// Initializes the synchronization object.
        /// </summary>
        /// <param name="cacheRepositoryPath"></param>
        /// <param name="mirrorConfiguration"></param>
        public GitSync(String cacheRepositoryPath, MirrorConfiguration mirrorConfiguration)
        {
            this.cacheRepositoryPath = cacheRepositoryPath;
            this.mirrorConfiguration = mirrorConfiguration;
        }



        /// <summary>
        /// Synchronizes the specified branch from remote repository to local TFS repository.
        /// </summary>
        public void SynchronizeRepository()
        {
            Trace.CorrelationManager.StartLogicalOperation();
            bool valid = Repository.IsValid(cacheRepositoryPath);
            if (!valid)
            {
                Trace.TraceInformation("Local cache invalid, recreating the repository.");
                CloneRemote();
                SetupMirror();
            }

            UpdateRepository();
            Trace.TraceInformation("Repository updated.");
            Trace.CorrelationManager.StopLogicalOperation();
        }

        /// <summary>
        /// Clones the source remote repository.
        /// </summary>
        private void CloneRemote()
        {
            var directoryName = Path.GetFileName(cacheRepositoryPath);
            var parentPath = Directory.GetParent(cacheRepositoryPath).FullName;
            RunGitCommand(String.Format("clone --mirror {0} {1}", mirrorConfiguration.SourceRepository.Url, directoryName), parentPath);
        }

        /// <summary>
        /// Registers all remotes in the mirror repository.
        /// </summary>
        private void SetupMirror()
        {
            foreach (TargetRepository targetRepository in mirrorConfiguration.TargetRepositories)
            {
                string remoteName = FormatRemoteName(targetRepository.Id);
                RunGitCommand(String.Format("remote add {0} {1}", remoteName, targetRepository.Url));
            }
        }

        /// <summary>
        /// Fetches from the source repository and mirrors everything to the target repositories.
        /// </summary>
        private void UpdateRepository()
        {
            RunGitCommand("fetch -p origin");
            foreach (TargetRepository targetRepository in mirrorConfiguration.TargetRepositories)
            {
                string remoteName = FormatRemoteName(targetRepository.Id);
                RunGitCommand(String.Format("push --mirror {0}", remoteName));
            }
        }

        /// <summary>
        /// Runs a git executable in the directory with the local mirror repository cache.
        /// </summary>
        /// <param name="arguments"></param>
        private void RunGitCommand(String arguments)
        {
            RunGitCommand(arguments, cacheRepositoryPath);
        }

        /// <summary>
        /// Runs a git executable in the specified working directory.
        /// </summary>
        /// <param name="arguments">Arguments for the git executable (including a name of the git command).</param>
        /// <param name="workingDirectory">Working directory.</param>
        private void RunGitCommand(String arguments, String workingDirectory)
        {
            Trace.CorrelationManager.StartLogicalOperation();
            Process p = new Process
            {
                StartInfo =
                {
                    FileName = "git",
                    Arguments = arguments,
                    WorkingDirectory = workingDirectory,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false
                }
            };
            Trace.TraceInformation("Running git {0} in directory {1}.", arguments, workingDirectory);
            p.Start();

            String stdOut = p.StandardOutput.ReadToEnd();
            String stdErr = p.StandardError.ReadToEnd();
            p.WaitForExit();

            try
            {
                if (p.ExitCode != 0)
                {
                    throw new GitCommandException(arguments, p.ExitCode, stdOut, stdErr);
                }
            }
            finally
            {
                Trace.TraceInformation("Process exitted with {0}", p.ExitCode);
                Trace.TraceInformation("Process stdout:\n{0}", stdOut);
                Trace.TraceInformation("Process stderr:\n{0}", stdErr);
                Trace.CorrelationManager.StopLogicalOperation();
            }
        }

        /// <summary>
        /// Formats a name of the remote.
        /// </summary>
        /// <param name="targetId">ID of target repository.</param>
        /// <returns>Name of the remote.</returns>
        private String FormatRemoteName(String targetId)
        {
            return String.Format("target_{0}", targetId);
        }
    }
}