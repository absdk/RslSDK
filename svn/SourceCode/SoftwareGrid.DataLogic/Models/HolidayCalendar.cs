

//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  www.softwaregrid.com
//
//*********************************************************

using System;
using System.ComponentModel.DataAnnotations;
using SoftwareGrid.DataLogic.Attributes;

namespace SoftwareGrid.DataLogic.Models
{
	public class HolidayCalendar
	{
		
		[Required]
		[Display(AutoGenerateField=false)]
		[Key]
    	public Int32 HolidayCalendarID { get; set; }

		[Required(ErrorMessage="Name is required")]
		[Display(Name="Name")]
		[StringLength(128)]
    	public String Name { get; set; }

		[Required(ErrorMessage="Holiday Calender Year is required")]
		[Display(Name="Holiday Calender Year")]
		public Int32 HolidayCalendarYear { get; set; }

		[Display(Name="Start Date")]
		[DataType(DataType.DateTime)]
    	public DateTime StartDate { get; set; }

		[Display(Name="End Date")]
		[DataType(DataType.DateTime)]
    	public DateTime EndDate { get; set; }

		[Display(Name="Description")]
		[StringLength(256)]
    	public String Description { get; set; }
           	  	

	}
    public class HolidayCalendarHolidayList
    {

        [Required(ErrorMessage = "Holiday Calender Holiday List is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 HolidayCalendarHolidayListID { get; set; }

        [Required(ErrorMessage = "Holiday Calender  is required")]
        [Display(Name = "Holiday Calender ")]
        [ForeignKey("HolidayCalendar")]
        public Int32 HolidayCalendarID { get; set; }

        [Display(Name = "Holiday Category")]
        [ForeignKey("HolidayCategory")]
        public Int32 HolidayCategoryID { get; set; }

        [Display(Name = "Holiday Name")]
        [StringLength(64)]
        public String HolidayName { get; set; }

        [Display(Name = "Holiday Date")]
        [DataType(DataType.DateTime)]
        public DateTime HolidayDate { get; set; }

        public virtual HolidayCalendar HolidayCalendar { get; set; }

       
    }
    public class HolidayCalendarWeeklyHoliday
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 HolidayCalendarWeeklyHolidayID { get; set; }

        [Required(ErrorMessage = "Holiday Calender  is required")]
        [Display(Name = "Holiday Calender ")]
        [ForeignKey("HolidayCalendar")]
        public Int32 HolidayCalendarID { get; set; }

        [Display(Name = "Sunday")]
        public Boolean Sunday { get; set; }

        [Display(Name = "Monday")]
        public Boolean Monday { get; set; }

        [Display(Name = "Tuesday")]
        public Boolean Tuesday { get; set; }

        [Display(Name = "Wednesday")]
        public Boolean Wednesday { get; set; }

        [Display(Name = "Thursday")]
        public Boolean Thursday { get; set; }

        [Display(Name = "Friday")]
        [ForeignKey("Frid")]
        public Boolean Friday { get; set; }

        [Display(Name = "Saturday")]
        public Boolean Saturday { get; set; }

        public virtual HolidayCalendar HolidayCalendar { get; set; }
               

    }

    public class HolidayCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 HolidayCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }


    }
    //public class EmployeeHolidayCalendar
    //{

    //    [Required]
    //    [Display(AutoGenerateField = false)]
    //    [Key]
    //    public Int32 EmployeeHolidayCalendarID { get; set; }

    //    [Required(ErrorMessage = "Employee is required")]
    //    [Display(Name = "Employee")]
    //    [ForeignKey("Employee")]
    //    public Int32 EmployeeID { get; set; }

    //    [Display(Name = "Organization Holiday")]
    //    [ForeignKey("OrganizationHolidayCalendar")]
    //    public Int32 OrganizationHolidayCalendarID { get; set; }

    //    [Display(Name = "Project Holiday")]
    //    [ForeignKey("SpmProjectHolidayCalendar")]
    //    public Int32 SpmProjectHolidayCalendarID { get; set; }


    //    [Required(ErrorMessage = "Is Active is required")]
    //    [Display(Name = "Is Active")]
    //    public Boolean IsActive { get; set; }

    //    public virtual User User { get; set; }
    //    public virtual OrganizationHolidayCaldender OrganizationHolidayCaldender { get; set; }
    //    public virtual SpmProjectHolidayCaldender SpmProjectHolidayCaldender { get; set; }

    //}

}
	