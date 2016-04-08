
using System;
using System.Web.Security;
//using ASPNET_SocialMedia.Web.Models;
using ASPNET_SocialMedia.Model.Models;
using ASPNET_SocialMedia.Web.Core.Models;


namespace ASPNET_SocialMedia.Web.Core.Authentication
{
    //public class UserAuthenticationTicketBuilder
    //{
    //     public static FormsAuthenticationTicket CreateAuthenticationTicket(User user)
    //    {
    //        UserInfo userInfo = CreateUserContextFromUser(user);

    //        var ticket = new FormsAuthenticationTicket(
    //            1,
    //            user.Email,
    //            DateTime.Now,
    //            DateTime.Now.Add(FormsAuthentication.Timeout),
    //            false,
    //            userInfo.ToString());

    //        return ticket;
    //    }

    //    private static UserInfo CreateUserContextFromUser(User user)
    //    {
    //        var userContext = new UserInfo
    //        {
    //            UserId = user.UserId,
    //            DisplayName = user.DisplayName,
    //            UserIdentifier = user.Email,
    //            RoleName=Enum.GetName(typeof(UserRoles),user.RoleId)
    //        };

    //        return userContext;
    //    }
    //}
}