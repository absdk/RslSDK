using System;
using System.ComponentModel.DataAnnotations;
using SoftwareGrid.DataLogic.Attributes;

namespace SoftwareGrid.DataLogic.Models
{
    public partial class AppMenu
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 AppMenuID { get; set; }

        [Required(ErrorMessage = "Menu Catagory is required")]
        [Display(Name = "Select Menu Category")]
        [ForeignKey("AppMenuCategory")]
        [IncludeInList( DisplayName="Menu Category", AllowWidthInPercentage=true, IncludeInGrid=true, Sequence=1, Width=15, AllowSearch=true)]
        public Int32 AppMenuCategoryID { get; set; }

        [Display(Name = "Select Parent Menu")]
        [IncludeInList(DisplayName = "Parent Menu", AllowWidthInPercentage = true, IncludeInGrid = true, Sequence = 2, Width = 15, AllowSearch = true)]
        public Int32? AppParentMenuID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Menu Name")]
        [StringLength(128)]
        [IncludeInList(AllowWidthInPercentage = true, IncludeInGrid = true, Sequence = 3, Width = 20, AllowSearch = true)]
        public String Name { get; set; }

        [Display(Name = "Menu Icon Name")]
        public String MenuIconName { get; set; }

        [Display(Name = "Menu Icon")]
        public Byte[] MenuIcon { get; set; }

        [Display(Name = "Is Blank or Parent Nod")]
        public Boolean IsBlank { get; set; }

        //is parent or child code should be written here, means menu, sub menu, sub menu, sub menu 
        //public Boolean IsBlank { get; set; }
        [Display(Name = "Area Name")]
        [StringLength(128)]
        [IncludeInList(AllowWidthInPercentage = true, IncludeInGrid = true, Sequence = 4, Width = 10, AllowSearch = true)]
        public String AreaName { get; set; }

        [Display(Name = "Controller Name")]
        [StringLength(128)]
        [IncludeInList(AllowWidthInPercentage = true, IncludeInGrid = true, Sequence = 5, Width = 20, AllowSearch = true)]
        public String ControllerName { get; set; }

        [Display(Name = "Action Name")]
        [StringLength(128)]
        [IncludeInList(AllowWidthInPercentage = true, IncludeInGrid = true, Sequence = 6, Width = 10, AllowSearch = true)]
        public String ActionName { get; set; }
        //this menu will be in a tree, so from the rightside grid list the item can be dropped into the menu

        [Display(AutoGenerateField = false)]
        public Int32? MenuSequenceNumber { get; set; }
        //this dont have to be shown, drag and drop should create this nummber automatically 

        public virtual AppMenuCategory AppMenuCategory { get; set; }
        
        [ForeignKey("AppParentMenuID")]
        public virtual AppMenu AppParentMenu { get; set; }
        //public IEnumerable<AppMenu> ChildMenuCategories { get; set; }


    }

    public partial class AppMenuCategory
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 AppMenuCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }
    }

    public partial class AppSiteMapRolePermission
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 AppSiteMapRolePermissionID { get; set; }

        [Required(ErrorMessage = "User Role is required")]
        [ForeignKey("UserRole")]
        [Display(Name = "Role Name")]
        public Int32 UserRoleID { get; set; }

        [Required(ErrorMessage = "Menu is required")]
        [Display(Name = "Select Menu")]
        [ForeignKey("AppMenu")]
        public Int32 AppMenuID { get; set; }

        virtual public UserRole UserRole { get; set; }
        public virtual AppMenu AppMenu { get; set; }
    }
}
