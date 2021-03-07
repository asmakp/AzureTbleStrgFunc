using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AzureTbleStrgFunc.Properties.Models;

namespace AzureTbleStrgFunc
{
    Not required
   /* public static class HandleDhtData
    {
        [FunctionName("HandleDhtData")]
        [return: Table("MultipleMessages")]
        public static  DhtMessage Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
           

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var data = JsonConvert.DeserializeObject<DhtMessage>(requestBody);
            return data;
        }
    }*/
}
