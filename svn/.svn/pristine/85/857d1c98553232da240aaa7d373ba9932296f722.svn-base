

//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  http://www.softwaregrid.com
//
//*********************************************************

using System;
using System.ComponentModel.DataAnnotations;
using SoftwareGrid.DataLogic.Attributes;

namespace SoftwareGrid.DataLogic.Models
{
	public class Organization
	{		
		[Required(ErrorMessage="Organization is required")]
		[Display(AutoGenerateField=false)]
		[Key]
    	public Int32 OrganizationID { get; set; }

		[ForeignKey("ParentOrganization")]
        [Display(Name = "Organization Name")]
        public Int32? ParentOrganizationID { get; set; }        
        
        [Required(ErrorMessage="Name is required")]
		[Display(Name="Name - Trade Name")]
		[StringLength(128)]
        [IncludeInList(Sequence = 2, AllowSearch = true, Width = 30, AllowWidthInPercentage = true)]
    	public String Name { get; set; }

		[Display(Name="Legal Business Name")]
		[StringLength(256)]
        [IncludeInList(Sequence = 4, AllowSearch = false, Width = 25, AllowWidthInPercentage = true)]
    	public String LegalBusinessName { get; set; }

		[Display(Name="Organization Code Number")]
		[StringLength(128)]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
    	public String OrganizationCodeNumber { get; set; }
               
        [Required(ErrorMessage = "Organization Category is required")]
        [ForeignKey("OrganizationCategory")]
        [IncludeInList(Sequence = 3, AllowSearch = true, Width = 20, AllowWidthInPercentage = true)]
        public Int32 OrganizationCategoryID { get; set; }

		[Required(ErrorMessage="About The Organization is required")]
		[Display(Name="About The Organization")]
        [MaxLength]
        [DataType(DataType.Html)]
    	public String AboutTheOrganization { get; set; }

        [Display(Name = "Web Address")]
        [StringLength(256)]
        public String WebAddress { get; set; }

        [Display(Name = "Organization Logo")]
        public Byte[] Logo { get; set; }
      
        [Display(Name = "Org Chart Sequence Number")]
        public Double OrgChartSequenceNumber { get; set; }
             
        public virtual OrganizationCategory OrganizationCategory { get; set; }
        public virtual Organization ParentOrganization { get; set; }
	}

    public class OrganizationAddress
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationAddressID { get; set; }

        [Required]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [ForeignKey("OrganizationAddressCategory")]
        [Display(Name = "Address Category")]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32? OrganizationAddressCategoryID { get; set; }
        //dropdown to select category by name

        [Required(ErrorMessage = "Location Name is required")]
        [Display(Name = "Location Name")]
        [StringLength(256)]
        public String LocationName { get; set; }

        [Display(Name = "Address Line")]
        [StringLength(256)]
        public String AddressLine { get; set; }

