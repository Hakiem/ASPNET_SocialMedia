﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;

namespace ASPNET_SocialMedia.Data.Configuration
{
    public class GroupRequestConfiguration : EntityTypeConfiguration<GroupRequest>
    {
        public GroupRequestConfiguration()
        {
            Property(g => g.GroupId).IsRequired();
            Property(g => g.UserId).HasMaxLength(128);
            Property(g => g.Accepted).IsRequired();
        }
    }
}
