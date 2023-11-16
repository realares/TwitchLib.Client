using System.Linq;
using TwitchLib.Client.Models;
using static TwitchLib.Client.Models.MessageEmote;

namespace TwitchLib.Client.RA
{
    public class MessageEmoteExtension
    {
        /// <summary>
        ///     A delegate which attempts to match the calling <see cref="MessageEmote"/> with its
        ///     <see cref="EmoteSource"/> and pulls the <see cref="EmoteSize.Small">small</see> version
        ///     of the URL.
        /// </summary>
        /// <param name="caller"></param>
        /// <returns></returns>
        public static string SourceMatchingReplacementImgText(MessageEmote caller, EmoteSize? sizeOverride = null)
        {
            var sizeIndex = (sizeOverride == null ? (int)caller.Size : (int)sizeOverride.Value);
            return caller.Source switch
            {
                EmoteSource.BetterTwitchTv => $"<img src='{string.Format(BetterTwitchTvEmoteUrls[sizeIndex], caller.Id)}'>",
                EmoteSource.FrankerFaceZ => $"<img src='{string.Format(FrankerFaceZEmoteUrls[sizeIndex], caller.Id)}'>",
                EmoteSource.Twitch => $"<img src='{string.Format(TwitchEmoteUrls[sizeIndex], caller.Id)}'>",
                EmoteSource.SevenTv => $"<img src='{string.Format(SevenTvEmoteUrls[sizeIndex], caller.Id)}'>",
                _ => caller.Text,
            };
        }
    }
}

