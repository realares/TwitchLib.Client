﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Interfaces;
using TwitchLib.Client.Models;
using static TwitchLib.Client.Models.MessageEmoteCollection;

namespace TwitchLib.Client.RA
{
    public static class TwitchClientExtensions
    {
        /// <inheritdoc />
        public static Task SendReplyAsync(this TwitchClient client, ChatMessage replyToMsg, string message, bool dryRun = false)
        {
            if (string.IsNullOrEmpty(message)) return Task.CompletedTask;
            return client.SendReplyAsync(client.GetJoinedChannel(replyToMsg.Channel), replyToMsg.Id, message, dryRun);
        }

    }
}
