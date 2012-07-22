using System.Web.Mvc;

namespace SoftwareGrid.Areas.OM
{
    public class OMAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "OM";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "OM_default",
                "OM/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
