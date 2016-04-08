using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;

namespace ASPNET_SocialMedia.Data.Configuration
{
    public class GroupInvitationConfiguration: EntityTypeConfiguration<GroupInvitation>
    {
        public GroupInvitationConfiguration()
        {
            Property(g => g.FromUserId).IsMaxLength();
            Property(g => g.ToUserId).IsMaxLength();
            Property(g => g.GroupId).IsRequired();
            Property(g => g.SentDate).IsRequired();
            Property(g => g.Accepted).IsRequired();
        }
    }
}
