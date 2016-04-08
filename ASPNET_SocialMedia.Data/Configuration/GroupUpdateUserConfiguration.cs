using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;

namespace ASPNET_SocialMedia.Data.Configuration
{
    public class GroupUpdateUserConfiguration:EntityTypeConfiguration<GroupUpdateUser>
    {
        public GroupUpdateUserConfiguration()
        {
            Property(g => g.GroupUpdateUserId).IsRequired();
            Property(g => g.UserId).IsRequired();
        }
    }
}
