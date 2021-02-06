﻿using System;

namespace PlenBotLogUploader.DPSReport
{
    /// <summary>
    /// An object holding boss information
    /// </summary>
    public class BossData
    {
        /// <summary>
        /// ID of the encounter
        /// </summary>
        public int BossId { get; set; }

        /// <summary>
        /// Name of the encounter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Twitch message when encounter is a success
        /// </summary>
        public string SuccessMsg { get; set; } = Properties.Settings.Default.BossTemplateSuccess;

        /// <summary>
        /// Twitch message when encounter is a failure
        /// </summary>
        public string FailMsg { get; set; } = Properties.Settings.Default.BossTemplateFail;

        /// <summary>
        /// Icon used for Discord webhooks
        /// </summary>
        public string Icon { get; set; } = "";

        /// <summary>
        /// Type of the boss
        /// </summary>
        public BossType Type { get; set; } = BossType.None;

        /// <summary>
        /// Indication if the encounter is an event
        /// </summary>
        public bool Event { get; set; } = false;

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <param name="savableFormat">whether the text should be in savable format</param>
        /// <returns>Returns a string that represents the current object.</returns>
        public string ToString(bool savableFormat = false)
        {
            if (!savableFormat)
            {
                return base.ToString();
            }
            return $"{BossId}<;>{Name}<;>{SuccessMsg}<;>{FailMsg}<;>{Icon}<;>{(int)Type}<;>{(Event ? "1" : "0")}";
        }

        /// <summary>
        /// Formats Twitch message based on the DPSReport's JSON response.
        /// </summary>
        /// <param name="reportJSON">DPSReport's JSON response</param>
        /// <returns>Formatted string</returns>
        public string TwitchMessageFormat(DPSReportJSON reportJSON, int pullCounter)
        {
            string format = (reportJSON.Encounter.Success ?? false) ? SuccessMsg : FailMsg;
            format = format.Replace("<boss>", reportJSON.ChallengeMode ? $"{Name} CM" : Name);
            format = format.Replace("<log>", reportJSON.Permalink);
            format = format.Replace("<pulls>", pullCounter.ToString());
            return format;
        }

        /// <summary>
        /// Creates an BossData object from a serialised format.
        /// </summary>
        /// <param name="savedFormat">string representing the object</param>
        /// <returns>deserilised object of BossData type</returns>
        public static BossData FromSavedFormat(string serialisedFormat)
        {
            try
            {
                string[] values = serialisedFormat.Split(new string[] { "<;>" }, StringSplitOptions.None);
                int.TryParse(values[0], out int bossId);
                int.TryParse(values[5], out int type);
                int.TryParse(values[6], out int isEvent);
                return new BossData() { BossId = bossId, Name = values[1], SuccessMsg = values[2], FailMsg = values[3], Icon = values[4], Type = (BossType)(type), Event = isEvent == 1 };
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
