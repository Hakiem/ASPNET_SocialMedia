using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class SecurityTokenRepository: RepositoryBase<SecurityToken>, ISecurityTokenRepository
        {
        public SecurityTokenRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface ISecurityTokenRepository : IRepository<SecurityToken>
    {
    }
}