using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceTraffic.GithubToTfsSync.EventHandlers
{
    /// <summary>
    /// Handles the push webhook event - updates mirrored repositories.
    /// </summary>
    public class PushEventHandler : IWebhookEventHandler
    {
        private GitSync gitSync;

        /// <summary>
        /// Initializes the event handler.
        /// </summary>
        /// <param name="gitSync">Object that will be used to synchronize repositories.</param>
        public PushEventHandler(GitSync gitSync)
        {
            this.gitSync = gitSync;
        }


        /// <summary>
        /// Handles the push event - updates mirrored repostories.
        /// </summary>
        /// <param name="payload">Request payload, currently not used as all branches and tags are updated in bulk.</param>
        /// <returns>Response object on success.</returns>
        public dynamic HandleEvent(dynamic payload)
        {
            gitSync.SynchronizeRepository();

            return new
            {
                success = true
            };
        }
    }
}