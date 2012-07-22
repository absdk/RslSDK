using System.Web;
using System.Web.Mvc;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.Common;
using SoftwareGrid.DataLogic.Models;
using System.IO;
using System;
using SoftwareGrid.ExceptionLogging;
namespace SoftwareGrid
{
    public class BaseController : Controller
    {
        public User CurrentLoggedInUser
        {
            get
            {
                User user = WebHelper.CurrentSession.Content.LoggedInUser;
                if (user == null)
                {
                    if (HttpContext.User != null && HttpContext.User.Identity != null && HttpContext.User.Identity.IsAuthenticated)
                    {
                        CookieHelper newCookieHelper = new CookieHelper();
                        int userId = newCookieHelper.GetUserDataFromLoginCookie().ToInteger(true);
                        if (userId > 0)
                        {
                            IUserRepository userRepository = DependencyResolver.Current.GetService(typeof(IUserRepository)) as IUserRepository;
                            user = userRepository.Find(userId);
                            WebHelper.CurrentSession.Content.LoggedInUser = user;
                        }
                    }
                    if (user == null)
                    {
                        user = new User();
                    }
                }
                return user;
            }
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            object currentControllerName = string.Empty;
            this.RouteData.Values.TryGetValue("controller", out currentControllerName);
            object currentActionName = string.Empty;
            this.RouteData.Values.TryGetValue("action", out currentActionName);
            if (currentControllerName.ToString() != Constants.CommonConstants.UserDefaultControllerName && currentActionName.ToString() != Constants.CommonConstants.UserDefaultActionName)
            {
                if (User.Identity.IsAuthenticated && CurrentLoggedInUser != null)
                {
                    filterContext.HttpContext.Response.Redirect("~/" + Constants.CommonConstants.UserDefaultControllerName + "/" + Constants.CommonConstants.UserDefaultActionName + "", true);
                }
                else
                {
                    base.OnActionExecuted(filterContext);
                }
            }
            else
            {
                base.OnActionExecuted(filterContext);
            }
        }
        
        public ActionResult UploadFile()
        {
            try
            {
                HttpFileCollectionBase files = Request.Files;
                if (files != null && files.Count > 0)
                {
                    // Some browsers send file names with full path. This needs to be stripped.
                    var fileName = Path.GetFileName(files[0].FileName);
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    Session.Add(files.AllKeys[0], fileName);

                    // The files are not actually saved in this demo
                    files[0].SaveAs(physicalPath);
                    return Content("");
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.Manage(ex);
            }
            return null;
            // Return an empty string to signify success
        }

        public ActionResult RemoveFile(string[] fileNames)
        {
            // The parameter of the Remove action must be called "fileNames"
            foreach (var fullName in fileNames)
            {
                var fileName = Path.GetFileName(fullName);
                var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);

                // TODO: Verify user permissions
                if (System.IO.File.Exists(physicalPath))
                {
                    // The files are not actually removed in this demo
                    System.IO.File.Delete(physicalPath);
                }
            }
            // Return an empty string to signify success
            return Content("");
        }

        public ActionResult SelectStates(string CountryID)
        {
            IStateRepository stateRepository = DependencyResolver.Current.GetService(typeof(IStateRepository)) as IStateRepository;
            ViewBag.PossibleStates = stateRepository.FindAllByCountryID(CountryID.ToInteger(true));
            return Json(new { data = this.RenderPartialViewToString(Constants.PartialViews.DropDownList_State, new State()) });
        }

        public ActionResult SelectStatesForIndex(string CountryID)
        {
            IStateRepository stateRepository = DependencyResolver.Current.GetService(typeof(IStateRepository)) as IStateRepository;
            ViewBag.PossibleStates = stateRepository.FindAllByCountryID(CountryID.ToInteger(true));
            return Json(new { data = this.RenderPartialViewToString(Constants.PartialViews.DropDownList_StateForIndex, new State()) });
        }
    }
}
