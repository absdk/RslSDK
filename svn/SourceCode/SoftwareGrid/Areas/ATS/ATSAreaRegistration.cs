using System.Web.Mvc;

namespace SoftwareGrid.Areas.ATS
{
    public class ATSAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "ATS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ATS_default",
                "ATS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
