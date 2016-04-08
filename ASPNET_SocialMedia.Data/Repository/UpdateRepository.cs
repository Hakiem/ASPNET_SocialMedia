using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class UpdateRepository: RepositoryBase<Update>, IUpdateRepository
        {
        public UpdateRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IUpdateRepository : IRepository<Update>
    {
    }
}