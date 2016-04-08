using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class GroupRequestRepository: RepositoryBase<GroupRequest>, IGroupRequestRepository
        {
        public GroupRequestRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IGroupRequestRepository : IRepository<GroupRequest>
    {
    }
}