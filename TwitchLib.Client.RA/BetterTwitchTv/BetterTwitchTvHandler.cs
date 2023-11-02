using System.Text.Json;
using TwitchLib.Client.Models;
using TwitchLib.Client.RA.BetterTwitchTv.Models;
using static TwitchLib.Client.Models.MessageEmote;

namespace TwitchLib.Client.RA.BetterTwitchTv
{
    public class BetterTwitchTvHandler
    {
        private const string BaseUrl = "https://api.betterttv.net/3/cached/";

        public static async Task AddOrRefreshEmotesAsync(MessageEmoteCollection emoteCollection, string twitchUserId, bool remove = false)
        {
            using var httpclient = new HttpClient()
            {
                BaseAddress = new Uri(BaseUrl)
            };

            var response = await httpclient.GetAsync("emotes/global");

            if (response.IsSuccessStatusCode)
            {
                var globalemotes = await JsonSerializer.DeserializeAsync<List<EmoteData>>(response.Content.ReadAsStream());

                AddOrReplaceEmote(globalemotes);
            }

            if (!string.IsNullOrWhiteSpace(twitchUserId))
            {
                response = await httpclient.GetAsync($"users/twitch/{twitchUserId}");
                if (response.IsSuccessStatusCode)
                {
                    var channelemotes = await JsonSerializer.DeserializeAsync<UserEmotes>(response.Content.ReadAsStream());

                    if (channelemotes != null)
                    {
                        AddOrReplaceEmote(channelemotes.ChannelEmotes);
                        AddOrReplaceEmote(channelemotes.SharedEmotes);
                    }
                }
            }

            void AddOrReplaceEmote(List<EmoteData>? emotes)
            { 
                if (emotes == null)
                    return;

                foreach (var emote in emotes)
                {
                    var twitchemote = new MessageEmote(emote.Id, emote.Code, EmoteSource.BetterTwitchTv);
                    if (remove)
                        emoteCollection.Remove(twitchemote);
                    emoteCollection.Add(twitchemote);
                }
            }
        }
    }
}
