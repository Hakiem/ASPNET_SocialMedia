using System;
using ASPNET_SocialMedia.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASPNET_SocialMedia.Data.Infrastructure;

namespace ASPNET_SocialMedia.Data.Repository
{
    class GroupUpdateSupportRepository : RepositoryBase<GroupUpdateSupport>, IGroupUpdateSupportRepository
    {
        public GroupUpdateSupportRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupUpdateSupportRepository : IRepository<GroupUpdateSupport>
    {
    }
}
