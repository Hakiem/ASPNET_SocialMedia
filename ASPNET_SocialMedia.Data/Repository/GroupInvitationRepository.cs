using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Data.Infrastructure;

namespace ASPNET_SocialMedia.Data.Repository
{
    public class GroupInvitationRepository : RepositoryBase<GroupInvitation>, IGroupInvitationRepository
    {
        public GroupInvitationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupInvitationRepository : IRepository<GroupInvitation>
    {
    }
}
