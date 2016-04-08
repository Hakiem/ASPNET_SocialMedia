using System.Web.Mvc;
using ASPNET_SocialMedia.Web.Core.Helpers;

namespace ASPNET_SocialMedia.Web.Core.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static UserHtmlHelper User(this HtmlHelper html)
        {
            return new UserHtmlHelper(html, new UrlHelper(html.ViewContext.RequestContext));
        }
    }
}