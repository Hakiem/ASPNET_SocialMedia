using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Data.Infrastructure;

namespace ASPNET_SocialMedia.Data.Repository
{
    public class SupportInvitationRepository : RepositoryBase<SupportInvitation>, ISupportInvitationRepository
    {
        public SupportInvitationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface ISupportInvitationRepository : IRepository<SupportInvitation>
    {
    }
}
