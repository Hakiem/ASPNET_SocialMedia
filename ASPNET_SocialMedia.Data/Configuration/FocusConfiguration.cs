using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Configuration
{
    public class FocusConfiguration:EntityTypeConfiguration<Focus>
    {
        public FocusConfiguration()
        {
            Property(f => f.FocusName).HasMaxLength(50);
            Property(f => f.Description).HasMaxLength(100);
        }
    }
}
