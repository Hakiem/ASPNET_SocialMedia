using System;

namespace ASPNET_SocialMedia.Model.Models
{
    public class Support
    {
        public int SupportId { get; set; }

        public int GoalId { get; set; }

        public string UserId { get; set; }

        public virtual Goal Goal { get; set; }

        public DateTime SupportedDate { get; set; }

    }
}
