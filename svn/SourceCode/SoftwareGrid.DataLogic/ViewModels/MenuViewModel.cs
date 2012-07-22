using System;
using System.Collections.Generic;

namespace SoftwareGrid.DataLogic.ViewModels
{
    public class MenuViewModel
    {
        public Int32 AppMenuID { get; set; } 
        public string Name { get; set; }
        public string MenuIconName { get; set; }
        public String AreaName { get; set; }
        public String ControllerName { get; set; }
        public String ActionName { get; set; }
        public int? Sequence { get; set; }
        public List<MenuViewModel> SubMenuList { get; set; }
    }
}
