using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMO.RainyDayEventReceiver.Models
{
    internal class RainyDayMessage
    {

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
