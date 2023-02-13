using System.Text.Json.Serialization;

namespace TwitchLib.Client.RA.BetterTwitchTv.Models
{

    public class UserEmotes
    {
        [JsonPropertyName("channelEmotes")]
        public List<EmoteData>? ChannelEmotes { get; set; }

        [JsonPropertyName("sharedEmotes")]
        public List<EmoteData>? SharedEmotes { get; set; }
    }
}