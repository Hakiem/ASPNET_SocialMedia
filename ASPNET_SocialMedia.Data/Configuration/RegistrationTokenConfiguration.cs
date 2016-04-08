using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;

namespace ASPNET_SocialMedia.Data.Configuration
{
    public class RegistrationTokenConfiguration:EntityTypeConfiguration<RegistrationToken>
    {
        public RegistrationTokenConfiguration()
        {
            Property(r => r.Role).HasMaxLength(50);

        }
    }
}
