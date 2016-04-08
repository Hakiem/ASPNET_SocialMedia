using System.ComponentModel;

namespace ASPNET_SocialMedia.Service
{
    public enum GroupFilter
    {
        [Description("All")]
        All,

        [Description("My Groups")]
        MyGroups,

        [Description("My Followings Groups")]
        MyFollowingsGroups,

        [Description("My Followed Groups")]
        MyFollowedGroups
    }
}
