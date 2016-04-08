using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Data.Infrastructure;

namespace ASPNET_SocialMedia.Data.Repository
{
    public class FollowUserRepository : RepositoryBase<FollowUser>, IFollowUserRepository
    {
        public FollowUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        //public IEnumerable<User> SearchUserForGroup(string searchString, int groupId)
        //{

        //}
    }
    public interface IFollowUserRepository : IRepository<FollowUser>
    {
        //IEnumerable<User> SearchUserForGroup(string searchString, int groupId);
    }
}
