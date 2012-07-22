using System.Web.Mvc;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.Common;
namespace SoftwareGrid
{
    public class VMSBaseController : UserBaseController
    {
        private void BuildMenu()
        {
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.VendorLandingMenu = repository.GetVendorLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
        }

        [HttpGet]
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionParameters != null && filterContext.ActionParameters.Count > 0 && filterContext.ActionParameters.ContainsKey(Constants.Params.VendorId))
            {
                int vendorId = filterContext.ActionParameters[Constants.Params.VendorId].ToInteger(true);
                ViewBag.VendorId = vendorId;
                IVendorRepository vendorRepository = DependencyResolver.Current.GetService(typeof(IVendorRepository)) as IVendorRepository;
                ViewBag.VendorOverviewHead = vendorRepository.FindOverviewHead(vendorId,null);
            }
            BuildMenu();
        }
    }
}
