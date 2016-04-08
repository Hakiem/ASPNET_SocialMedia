using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;

namespace ASPNET_SocialMedia.Data.Configuration
{
    public class GroupConfiguration: EntityTypeConfiguration<Group>
    {
        public GroupConfiguration()
        {
            Property(g => g.GroupName).HasMaxLength(50);
            Property(g => g.CreatedDate).IsRequired();
            Property(g => g.Description).IsMaxLength();
        }
    }
}
