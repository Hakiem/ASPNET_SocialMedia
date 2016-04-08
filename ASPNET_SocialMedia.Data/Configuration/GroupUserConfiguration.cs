﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using ASPNET_SocialMedia.Model.Models;

namespace ASPNET_SocialMedia.Data.Configuration
{
    public class GroupUserConfiguration:EntityTypeConfiguration<GroupUser>
    {
        public GroupUserConfiguration()
        {
            Property(g => g.GroupId).IsRequired();
            Property(g => g.UserId).IsRequired().IsMaxLength();
            Property(g => g.Admin).IsRequired();
            Property(g => g.AddedDate).IsRequired();
        
        }
    }
}
