using IoTHubTrigger = Microsoft.Azure.WebJobs.EventHubTriggerAttribute;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Azure.EventHubs;
using System.Text;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using AzureTbleStrgFunc.Properties.Models;
using Newtonsoft.Json;
using System;

namespace AzureTbleStrgFunc
{
    public static class SaveToTableStroage
    {
        private static HttpClient client = new HttpClient();

        [FunctionName("SaveToTableStroage")]
        [return: Table("Message2")]
        public static DhtMessage Run([IoTHubTrigger("messages/events", Connection = "IotHubConnection1")]EventData message, ILogger log)
        { try
            {
              
                var payload = JsonConvert.DeserializeObject<DhtMessage>(Encoding.UTF8.GetString(message.Body.Array));
                //payload.PartitionKey = "dht";
                payload.PartitionKey = message.Properties["messageType"].ToString();
                payload.RowKey = Guid.NewGuid().ToString();

                  log.LogInformation("Saving data to Table Storage.");
                return payload;             
            }
            catch
            {
                log.LogInformation("Failed to Deserialize message. No data was save to Table Storage");
            }

                return null;
            
        }
    }
    
}