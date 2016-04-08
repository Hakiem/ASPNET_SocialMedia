using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class GroupCommentRepository : RepositoryBase<GroupComment>, IGroupCommentRepository
    {
        public GroupCommentRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupCommentRepository : IRepository<GroupComment>
    {
    }
}