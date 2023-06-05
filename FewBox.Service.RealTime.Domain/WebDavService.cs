using System.IO;
using System.Net;
using System.Threading.Tasks;
using FewBox.Service.RealTime.Model.Configs;
using FewBox.Service.RealTime.Model.Services;
using Microsoft.Extensions.Logging;
using WebDav;

namespace FewBox.Service.RealTime.Domain
{
    public class WebDavService : IWebDavService
    {
        private RealtimeConfig RealtimeConfig { get; set; }
        private ILogger Logger { get; set; }
        public WebDavService(RealtimeConfig realtimeConfig, ILogger<WebDavService> logger)
        {
            this.RealtimeConfig = realtimeConfig;
            this.Logger = logger;
        }
        public async Task<bool> UploadFile(string fileName, byte[] bytes)
        {
            var clientParams = new WebDavClientParams
            {
                Credentials = new NetworkCredential(this.RealtimeConfig.WebDav.UserName, this.RealtimeConfig.WebDav.Password)
            };
            using (IWebDavClient webDavClient = new WebDavClient(clientParams))
            {
                using (MemoryStream imageStream = new MemoryStream(bytes))
                {
                    string requestUri = $"{this.RealtimeConfig.WebDav.Url}/{fileName}";
                    var result = await webDavClient.PutFile(requestUri, imageStream);
                    if (result.IsSuccessful)
                    {
                        // Do Nothing
                    }
                    else
                    {
                        this.Logger.LogError(result.StatusCode, result.Description);
                    }
                    return result.IsSuccessful;
                }
            }
        }
    }
}