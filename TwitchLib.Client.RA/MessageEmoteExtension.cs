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
        public static string SourceMatchingReplacementImgText(MessageEmote caller)
        {
            var sizeIndex = (int)caller.Size;
            switch (caller.Source)
            {
                case EmoteSource.BetterTwitchTv:
                    return $"<img src='{string.Format(BetterTwitchTvEmoteUrls[sizeIndex], caller.Id)}'>";
                case EmoteSource.FrankerFaceZ:
                    return $"<img src='{string.Format(FrankerFaceZEmoteUrls[sizeIndex], caller.Id)}'>";
                case EmoteSource.Twitch:
                    return $"<img src='{string.Format(TwitchEmoteUrls[sizeIndex], caller.Id)}'>";
            }
            return caller.Text;
        }
    }
}

