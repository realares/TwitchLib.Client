using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TwitchLib.Client.Models;
using TwitchLib.Client.RA.BetterTwitchTv.Models;
using static TwitchLib.Client.Models.MessageEmote;

namespace TwitchLib.Client.RA.SevenTV
{
    public class SevenTVEmoteHandler
    {
        private const string baseurl = "https://7tv.io";
        private const string globalset = "global";
        private const string jkj = "https://7tv.io/v3/users/TWITCH/524543847";

        private HttpClient _client;

        public static async Task AddOrRefreshEmotesAsync(
            MessageEmoteCollection emoteCollection, 
            string twitchUserId, string? emotesetid = null, bool remove = false)
        {
            using var httpclient = new HttpClient()
            {
                BaseAddress = new Uri(baseurl)
            };

            var response = await httpclient.GetAsync("v3/emote-sets/global");

            if (response.IsSuccessStatusCode)
            {
                var globalemotes = await JsonSerializer.DeserializeAsync<EmoteSet>(response.Content.ReadAsStream());

                AddOrReplaceEmote(globalemotes);
            }

            //if (string.IsNullOrEmpty(emotesetid))
            {
                response = await httpclient.GetAsync($"v3/users/TWITCH/{twitchUserId}");
                if (response.IsSuccessStatusCode)
                {
                    var Connection = await JsonSerializer.DeserializeAsync<Connection>(response.Content.ReadAsStream());
                    AddOrReplaceEmote(Connection.emote_set);
                }

            }

            void AddOrReplaceEmote(EmoteSet? emotes)
            {
                if (emotes?.emotes == null)
                    return;

                foreach (var emote in emotes.emotes)
                {
                    var twitchemote = new MessageEmote(emote.id, emote.name, EmoteSource.SevenTv);
                    if (remove)
                        emoteCollection.Remove(twitchemote);
                    emoteCollection.Add(twitchemote);
                }
            }
        }

    }

    public enum ConnectionType { TWITCH, YOUTUBE, DISCORD, KICK };
    public class Connection
    {
        public string? id { get; set; } = null;
        public string? platform { get; set; } = null;
        public string? username { get; set; } = null;
        public string? display_name { get; set; } = null;
        public long linked_at { get; set; } = 0;
        public int emote_capacity { get; set; } = 0;
        public EmoteSet? emote_set { get; set; } = null;
        public User? user { get; set; } = null;
    }
    public class User
    {
        public string? id { get; set; } = null;
        public string? username { get; set; } = null;
        public string? display_name { get; set; } = null;
        public long createdAt { get; set; } = 0;
        public string? avatar_url { get; set; } = null;
        public string? biography { get; set; } = null;
        public Style? style { get; set; } = null;
        public EmoteSet[]? emote_sets { get; set; } = null;
        public Editor[]? editors { get; set; } = null;
        public string[]? roles { get; set; } = null;
        public Connection[]? connections { get; set; } = null;
    }
    public class Style
    {
        public int color { get; set; } = 0;
        public string? paint { get; set; } = null;
    }
    public class Editor
    {
        public string? id { get; set; } = null;
        public int permissions { get; set; } = 0;
        public bool visible { get; set; } = false;
        public long added_at { get; set; } = 0;
    }
    public class EmoteSet
    {
        public string? id { get; set; } = null;
        public string? name { get; set; } = null;
        public string[]? tags { get; set; } = null;
        public bool immutable { get; set; } = false;
        public bool privileged { get; set; } = false;
        public Emote[]? emotes { get; set; } = null;
        public int capacity { get; set; } = 0;
        public Origin[]? origins { get; set; } = null;
        public User? owner { get; set; } = null;
    }
    public class Origin
    {
        public string? id { get; set; } = null;
        public int weight { get; set; } = 0;
        public object[]? slices { get; set; } = null;
    }

    public class Emote
    {
        public string? id { get; set; } = null;
        public string? name { get; set; } = null;
        public int flags { get; set; } = 0;
        public long timestamp { get; set; } = 0;
        public string? actor_id { get; set; } = null;
        public EmoteData? data { get; set; } = null;
    }
    public class EmoteData
    {
        public string? id { get; set; } = null;
        public string? name { get; set; } = null;
        public int flags { get; set; } = 0;
        public int lifecycle { get; set; } = 0;
        public bool listed { get; set; } = false;
        public bool animated { get; set; } = false;
        public User? owner { get; set; } = null;
        public EmoteHost? host { get; set; } = null;
    }
    public class EmoteHost
    {
        public string? url { get; set; } = null;
        public EmoteFile[]? files { get; set; } = null;
    }
    public class EmoteFile
    {
        public string? name { get; set; } = null;
        public string? static_name { get; set; } = null;
        public int width { get; set; } = 0;
        public int height { get; set; } = 0;
        public long size { get; set; } = 0;
        public string? format { get; set; } = null;
    }
}
