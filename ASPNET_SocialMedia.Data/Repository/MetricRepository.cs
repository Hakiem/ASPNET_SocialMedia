using ASPNET_SocialMedia.Data.Infrastructure;
using ASPNET_SocialMedia.Model.Models;
namespace ASPNET_SocialMedia.Data.Repository
{
    public class MetricRepository: RepositoryBase<Metric>, IMetricRepository
        {
        public MetricRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IMetricRepository : IRepository<Metric>
    {
    }
}