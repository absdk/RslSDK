using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareGrid.Helpers
{
    public static class ControllerExtensions
    {
        public static void SetTheme(this Controller controller, string cssFile, bool themeChange = false)
        {
            string cssPath = string.Empty;

            HttpCookie cookie = new HttpCookie("CookieTheme");

            if (themeChange)
            {
                //set selected theme
                cssPath += cssFile;
                cookie.Value = cssPath;
            }
            else
            {
                //set default theme
                //cssPath += @"switcher.css";
                cookie.Value = cssPath;
            }

            controller.HttpContext.Response.Cookies.Add(cookie);

        }

        public static void SetColour(this Controller controller, string cssFile, bool colourChange = false)
        {
            string cssPath = string.Empty;

            HttpCookie cookie = new HttpCookie("CookieColour");

            if (colourChange)
            {
                //set selected theme
                cssPath += cssFile;
                cookie.Value = cssPath;
            }
            else
            {
                //set default theme
                //cssPath += @"switcher.css";
                cookie.Value = cssPath;
            }

            controller.HttpContext.Response.Cookies.Add(cookie);

        }

        public static void SetLayout(this Controller controller, string cssFile, bool layoutChange = false)
        {
            string cssPath = string.Empty;

            HttpCookie cookie = new HttpCookie("CookieLayout");

            if (layoutChange)
            {
                //set selected theme
                cssPath += cssFile;
                cookie.Value = cssPath;
            }
            else
            {
                //set default theme
                //cssPath += @"switcher.css";
                cookie.Value = cssPath;
            }

            controller.HttpContext.Response.Cookies.Add(cookie);

        }

        public static void SetHeader(this Controller controller, string cssFile, bool headerChange = false)
        {
            string cssPath = string.Empty;

            HttpCookie cookie = new HttpCookie("CookieHeader");

            if (headerChange)
            {
                //set selected theme
                cssPath += cssFile;
                cookie.Value = cssPath;
            }
            else
            {
                //set default theme
                //cssPath += @"switcher.css";
                cookie.Value = cssPath;
            }

            controller.HttpContext.Response.Cookies.Add(cookie);

        }

        public static void SetDarkBG(this Controller controller, string cssFile, bool dBGChange = false)
        {
            string cssPath = string.Empty;

            HttpCookie cookie = new HttpCookie("CookieDarkBG");

            if (dBGChange)
            {
                //set selected theme
                cssPath += cssFile;
                cookie.Value = cssPath;
            }
            else
            {
                //set default theme
                //cssPath += @"switcher.css";
                cookie.Value = cssPath;
            }

            controller.HttpContext.Response.Cookies.Add(cookie);

        }

        public static void SetLightBG(this Controller controller, string cssFile, bool lBGChange = false)
        {
            string cssPath = string.Empty;

            HttpCookie cookie = new HttpCookie("CookieLightBG");

            if (lBGChange)
            {
                //set selected theme
                cssPath += cssFile;
                cookie.Value = cssPath;
            }
            else
            {
                //set default theme
                //cssPath += @"switcher.css";
                cookie.Value = cssPath;
            }

            controller.HttpContext.Response.Cookies.Add(cookie);

        }

    }
}