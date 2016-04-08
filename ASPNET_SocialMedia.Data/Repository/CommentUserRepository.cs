using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Data.Infrastructure;

namespace ASPNET_SocialMedia.Data.Repository
{
    public class CommentUserRepository : RepositoryBase<CommentUser>, ICommentUserRepository
    {
        public CommentUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface ICommentUserRepository : IRepository<CommentUser>
    {
        
    }
}
