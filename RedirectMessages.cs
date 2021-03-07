using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace AzureTbleStrgFunc
{
    public static class RedirectMessages
    {
       /* private static HttpClient client = new HttpClient();

        [FunctionName("RedirectMessages")]
        public static async Task Run([IoTHubTrigger("messages/events", Connection = "IotHubConnection1")]EventData message, ILogger log)
        {
            switch (message.Properties["type"])
            {
                case "dht":
                    await client.PostAsJsonAsync("https://iot20-func.azurewebsites.net/api/HandleDhtData", Encoding.UTF8.GetString(message.Body.Array));
                    break;
                case "Location":
                    await client.PostAsJsonAsync("https://iot20-func.azurewebsites.net/api/HandleLocationData", Encoding.UTF8.GetString(message.Body.Array));
                    break;
                case "lightsensor":
                    await client.PostAsJsonAsync("https://iot20-fa.azurewebsites.net/api/HandleLightSensorData", Encoding.UTF8.GetString(message.Body.Array));
                    break;
            }
        }*/
    }
}