using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;

namespace ASPNET_SocialMedia.Data.Configuration
{
    public class SupportInvitationConfiguration:EntityTypeConfiguration<SupportInvitation>
    {
        public SupportInvitationConfiguration()
        {
            Property(s => s.GoalId).IsRequired();
            Property(s => s.SentDate).IsRequired();
            Property(s => s.Accepted).IsRequired();
            Property(s => s.FromUserId).IsMaxLength();
            Property(s => s.ToUserId).IsMaxLength();
        }
    }
}
