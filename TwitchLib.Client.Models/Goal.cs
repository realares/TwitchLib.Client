using TwitchLib.Client.Models.Internal;

namespace TwitchLib.Client.Models;

public class Goal
{
    public string ContributionType { get; set; } = default!; //SUB_POINTS, SUB

    public int CurrentContributions { get; set; }

    public string? Description { get; set; }

    public int TargetContributions { get; set; }

    public int UserContributions { get; set; }

    internal static bool TrySetTag(ref Goal? goal, KeyValuePair<string, string> tag)
    {
        switch (tag.Key)
        {
            case Tags.MsgParamGoalContributionType:
                (goal ??= new()).ContributionType = tag.Value;
                break;
            case Tags.MsgParamGoalCurrentContributions:
                (goal ??= new()).CurrentContributions = int.Parse(tag.Value); ;
                break;
            case Tags.MsgParamGoalDescription:
                (goal ??= new()).Description = tag.Value;
                break;
            case Tags.MsgParamGoalTargetContributions:
                (goal ??= new()).TargetContributions = int.Parse(tag.Value);
                break;
            case Tags.MsgParamGoalUserContributions:
                (goal ??= new()).UserContributions = int.Parse(tag.Value);
                break;
            default:
                return false;
        }
        return true;
    }
}
