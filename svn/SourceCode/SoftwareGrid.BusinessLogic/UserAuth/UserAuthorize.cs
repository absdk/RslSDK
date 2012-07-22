using System.Web.Mvc;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.BusinessLogic.Repositories;
using EasySoft.Helper;
using SoftwareGrid.Common;

namespace SoftwareGrid.BusinessLogic.Helpers
{
    public class UserAuthorize : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(System.Web.HttpContextBase httpContext)
        {
            //if (httpContext.User.Identity.IsAuthenticated)
            //{
            //    MembershipUser user=Membership.GetUser(httpContext.User.Identity.Name);
            //    if (user != null)
            //    {
            //        string []roles=System.Web.Security.Roles.GetRolesForUser(httpContext.User.Identity.Name);
            //    }
            //}
            //return false;
            if (httpContext.User.Identity.IsAuthenticated)
            {
                var routeData = ((MvcHandler)httpContext.Handler).RequestContext.RouteData;
                object currentAreaName = string.Empty;
                routeData.Values.TryGetValue("area", out currentAreaName);
                object currentControllerName = string.Empty;
                routeData.Values.TryGetValue("controller", out currentControllerName);
                object currentActionName = string.Empty;
                routeData.Values.TryGetValue("action", out currentActionName);
                if (currentControllerName.ToString(true).ToLower() == Constants.CommonConstants.DefaultControllerName.ToLower() && currentActionName.ToString(true).ToLower() == Constants.CommonConstants.DefaultActionName.ToLower())
                {
                    return true;
                }
                User loggedInUser = WebHelper.CurrentSession.Content.LoggedInUser;
                if (loggedInUser == null)
                {
                    IUserRepository userRepository = DependencyResolver.Current.GetService(typeof(IUserRepository)) as IUserRepository;
                    loggedInUser = userRepository.Find(httpContext.User.Identity.Name);
                    WebHelper.CurrentSession.Content.LoggedInUser = loggedInUser;
                }
                if (loggedInUser != null)
                {
                    //Administrator access
                    if (loggedInUser.UserRoleID == 1)
                    {
                        return true;
                    }
                    IUserRolePermissionRepository userRolePermissionRepository = DependencyResolver.Current.GetService(typeof(IUserRolePermissionRepository)) as IUserRolePermissionRepository;
                    return userRolePermissionRepository.HasPermission(loggedInUser.UserRoleID, currentAreaName.ToString(true), currentControllerName.ToString(true), currentActionName.ToString(true));
                }
            }
            return base.AuthorizeCore(httpContext);
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }
    }
}
