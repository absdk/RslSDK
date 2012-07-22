using System.Web.Mvc;
using SoftwareGrid.BusinessLogic.Helpers;

namespace SoftwareGrid.Controllers
{
    public class HomeController : UserBaseController
    {
        [UserAuthorize]
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
