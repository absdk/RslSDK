﻿
//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  www.softwaregrid.com

//Software Project Management Module
//
//*********************************************************


using System;
using System.ComponentModel.DataAnnotations;

namespace SoftwareGrid.DataLogic.Models
{
    public class SpmProject
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SoftwareProjectID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Project Title")]
        [MaxLength(200), MinLength(5)]
        public String ProjectTitle { get; set; }

        [Required]
        [Display(Name = "Version Name")]
        [StringLength(64)]
        public String ProjectVersionName { get; set; }

        [Required(ErrorMessage = "Is Template is required")]
        [Display(Name = "Is Template")]
        public Boolean IsTemplate { get; set; }
        //Yes No Button

        [Display(Name = "Project Category")]
        [ForeignKey("SpmProjectCategory")]
        public Int32? SpmProjectCategoryID { get; set; }
        //not mandatory

        [Display(Name = "Project Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }
        //HTML editor, can insert image, table, etc. 

        [Required(ErrorMessage = "Project Status is required")]
        [Display(Name = "Project Status")]
        [ForeignKey("SpmProjectStatusCategory")]
        public Int32 SpmProjectStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Created By User is required")]
        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }
        //by default who is writing it. Option to keep this open. it could be initiated by - in project management team.

        [Required(ErrorMessage = "Created Date is required")]
        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        [Display(Name = "Remarks")]
        [StringLength(256)]
        public String Remarks { get; set; }

        public virtual SpmProjectStatusCategory SpmProjectStatusCategory { get; set; }
        public virtual SpmProjectCategory SpmProjectCategory { get; set; }
        public virtual User CreatedByUser { get; set; }
    }
    public class SpmProjectOrganizationInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectOrganizationInfoID { get; set; }

