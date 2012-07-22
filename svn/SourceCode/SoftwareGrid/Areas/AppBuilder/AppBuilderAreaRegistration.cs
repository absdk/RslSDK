using System.Web.Mvc;

namespace SoftwareGrid.Areas.AppBuilder
{
    public class AppBuilderAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "AppBuilder";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "AppBuilder_default",
                "AppBuilder/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
