using TwitchLib.Client.Enums;
using TwitchLib.Client.Models.Interfaces;

namespace TwitchLib.Client.Models
{
    /// <summary>Class represents Message.</summary>
    public abstract class TwitchLibMessage : IHexColorProperty
    {
        /// <summary>List of key-value pair badges.</summary>
        public List<KeyValuePair<string, string>> Badges { get; set; } = default!;

        /// <summary>Twitch username of the bot that received the message.</summary>
        public string BotUsername { get; set; } = default!;

        /// <summary>Property representing HEX color as a System.Drawing.Color object.</summary>
        public string HexColor { get; set; } = default!;

        /// <summary>Case-sensitive username of sender of chat message.</summary>
        public string DisplayName { get; set; } = default!;

        /// <summary>Emote Ids that exist in message.</summary>
        public EmoteSet EmoteSet { get; set; } = default!;

        /// <summary>Twitch site-wide turbo status.</summary>
        public bool IsTurbo { get; set; }

        /// <summary>Twitch-unique integer assigned on per account basis.</summary>
        public string UserId { get; set; } = default!;

        /// <summary>Username of sender of chat message.</summary>
        public string Username { get; set; } = default!;

        /// <summary>User type can be viewer, moderator, global mod, admin, or staff</summary>
        public UserType UserType { get; set; }
        
        /// <summary>Raw IRC-style text received from Twitch.</summary>
        public string RawIrcMessage { get; set; } = default!;

        /// <summary>
        /// Contains undocumented tags.
        /// </summary>
        public Dictionary<string, string>? UndocumentedTags { get; set; }
    }
}
