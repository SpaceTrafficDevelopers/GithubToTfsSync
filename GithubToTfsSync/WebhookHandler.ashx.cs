using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Helpers;
using System.Web.Routing;
using System.Web.Services.Protocols;
using SpaceTraffic.GithubToTfsSync.EventHandlers;

namespace SpaceTraffic.GithubToTfsSync
{
    /// <summary>
    /// Summary description for WebhookHandler
    /// </summary>
    public class WebhookHandler : IHttpHandler
    {
        private const int S400_BAD_REQUEST = 400;
        private const int S500_INTERNAL_ERROR = 500;

        private byte[] webhookSecret;

        private GitSync gitSync;

        private Dictionary<String, IWebhookEventHandler> eventHandlers;

        /// <summary>
        /// Initializes the handler and loads application configuration.
        /// </summary>
        public WebhookHandler()
        {
            String secret = WebConfigurationManager.AppSettings.Get("webhookSecret");
            if (!String.IsNullOrEmpty(secret))
            {
                webhookSecret = Encoding.UTF8.GetBytes(secret);
            }
            gitSync = CreateGitSync();
            InitializeEventHandlers();
        }


        /// <summary>
        /// Loads the application 
        /// </summary>
        private GitSync CreateGitSync()
        {
            string cachePath = WebConfigurationManager.AppSettings.Get("cacheRepositoryPath");
            MirrorConfiguration configuration = WebConfigurationManager.GetSection("mirrorConfiguration") as MirrorConfiguration;

            return new GitSync(cachePath, configuration);
        }

        private void InitializeEventHandlers()
        {
            eventHandlers = new Dictionary<string, IWebhookEventHandler>()
            {
                {"ping", new PingEventHandler()},
                {"push", new PushEventHandler(gitSync)}
            };
        }


        public void ProcessRequest(HttpContext context)
        {
            var request = context.Request;
            var response = context.Response;

            try
            {
                Trace.TraceInformation("Started processing the request.");

                string eventName = request.Headers.Get("X-Github-Event");
                string signature = request.Headers.Get("X-Hub-Signature");

                byte[] body = ReadPostData(request);

                if (webhookSecret != null)
                {
                    ValidateMessageDigest(signature, body, webhookSecret);
                }

                String bodyString = Encoding.UTF8.GetString(body);
                dynamic payload = Json.Decode(bodyString);

                ProcessEvent(response, eventName, payload);
            }
            catch (InvalidRequestException e)
            {
                Trace.TraceError(e.ToString());
                SendError(response, S400_BAD_REQUEST, e.Message);
            }
            catch (Exception e)
            {
                Trace.TraceError(e.ToString());
                SendError(response, S500_INTERNAL_ERROR, e.Message);
            }
            finally
            {
                Trace.TraceInformation("Finished processing the request.");
            }
        }

        private byte[] ReadPostData(HttpRequest request)
        {
            if (request.HttpMethod == "POST")
            {
                // Reset the input stream position.
                request.InputStream.Seek(0, SeekOrigin.Begin);
                // Read the whole message.
                byte[] body;
                using (var memoryStream = new MemoryStream())
                {
                    request.InputStream.CopyTo(memoryStream);
                    body = memoryStream.ToArray();
                }
                return body;
            }
            else
            {
                throw new InvalidRequestException("Webhook handler accepts only POST requests.");
            }
        }

        /// <summary>
        /// Validates the message signature.
        /// </summary>
        /// <param name="signature">Signature string in format [&lt;algo&gt;=]&lt;hex&gt, i.e. "sha1=0011..."</param>
        /// <param name="message">Bytes of the message.</param>
        /// <param name="secret">String used as the secret.</param>
        public void ValidateMessageDigest(string signature, byte[] message, byte[] secret)
        {
            if (string.IsNullOrEmpty(signature))
            {
                throw new InvalidRequestException("Missing required request signature. Please use the X-Hub-Signature header.");
            }
            
            var hmac = ExtractAndCreateHmac(ref signature);
            hmac.Key = secret;

            byte[] hash = hmac.ComputeHash(message);

            var signatureBinary = SoapHexBinary.Parse(signature);
            if (!signatureBinary.Value.SequenceEqual(hash))
            {
                throw new InvalidRequestException("Invalid message signature.");
            }
        }

        /// <summary>
        /// Extracts HMAC algorithm from signature string
        /// </summary>
        /// <param name="signature">Signature string in format [&lt;algo&gt;=]&lt;hex&gt, i.e. "sha1=0011..."</param>
        /// <returns>Instance of selected HMAC implementation. If algorithm is not specified in the signature string, SHA1 is used.</returns>
        private static HMAC ExtractAndCreateHmac(ref string signature)
        {
            HMAC hmac;
            if (signature.Contains('='))
            {
                int pos = signature.IndexOf('=');
                string algo = signature.Substring(0, pos);
                signature = signature.Substring(pos + 1);
                hmac = HMAC.Create(String.Format("HMAC{0}", algo.ToUpper()));

                if (hmac == null)
                {
                    throw new InvalidRequestException("Unsupported HMAC algorithm.");
                }
            }
            else
            {
                hmac = new HMACSHA1();
            }
            return hmac;
        }

        public void ProcessEvent(HttpResponse response, String eventName, dynamic payload)
        {
            if (eventName == null)
            {
                throw new InvalidRequestException("No event specified, please use the X-Github-Event header.");
            }
            if (eventHandlers.ContainsKey(eventName))
            {
                Trace.TraceInformation("Invoking the {0} event handler.", eventName);
                dynamic result = eventHandlers[eventName].HandleEvent(payload);
                SendJson(response, result);
            }
            else
            {
                throw new InvalidRequestException(String.Format("Invalid event type: {0}", eventName));
            }
        }


        public void SendError(HttpResponse response, int statusCode, string message)
        {
            object responseObject = new
            {
                error = true,
                message
            };
            response.StatusCode = statusCode;
            SendJson(response, responseObject);
        }

        /// <summary>
        /// Sends a JSON response.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="responseObject"></param>
        protected void SendJson(HttpResponse response, Object responseObject)
        {
            response.ContentType = "application/json";
            response.Write(Json.Encode(responseObject));
        }

        /// <summary>
        /// The handler is reusable, no state is persisted between webhook calls.
        /// </summary>
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}