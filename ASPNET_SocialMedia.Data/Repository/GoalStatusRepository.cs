using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class GoalStatusRepository : RepositoryBase<GoalStatus>, IGoalStatusRepository
    {
        public GoalStatusRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGoalStatusRepository : IRepository<GoalStatus>
    {
    }
}