using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client.Models;

namespace TwitchLib.Client.RA
{
    public static class TwitchClientExtensions
    {
        /// <inheritdoc />
        public static Task SendReplyAsync(this TwitchClient client, ChatMessage replyToMsg, string message, bool dryRun = false)
        {
            return client.SendReplyAsync(client.GetJoinedChannel(replyToMsg.Channel), replyToMsg.Id, message, dryRun);
        }
    }
}
