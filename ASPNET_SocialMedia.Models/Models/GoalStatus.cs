using System.Collections.Generic;

namespace ASPNET_SocialMedia.Model.Models
{
    public class GoalStatus
    {
        public int GoalStatusId { get; set; }

        public string GoalStatusType { get; set; }

        public virtual ICollection<Goal> Goals { get; set; }

        public virtual ICollection<GroupGoal> GroupGoals { get; set; }

    }
}
