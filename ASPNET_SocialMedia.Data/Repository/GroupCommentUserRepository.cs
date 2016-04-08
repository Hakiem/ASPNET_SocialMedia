using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Data.Infrastructure;

namespace ASPNET_SocialMedia.Data.Repository
{
    public class GroupCommentUserRepository : RepositoryBase<GroupCommentUser>, IGroupCommentUserRepository
    {
        public GroupCommentUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface IGroupCommentUserRepository : IRepository<GroupCommentUser>
    {
        
    }
}
