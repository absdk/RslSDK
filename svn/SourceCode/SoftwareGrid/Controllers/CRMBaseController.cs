using System.Web.Mvc;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.Common;
namespace SoftwareGrid
{
    public class CRMBaseController : UserBaseController
    {

        private void BuildMenu()
        {

        }

        [HttpGet]
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionParameters != null && filterContext.ActionParameters.Count > 0 && filterContext.ActionParameters.ContainsKey(Constants.Params.CompanyId))
            {
                int companyId = filterContext.ActionParameters[Constants.Params.CompanyId].ToInteger(true);
                ViewBag.CompanyId = companyId;
                ICompanyRepository companyRepository = DependencyResolver.Current.GetService(typeof(ICompanyRepository)) as ICompanyRepository;
                ViewBag.CompanyOverviewHead = companyRepository.FindOverviewHead(companyId,null);
            }
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.CompanyLandingMenu = repository.GetCompanyLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
        }
    }
}
