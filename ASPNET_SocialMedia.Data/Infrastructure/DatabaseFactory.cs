using ASPNET_SocialMedia.Data.Models;

namespace ASPNET_SocialMedia.Data.Infrastructure
{
public class DatabaseFactory : Disposable, IDatabaseFactory
{
    private ASPNET_SocialMediaEntities dataContext;
    public ASPNET_SocialMediaEntities Get()
    {
        return dataContext ?? (dataContext = new ASPNET_SocialMediaEntities());
    }
    protected override void DisposeCore()
    {
        if (dataContext != null)
            dataContext.Dispose();
    }
}
}
