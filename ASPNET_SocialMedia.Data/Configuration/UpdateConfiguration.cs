using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;


namespace ASPNET_SocialMedia.Data.Configuration
{
    public class UpdateConfiguration:EntityTypeConfiguration<Update>
    {
        public UpdateConfiguration()
        {
            Property(u => u.Updatemsg).IsMaxLength();
            Property(u => u.GoalId).IsRequired();
            Property(u => u.UpdateDate).IsRequired();

        }
    }
}
