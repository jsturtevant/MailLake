using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfficeGraphHOL.Models.Workingwith
{

    public class Rootobject
    {
        [JsonProperty("@odata.context")]
        public string odatacontext { get; set; }
        public Value[] value { get; set; }
    }

    public class Value
    {
        [JsonProperty("@odata.type")]
        public string odatatype { get; set; }
        [JsonProperty("@odata.id")]
        public string odataid { get; set; }
        public string PreferredName { get; set; }
        public string objectId { get; set; }
    }
}