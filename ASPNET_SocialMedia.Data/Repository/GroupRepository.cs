using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;

namespace ASPNET_SocialMedia.Data.Repository
{
    public class GroupRepository:RepositoryBase<Group>, IGroupRepository
        {
        public GroupRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IGroupRepository : IRepository<Group>
    {
    }
   
}
