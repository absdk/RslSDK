using System.Web.Mvc;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.Common;
namespace SoftwareGrid
{
    public class OrganizationBaseController : UserBaseController
    {

        private void BuildMenu()
        {

        }

        [HttpGet]
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionParameters != null && filterContext.ActionParameters.Count > 0 && filterContext.ActionParameters.ContainsKey(Constants.Params.OrganizationId))
            {
                int organizationId = filterContext.ActionParameters[Constants.Params.OrganizationId].ToInteger(true);
                ViewBag.OrganizationId = organizationId;
                IOrganizationRepository organizationRepository = DependencyResolver.Current.GetService(typeof(IOrganizationRepository)) as IOrganizationRepository;
                ViewBag.OrganizationOverviewHead = organizationRepository.FindOverviewHead(organizationId, null);
            }
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.OrganizationLandingMenu = repository.GetOrganizationLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
        }
    }
}
