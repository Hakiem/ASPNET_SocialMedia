using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Data.Infrastructure;

namespace ASPNET_SocialMedia.Data.Repository
{
    public class GroupUserRepository : RepositoryBase<GroupUser>, IGroupUserRepository
    {
        public GroupUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        //public IEnumerable<User> SearchUserForGroup(string searchString, int groupId)
        //{
            
        //}
    }
    public interface IGroupUserRepository : IRepository<GroupUser>
    {
        //IEnumerable<User> SearchUserForGroup(string searchString, int groupId);
    }
}
