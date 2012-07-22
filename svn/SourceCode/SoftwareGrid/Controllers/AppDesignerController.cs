using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoftwareGrid.Helpers;

namespace SoftwareGrid.Controllers
{
    public class AppDesignerController : Controller
    {
        //for layout change in application theme
        public ActionResult AppLayout(string id)
        {
            string cssFile = id;
            this.SetLayout(cssFile, true);
            return RedirectToAction("Index", "Home");
        }

        //for Theme change in application theme
        public ActionResult AppTheme(string id)
        {
            string cssFile = id;
            this.SetTheme(cssFile, true);
            return RedirectToAction("Index", "Home");
        }

        //for Background change in application theme
        public ActionResult AppDarkBG(string id)
        {
            string cssFile = id;
            this.SetDarkBG(cssFile, true);
            return RedirectToAction("Index", "Home");
        }

        //for Background change in application theme
        public ActionResult AppLightBG(string id)
        {
            string cssFile = id;
            this.SetLightBG(cssFile, true);
            return RedirectToAction("Index", "Home");
        }

        //for Colour change in application theme
        public ActionResult AppColour(string id)
        {
            string cssFile = id;
            this.SetColour(cssFile, true);
            return RedirectToAction("Index", "Home");
        }

        //for Header change in application theme
        public ActionResult AppHeader(string id)
        {
            string cssFile = id;
            this.SetHeader(cssFile, true);
            return RedirectToAction("Index", "Home");
        }

    }
}
