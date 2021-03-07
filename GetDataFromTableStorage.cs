using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.Azure.Cosmos.Table;
using System.Collections.Generic;
using AzureTbleStrgFunc.Properties.Models;
using System.Linq;

namespace AzureTbleStrgFunc
{
    public static class GetDataFromTableStorage
    {
        [FunctionName("GetDataFromTableStorage")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            [Table("Message2")] CloudTable cloudTable,
            ILogger log)
        {
            string limit = req.Query["limit"];
            string orderby = req.Query["orderby"];

            IEnumerable<DhtMessage> results = await cloudTable.ExecuteQuerySegmentedAsync(new TableQuery<DhtMessage>(), null);

            results = results.OrderByDescending(ts => ts.Timestamp).Take<DhtMessage>(10);
            
            //if (orderby == "desc")
            //    results = results.OrderByDescending(ts => ts.Timestamp);

            //if (limit != null)
            //    results = results.Take(int.Parse(limit));

            return new OkObjectResult(results);

        }
    }
}
