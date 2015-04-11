using System.Diagnostics;

namespace SpaceTraffic.GithubToTfsSync.EventHandlers
{
    /// <summary>
    /// Ping event handler.
    /// </summary>
    public class PingEventHandler : IWebhookEventHandler
    {
        /// <summary>
        /// Responds to the ping event data.
        /// </summary>
        /// <param name="payload">JSON payload of the request.</param>
        /// <returns>Response object.</returns>
        public dynamic HandleEvent(dynamic payload)
        {
            string zen = payload.zen;
            Trace.TraceInformation("Random github zen: {0}", zen);
            return new
            {
                success = true,
                zen
            };
        }
    }
}