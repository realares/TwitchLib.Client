using System.Text.Json.Serialization;

namespace TwitchLib.Client.RA.BetterTwitchTv.Models
{

    public class EmoteData
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("imageType")]
        public string? ImageType { get; set; }
    }
}