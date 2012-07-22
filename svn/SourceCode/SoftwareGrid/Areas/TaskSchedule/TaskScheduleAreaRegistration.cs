using System.Web.Mvc;

namespace SoftwareGrid.Areas.TaskSchedule
{
    public class TaskScheduleAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "TaskSchedule";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "TaskSchedule_default",
                "TaskSchedule/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
