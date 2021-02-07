﻿using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PlenBotLogUploader.Tools
{
    public class HttpClientController : HttpClient
    {
        #region init
        /// <summary>
        /// The initial settings by HttpClientController child of HttpClient.
        /// </summary>
        public HttpClientController()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }
        #endregion

        /// <summary>
        /// Downloads a file asynchronously.
        /// </summary>
        public async Task<bool> DownloadFileAsync(string url, string destination)
        {
            try
            {
                Uri uri = new Uri(url);
                using (HttpResponseMessage responseMessage = await GetAsync(uri))
                {
                    using (Stream response = await responseMessage.Content.ReadAsStreamAsync())
                    {
                        using (FileStream stream = File.Create(@destination))
                        {
                            await response.CopyToAsync(stream);
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Downloads a file to string asynchronously.
        /// </summary>
        public async Task<string> DownloadFileToStringAsync(string url)
        {
            try
            {
                Uri uri = new Uri(url);
                using (HttpResponseMessage responseMessage = await GetAsync(uri))
                {
                    string response = await responseMessage.Content.ReadAsStringAsync();
                    return response;
                }
            }
            catch
            {
                return "";
            }
        }
    }
}
