using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class CommentRepository: RepositoryBase<Comment>, ICommentRepository
        {
        public CommentRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }
      
        }
    public interface ICommentRepository : IRepository<Comment>
    {    

    }
}