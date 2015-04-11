using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SpaceTraffic.GithubToTfsSync
{
    /// <summary>
    /// Interface for the webhook event handler.
    /// </summary>
    interface IWebhookEventHandler
    {
        /// <summary>
        /// Handles the event.
        /// </summary>
        /// <param name="payload">Decoded JSON payload of the event.</param>
        /// <returns>Response object, that will be encoded to JSON.</returns>
        dynamic HandleEvent(dynamic payload);
    }
}
