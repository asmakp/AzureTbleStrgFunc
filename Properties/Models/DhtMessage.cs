using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureTbleStrgFunc.Properties.Models
{
    public class DhtMessage : TableEntity //TableEntity has attribute- partition key row key and time stamp
    {
       // public string Type { get; set; }
        public string MsgCreateTime { get; set; }
        public string DeviceId { get; set; }
        public double Temperature { get; set; }
        public double Humidity { get; set; }
    }
}

