using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class FocusRepository: RepositoryBase<Focus>, IFocusRepository
        {
        public FocusRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IFocusRepository : IRepository<Focus>
    {
    }
}