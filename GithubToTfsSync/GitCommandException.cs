using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace SpaceTraffic.GithubToTfsSync
{
    [Serializable]
    public class GitCommandException : Exception
    {
        public GitCommandException(String arguments, int exitCode, String stdOut, String stdErr)
            : base (String.Format("git {0} has failed with code {1}.\n\nStdOut:\n{2}\n\nStdErr:\n{3}", arguments, exitCode, stdOut, stdErr))
        {
            
        }
    }
}