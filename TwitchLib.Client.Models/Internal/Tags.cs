﻿#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace TwitchLib.Client.Models.Internal
{
    public static class Tags
    {
        public const string Badges = "badges";
        public const string BadgeInfo = "badge-info";
        public const string BanDuration = "ban-duration";
        public const string BanReason = "ban-reason";
        public const string BroadcasterLang = "broadcaster-lang";
        public const string Bits = "bits";
        public const string Color = "color";
        public const string CustomRewardId = "custom-reward-id";
        public const string DisplayName = "display-name";
        public const string Emotes = "emotes";
        public const string EmoteOnly = "emote-only";
        public const string EmotesSets = "emote-sets";
        public const string FirstMessage = "first-msg";
        public const string Flags = "flags";
        public const string FollowersOnly = "followers-only";
        public const string Id = "id";
        public const string Login = "login";
        public const string Mercury = "mercury";
        public const string MessageId = "message-id";
        public const string Mod = "mod";
        public const string MsgId = "msg-id";   // Valid values: sub, resub, subgift, anonsubgift, submysterygift, giftpaidupgrade, rewardgift, 
                                                // anongiftpaidupgrade, raid, unraid, ritual, bitsbadgetier, announcement
        public const string MsgParamColor = "msg-param-color"; // Sent only on announcement
        public const string MsgParamDisplayname = "msg-param-displayName";                      // Sent only on raid
        public const string MsgParamLogin = "msg-param-login";                                  // Sent only on raid
        public const string MsgParamCumulativeMonths = "msg-param-cumulative-months";           // Sent only on sub, resub
        public const string MsgParamGiftTheme = "msg-param-gift-theme";
        public const string MsgParamGoalContributionType = "msg-param-goal-contribution-type";
        public const string MsgParamGoalCurrentContributions = "msg-param-goal-current-contributions";
        public const string MsgParamGoalDescription = "msg-param-goal-description";
        public const string MsgParamGoalTargetContributions = "msg-param-goal-target-contributions";
        public const string MsgParamGoalUserContributions = "msg-param-goal-user-contributions";
        public const string MsgParamMonths = "msg-param-months";                                // Sent only on subgift, anonsubgift
        public const string MsgParamPriorGifterAnonymous = "msg-param-prior-gifter-anonymous";
        public const string MsgParamPriorGifterDisplayName = "msg-param-prior-gifter-display-name";
        public const string MsgParamPriorGifterId = "msg-param-prior-gifter-id";
        public const string MsgParamPriorGifterUserName = "msg-param-prior-gifter-user-name";
        public const string MsgParamPromoGiftTotal = "msg-param-promo-gift-total";              // Sent only on anongiftpaidupgrade, giftpaidupgrade
        public const string MsgParamPromoName = "msg-param-promo-name";                         // Sent only on anongiftpaidupgrade, giftpaidupgrade
        public const string MsgParamShouldShareStreak = "msg-param-should-share-streak";        // Sent only on sub, resub
        public const string MsgParamStreakMonths = "msg-param-streak-months";                   // Sent only on sub, resub
        public const string MsgParamSubPlan = "msg-param-sub-plan";                             // Sent only on sub, resub, subgift, anonsubgift
        public const string MsgParamSubPlanName = "msg-param-sub-plan-name";                    // Sent only on sub, resub, subgift, anonsubgift
        public const string MsgParamViewerCount = "msg-param-viewerCount";                      // Sent only on raid
        public const string MsgParamRecipientDisplayname = "msg-param-recipient-display-name";  // Sent only on subgift, anonsubgift
        public const string MsgParamRecipientId = "msg-param-recipient-id";                     // Sent only on subgift, anonsubgift
        public const string MsgParamRecipientUsername = "msg-param-recipient-user-name";        // Sent only on subgift, anonsubgift
        public const string MsgParamRitualName = "msg-param-ritual-name";                       // Sent only on ritual
        public const string MsgParamMassGiftCount = "msg-param-mass-gift-count";
        public const string MsgParamSenderCount = "msg-param-sender-count";
        public const string MsgParamSenderLogin = "msg-param-sender-login";                     // Sent only on giftpaidupgrade
        public const string MsgParamSenderName = "msg-param-sender-name";                       // Sent only on giftpaidupgrade
        public const string MsgParamThreshold = "msg-param-threshold";                          // Sent only on bitsbadgetier
        public const string Noisy = "noisy";
        public const string PinnedChatPaidAmount = "pinned-chat-paid-amount";
        public const string PinnedChatPaidCurrency = "pinned-chat-paid-currency";
        public const string PinnedChatPaidExponent = "pinned-chat-paid-exponent";
        public const string PinnedChatPaidLevel = "pinned-chat-paid-level";
        public const string PinnedChatPaidIsSystemMessage = "pinned-chat-paid-is-system-message";

        #region  Sent only on replies
        public const string ReplyParentDisplayName = "reply-parent-display-name";               // Sent only on replies
        public const string ReplyParentMsgBody = "reply-parent-msg-body";                       // Sent only on replies
        public const string ReplyParentMsgId = "reply-parent-msg-id";                           // Sent only on replies
        public const string ReplyParentUserId = "reply-parent-user-id";                         // Sent only on replies
        public const string ReplyParentUserLogin = "reply-parent-user-login";                   // Sent only on replies
        public const string ReplyThreadParentMsgId = "reply-thread-parent-msg-id";
        public const string ReplyThreadParentUserLogin = "reply-thread-parent-user-login";
        #endregion

        public const string Rituals = "rituals";
        public const string RoomId = "room-id";
        public const string R9K = "r9k";
        public const string Slow = "slow";
        public const string Subscriber = "subscriber";      // Deprecated, use badges instead
        public const string SubsOnly = "subs-only";
        public const string SystemMsg = "system-msg";
        public const string ThreadId = "thread-id";
        public const string TmiSentTs = "tmi-sent-ts";
        public const string Turbo = "turbo";                // Deprecated, use badges instead
        public const string UserId = "user-id";
        public const string UserType = "user-type";         // Deprecated, use badges instead
        public const string MsgParamMultiMonthGiftDuration = "msg-param-gift-months";             // Sent only on subgift, anonsubgift
        public const string TargetUserId = "target-user-id";
    }
}