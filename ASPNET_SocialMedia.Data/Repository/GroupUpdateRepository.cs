using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class GroupUpdateRepository : RepositoryBase<GroupUpdate>, IGroupUpdateRepository
    {
        public GroupUpdateRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupUpdateRepository : IRepository<GroupUpdate>
    {
    }
}