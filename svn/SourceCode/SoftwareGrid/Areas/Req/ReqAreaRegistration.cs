using System.Web.Mvc;

namespace SoftwareGrid.Areas.Req
{
    public class ReqAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Req";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Req_default",
                "Req/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
