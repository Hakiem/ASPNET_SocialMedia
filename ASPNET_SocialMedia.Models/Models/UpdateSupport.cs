using System;

namespace ASPNET_SocialMedia.Model.Models
{
    public class UpdateSupport
    {
        public int UpdateSupportId { get; set; }

        public int UpdateId { get; set; }

        public string UserId { get; set; }

        public virtual Update Update { get; set; }

        public DateTime UpdateSupportedDate { get; set; }

    }
}
