using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace AzureTbleStrgFunc
{
    public static class SaveToTableStroage
    {
        private static HttpClient client = new HttpClient();

        [FunctionName("SaveToTableStroage")]
        public static void Run([IoTHubTrigger("messages/events", Connection = "IotHubConnection")]EventData message, ILogger log)
        {
            log.LogInformation($"C# IoT Hub trigger function processed a message: {Encoding.UTF8.GetString(message.Body.Array)}");
        }
    }
}