        [Display(Name = "Post Office Box Number")]
        [IncludeInList(Sequence = 6, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32 PostBoxNumber { get; set; }

        [Required(ErrorMessage = "City Name is required")]
        [Display(Name = "City Name")]
        [StringLength(128)]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String CityName { get; set; }

        [ForeignKey("Country")]
        [Display(Name = "Country")]
        [IncludeInList(Sequence = 3, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32? CountryID { get; set; }

        [ForeignKey("State")]
        [Display(Name = "State")]
        [IncludeInList(Sequence = 4, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32? StateID { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(16)]
        public String ZipCode { get; set; }

        [Display(Name = "Office Phone")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        [IncludeInList(Sequence = 5, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String OfficePhone { get; set; }

        [Display(Name = "Fax Number")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String FaxNumber { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        public String EmailAddress { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual OrganizationAddressCategory OrganizationAddressCategory { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }

    }
    public class OrganizationBusinessDivision
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationBusinessDivisionID { get; set; }

        [Required]
        [Display(Name = "Organization")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [Display(Name = "Division Name")]
        [StringLength(128)]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 50, AllowWidthInPercentage = true)]
        public String DivisionName { get; set; }

        [Display(Name = "Code Number")]
        [StringLength(128)]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String CodeNumber { get; set; }

        [Display(Name = "Division Sequence Number")]
        [IncludeInList(Sequence = 3, DisplayName = "Sequence Number", AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Double DepartmentNumber { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        public virtual Organization Organization { get; set; }
        

    }
    public class OrganizationDepartment
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationDepartmentID { get; set; }

        [Required]
        [Display(Name = "Organization")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [Display(Name = "Business Division")]
        [ForeignKey("OrganizationBusinessDivision")]
        [IncludeInList(Sequence = 3, DisplayName="Business Division", AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Int32? OrganizationBusinessDivisionID { get; set; }

        [Display(Name = "Parent Department")]
        [ForeignKey("ParentDepartment")]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Int32? ParentDepartmentID { get; set; }

        [Display(Name = "Department name")]
        [StringLength(128)]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String DepartmentName { get; set; }

        
        [Display(Name = "Department Code Number")]
        [StringLength(128)]
        [IncludeInList(Sequence = 4, DisplayName = "Code Number", AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String DepartmentCodeNumber { get; set; }

        [Display(Name = "Department Sequence Number")]
        [IncludeInList(Sequence = 5, DisplayName = "Sequence Number", AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Double DepartmentNumber { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual OrganizationBusinessDivision OrganizationBusinessDivision { get; set; }
        public virtual OrganizationDepartment ParentDepartment { get; set; }


    }

    public class OrganizationPosition
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationPositionID { get; set; }

        [Required(ErrorMessage = "Organization is required")]
        [Display(Name = "Organization")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }
       
        [Display(Name = "Business Division")]
        [ForeignKey("OrganizationBusinessDivision")]
        [IncludeInList(Sequence = 3, AllowSearch = false, Width = 30, AllowWidthInPercentage = true)]
        public Int32? OrganizationBusinessDivisionID { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        [ForeignKey("OrganizationDepartment")]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 30, AllowWidthInPercentage = true)]
        public Int32? OrganizationDepartmentID { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [Display(Name = "Position")]
        [StringLength(128)]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 30, AllowWidthInPercentage = true)]
        public String PositionName { get; set; }

        [Display(Name = "Job Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Display(Name = "Hierarchical Number")]
        public Double ChartHierarchicalNumber { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual OrganizationBusinessDivision OrganizationBusinessDivision { get; set; }
        public virtual OrganizationDepartment OrganizationDepartment { get; set; }
        
    }
    public class OrganizationPositionCompetency
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationPositionCompetencyID { get; set; }

        [Required]
        [Display(Name = "Organization Position")]
        [ForeignKey("OrganizationPosition")]
        public Int32 OrganizationPositionID { get; set; }


        [Display(Name = "Skills Expertise Education")]
        [ForeignKey("SkillsExpEdu")]
        public Int32 SkillsExpEduID { get; set; }

        [Display(Name = "Hierarchical Number")]
        public Double HierarchicalNumber { get; set; }

        public virtual OrganizationPosition OrganizationPosition { get; set; }
        public virtual SkillsExpEdu SkillsExpEdu { get; set; }

    }
    public class OrganizationPositionSalaryStaffingRate
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationPositionSalaryStaffingRateID { get; set; }

        [Required]
        [Display(Name = "Organization Position")]
        [ForeignKey("OrganizationPosition")]
        public Int32 OrganizationPositionID { get; set; }
        
        [Display(Name = "Salary Rate Category")]
        [ForeignKey("SalaryRateType")]
        public Int32 SalaryRateTypeID { get; set; }

        [Required(ErrorMessage = "Minimum Rate is required")]
        [Display(Name = "Minimum Rate")]
        public Double MinimumRate { get; set; }

        [Required(ErrorMessage = "Maximum Rate is required")]
        [Display(Name = "Maximum Rate")]
        public Double MaximumRate { get; set; }

        [Display(Name = "Average Rate")]
        public Double AverageRate { get; set; }

        [ForeignKey("Currency")]
        public Int32? CurrencyID { get; set; }

        public virtual OrganizationPosition OrganizationPosition { get; set; }
        public virtual SkillsExpEdu SkillsExpEdu { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual SalaryRateType SalaryRateType { get; set; }

    }

    public class OrganizationProject
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationProjectID { get; set; }

        [Display(Name = "Organization Name")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Project Name")]
        [StringLength(128)]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 70, AllowWidthInPercentage = true)]
        public String Name { get; set; }

        [Display(Name = "Project Code Number")]
        [StringLength(128)]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String ProjectCodeNumber { get; set; }

        [Required(ErrorMessage = "Project Description is required")]
        [Display(Name = "Project Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String ProjectDescription { get; set; }

        public virtual Organization Organization { get; set; }
    }

    public class OrganizationWorkforcePlan
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationWorkforcePlanID { get; set; }

        [Required(ErrorMessage = "Organization is required")]
        [Display(Name = "Primary Organizatin")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Title")]
        [StringLength(128)]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 60, AllowWidthInPercentage = true)]
        public String Title { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Required(ErrorMessage = "Startdate is required")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public DateTime Startdate { get; set; }

        [Required(ErrorMessage = "End Date is required")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        [IncludeInList(Sequence = 3, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public DateTime EndDate { get; set; }

        public virtual Organization Organization { get; set; }

    }
    public class OrganizationWorkforcePlanDetail
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationWorkforcePlanDetailID { get; set; }

        [Display(Name = "Select Organization Workforce Plan")]
        [ForeignKey("OrganizationWorkforcePlan")]
        public Int32 OrganizationWorkforcePlanID { get; set; }


        [Display(Name = "Business Division")]
        [ForeignKey("OrganizationBusinessDivision")]
        public Int32? OrganizationBusinessDivisionID { get; set; }

        [Display(Name = "Select a project")]
        [ForeignKey("OrganizationProject")]
        public Int32? OrganizationProjectID { get; set; }

        
        [Display(Name = "Department")]
        [ForeignKey("OrganizationDepartment")]
        public Int32? OrganizationDepartmentID { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [Display(Name = "Position")]
        [ForeignKey("OrganizationPosition")]
        public Int32 OrganizationPositionID { get; set; }

        [Display(Name = "Number of Employee To be Hired")]
        public Double NumberOfEmployeeTobeHired { get; set; }

        [Display(Name = "Already Hired")]
        public Double HiredNumberEmployee { get; set; }

        [ForeignKey("EmploymentType")]
        public Int32? EmploymentTypeID { get; set; }

        [Display(Name = "Contract Period")]
        [StringLength(128)]
        public String ContractPeriod { get; set; }
        //if contract employment duration

        [Required(ErrorMessage = "Planned Start Date is required")]
        [Display(Name = "Planned Start Date")]
        [DataType(DataType.Date)]
        public DateTime PlannedStartDate { get; set; }

        [Display(Name = "Notes or Approval Code")]
        [StringLength(256)]
        public String Notes { get; set; }

        [Display(Name = "Hierarchical Sequence")]
        public Double HierarchicalSequence { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual OrganizationProject OrganizationProject { get; set; }
        public virtual EmploymentType EmploymentType { get; set; }
        public virtual OrganizationWorkforcePlan OrganizationWorkforcePlan { get; set; }
        public virtual OrganizationBusinessDivision OrganizationBusinessDivision { get; set; }
        public virtual OrganizationDepartment OrganizationDepartment { get; set; }
        public virtual OrganizationPosition OrganizationPosition { get; set; }

    }
    
    public  class OrganizationalChart
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationalChartID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

        //employee
        //sequence
        //is published



    }   
 
    public  class OrganizationDocument
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationDocumentID { get; set; }

        [Required(ErrorMessage = "Organization is required")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [ForeignKey("OrganizationDocumentFolder")]
        [IncludeInList(Sequence = 4, DisplayName="Folder Name", AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Int32? OrganizationDocumentFolderID { get; set; }
        
        [Display(Name = "Document Category")]
        [ForeignKey("OrganizationDocumentCategory")]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Int32? OrganizationDocumentCategoryID { get; set; }        

        [Required(ErrorMessage = "Document Title is required")]
        [Display(Name = "Title")]
        [StringLength(256)]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 30, AllowWidthInPercentage = true)]
        public String DocumentTitle { get; set; }

        [Display(Name = "Upload File")]
        public Byte[] DocumentFile { get; set; }

        [Display(Name = "Original File Name, Extension and Size")]
        [StringLength(256)]
        [IncludeInList(Sequence = 3, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String OriginalFileInfo { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual OrganizationDocumentCategory OrganizationDocumentCategory { get; set; }
        public virtual OrganizationDocumentFolder OrganizationDocumentFolder { get; set; }

    }
    public  class OrganizationDocumentFolder
    {

        [Required(ErrorMessage = "Contact Folder is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationDocumentFolderID { get; set; }

        [Required(ErrorMessage = "Organization is required")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [Display(Name = "Parent Folder")]
        [ForeignKey("ParentFolder")]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 30, AllowWidthInPercentage = true)]
        public Int32 ParentFolderID { get; set; }

        [Required(ErrorMessage = "Folder Name is required")]
        [Display(Name = "Folder Name")]
        [StringLength(64)]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 30, AllowWidthInPercentage = true)]
        public String FolderName { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }

        [Required(ErrorMessage = "Created By User is required")]
        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        [IncludeInList(Sequence = 3, AllowSearch = false, Width = 30, AllowWidthInPercentage = true)]
        public Int32 CreatedByUserID { get; set; }

        public virtual OrganizationDocumentFolder ParentFolder { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual Organization Organization { get; set; }

    }

    public  class OrganizationNote
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationNoteID { get; set; }

        [Required(ErrorMessage = "Organization is required")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [Required(ErrorMessage = "Note Category is required")]
        [Display(Name = "Organization Note Category")]
        [ForeignKey("OrganizationNoteCategory")]
        [IncludeInList(Sequence = 1, DisplayName="Note Category", AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32 OrganizationNoteCategoryID { get; set; }

        [Required(ErrorMessage = "Note Created By is required")]
        [Display(Name = "Wrtitten By")]
        [ForeignKey("WrittenByUser")]
        [IncludeInList(Sequence = 3, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Int32 WrittenByUserID { get; set; }

        [Required(ErrorMessage = "Create Date Time is required")]
        [Display(Name = "Create Date Time")]
        [DataType(DataType.DateTime)]
        [IncludeInList(Sequence = 4, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public DateTime CreateDateTime { get; set; }

        [Required(ErrorMessage = "Note Detail is required")]
        [Display(Name = "Note")]
        [MaxLength]
        [DataType(DataType.Html)]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 40, AllowWidthInPercentage = true)]
        public String Note { get; set; }

        public virtual OrganizationNoteCategory OrganizationNoteCategory { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual User WrittenByUser { get; set; }
    }
    
    public class OrganizationCategory
    {
        [Required(ErrorMessage = "Organization Category is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

        [Display(Name = "Description")]
        [StringLength(256)]
        public String Description { get; set; }
    }

    public class OrganizationNoteCategory
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationNoteCategoryID { get; set; }

        [Required(ErrorMessage = "Organization Note Category is required")]
        [Display(Name = "Name")]
        [StringLength(256)]
        public String Name { get; set; }
    }

    public class OrganizationDocumentCategory
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationDocumentCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }
    }

    public class OrganizationAddressCategory
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationAddressCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }
    }    

    public  class OrganizationBankInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationBankInfoID { get; set; }

        [Required(ErrorMessage = "Organization is required")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [Display(Name = "Bank Name")]
        [StringLength(128)]
        [IncludeInList(Sequence = 1, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String BankName { get; set; }

        [Display(Name = "Bank Address")]
        [StringLength(512)]
        [IncludeInList(Sequence = 2, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String BankAddress { get; set; }

        [Display(Name = "P O Box")]
        public Int32 POBox { get; set; }

        [Display(Name = "Bank City")]
        [StringLength(256)]
        public String BankCity { get; set; }

        [Display(Name = "State")]
        [ForeignKey("State")]
        public Int32? StateID { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(15)]
        public String ZipCode { get; set; }

        [Display(Name = "Country")]
        [ForeignKey("Country")]
        public Int32? CountryID { get; set; }

        [Display(Name = "Account Number")]
        [StringLength(512)]
        [IncludeInList(Sequence = 3, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String ComanyBankAccountNumber { get; set; }

        [Display(Name = "Account Type")]
        [StringLength(256)]
        public String BankAccountType { get; set; }

        [Display(Name = "Swipe Code")]
        [StringLength(30)]
        [IncludeInList(Sequence = 4, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String SwipeCode { get; set; }

        [Display(Name = "Routing No")]
        [StringLength(30)]
        [IncludeInList(Sequence = 5, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String RoutingNo { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }

     }

    public  class OrganizationHolidayCalendar
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 OrganizationHolidayCalendarID { get; set; }

        [Required(ErrorMessage = "Organization is required")]
        [Display(AutoGenerateField = false)]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [Required(ErrorMessage = "Holiday Calendar  is required")]
        [Display(Name = "Holiday Calendar ")]
        [ForeignKey("HolidayCalendar")]
        public Int32 HolidayCalendarID { get; set; }

        [Required(ErrorMessage = "Is Active is required")]
        [Display(Name = "Is Active")]
        public Boolean IsActive { get; set; }

        //public virtual HolidayCalendar HolidayCalendar { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual HolidayCalendar HolidayCalendar { get; set; }

    }


   



















}
	