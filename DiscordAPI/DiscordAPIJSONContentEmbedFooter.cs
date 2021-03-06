﻿using Newtonsoft.Json;

namespace PlenBotLogUploader.DiscordAPI
{
    /// <summary>
    /// Discord embedded rich content's footer
    /// </summary>
    public class DiscordAPIJSONContentEmbedFooter
    {
        /// <summary>
        /// footer text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; } = $"PlenBot Log Uploader r.{Properties.Settings.Default.ReleaseVersion}";

        /// <summary>
        /// url of the footer icon (only supports http(s) and attachments)
        /// </summary>
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; } = "https://plenbot.net/uploader/img/favicon.png";
    }
}
