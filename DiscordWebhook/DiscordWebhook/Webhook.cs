﻿using System;
using System.Collections.Specialized;
using System.Net;

namespace DiscordWebhook
{
    public class WeebHook : IDisposable
    {
        private readonly WebClient dWebClient;
        private static NameValueCollection discordValues = new NameValueCollection();
        public string WebHook { get; set; }
        public string UserName { get; set; }
        public string ProfilePicture { get; set; }

        public WeebHook()
        {
            dWebClient = new WebClient();
        }
        public void SendMessage(string msgSend)
        {
            discordValues.Add("username", UserName);
            discordValues.Add("avatar_url", ProfilePicture);
            discordValues.Add("content", msgSend);

            dWebClient.UploadValues(WebHook, discordValues);
        }
        public void Dispose()
        {
            dWebClient.Dispose();
        }
    }
}