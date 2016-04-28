using Newtonsoft.Json;
using SteamSpySharp.Models;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace SteamSpySharp
{
    public class ApiClient
    {
        public static readonly string DefaultEndpoint = "http://steamspy.com/";

        private HttpClient httpClient;

        public ApiClient() :  this(DefaultEndpoint)
        {
        }

        public ApiClient(string apiEndpoint)
        {
            this.httpClient = new HttpClient();
            this.httpClient.BaseAddress = new Uri(apiEndpoint);
        }

        public async Task<AppDetails> GetAppDetailsAsync(int appId)
        {
            var result = await this.httpClient.GetStringAsync("api.php?request=appdetails&appid=" + appId.ToString());

            using (StringReader stringReader = new StringReader(result))
            {
                using (JsonTextReader jsonReader = new JsonTextReader(stringReader))
                {
                    var serializer = new JsonSerializer();
                    return serializer.Deserialize<AppDetails>(jsonReader);
                }
            }
        }
    }
}   
