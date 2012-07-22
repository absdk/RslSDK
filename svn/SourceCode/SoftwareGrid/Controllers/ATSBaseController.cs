using System.Web.Mvc;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.DataLogic.Models;
namespace SoftwareGrid
{
    public class ATSBaseController : UserBaseController
    {

        private void BuildMenu()
        {

        }

        [HttpGet]
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.ActionParameters != null && filterContext.ActionParameters.Count > 0 && filterContext.ActionParameters.ContainsKey("applicantId"))
            {
                int applicantId = filterContext.ActionParameters["applicantId"].ToInteger(true);
                ViewBag.ApplicantId = applicantId;
                IApplicantRepository applicantRepository = DependencyResolver.Current.GetService(typeof(IApplicantRepository)) as IApplicantRepository;
                ViewBag.OverviewApplicant = applicantRepository.Find(applicantId);
            }
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.ApplicantLandingMenu = repository.GetApplicantLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
        }
    }
}
