using System.Web.Mvc;

namespace SoftwareGrid.Areas.VMS
{
    public class VMSAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "VMS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "VMS_default",
                "VMS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
