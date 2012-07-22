using System.Web.Mvc;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.DataLogic.Models;
namespace SoftwareGrid
{
    public class UserBaseController : BaseController
    {

        private void BuildMenu()
        {

        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.TopMenu = repository.GetTopMenu(CurrentLoggedInUser.UserRoleID);
                ViewBag.ApplicantLandingMenu = repository.GetApplicantLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult ShowMenuIcon(int id)
        {
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            AppMenu menu = repository.Find(id);
            if (menu.MenuIconName.IsNotNullOrEmpty())
            {
                ImageResult result = new ImageResult(menu.MenuIcon, "image/jpeg");
                return result;
            }
            return null;
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult ShowApplicantPhoto(int? id,int? applicantId)
        {
            if (applicantId.HasValue && applicantId.Value>0)
            {
                id = applicantId;
            }
            IApplicantRepository applicantRepository = DependencyResolver.Current.GetService(typeof(IApplicantRepository)) as IApplicantRepository;
            Applicant applicant = applicantRepository.Find(id.Value);
            if (applicant.Photo != null)
            {
                ImageResult result = new ImageResult(applicant.Photo, "image/jpeg");
                return result;
            }
            else
            {
                string imgPath = Url.Content("~/Content/Images/no-photo.jpg");
                ImageResult result = new ImageResult(imgPath, "image/jpeg");
                return result;
            }
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult ShowCompanyLogo(int? id, int? companyId)
        {
            if (companyId.HasValue && companyId.Value > 0)
            {
                id = companyId;
            }
            ICompanyRepository companyRepository = DependencyResolver.Current.GetService(typeof(ICompanyRepository)) as ICompanyRepository;
            Company company = companyRepository.Find(id.Value);
            if (company.Logo != null)
            {
                ImageResult result = new ImageResult(company.Logo, "image/jpeg");
                return result;
            }
            else
            {
                string imgPath = Url.Content("~/Content/Images/no-photo.jpg");
                ImageResult result = new ImageResult(imgPath, "image/jpeg");
                return result;
            }
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult ShowVendorLogo(int? id, int? vendorId)
        {
            if (vendorId.HasValue && vendorId.Value > 0)
            {
                id = vendorId;
            }
            IVendorRepository vendorRepository = DependencyResolver.Current.GetService(typeof(IVendorRepository)) as IVendorRepository;
            Vendor vendor = vendorRepository.Find(id.Value);
            if (vendor.Logo != null)
            {
                ImageResult result = new ImageResult(vendor.Logo, "image/jpeg");
                return result;
            }
            else
            {
                string imgPath = Url.Content("~/Content/Images/no-photo.jpg");
                ImageResult result = new ImageResult(imgPath, "image/jpeg");
                return result;
            }
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult ShowOrganizationLogo(int? id, int? organizationId)
        {
            if (organizationId.HasValue && organizationId.Value > 0)
            {
                id = organizationId;
            }
            IOrganizationRepository organizationRepository = DependencyResolver.Current.GetService(typeof(IOrganizationRepository)) as IOrganizationRepository;
            Organization organization = organizationRepository.Find(id.Value);
            if (organization.Logo != null)
            {
                ImageResult result = new ImageResult(organization.Logo, "image/jpeg");
                return result;
            }
            else
            {
                string imgPath = Url.Content("~/Content/Images/no-photo.jpg");
                ImageResult result = new ImageResult(imgPath, "image/jpeg");
                return result;
            }
        }
    }
}
