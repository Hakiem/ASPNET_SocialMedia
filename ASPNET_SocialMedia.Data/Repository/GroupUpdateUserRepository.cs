using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Data.Infrastructure;

namespace ASPNET_SocialMedia.Data.Repository
{
    public class GroupUpdateUserRepository : RepositoryBase<GroupUpdateUser>, IGroupUpdateUserRepository
    {
        public GroupUpdateUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface IGroupUpdateUserRepository : IRepository<GroupUpdateUser>
    {
       
    }
}
