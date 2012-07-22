using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


public static class HtmlHelperExtensions
{
    public static IHtmlString RenderTheme(this HtmlHelper htmlHelper)
    {
        string themePath = String.Empty;
        string themeCookies = String.Empty;

        //string cssPath = @"switcher.css";
        //string cssPath = @"switcher";

        HttpContext httpContext = System.Web.HttpContext.Current;

        if (httpContext.Request.Cookies["CookieTheme"] != null)
        {
            themeCookies += httpContext.Request.Cookies["CookieTheme"].Value.ToString();
        }

        if (!String.IsNullOrEmpty(themeCookies))
        {
            themePath += themeCookies;
        }

        return MvcHtmlString.Create(themePath);
    }

    public static IHtmlString RenderColour(this HtmlHelper htmlHelper)
    {
        string themePath = String.Empty;
        string themeCookies = String.Empty;

        //string cssPath = @"switcher.css";
        //string cssPath = @"switcher";

        HttpContext httpContext = System.Web.HttpContext.Current;

        if (httpContext.Request.Cookies["CookieColour"] != null)
        {
            themeCookies += httpContext.Request.Cookies["CookieColour"].Value.ToString();
        }

        if (!String.IsNullOrEmpty(themeCookies))
        {
            themePath += themeCookies;
        }

        return MvcHtmlString.Create(themePath);
    }

    public static IHtmlString RenderLayout(this HtmlHelper htmlHelper)
    {
        string layoutPath = String.Empty;
        string layoutCookies = String.Empty;

        //string cssPath = @"switcher.css";
        //string cssPath = @"switcher";

        HttpContext httpContext = System.Web.HttpContext.Current;

        if (httpContext.Request.Cookies["CookieLayout"] != null)
        {
            layoutCookies += httpContext.Request.Cookies["CookieLayout"].Value.ToString();
        }

        if (!String.IsNullOrEmpty(layoutCookies))
        {
            layoutPath += layoutCookies;
        }

        return MvcHtmlString.Create(layoutPath);
    }

    public static IHtmlString RenderHeader(this HtmlHelper htmlHelper)
    {
        string headerPath = String.Empty;
        string headerCookies = String.Empty;

        //string cssPath = @"switcher.css";
        //string cssPath = @"switcher";

        HttpContext httpContext = System.Web.HttpContext.Current;

        if (httpContext.Request.Cookies["CookieHeader"] != null)
        {
            headerCookies += httpContext.Request.Cookies["CookieHeader"].Value.ToString();
        }

        if (!String.IsNullOrEmpty(headerCookies))
        {
            headerPath += headerCookies;
        }

        return MvcHtmlString.Create(headerPath);
    }

    public static IHtmlString RenderDarkBG(this HtmlHelper htmlHelper)
    {
        string dbgPath = String.Empty;
        string dbgCookies = String.Empty;

        //string cssPath = @"switcher.css";
        //string cssPath = @"switcher";

        HttpContext httpContext = System.Web.HttpContext.Current;

        if (httpContext.Request.Cookies["CookieDarkBG"] != null)
        {
            dbgCookies += httpContext.Request.Cookies["CookieDarkBG"].Value.ToString();
        }

        if (!String.IsNullOrEmpty(dbgCookies))
        {
            dbgPath += dbgCookies;
        }

        return MvcHtmlString.Create(dbgPath);
    }

    public static IHtmlString RenderLightBG(this HtmlHelper htmlHelper)
    {
        string lbgPath = String.Empty;
        string lbgCookies = String.Empty;

        //string cssPath = @"switcher.css";
        //string cssPath = @"switcher";

        HttpContext httpContext = System.Web.HttpContext.Current;

        if (httpContext.Request.Cookies["CookieLightBG"] != null)
        {
            lbgCookies += httpContext.Request.Cookies["CookieLightBG"].Value.ToString();
        }

        if (!String.IsNullOrEmpty(lbgCookies))
        {
            lbgPath += lbgCookies;
        }

        return MvcHtmlString.Create(lbgPath);
    }
}
