﻿using Newtonsoft.Json;

namespace PlenBotLogUploader.GW2API
{
    public class GW2Server
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public string Region => (ID < 2000) ? "NA" : "EU";
    }
}
