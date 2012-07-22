using System.Web.Mvc;

namespace SoftwareGrid.Areas.UM
{
    public class UMAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "UM";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "UM_default",
                "UM/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
