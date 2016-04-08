using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;

namespace ASPNET_SocialMedia.Data.Configuration
{
    public class CommentUserConfiguration : EntityTypeConfiguration<CommentUser>
    {
        public CommentUserConfiguration()
        {
            Property(c => c.CommentId).IsRequired();
            Property(c => c.UserId).IsRequired();
        }
    }
}
