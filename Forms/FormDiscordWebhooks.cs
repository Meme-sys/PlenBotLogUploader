﻿using Newtonsoft.Json;
using PlenBotLogUploader.DiscordAPI;
using PlenBotLogUploader.DPSReport;
using PlenBotLogUploader.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlenBotLogUploader
{
    public partial class FormDiscordWebhooks : Form
    {
        #region definitions
        // fields
        private readonly FormMain mainLink;
        //      private readonly Dictionary<int, BossData> allBosses = Bosses.GetAllBosses();
        private int webhookIdsKey = 0;
        private readonly Dictionary<int, DiscordWebhookData> allWebhooks = DiscordWebhooks.GetAllWebhooks();
        #endregion

        public FormDiscordWebhooks(FormMain mainLink)
        {
            this.mainLink = mainLink;
            InitializeComponent();
            Icon = Properties.Resources.AppIcon;
            if (File.Exists($@"{mainLink.LocalDir}\discord_webhooks.txt"))
            {
                try
                {
                    allWebhooks = DiscordWebhooks.FromFile($@"{mainLink.LocalDir}\discord_webhooks.txt");
                    webhookIdsKey = allWebhooks.Count();
                }
                catch
                {
                    allWebhooks.Clear();
                    webhookIdsKey = 0;
                }
            }
            else
            {
                allWebhooks.Clear();
            }
            foreach (int key in allWebhooks.Keys)
            {
                listViewDiscordWebhooks.Items.Add(new ListViewItem() { Name = key.ToString(), Text = allWebhooks[key].Name, Checked = allWebhooks[key].Active });
            }
        }

        private async void FormDiscordPings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            using (StreamWriter writer = new StreamWriter($@"{mainLink.LocalDir}\discord_webhooks.txt"))
            {
                await writer.WriteLineAsync("## Edit the contents of this file at your own risk, use the application interface instead.");
                foreach (int key in allWebhooks.Keys)
                {
                    await writer.WriteLineAsync(allWebhooks[key].ToString(true));
                }
            }
        }

        public async Task ExecuteAllActiveWebhooksAsync(DPSReportJSON reportJSON)
        {
            string bossName = reportJSON.Encounter.Boss + (reportJSON.ChallengeMode ? " CM" : "");
            string successString = (reportJSON.Encounter.Success ?? false) ? ":white_check_mark:" : "❌";
            string extraJSON = (reportJSON.ExtraJSON == null) ? "" : $"Recorded by: {reportJSON.ExtraJSON.RecordedBy}\nDuration: {reportJSON.ExtraJSON.Duration}\nElite Insights version: {reportJSON.ExtraJSON.EliteInsightsVersion}\n";
            string icon = "";
            BossData bossData = Bosses.GetBossDataFromId(reportJSON.Encounter.BossId);
            if (bossData != null)
            {
                bossName = bossData.Name + (reportJSON.ChallengeMode ? " CM" : "");
                icon = bossData.Icon;
            }
            int color = (reportJSON.Encounter.Success ?? false) ? 32768 : 16711680;
            DiscordAPIJSONContentEmbedThumbnail discordContentEmbedThumbnail = new DiscordAPIJSONContentEmbedThumbnail()
            {
                Url = icon
            };
            DateTime timestampDateTime = DateTime.UtcNow;
            if (DateTime.TryParse(reportJSON.ExtraJSON.TimeStart, out DateTime timeStart))
            {
                timestampDateTime = timeStart;
            }
            string timestamp = timestampDateTime.ToString("yyyy'-'MM'-'ddTHH':'mm':'ssZ");
            DiscordAPIJSONContentEmbed discordContentEmbed = new DiscordAPIJSONContentEmbed()
            {
                Title = bossName,
                Url = reportJSON.Permalink,
                Description = $"{extraJSON}Result: {successString}\narcdps version: {reportJSON.EVTC.Type}{reportJSON.EVTC.Version}",
                Color = color,
                TimeStamp = timestamp,
                Thumbnail = discordContentEmbedThumbnail
            };
            DiscordAPIJSONContent discordContentWithoutPlayers = new DiscordAPIJSONContent()
            {
                Embeds = new List<DiscordAPIJSONContentEmbed>() { discordContentEmbed }
            };
            DiscordAPIJSONContentEmbed discordContentEmbedForPlayers = new DiscordAPIJSONContentEmbed()
            {
                Title = bossName,
                Url = reportJSON.Permalink,
                Description = $"{extraJSON}Result: {successString}\narcdps version: {reportJSON.EVTC.Type}{reportJSON.EVTC.Version}",
                Color = color,
                TimeStamp = timestamp,
                Thumbnail = discordContentEmbedThumbnail
            };
            if (reportJSON.Players.Values.Count <= 10)
            {
                List<DiscordAPIJSONContentEmbedField> fields = new List<DiscordAPIJSONContentEmbedField>();
                foreach (DPSReportJSONPlayers player in reportJSON.Players.Values)
                {
                    fields.Add(new DiscordAPIJSONContentEmbedField() { Name = player.CharacterName, Value = $"```\n{player.DisplayName}\n\n{Players.ResolveSpecName(player.Profession, player.EliteSpec)}\n```", Inline = true });
                }
                discordContentEmbedForPlayers.Fields = fields;
            }
            DiscordAPIJSONContent discordContentWithPlayers = new DiscordAPIJSONContent()
            {
                Embeds = new List<DiscordAPIJSONContentEmbed>() { discordContentEmbedForPlayers }
            };
            try
            {
                string jsonContentWithoutPlayers = JsonConvert.SerializeObject(discordContentWithoutPlayers);
                string jsonContentWithPlayers = JsonConvert.SerializeObject(discordContentWithPlayers);
                foreach (int key in allWebhooks.Keys)
                {
                    DiscordWebhookData webhook = allWebhooks[key];
                    if (!webhook.Active
                        || (webhook.SuccessFailToggle.Equals(DiscordWebhookDataSuccessToggle.OnSuccessOnly) && !(reportJSON.Encounter.Success ?? false))
                        || (webhook.SuccessFailToggle.Equals(DiscordWebhookDataSuccessToggle.OnFailOnly) && (reportJSON.Encounter.Success ?? false))
                        || webhook.BossesDisable.Contains(reportJSON.Encounter.BossId))
                    {
                        continue;
                    }
                    Uri uri = new Uri(webhook.URL);
                    if (webhook.ShowPlayers)
                    {
                        using (StringContent content = new StringContent(jsonContentWithPlayers, Encoding.UTF8, "application/json"))
                        {
                            using (await mainLink.HttpClientController.PostAsync(uri, content)) { }
                        }
                    }
                    else
                    {
                        using (StringContent content = new StringContent(jsonContentWithoutPlayers, Encoding.UTF8, "application/json"))
                        {
                            using (await mainLink.HttpClientController.PostAsync(uri, content)) { }
                        }
                    }
                }
                if (allWebhooks.Count > 0)
                {
                    mainLink.AddToText(">:> All active webhooks successfully executed.");
                }
            }
            catch
            {
                mainLink.AddToText(">:> Unable to execute active webhooks.");
            }
        }

        public async Task ExecuteSessionWebhooksAsync(List<DPSReportJSON> reportsJSON, LogSessionSettings logSessionSettings)
        {
            SessionTextConstructor.DiscordEmbeds discordEmbeds = SessionTextConstructor.ConstructSessionEmbeds(reportsJSON, logSessionSettings);
            if (logSessionSettings.UseSelectedWebhooksInstead)
            {
                await SendDiscordMessageToSelectedWebhooksAsync(logSessionSettings.SelectedWebhooks, discordEmbeds, logSessionSettings.ContentText);
            }
            else
            {
                await SendDiscordMessageToAllActiveWebhooksAsync(discordEmbeds, logSessionSettings.ContentText);
            }
            if (logSessionSettings.UseSelectedWebhooksInstead && logSessionSettings.SelectedWebhooks.Count > 0)
            {
                mainLink.AddToText(">:> All selected webhooks successfully executed with finished log session.");
            }
            else if (allWebhooks.Count > 0)
            {
                mainLink.AddToText(">:> All active webhooks successfully executed with finished log session.");
            }
        }

        private async Task SendDiscordMessageToAllActiveWebhooksAsync(SessionTextConstructor.DiscordEmbeds discordEmbeds, string contentText)
        {
            string jsonContentSuccessFailure = JsonConvert.SerializeObject(new DiscordAPIJSONContent()
            {
                Content = contentText,
                Embeds = discordEmbeds.SuccessFailure
            });
            string jsonContentSuccess = JsonConvert.SerializeObject(new DiscordAPIJSONContent()
            {
                Content = contentText,
                Embeds = discordEmbeds.Success
            });
            string jsonContentFailure = JsonConvert.SerializeObject(new DiscordAPIJSONContent()
            {
                Content = contentText,
                Embeds = discordEmbeds.Failure
            });
            try
            {
                foreach (int key in allWebhooks.Keys)
                {
                    DiscordWebhookData webhook = allWebhooks[key];
                    if (!webhook.Active)
                    {
                        continue;
                    }
                    string jsonContent =
                        (webhook.SuccessFailToggle.Equals(DiscordWebhookDataSuccessToggle.OnSuccessAndFailure)) ? jsonContentSuccessFailure :
                        ((webhook.SuccessFailToggle.Equals(DiscordWebhookDataSuccessToggle.OnSuccessOnly) ? jsonContentSuccess : jsonContentFailure));
                    Uri uri = new Uri(webhook.URL);
                    using (StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json"))
                    {
                        using (await mainLink.HttpClientController.PostAsync(uri, content)) { }
                    }
                }
            }
            catch
            {
                mainLink.AddToText(">:> Unable to execute active webhooks with a finished log session.");
            }
        }

        private async Task SendDiscordMessageToSelectedWebhooksAsync(List<DiscordWebhookData> webhooks, SessionTextConstructor.DiscordEmbeds discordEmbeds, string contentText)
        {
            string jsonContentSuccessFailure = JsonConvert.SerializeObject(new DiscordAPIJSONContent()
            {
                Content = contentText,
                Embeds = discordEmbeds.SuccessFailure
            });
            string jsonContentSuccess = JsonConvert.SerializeObject(new DiscordAPIJSONContent()
            {
                Content = contentText,
                Embeds = discordEmbeds.Success
            });
            string jsonContentFailure = JsonConvert.SerializeObject(new DiscordAPIJSONContent()
            {
                Content = contentText,
                Embeds = discordEmbeds.Failure
            });
            try
            {
                foreach (DiscordWebhookData webhook in webhooks)
                {
                    string jsonContent =
                        (webhook.SuccessFailToggle.Equals(DiscordWebhookDataSuccessToggle.OnSuccessAndFailure)) ? jsonContentSuccessFailure :
                        ((webhook.SuccessFailToggle.Equals(DiscordWebhookDataSuccessToggle.OnSuccessOnly) ? jsonContentSuccess : jsonContentFailure));
                    Uri uri = new Uri(webhook.URL);
                    using (StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json"))
                    {
                        using (await mainLink.HttpClientController.PostAsync(uri, content)) { }
                    }
                }
            }
            catch
            {
                mainLink.AddToText(">:> Unable to execute selected webhooks with a finished log session.");
            }
        }

        private void ToolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            webhookIdsKey++;
            (_disposable = new FormEditDiscordWebhook(this, null, webhookIdsKey)).Show();
        }

        private void ToolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (listViewDiscordWebhooks.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewDiscordWebhooks.SelectedItems[0];
                int.TryParse(selected.Name, out int reservedId);
                listViewDiscordWebhooks.Items.RemoveByKey(reservedId.ToString());
                allWebhooks.Remove(reservedId);
            }
        }

        private void ToolStripMenuItemEdit_Click(object sender, EventArgs e)
        {
            if (listViewDiscordWebhooks.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewDiscordWebhooks.SelectedItems[0];
                int.TryParse(selected.Name, out int reservedId);
                (_disposable = new FormEditDiscordWebhook(this, allWebhooks[reservedId], reservedId)).Show();
            }
        }

        private void ListViewDiscordWebhooks_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int.TryParse(e.Item.Name, out int reservedId);
            allWebhooks[reservedId].Active = e.Item.Checked;
        }

        private void ContextMenuStripInteract_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool toggle = listViewDiscordWebhooks.SelectedItems.Count > 0;
            toolStripMenuItemEdit.Enabled = toggle;
            toolStripMenuItemDelete.Enabled = toggle;
            toolStripMenuItemTest.Enabled = toggle;
        }

        private async void ToolStripMenuItemTest_Click(object sender, EventArgs e)
        {
            if (listViewDiscordWebhooks.SelectedItems.Count > 0)
            {
                ListViewItem selected = listViewDiscordWebhooks.SelectedItems[0];
                int.TryParse(selected.Name, out int reservedId);
                if (await allWebhooks[reservedId].TestWebhookAsync(mainLink.HttpClientController))
                {
                    MessageBox.Show("Webhook is valid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Webhook is not valid.\nCheck your URL.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            webhookIdsKey++;
            (_disposable = new FormEditDiscordWebhook(this, null, webhookIdsKey)).Show();
        }

        private FormEditDiscordWebhook _disposable;

        public new void Dispose()
        {
            _disposable?.Dispose();
        }
    }
}