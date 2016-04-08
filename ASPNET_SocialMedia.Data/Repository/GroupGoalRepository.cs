using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Data.Infrastructure;


namespace ASPNET_SocialMedia.Data.Repository
{
    public class GroupGoalRepository : RepositoryBase<GroupGoal>, IGroupGoalRepository
    {
        public GroupGoalRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupGoalRepository : IRepository<GroupGoal>
    {
    }
}