        [Required]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required]
        [Display(Name = "Organization Name")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        public virtual SpmProject SpmProject { get; set; }
        public virtual Organization Organization { get; set; }

    }
    public class SpmProjectCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class SpmProjectStatusCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }
        //Draft, Initiated, approved, decliend, closed, open and in progress, closing stage, deferred
        //add this to seed data

    }

    public class SpmProjectSkillsExpEduRequirementInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectSkillsExpEduRequirementInfoID { get; set; }

        [Required]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        
        [Required]
        [Display(Name = "SkillsExpEdu")]
        [ForeignKey("SkillsExpEdu")]
        public Int32 SkillsExpEduID { get; set; }

        public virtual SpmProject SpmProject { get; set; }
        public virtual SkillsExpEdu SkillsExpEdu { get; set; }


    }
    public class SpmDepartment
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmDepartmentID { get; set; }

        [Required]
        [Display(Name = "Project Name")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }
        //Project ID will be from the landing pages

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        [ForeignKey("Department")]
        public Int32 DepartmentID { get; set; }

        [Display(Name = "Project Chart Hierarchical Number")]
        public Double ProjectChartHierarchicalNumber { get; set; }
        //drag drop from master to here and move up and down the department name

        public virtual SpmProject SpmProject { get; set; }
        public virtual Department Department { get; set; }

    }
    public class SpmPosition
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 JobTitleAndDepartmentID { get; set; }

        [Required]
        [Display(Name = "Project Name")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }
        //Project ID will be from the landing pages

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        [ForeignKey("SpmDepartment")]
        public Int32 SpmDepartmentID { get; set; }
        //Treeview

        [Required(ErrorMessage = "Position is required")]
        [Display(Name = "Position")]
        [ForeignKey("Position")]
        public Int32 PositionID { get; set; }
        //Treeview

        [Display(Name = "Job Description")]
        [MaxLength]
        public String Description { get; set; }
        //Job Description will be copied from master data and can be updated here

        [Display(Name = "Project Chart Hierarchical Number")]
        public Double ProjectChartHierarchicalNumber { get; set; }
        //drag drop from master to here and move up and down the department name
        //Can move and down the position. Position can be dropped on top of department
        //it can display like a chart and later one show who is in this role

        public virtual SpmProject SpmProject { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }

    }

    public class SpmLocationInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 PMLocationID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Display(Name = "Project Location Category")]
        [ForeignKey("SpmProjectLocationCategory")]
        public Int32 SpmProjectLocationCategoryID { get; set; }


        [Required(ErrorMessage = "Location Title is required")]
        [Display(Name = "Location Title")]
        [StringLength(256)]
        public String LocationTitle { get; set; }

        [Display(Name = "Address")]
        [StringLength(256)]
        public String Address { get; set; }

        [Display(Name = "City")]
        [StringLength(256)]
        public String City { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(64)]
        public String ZipCode { get; set; }

        [Display(Name = "Country")]
        [ForeignKey("Country")]
        public Int32 CountryID { get; set; }

        [Display(Name = "State")]
        [ForeignKey("State")]
        public Int32 StateID { get; set; }

        [Display(Name = "Phone")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String OfficePhone { get; set; }

        [Display(Name = "Fax Number")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String FaxNumber { get; set; }

        [Display(Name = "Primary Email")]
        [StringLength(64)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public String PrimaryEmail { get; set; }

        public virtual SpmProject SpmProject { get; set; }
        public virtual SpmProjectStatusCategory SpmProjectStatusCategory { get; set; }
        public virtual State State { get; set; }
        public virtual Country Country { get; set; }
    }
    public class SpmProjectLocationCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectLocationCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }

    public class SpmProjectTeamMemberInfo
    {

        [Required(ErrorMessage = " Project User Info is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectTeamMemberInfoID { get; set; }

        [Required(ErrorMessage = " Project  is required")]
        [Display(Name = " Project ")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Assignto User is required")]
        [Display(Name = "Assignto User")]
        [ForeignKey("AssigntoUser")]
        public Int32 AssigntoUserID { get; set; }

        [Required(ErrorMessage = "Assign By User is required")]
        [Display(Name = "Assign By User")]
        [ForeignKey("AssignByUser")]
        public Int32 AssignByUserID { get; set; }

        [Required(ErrorMessage = "Assign Date is required")]
        [Display(Name = "Assign Date")]
        [DataType(DataType.DateTime)]
        public DateTime AssignDate { get; set; }

        public virtual User User { get; set; }
        public virtual SpmProject SpmProject { get; set; }

    }
    public class SPmProjectTeamSchedule
    {

        [Required(ErrorMessage = "Project Management is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 PMProjectManagementID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        public virtual SpmProject SpmProject { get; set; }

    }
    public class SpmProjectTeamCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectTeamCategoryID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

        public virtual SpmProject SpmProject { get; set; }

    }
    public class SpmProjectWorkforcePlanning
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectWorkforcePlanningID { get; set; }

        [Required]
        [Display(Name = "Project Name")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }
        //Project ID will be from the landing pages

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        [ForeignKey("SpmDepartment")]
        public Int32 SpmDepartmentID { get; set; }
        //Treeview

        [Required(ErrorMessage = "Position is required")]
        [Display(Name = "Position")]
        [ForeignKey("Position")]
        public Int32 PositionID { get; set; }
        //Treeview

        [Required]
        [Display(Name = "Number of Employee To be Hired")]
        public Int32 NumberOfEmployeeTobeHired { get; set; }

        [Display(Name = "Number Of Employee Hired")]
        public Int32 HiredNumberOfEmployee { get; set; }

        [ForeignKey("EmploymentType")]
        public Int32 EmploymentTypeID { get; set; }

        [Display(Name = "Estimated Duration")]
        [StringLength(128)]
        public String ContractDuration { get; set; }
        //if contract employment duration

        [Display(Name = "Estimated Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime EstimatedStartdate { get; set; }

        [Display(Name = "Estimated End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EstimatedEndDate { get; set; }


        [Display(Name = "Notes or Approval Code")]
        [StringLength(256)]
        public String Notes { get; set; }

        [Display(Name = "Project Chart Hierarchical Number")]
        public Double ProjectChartHierarchicalNumber { get; set; }
        //drag drop from master to here and move up and down the department name
        //Can move and down the position. Position can be dropped on top of department
        //it can display like a chart and later one show who is in this role

        public virtual SpmProject SpmProject { get; set; }
        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }

    }
    public class SpmProjectManagementTeamChart
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectManagementTeamChartID { get; set; }


        [Display(Name = "Select a project")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Chart Title")]
        [StringLength(128)]
        public String ChartTitle { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        [ForeignKey("SpmDepartment")]
        public Int32 SpmDepartmentID { get; set; }

        [Required(ErrorMessage = "Position is required")]
        [Display(Name = "Position")]
        [ForeignKey("SpmPosition")]
        public Int32 SpmPositionID { get; set; }

        //Need User Info here


        public virtual SpmProject SpmProject { get; set; }
        public virtual SpmDepartment SpmDepartment { get; set; }
        public virtual SpmPosition SpmPosition { get; set; }

    }

    public class SpmProjectPhase
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectPhaseID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Phase Title is required")]
        [Display(Name = "Phase Title")]
        [StringLength(128)]
        public String PhaseTitle { get; set; }

        [Display(Name = "Phase Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String PhaseDescription { get; set; }
        //HTML editor, can insert image, table, etc. 

        [Required(ErrorMessage = "Expected Start Date is required")]
        [Display(Name = "Expected Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime ExpectedStartDate { get; set; }

        [Required(ErrorMessage = "Expected End Date is required")]
        [Display(Name = "Expected End Date")]
        [DataType(DataType.DateTime)]
        public DateTime ExpectedEndDate { get; set; }

        [Required(ErrorMessage = "Planned Number Of Days is required")]
        [Display(Name = "PlannedNumber Of Days")]
        public Int32 PlannedNumberOfDays { get; set; }

        [Required(ErrorMessage = "Actual Start Date is required")]
        [Display(Name = "Actual Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime ActualStartDate { get; set; }

        [Required(ErrorMessage = "Actual End Date is required")]
        [Display(Name = "Actual End Date")]
        [DataType(DataType.DateTime)]
        public DateTime ActualEndDate { get; set; }

        [Required(ErrorMessage = "Actaul Number Of Days is required")]
        [Display(Name = "Actaul Number Of Days")]
        public Int32 ActaulNumberOfDays { get; set; }

        public virtual SpmProject SpmProject { get; set; }

    }
    public class SpmProjectPhaseDeliveriableInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectPhaseDeliveriableInfoID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Project Phase is required")]
        [Display(Name = "Select Project Phase")]
        [ForeignKey("SpmProjectPhase")]
        public Int32 SpmProjectPhaseID { get; set; }

        //Need add deliveriable

        [Display(Name = "Expected Delivery Date")]
        [DataType(DataType.DateTime)]
        public DateTime ExpectedDeliveryDate { get; set; }

        [Display(Name = "Actual Delivery Date")]
        [DataType(DataType.DateTime)]
        public DateTime ActualDeliveryDate { get; set; }

        public virtual SpmProject SpmProject { get; set; }
        public virtual SpmProjectPhase SpmProjectPhase { get; set; }

    }
    public class SpmDeliverablesInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmDeliverablesInfoID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required]
        [Display(Name = "Project Deliverables Category")]
        [ForeignKey("SpmDeliverableCategory")]
        public Int32 SpmDeliverableCategory { get; set; }

        [Display(Name = "Deliverable Title")]
        [StringLength(128)]
        public String Name { get; set; }

        [Display(Name = "Deliverable Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String DeliverableDescription { get; set; }
        //HTML editor, can insert image, table, etc.

        [Display(Name = "Percentage Of Entire Project")]
        public Int32 PercentageOfEntireProject { get; set; }

        [Display(Name = "Expected Delivery Date")]
        [DataType(DataType.DateTime)]
        public DateTime ExpectedDeliveryDateTime { get; set; }

        [Display(Name = "Deliverable Status")]
        [ForeignKey("SpmDeliverableStatusCategory")]
        public Int32 SpmDeliverableStatusID { get; set; }

    }
    public class SpmDeliverableCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmDeliverableCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class SpmDeliverableStatusCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmDeliverableStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }

    public class SpmReleasePlan
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmReleasePlanID { get; set; }

        [Required(ErrorMessage = " Project  is required")]
        [Display(Name = " Project ")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Release Name is required")]
        [Display(Name = "Release Name")]
        [StringLength(256)]
        public String ReleaseName { get; set; }

        [Display(Name = "Expected Release Date")]
        [DataType(DataType.DateTime)]
        public DateTime ExpectedReleaseDate { get; set; }

        [Display(Name = "Actual Release Date")]
        [DataType(DataType.DateTime)]
        public DateTime ActualReleaseDate { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }

    }
    public class SpmProjectTimeEstimateInfo
    {

        [Required(ErrorMessage = " Project Time Estimate Info is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectTimeEstimateInfoID { get; set; }

        [Required(ErrorMessage = " Project  is required")]
        [Display(Name = " Project ")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Display(Name = " Module")]
        [ForeignKey("SpmSpecModule")]
        public Int32 SpmSpecModuleID { get; set; }

        [Display(Name = "  Spec")]
        [ForeignKey("SpmSpec")]
        public Int32 SpmSpecID { get; set; }

        [Required(ErrorMessage = "Estimated Hours is required")]
        [Display(Name = "Estimated Hours")]
        public Double EstimatedHours { get; set; }

        [Display(Name = "Estimated Cost")]
        public Double EstimatedCost { get; set; }

        [Display(Name = "Actual Hours")]
        public Double ActualHours { get; set; }

        [Display(Name = "Notes")]
        [StringLength(256)]
        public String Notes { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public virtual SpmSpec SpmSpec { get; set; }
        public virtual SpmSpecModule SpmSpecModule { get; set; }
        public virtual SpmProject SpmProject { get; set; }

    }

    public class SpmSpecModule
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecModuleID { get; set; }

        [Required(ErrorMessage = "Project  is required")]
        [Display(Name = " Project ")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Is Template is required")]
        [Display(Name = "Is Template")]
        public Boolean IsTemplate { get; set; }
        //Yes No Button

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Module Name")]
        [StringLength(256)]
        public String Name { get; set; }

        [Display(Name = "Traceability Id Number")]
        public Int32 TraceabilityIdNumber { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Display(Name = "Sort Order Number")]
        public Int32 SortOrderNumber { get; set; }

        [Display(Name = "Module Status ")]
        [ForeignKey("SpmSpecModuleSpecStatusCategory")]
        public Int32 SpmSpecModuleStatusCategoryID { get; set; }

        [Display(Name = "Display Sort Number")]
        public Int32 DisplaySortNumberNumber { get; set; }

        [Required(ErrorMessage = "Created By User is required")]
        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }

        [Required(ErrorMessage = "Created Date is required")]
        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        public virtual SpmProject SpmProject { get; set; }
        public virtual SpmSpecModuleStatusCategory SpmSpecModuleStatusCategory { get; set; }
        public virtual User CreatedByUser { get; set; }

    }
    public class SpmSpecModuleStatusCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecModuleStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }


    }

    public class SpmSpec
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecID { get; set; }

        [Display(Name = "Parent   Spec")]
        [ForeignKey("ParentSpmSpec")]
        public Int32 ParentSpmSpecID { get; set; }
        //self child-parent link

        [Required(ErrorMessage = "Project  is required")]
        [Display(Name = "Project ")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }
        //auto selected from master pages

        [Required(ErrorMessage = "Spec Category  is required")]
        [Display(Name = " Spec Category ")]
        [ForeignKey("SpmSpecCategory")]
        public Int32 SpmSpecCategoryID { get; set; }
        //functional and non-functional

        [Display(Name = " Select Module")]
        [ForeignKey("SpmSpecModule")]
        public Int32 SpmSpecModuleID { get; set; }

        [Required(ErrorMessage = "Is Template is required")]
        [Display(Name = "Is Template")]
        public Boolean IsTemplate { get; set; }
        //Yes No Button

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Spec Title")]
        [StringLength(256)]
        public String SpecTitle { get; set; }

        [Display(Name = "Traceability Id Number")]
        public Int32 TraceabilityIdNumber { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Display(Name = "Display Sort Number")]
        public Int32 DisplaySortNumberNumber { get; set; }

        [Display(Name = "Spec Status ")]
        [ForeignKey("SpmSpecStatusCategory")]
        public Int32 SpmSpecStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Created By User is required")]
        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }

        [Required(ErrorMessage = "Created Date is required")]
        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        public virtual SpmProject SpmProject { get; set; }
        public virtual SpmSpecModule SpmSpecModule { get; set; }
        public virtual SpmSpecModuleStatusCategory SpmSpecModuleStatusCategory { get; set; }
        public virtual User CreatedByUser { get; set; }

    }
    public class SpmSpecCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

        //spec functional and non-functional

    }
    public class SpmSpecStatusCateory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecStatusCateoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }


    }
    public class SpmSpecPreRequisition
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecPreRequisitionID { get; set; }

        [Display(Name = "Primary Spec")]
        [ForeignKey("PrimarySpmSpec")]
        public Int32 PrimarySpmSpecID { get; set; }

        [Display(Name = "PreRequisition Spec")]
        [ForeignKey("PreRequisitionSpmSpec")]
        public Int32 PreRequisitionSpmSpecID { get; set; }

        public virtual SpmSpec PrimarySpmSpec { get; set; }
        public virtual SpmSpec PreRequisitionSpmSpec { get; set; }


    }
    public class SpmSpecDetailInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecDetailInfoID { get; set; }

        [Required(ErrorMessage = "Spec is required")]
        [Display(Name = "Spec Name")]
        [ForeignKey("SpmSpec")]
        public Int32 SpmSpecID { get; set; }

        [Display(Name = "Select Detail Spec Category")]
        [ForeignKey("SpmSpecDetailInfoCategory")]
        public Int32 SpmSpecDetailInfoCategoryID { get; set; }

        [Display(Name = "Is Template")]
        public Boolean IsTemplate { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Display(Name = "Display Sort Number")]
        public Int32 DisplaySortNumberNumber { get; set; }

        [Required(ErrorMessage = "Created By User is required")]
        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }

        [Required(ErrorMessage = "Created Date is required")]
        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        public virtual SpmSpec SpmSpec { get; set; }
        public virtual SpmSpecDetailInfoCategory SpmSpecDetailInfoCategory { get; set; }
        public virtual User CreatedByUser { get; set; }

    }
    public class SpmSpecDetailInfoCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecDetailInfoCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

        //UI Mockup, Data class, seed data, 

    }
    public class SpmSpecAssignToTeamInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecAssignToTeamInfoID { get; set; }

        [Required]
        [Display(Name = "Select Spec")]
        [ForeignKey("SpmSpec")]
        public Int32 SpmSpecID { get; set; }

        [Display(Name = "Assign to User")]
        [ForeignKey("AssigntoUser")]
        public Int32 AssigntoUserID { get; set; }

        [Display(Name = "Assign Date")]
        [DataType(DataType.DateTime)]
        public DateTime AssignDate { get; set; }

        public virtual User AssignToUser { get; set; }
        public virtual SpmSpec SpmSpec { get; set; }

    }

    public class SpmSpecBuilderQuestionCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecBuilderQuestionCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }
    }
    public class SpmSpecBuilderQuestion
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecBuilderQuestionID { get; set; }

        [Required(ErrorMessage = " Spec Builder Question Category is required")]
        [Display(Name = " Spec Builder Question Category")]
        [ForeignKey("SpmSpecBuilderQuestionCategory")]
        public Int32 SpmSpecBuilderQuestionCategoryID { get; set; }

        [Required(ErrorMessage = "Is Template is required")]
        [Display(Name = "Is Template")]
        public Boolean IsTemplate { get; set; }
        //Yes No Button

        [Display(Name = "Related to Spec Title")]
        [ForeignKey("RelatedToSpmSpec")]
        public Int32 RelatedToSpmSpecID { get; set; }

        [Display(Name = "Related to User Story")]
        [ForeignKey("RelatedToSpmSpecUserStory")]
        public Int32 RelatedToSpmSpecUserStoryID { get; set; }

        [Required(ErrorMessage = "Question is required")]
        [Display(Name = "Question")]
        [MaxLength]
        public String Question { get; set; }

        public virtual SpmSpecBuilderQuestionCategory SpmSpecBuilderQuestionCategory { get; set; }
        public virtual SpmSpec RelatedToSpmSpec { get; set; }
        public virtual SpmSpecUserStory SpmSpecUserStory { get; set; }
    }
    public class SpmSpecBuilderQuestionAnswer
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecBuilderQuestionAnswerID { get; set; }

        [Required]
        [Display(Name = "SpmSpecBuilderQuestion")]
        [ForeignKey("SpmSpecBuilderQuestion")]
        public Int32 SpmSpecBuilderQuestioID { get; set; }

        [Required(ErrorMessage = "Answer is required")]
        [Display(Name = "Answer")]
        [MaxLength]
        public String Answer { get; set; }

        [Display(Name = "Is Included In Spec")]
        public Boolean IsIncludedInSpec { get; set; }

        [Display(Name = "Answered By User")]
        [ForeignKey("AnsweredByUser")]
        public Int32 AnsweredByUserID { get; set; }

        public virtual User AnsweredByUser { get; set; }
        public virtual SpmSpecBuilderQuestion SpmSpecBuilderQuestion { get; set; }

    }


    public class SpmSpecUserStoryStatusCateory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecUserStoryStatusCateoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }


    }
    public class SpmSpecUserStory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecUserStoryID { get; set; }

        [Display(Name = "Select Spec Title")]
        [ForeignKey("RelatedToSpmSpec")]
        public Int32 RelatedToSpmSpecID { get; set; }

        [Required(ErrorMessage = "Story Title is required")]
        [Display(Name = "Title")]
        [StringLength(64)]
        public String Name { get; set; }

        [Required(ErrorMessage = "Is Template is required")]
        [Display(Name = "Is Template")]
        public Boolean IsTemplate { get; set; }
        //Yes No Button

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Display(Name = "Display Sort Number")]
        public Int32 DisplaySortNumberNumber { get; set; }

        [Display(Name = "Traceability Id Number")]
        public Int32 TraceabilityIdNumber { get; set; }

        [Display(Name = "User Story Status ")]
        [ForeignKey("SpmSpecUserStoryStatusCategory")]
        public Int32 SSpmSpecUserStoryStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Created By User is required")]
        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }

        [Required(ErrorMessage = "Created Date is required")]
        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDateTime { get; set; }

        [Display(Name = "Business Value")]
        public Double BusinessValue { get; set; }

        public virtual SpmSpec RelatedToSpmSpec { get; set; }
        public virtual SpmSpecUserStoryStatusCateory SpmSpecUserStoryStatusCateory { get; set; }
        public virtual User CreatedByUser { get; set; }

        //more to add priority
        //Complexity
        //


    }
    public class SpmSpecUserStoryAcceptanceCriteria
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecUserStoryAcceptanceCriteriaID { get; set; }

        [Required]
        [Display(Name = "Select User Story")]
        [ForeignKey("SpmSpecUserStory")]
        public Int32 SpmSpecUserStoryID { get; set; }

        [Display(Name = "Acceptance Criteria Info")]
        [MaxLength]
        public String AcceptanceCriteriaInfo { get; set; }

        [Display(Name = "Is Accepted ")]
        public Boolean IsAccepted { get; set; }

        public virtual SpmSpecUserStory SpmSpecUserStory { get; set; }

    }
    public class SpmSpecDefinationOfDoneCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSpecDefinationOfDoneCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }

    public class SpmSprint
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSprintID { get; set; }

        [Required(ErrorMessage = "Project  is required")]
        [Display(Name = "Project ")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Display(Name = "Sprint Name")]
        [StringLength(128)]
        public String SprintName { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Number Of Days")]
        public Int32 SprintDurationInDays { get; set; }

        [Display(Name = "Sprint Remarks")]
        [StringLength(512)]
        public String SprintRemarks { get; set; }

        //public virtual SpmProject SpmProject { get; set; }

    }
    public class SpmSprintTeam
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSprintTeamID { get; set; }

        [Required(ErrorMessage = " Sprint  is required")]
        [Display(Name = "Sprint ")]
        [ForeignKey("SpmSprint")]
        public Int32 SpmSprintID { get; set; }

        [Required(ErrorMessage = "Assignto User is required")]
        [Display(Name = "User")]
        [ForeignKey("User")]
        public Int32 SprintUserID { get; set; }

        public virtual User SprintUser { get; set; }
        public virtual SpmSprint SpmSprint { get; set; }

    }
    public class SpmSprintModuleSpecUserStoryBug
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSprintModuleSpecUserStoryID { get; set; }

        [Required]
        [Display(Name = "Sprint ")]
        [ForeignKey("SpmSprint")]
        public Int32 SpmSprintID { get; set; }

        [Display(Name = "Module")]
        [ForeignKey("SpmModule")]
        public Int32 SpmModuleID { get; set; }

        [Display(Name = "Spec")]
        [ForeignKey("SpmSpec")]
        public Int32 SpmSpecID { get; set; }

        [Display(Name = "User Story")]
        [ForeignKey("SpmSpecUserStory")]
        public Int32 SpmSpecUserStoryID { get; set; }

        [Required(ErrorMessage = " Project Bug Info is required")]
        [Display(Name = "Bug Info")]
        [ForeignKey("SpmBugInfo")]
        public Int32 SpmBugInfoID { get; set; }

        public virtual SpmSprint SpmSprint { get; set; }
        public virtual SpmSpec SpmSpec { get; set; }
        public virtual SpmSpecModule SpmSpecModule { get; set; }
        public virtual SpmSpecUserStory SpmSpecUserStory { get; set; }
        public virtual SpmBugInfo SpmBugInfo { get; set; }



    }
    public class SpmSprintTask
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmSprintTaskID { get; set; }

        [Required(ErrorMessage = "Sprint  is required")]
        [Display(Name = "Sprint ")]
        public Int32 SpmSprintID { get; set; }

        [Required(ErrorMessage = "Task  is required")]
        [Display(Name = "Task ")]
        [ForeignKey("Task")]
        public Int32 TaskID { get; set; }

        public virtual SpmSprint SpmSprint { get; set; }
        public virtual Task Task { get; set; }
    }

    public class SpmBugInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmBugInfoID { get; set; }

        [Display(Name = "Related to Spec Title")]
        [ForeignKey("RelatedToSpmSpec")]
        public Int32 RelatedToSpmSpecID { get; set; }

        [Display(Name = "Related to User Story")]
        [ForeignKey("RelatedToSpmSpecUserStory")]
        public Int32 RelatedToSpmSpecUserStoryID { get; set; }

        [Required(ErrorMessage = "Bug Category is required")]
        [Display(Name = "Bug Type or Category")]
        [ForeignKey("SpmBugCategory")]
        public Int32 SpmBugCategoryID { get; set; }

        [Display(Name = "Title")]
        [StringLength(256)]
        public String Title { get; set; }

        [Display(Name = "Bug Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String BugDescription { get; set; }

        [Required(ErrorMessage = "Created By User is required")]
        [Display(Name = "Created By User")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }

        [Required(ErrorMessage = "Created Date is required")]
        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Bug Status is required")]
        [Display(Name = "Bug Status")]
        [ForeignKey("SpmBugStatusCategory")]
        public Int32 SpmBugStatusCategoryID { get; set; }

        [Display(Name = "Fixed By User")]
        [ForeignKey("FixedByUser")]
        public Int32 FixedByUserID { get; set; }

        [Display(Name = "Fixed Date")]
        [DataType(DataType.DateTime)]
        public DateTime FixedDate { get; set; }

        [Display(Name = "Bug Fixing Note")]
        [MaxLength]
        public String BugFixingNote { get; set; }

        public virtual SpmBugCategory SpmBugCategory { get; set; }
        public virtual SpmBugStatusCategory SpmBugStatusCategory { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual User FixedByUser { get; set; }
        public virtual SpmSpec RelatedToSpmSpec { get; set; }
        public virtual SpmSpecUserStory SpmSpecUserStory { get; set; }

    }
    public class SpmBugStatusCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmBugStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }
    }
    public class SpmBugCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmBugCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }

    }
    public class SpmBugAssignedTeam
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmBugAssignedTeamID { get; set; }

        [Required(ErrorMessage = "Bug Info is required")]
        [Display(Name = "Bug Info")]
        [ForeignKey("SpmBugInfo")]
        public Int32 SpmBugInfoID { get; set; }

        [Required(ErrorMessage = "Assign To User is required")]
        [Display(Name = "Assign To User")]
        [ForeignKey("AssignToUser")]
        public Int32 AssignToUserID { get; set; }

        [Required(ErrorMessage = "Assign Date is required")]
        [Display(Name = "Assign Date")]
        [DataType(DataType.DateTime)]
        public DateTime AssignDate { get; set; }

        public virtual User AssignToUser { get; set; }
        public virtual SpmBugInfo SpmBugInfo { get; set; }

    }

    public class SpmAppTestCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmTestCategoryID { get; set; }

        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class SpmAppTestStatusCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmTestStatusID { get; set; }

        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }


    }
    public class SpmAppTestPlan
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmTestStatusInfoID { get; set; }

        [Required(ErrorMessage = " Project  is required")]
        [Display(Name = " Project ")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "  Spec is required")]
        [Display(Name = "Spec")]
        [ForeignKey("SpmSpec")]
        public Int32 SpmSpecID { get; set; }

        [Required(ErrorMessage = "Test Category is required")]
        [Display(Name = "Test Category")]
        [ForeignKey("SpmTestCategory")]
        public Int32 SpmTestCategoryID { get; set; }

        [Required(ErrorMessage = "Test By User is required")]
        [Display(Name = "Test By User")]
        [ForeignKey("TestByUser")]
        public Int32 TestByUserID { get; set; }

        [Required(ErrorMessage = "Test Date is required")]
        [Display(Name = "Test Date")]
        [DataType(DataType.DateTime)]
        public DateTime TestDate { get; set; }

        [Display(Name = "Test Result Description")]
        [MaxLength]
        public String TestResultDescription { get; set; }

        [Required(ErrorMessage = "Test Status is required")]
        [Display(Name = "Test Status")]
        [ForeignKey("SpmTestStatus")]
        public Int32 SpmTestStatusID { get; set; }

        public virtual User User { get; set; }
        public virtual SpmSpec SpmSpec { get; set; }

    }

    public class SpmProjectNote
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectNoteID { get; set; }

        [Required(ErrorMessage = "Project ID is required")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Display(Name = "Note Category")]
        [ForeignKey("SpmProjectNoteCategory")]
        public Int32 SpmProjectNoteCategoryID { get; set; }

        [Required(ErrorMessage = "Note Detail is required")]
        [Display(Name = "Note")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Note { get; set; }
        //htm editor

        [Required(ErrorMessage = "Note Created By is required")]
        [Display(Name = "Wrtitten By")]
        [ForeignKey("WrittenByUser")]
        public Int32 WrittenByUserID { get; set; }
        //by default loggedin user

        [Required(ErrorMessage = "Create Date Time is required")]
        [Display(Name = "Create Date Time")]
        [DataType(DataType.DateTime)]
        public DateTime CreateDateTime { get; set; }
        //current date and time, auto stamp

        public virtual SpmProject SpmProject { get; set; }
        public virtual SpmProjectNoteCategory SpmProjectNoteCategory { get; set; }
        public virtual User WrittenByUser { get; set; }

    }
    public class SpmProjectNoteCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectNoteCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }

    public class SpmDocumentCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmDocumentCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class SpmDocumentFolder
    {

        [Required(ErrorMessage = "Contact Folder is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmDocumentFolderID { get; set; }

        [Required]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Folder Name is required")]
        [Display(Name = "Folder Name")]
        [StringLength(64)]
        public String FolderName { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }
        //in a treeview it will show on mouse over
        //in a grid it will show in the grid

        [Required(ErrorMessage = "Created By User is required")]
        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual SpmProject SpmProject { get; set; }

    }
    public class SpmDocumentFolderAccess
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmDocumentFolderAccessID { get; set; }

        [Required]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required]
        [Display(Name = "Select Folder")]
        [ForeignKey("SpmDocumentFolder")]
        public Int32 SpmDocumentFolderID { get; set; }


        [Required(ErrorMessage = "Share With User is required")]
        [Display(Name = "Share with User")]
        [ForeignKey("ShareWithUser")]
        public Int32 ShareWithUserID { get; set; }

        public virtual User SharewithUser { get; set; }
        public virtual SpmProject SpmProject { get; set; }

    }
    public class SpmDocument
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmDocumentID { get; set; }

        [Required(ErrorMessage = "Project ID is required")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Display(Name = "Document Category")]
        [ForeignKey("SpmDocumentCategory")]
        public Int32 SpmDocumentCategoryID { get; set; }

        [Display(Name = "Select Folder")]
        [ForeignKey("SpmDocumentFolder")]
        public Int32 SpmDocumentFolderID { get; set; }

        [Required(ErrorMessage = "Document Title is required")]
        [Display(Name = "Title")]
        [StringLength(256)]
        public String DocumentTitle { get; set; }

        [Display(Name = "Upload File")]
        public Byte[] DocumentFile { get; set; }

        [Display(Name = "Original File Name, Extension and Size")]
        [StringLength(256)]
        public String OriginalFileInfo { get; set; }

        [Required(ErrorMessage = "Uploaded By is required")]
        [Display(Name = "Uploaded By")]
        [ForeignKey("UploadedByUser")]
        public Int32 UploadedByUserID { get; set; }
        //by default loggedin user, dont need to diaply

        [Display(Name = "Upload Date Time")]
        [DataType(DataType.DateTime)]
        public DateTime CreateDateTime { get; set; }
        //auto current date and time, auto stamp

        public virtual SpmProject SpmProject { get; set; }
        public virtual User UploadedByUser { get; set; }
        public virtual SpmDocumentCategory SpmDocumentCategory { get; set; }
        public virtual SpmDocumentFolder SpmDocumentFolder { get; set; }

    }
    public class SpmDocumentAccess
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmDocumentAccessID { get; set; }

        [Required]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required]
        [Display(Name = "Select Document")]
        [ForeignKey("SpmDocument")]
        public Int32 SpmDocumentID { get; set; }

        [Required(ErrorMessage = "Share With User is required")]
        [Display(Name = "Share with User")]
        [ForeignKey("ShareWithUser")]
        public Int32 ShareWithUserID { get; set; }

        public virtual User SharewithUser { get; set; }
        public virtual SpmProject SpmProject { get; set; }
        public virtual SpmDocument SpmDocument { get; set; }

    }

    public class SpmRiskInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmRiskInfoID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Risk Category is required")]
        [Display(Name = "Risk Category")]
        [ForeignKey("SpmRiskCategory")]
        public Int32 SpmRiskCategoryID { get; set; }

        //[Required(ErrorMessage="Risk Library Info is required")]
        //[Display(Name="Risk Library Info")]
        //[ForeignKey("PMRiskLibraryInfo")]
        //public Int32 PMRiskLibraryInfoID { get; set; }

        [Required(ErrorMessage = "Risk Register By User is required")]
        [Display(Name = "Risk Register By User")]
        [ForeignKey("RiskRegisterByUser")]
        public Int32 RiskRegisterByUserID { get; set; }

        [Required(ErrorMessage = "Register Date is required")]
        [Display(Name = "Register Date")]
        [DataType(DataType.DateTime)]
        public DateTime RegisterDate { get; set; }

        [Required(ErrorMessage = "Risk Priority is required")]
        [Display(Name = "Select Risk Priority")]
        [ForeignKey("RiskPriority")]
        public Int32 RiskPriorityID { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        public String Description { get; set; }

        [Required]
        [Display(Name = "Risk Status")]
        [ForeignKey("PMRiskStatus")]
        public Int32 PMRiskStatusID { get; set; }

        public virtual SpmProject SpmProject { get; set; }
        public virtual SpmRiskCategory SpmRiskCategory { get; set; }
        public virtual SpmRiskPriorityCategory SpmRiskPriorityCategory { get; set; }
        public virtual User RiskRegisterByUser { get; set; }
        public virtual User User { get; set; }
        public virtual SpmRiskQuantificationInfo PMRiskQuantificationInfoes { get; set; }

    }
    public class SpmRiskCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmRiskCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class SpmRiskPriorityCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmRiskPriorityCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class SpmRiskStatusCategory
    {

        [Required(ErrorMessage = "Risk Status is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmRiskStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }


    }
    public class SpmRiskQuantificationInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmRiskQuantificationInfoID { get; set; }

        [Required(ErrorMessage = "Risk Info is required")]
        [Display(Name = "Risk Info")]
        [ForeignKey("SpmRiskInfo")]
        public Int32 SpmRiskInfoID { get; set; }

        [Required(ErrorMessage = "Quantified By User is required")]
        [Display(Name = "Quantified By User")]
        [ForeignKey("QuantifiedByUser")]
        public Int32 QuantifiedByUserID { get; set; }

        [Required(ErrorMessage = "Updated Date is required")]
        [Display(Name = "Updated Date")]
        [DataType(DataType.DateTime)]
        public DateTime UpdatedDate { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }

        public virtual User QuantifiedByUser { get; set; }
        public virtual SpmRiskInfo SpmRiskInfo { get; set; }

    }
    public class SpmRiskLibraryInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmRiskLibraryInfoID { get; set; }

        [Required]
        [Display(Name = "Risk Category")]
        [ForeignKey("SpmRiskCategory")]
        public Int32 SpmRiskCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

        [Display(Name = "Notes")]
        [StringLength(256)]
        public String Notes { get; set; }

        public virtual SpmRiskCategory SpmRiskCategory { get; set; }

    }
    public class SpmRiskManagementTeam
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmRiskManagementTeamID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Assign To User is required")]
        [Display(Name = "Assign To User")]
        [ForeignKey("AssignToUser")]
        public Int32 AssignToUserID { get; set; }

        [Required(ErrorMessage = "Assign By User is required")]
        [Display(Name = "Assign By User")]
        [ForeignKey("AssignByUser")]
        public Int32 AssignByUserID { get; set; }

        [Required(ErrorMessage = "Updated Date is required")]
        [Display(Name = "Updated Date")]
        [DataType(DataType.DateTime)]
        public DateTime UpdatedDate { get; set; }

        [Required(ErrorMessage = "Is Primary is required")]
        [Display(Name = "Is Primary")]
        public Boolean IsPrimary { get; set; }

        public virtual SpmProject SpmProject { get; set; }
        public virtual User AssignToUser { get; set; }
        public virtual User AssignByUser { get; set; }

    }

    public class SpmVendorInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmVendorInfoID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Vendor Company is required")]
        [Display(Name = "Vendor Company")]
        [ForeignKey("VendorCompany")]
        public Int32 VendorCompanyID { get; set; }

        [Required(ErrorMessage = "Vendor Contact is required")]
        [Display(Name = "Vendor Contact")]
        [ForeignKey("VendorContact")]
        public Int32 VendorContactID { get; set; }


        public virtual SpmProject SpmProject { get; set; }



    }
    public class SpmClientContactInfo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmClientContactInfoID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Client Company is required")]
        [Display(Name = "Client Company")]
        [ForeignKey("CrmCompany")]
        public Int32 CrmCompanyID { get; set; }

        [Required(ErrorMessage = "Client Contact is required")]
        [Display(Name = "Client Contact")]
        [ForeignKey("CrmContact")]
        public Int32 CrmContactID { get; set; }

    }

    public class SpmProjectHolidayCalendar
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SpmProjectHolidayCalendarID { get; set; }

        [Required(ErrorMessage = "Project Info is required")]
        [Display(Name = "Project Info")]
        [ForeignKey("SpmProject")]
        public Int32 SpmProjectID { get; set; }

        [Required(ErrorMessage = "Holiday Calendar  is required")]
        [Display(Name = "Holiday Calendar ")]
        [ForeignKey("HolidayCalendar")]
        public Int32 HolidayCalendarID { get; set; }

        [Required(ErrorMessage = "Is Active is required")]
        [Display(Name = "Is Active")]
        public Boolean IsActive { get; set; }

        //public virtual HolidayCalendar HolidayCalendar { get; set; }
        public virtual SpmProject SpmProject { get; set; }

    }

}