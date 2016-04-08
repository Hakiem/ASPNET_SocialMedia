using System;
using ASPNET_SocialMedia.Data.Models;

namespace ASPNET_SocialMedia.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        ASPNET_SocialMediaEntities Get();
    }
}
