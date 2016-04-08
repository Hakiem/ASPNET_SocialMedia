using System;
using ASPNET_SocialMedia.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ASPNET_SocialMedia.Data.Infrastructure;

namespace ASPNET_SocialMedia.Data.Repository
{
    class UpdateSupportRepository : RepositoryBase<UpdateSupport>, IUpdateSupportRepository
    {
        public UpdateSupportRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IUpdateSupportRepository : IRepository<UpdateSupport>
    {
    }
}
