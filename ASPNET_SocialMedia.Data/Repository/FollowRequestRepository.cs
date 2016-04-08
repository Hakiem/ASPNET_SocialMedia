using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class FollowRequestRepository : RepositoryBase<FollowRequest>, IFollowRequestRepository
    {
        public FollowRequestRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IFollowRequestRepository : IRepository<FollowRequest>
    {
    }
}