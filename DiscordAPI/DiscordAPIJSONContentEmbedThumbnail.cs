﻿using Newtonsoft.Json;

namespace PlenBotLogUploader.DiscordAPI
{
    /// <summary>
    /// Discord embedded rich content's thumbnail
    /// </summary>
    public class DiscordAPIJSONContentEmbedThumbnail
    {
        /// <summary>
        /// source url of the thumbnail (only supports http(s) and attachments)
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
