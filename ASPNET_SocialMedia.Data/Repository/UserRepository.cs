using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Data.Models;
using ASPNET_SocialMedia.Model.Models;
using System;
using System.Linq.Expressions;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class UserRepository: RepositoryBase<ApplicationUser>, IUserRepository
        {
        public UserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }        
        }
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        
    }
}