using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpaceTraffic.GithubToTfsSync.EventHandlers
{
    public class PushEventHandler : IWebhookEventHandler
    {
        private GitSync gitSync;


        public PushEventHandler(GitSync gitSync)
        {
            this.gitSync = gitSync;
        }


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