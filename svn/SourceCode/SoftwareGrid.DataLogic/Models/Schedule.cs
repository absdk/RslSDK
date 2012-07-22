

//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  Http://www.softwaregrid.com
//
//*********************************************************

using System;
using System.ComponentModel.DataAnnotations;

namespace SoftwareGrid.DataLogic.Models
{
	public class Schedule
	{
		
		[Required]
		[Display(AutoGenerateField=false)]
		[Key]
    	public Int32 ScheduleID { get; set; }

		[Required(ErrorMessage="User Name is required")]
		[Display(Name="Created By")]
        [ForeignKey("CreatedByUser")]
    	public Int32 UserID { get; set; }

	
		[Display(Name="Schedule Category")]
        [ForeignKey("ScheduleCategory")]
    	public Int32? ScheduleCategoryID { get; set; }
        //default work or setup from mysettings

		[Required(ErrorMessage="Subject is required")]
		[Display(Name="Subject")]
		[StringLength(256)]
    	public String Subject { get; set; }

		[Display(Name="Description")]
		[MaxLength]
    	public String Description { get; set; }

	
		[Display(Name="Start Time")]
		[DataType(DataType.DateTime)]
		public DateTime StartTime { get; set; }

	
		[Display(Name="End Time")]
		[DataType(DataType.DateTime)]
		public DateTime EndTime { get; set; }
        //default endtime to be selected 30 min later, jscript

		[Required(ErrorMessage="Is Reminder is required")]
		[Display(Name="Is Reminder")]
    	public Boolean IsReminder { get; set; }
        //by default true

		[Display(Name="When to Remind")]
		[DataType(DataType.DateTime)]
		public DateTime ReminderTime { get; set; }

		[Display(Name="Setup Recurrence")]
		[StringLength(256)]
    	public String RecurrenceRule { get; set; }
        //weekly, same day every week or month

    
        public virtual ScheduleCategory ScheduleCategory { get; set; }
        public virtual User CreatedByUser { get; set; }
        
        }


    public class ScheduleCategory
	{
		
		[Required]
		[Display(AutoGenerateField=false)]
		[Key]
    	public Int32 ScheduleCategoryID { get; set; }

		[Required(ErrorMessage="Name is required")]
		[Display(Name="Name")]
		[StringLength(64)]
    	public String Name { get; set; }

		[Required(ErrorMessage="Color Code is required")]
		[Display(Name="Color Code for Schedule Category")]
		[StringLength(16)]
    	public String ColorCode { get; set; }
        //color should be selected from color plate, please see LinkedIn
    	}
    	
//Seeddata Schedule Type, Work Planner, Personal, Appointment, Vacation Planner

     public class ScheduleShareByCategory
	{
		
		[Required]
		[Display(AutoGenerateField=false)]
		[Key]
         public Int32 ScheduleShareByCategoryID { get; set; }

		[Required]
		[Display(Name="Primary Schedule User")]
        [ForeignKey("PrimaryUser")]
    	public Int32 PrimaryScheduleUserID { get; set; }

		[Required(ErrorMessage="Schedule Category is required")]
		[Display(Name="Select Schedule Category")]
        [ForeignKey("ScheduleCategory")]
    	public Int32 ScheduleCategoryID { get; set; }

		[Required(ErrorMessage="Member Schedule Share is required")]
		[Display(Name="Member Schedule Share")]
        [ForeignKey("ShareWithUser")]
    	public Int32 SharedWithUserID { get; set; }

        public virtual ScheduleCategory ScheduleCategory { get; set; }
        public virtual User PrimaryUser { get; set; }
        public virtual User ShareWithUser { get; set; }


    	}

    public class ScheduleShareParticipant
	{
		
		[Required]
		[Display(AutoGenerateField=false)]
		[Key]
        public Int32 ScheduleShareParticipantID { get; set; }

        [Display(Name = "Select Schedule")]
        [ForeignKey("Schedule")]
        public Int32 ScheduleID { get; set; }

        [Required(ErrorMessage = "User is required")]
        [Display(Name = "Select User to Share Schedule")]
        [ForeignKey("ShareScheduleWithUser")]
        public Int32 ShareScheduleWithUserID { get; set; }
        
        public virtual Schedule Schedule { get; set; }
        public virtual User ShareScheduleWithUser { get; set; }

    	}

   }
