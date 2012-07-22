

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
	public class Employee 
	{
		
		[Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeID { get; set; }

        [Display(Name = "Employee ID")]
        [StringLength(64)]
        //[DataType("DataType.DisplayId ")]
        [IncludeInList(Sequence = 1, AllowSearch = true, Width = 5, AllowWidthInPercentage = true)]
        public String EmployeeDisplayId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(64)]
        public String FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(64)]
        public String MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(64)]
        public String LastName { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(64)]
        public String FullName { get; set; }

        [Display(Name = "Organization")]
        [ForeignKey("Organziation")]
        public Int32 OrganizationID { get; set; }

        [Display(Name = "Department")]
        [ForeignKey("OrganizationDepartment")]
        public Int32 OrganizationDepartmentID { get; set; }

        [Display(Name = "Job Title")]
        [ForeignKey("OrganizationPosition")]
        public Int32 OrganizationPositionID { get; set; }

      
        [Display(Name = "Address1")]
        [StringLength(256)]
        public String Address1 { get; set; }

        [Display(Name = "Address2")]
        [StringLength(256)]
        public String Address2 { get; set; }

        [Display(Name = "City")]
        [StringLength(128)]
        public String City { get; set; }

        [Display(Name = "Post Box Number")]
        [StringLength(16)]
        public String PostBoxNumber { get; set; }

        [Display(Name = "Country")]
        [ForeignKey("Country")]
        public Int32 CountryID { get; set; }

        [Display(Name = "State")]
        [ForeignKey("State")]
        public Int32 StateID { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(32)]
        public String ZipCode { get; set; }

        [Display(Name = "Office Phone")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String OfficePhone { get; set; }

        [Display(Name = "Mobile")]
        [StringLength(64)]
        public String Mobile { get; set; }

        [Display(Name = "Fax Number")]
        [StringLength(64)]
        public String FaxNumber { get; set; }

        [Display(Name = "Primary Email Address")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public String EmailAddress { get; set; }

        [Display(Name = "Alternative Email")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public String AlternativeEmail { get; set; }

        [Display(Name = "Facebok Profile Address")]
        [StringLength(256)]
        public String FacebokProfileAddress { get; set; }

        [Display(Name = "Twitter Address")]
        [StringLength(256)]
        public String TwitterAccount { get; set; }

        [Display(Name = "GooglePlus Address")]
        [StringLength(256)]
        public String GooglePlusAccountAddress { get; set; }

        [Display(Name = "Linkedin Profile Address")]
        [StringLength(256)]
        public String LinkedInProfileAddress { get; set; }

        [Display(Name = "Personal Blog Address")]
        [StringLength(256)]
        public String PersonalBlogAddress { get; set; }

        [Display(Name = "Photo")]
        public Byte[] Photo { get; set; }

        [Display(Name = "Internal Remarks")]
        [StringLength(256)]
        public String InternalRemarks { get; set; }
                    
        [Display(Name = "Sequence in Company Oganization Chart")]
        public Double SequenceInCompanyOrganizationalChart { get; set; }

   
        public virtual Organization Organization { get; set; }
        public virtual OrganizationPosition OrganizationPosition { get; set; }
        public virtual OrganizationDepartment OrganizationDepartment { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
   
    }   
    public class EmployeeWorkProfile
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeWorkProfileID { get; set; }

        [Required(ErrorMessage = "Job Description is required")]
        [Display(Name = "Job Description")]
        public String JobDescription { get; set; }

        //need to add
    }

    public class EmployeeTerminationInfo
    {

        [Required(ErrorMessage = "Employee Termination Info is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeTerminationInfoID { get; set; }

        [Required(ErrorMessage = "Employee is required")]
        [Display(Name = "Employee")]
        [ForeignKey("Employee")]
        public Int32 EmployeeID { get; set; }

        [Display(Name = "Expected Termination Date")]
        [DataType(DataType.DateTime)]
        public DateTime ExpectedTerminationDate { get; set; }

        [Display(Name = "Actual Termination Date")]
        [DataType(DataType.DateTime)]
        public DateTime ActualTerminationDate { get; set; }

        [Required(ErrorMessage = "Employee Reason For Leaving is required")]
        [Display(Name = "Employee Reason For Leaving")]
        [ForeignKey("EmploymentLeaveReasonCategory")]
        public Int32? EmploymentLeaveReasonCategoryID { get; set; }

        [Display(Name = "Note")]
        [MaxLength]
        public String Note { get; set; }

        [Required(ErrorMessage = "Update By Employee is required")]
        [Display(Name = "Update By Employee")]
        [ForeignKey("UpdateByEmployee")]
        public Int32 UpdateByEmployeeID { get; set; }

        [Required(ErrorMessage = "Update Date is required")]
        [Display(Name = "Update Date")]
        [DataType(DataType.DateTime)]
        public DateTime UpdateDate { get; set; }

        
        public virtual Employee Employee { get; set; }
        public virtual EmploymentLeaveReasonCategory EmploymentLeaveReasonCategory { get; set; }
       

    }
    public class EmployeeEmploymentStatus
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeEmploymentStatusID { get; set; }

        [Required(ErrorMessage = "Employee is required")]
        [Display(Name = "Employee")]
        [ForeignKey("Employee")]
        public Int32 EmployeeID { get; set; }

        [Required(ErrorMessage = "Employment Status is required")]
        [Display(Name = "Employment Status")]
        [ForeignKey("EmploymentStatus")]
        public Int32 EmploymentStatusID { get; set; }

        [Display(Name = "Note")]
        [MaxLength]
        public String Note { get; set; }

        [Required(ErrorMessage = "Update Employee is required")]
        [Display(Name = "Update Employee")]
        [ForeignKey("UpdateEmployee")]
        public Int32 UpdateEmployeeID { get; set; }

        [Required(ErrorMessage = "Update Date is required")]
        [Display(Name = "Update Date")]
        [DataType(DataType.DateTime)]
        public DateTime UpdateDate { get; set; }

        [Required(ErrorMessage = "Is Current is required")]
        [Display(Name = "Is Current")]
        public Boolean IsCurrent { get; set; }

        [Required(ErrorMessage = "Is Removed is required")]
        [Display(Name = "Is Removed")]
        public Boolean IsRemoved { get; set; }

        //public virtual EmploymentStatus EmploymentStatus { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee Employee1 { get; set; }

    }
    public class EmployeeBankInformation
    {

        [Required(ErrorMessage = "Employee Bank Information is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeBankInformationID { get; set; }

        [Required(ErrorMessage = "Employee is required")]
        [Display(Name = "Employee")]
        [ForeignKey("Employee")]
        public Int32 EmployeeID { get; set; }

        [Display(Name = "Select From Organization Bank Info")]
        [ForeignKey("SelectFromOrganizationBankInfo")]
        public Int32 SelectFromOrganizationBankInfoID { get; set; }

        [Display(Name = "Bank Name")]
        [StringLength(128)]
        public String BankName { get; set; }

        [Display(Name = "Bank Address")]
        [StringLength(512)]
        public String BankAddress { get; set; }

        [Display(Name = "P O Box")]
        public Int32 POBox { get; set; }

        [Display(Name = "Bank City")]
        [StringLength(256)]
        public String BankCity { get; set; }

        [Display(Name = "State")]
        [ForeignKey("State")]
        public Int32 StateID { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(15)]
        public String ZipCode { get; set; }

        [Display(Name = "Country")]
        [ForeignKey("Country")]
        public Int32 CountryID { get; set; }

        [Display(Name = "Account Number")]
        [StringLength(512)]
        public String AccountNumber { get; set; }

        [Required(ErrorMessage = "Bank Account Category is required")]
        [Display(Name = "Bank Account Category")]
        [ForeignKey("BankAccountCategory")]
        public Int32 BankAccountCategoryID { get; set; }

        [Display(Name = "Swipe Code")]
        [StringLength(30)]
        public String SwipeCode { get; set; }

        [Display(Name = "Routing No")]
        [StringLength(30)]
        public String RoutingNo { get; set; }

        [Display(Name = "Is Salary Account")]
        public Boolean IsSalaryAccount { get; set; }

        [Display(Name = "Is Default")]
        public Boolean IsDefault { get; set; }

        [Required(ErrorMessage = "Is Removed is required")]
        [Display(Name = "Is Removed")]
        public Boolean IsRemoved { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual OrganizationBankInfo OrganizationBankInfo { get; set; }

        //public virtual BankAccountCategory BankAccountCategory { get; set; }

    }
    public class EmployeeEmergencyContact
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeEmergencyContactID { get; set; }

        [Required(ErrorMessage = "Employee is required")]
        [Display(Name = "Employee")]
        [ForeignKey("Employee")]
        public Int32 EmployeeID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(256)]
        public String FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(256)]
        public String MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [StringLength(256)]
        public String LastName { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(256)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public String EmailAddress { get; set; }

        [Display(Name = "Home Phone Number")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String HomePhoneNumber { get; set; }

        [Display(Name = "Mobile Phone Number")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String MobilePhoneNumber { get; set; }

        [Display(Name = "Relationship")]
        [StringLength(256)]
        public String Relationship { get; set; }

        [Required(ErrorMessage = "Is Removed is required")]
        [Display(Name = "Is Removed")]
        public Boolean IsRemoved { get; set; }

        public virtual Employee Employee { get; set; }

    }
    public class EmployeeFamilyInfo
    {

        [Required(ErrorMessage = "Employee Family Info is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeFamilyInfoID { get; set; }

        [Required(ErrorMessage = "Employee is required")]
        [Display(AutoGenerateField = false)]
        [ForeignKey("Employee")]
        public Int32 EmployeeID { get; set; }

        [Required(ErrorMessage = "Employee Family Relation Type is required")]
        [Display(Name = "Employee Family Relation Type")]
        [ForeignKey("FamilyRelationship")]
        public Int32 FamilyRelationshipID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(256)]
        public String FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(256)]
        public String MiddleName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        [StringLength(256)]
        public String LastName { get; set; }

        [Display(Name = "Profession")]
        [ForeignKey("ContactProfessionType")]
        [StringLength(128)]
        public String ContactProfessionTypeID { get; set; }

        [Required(ErrorMessage = "Is Dependent is required")]
        [Display(Name = "Is Dependent")]
        public Boolean IsDependent { get; set; }

        [Display(Name = "Education")]
        [ForeignKey("SkillsExpEdu")]
        public Int32? SkillsExpEduID { get; set; }

        [Display(Name = "Age")]
        public Int32 Age { get; set; }

        [Display(Name = "Email Address")]
        [StringLength(256)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public String EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String PhoneNumber { get; set; }

        [Required(ErrorMessage = "Is Removed is required")]
        [Display(Name = "Is Removed")]
        public Boolean IsRemoved { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual FamilyRelationship FamilyRelationship { get; set; }
        public virtual SkillsExpEdu SkillsExpEdu { get; set; }
        public virtual ContactProfessionType ContactProfessionType { get; set; }
        

    }
 
    public class EmployeeWorkPermitLabourCard
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeWorkPermitLabourCardID { get; set; }

        [Required(ErrorMessage = "Employee is required")]
        [Display(Name = "Employee")]
        [ForeignKey("Employee")]
        public Int32 EmployeeID { get; set; }

        [Required(ErrorMessage = "Labour Card Number is required")]
        [Display(Name = "Labour Card Number")]
        [StringLength(512)]
        public String LabourCardNumber { get; set; }

        [Required(ErrorMessage = "Issue Date is required")]
        [Display(Name = "Issue Date")]
        [DataType(DataType.DateTime)]
        public DateTime IssueDate { get; set; }

        [Required(ErrorMessage = "Expire Date is required")]
        [Display(Name = "Expire Date")]
        [DataType(DataType.DateTime)]
        public DateTime ExpireDate { get; set; }

        [Display(Name = "Issued City")]
        [StringLength(256)]
        public String IssuedCity { get; set; }

        [Display(Name = "Issued State")]
        [ForeignKey("IssuedState")]
        public Int32 IssuedStateID { get; set; }

        [Required(ErrorMessage = "Iissued Country is required")]
        [Display(Name = "Issued Country")]
        [ForeignKey("IssuedCountry")]
        public Int32 IssuedCountryID { get; set; }

        [Required(ErrorMessage = "Is Current is required")]
        [Display(Name = "Is Current")]
        public Boolean IsCurrent { get; set; }

        [Display(Name = "Reference Number")]
        [StringLength(128)]
        public String ReferenceNumber { get; set; }

      
        public virtual Employee Employee { get; set; }
        public virtual Country IssuedCountry { get; set; }
        public virtual State IssuedState { get; set; }

    }
    public class EmployeeInsurance
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeInsuranceID { get; set; }

        [Required(ErrorMessage = "Employee Insurance Category is required")]
        [Display(Name = "Employee Insurance Category")]
        [ForeignKey("EmployeeInsuranceCategory")]
        public Int32 EmployeeInsuranceCategoryID { get; set; }

        [Required(ErrorMessage = "Employee is required")]
        [Display(Name = "Employee")]
        [ForeignKey("Employee")]
        public Int32 EmployeeID { get; set; }

        [Display(Name = "Insurance No")]
        [StringLength(512)]
        public String InsuranceNo { get; set; }

        [Display(Name = "Insurance Status")]
        public Boolean InsuranceStatus { get; set; }

        [Display(Name = "Amount")]
        public Double Amount { get; set; }

        [Display(Name = "Amount Currency")]
        [ForeignKey("AmountCurrency")]
        public Int32 AmountCurrencyID { get; set; }

        [Display(Name = "Effective Date")]
        [DataType(DataType.DateTime)]
        public DateTime EffectiveDate { get; set; }

        [Display(Name = "Insurance Period")]
        [StringLength(64)]
        public String InsurancePeriod { get; set; }

        [Display(Name = "Expiration Date")]
        [DataType(DataType.DateTime)]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Insurance Provider Name")]
        [StringLength(128)]
        [ForeignKey("InsuranceProviderNa")]
        public String InsuranceProviderName { get; set; }

        [Display(Name = "Paid By Company")]
        [ForeignKey("PaidByCompa")]
        public Double PaidByCompany { get; set; }

        [Display(Name = "Paid By Self")]
        [ForeignKey("PaidBySe")]
        public Double PaidBySelf { get; set; }

        [Display(Name = "Insurance Description")]
        [StringLength(8000)]
        public String InsuranceDescription { get; set; }

        [Required(ErrorMessage = "Is Removed is required")]
        [Display(Name = "Is Removed")]
        public Boolean IsRemoved { get; set; }

        public virtual EmployeeInsuranceCategory EmployeeInsuranceCategory { get; set; }

        public virtual Employee Employee { get; set; }

    }
    public class EmployeeInsuranceCategory
    {

        [Required(ErrorMessage = "Employee Insurance Category is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 EmployeeInsuranceCategoryID { get; set; }

        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }

        [Required(ErrorMessage = "Is Removed is required")]
        [Display(Name = "Is Removed")]
        public Boolean IsRemoved { get; set; }

        public virtual EmployeeInsurance EmployeeInsurances { get; set; }

    }

   // public class EmployeeLoanApplication
   // {

   //     [Required(ErrorMessage = "Employee Loan Application is required")]
   //     [Display(AutoGenerateField = false)]
   //     [Key]
   //     public Int32 EmployeeLoanApplicationID { get; set; }

   //     [Required(ErrorMessage = "Employee is required")]
   //     [Display(Name = "Employee")]
   //     [ForeignKey("Employee")]
   //     public Int32 EmployeeID { get; set; }

   //     [Required(ErrorMessage = "Loan Category is required")]
   //     [Display(Name = "Loan Category")]
   //     [ForeignKey("LoanCategory")]
   //     public Int32 LoanCategoryID { get; set; }

   //     [Required(ErrorMessage = "Applied Loan Amount is required")]
   //     [Display(Name = "Applied Loan Amount")]
   //     public Double AppliedLoanAmount { get; set; }

   //     [Required(ErrorMessage = "Currency is required")]
   //     [Display(Name = "Currency")]
   //     [ForeignKey("Currency")]
   //     public Int32 CurrencyID { get; set; }

   //     [Required(ErrorMessage = "Apply Date is required")]
   //     [Display(Name = "Apply Date")]
   //     [DataType(DataType.DateTime)]
   //     public DateTime ApplyDate { get; set; }

   //     [Display(Name = "Description")]
   //     [StringLength(512)]
   //     public String Description { get; set; }

   //     [Display(Name = "Loan Payment Start Date")]
   //     [DataType(DataType.DateTime)]
   //     public DateTime LoanPaymentStartDate { get; set; }

   //     [Display(Name = "Loan Payment End Date")]
   //     [DataType(DataType.DateTime)]
   //     public DateTime LoanPaymentEndDate { get; set; }

   //     [Display(Name = "Number Of Payment Installment")]
   //     public Int32 NumberOfPaymentInstallment { get; set; }

   //     [Display(Name = "Approved Loan Amount")]
   //     public Double ApprovedLoanAmount { get; set; }

   //     [Display(Name = "Approved Date")]
   //     [DataType(DataType.DateTime)]
   //     public DateTime ApprovedDate { get; set; }

   //     [Required(ErrorMessage = "Loan Approval Status is required")]
   //     [Display(Name = "Loan Approval Status")]
   //     [ForeignKey("LoanApprovalStatus")]
   //     public Int32 LoanApprovalStatusID { get; set; }

   //     [Display(Name = "Payment Amount")]
   //     public Double PaymentAmount { get; set; }

   //     public virtual EmployeeAdditionalPaymentInfo EmployeeAdditionalPaymentInfoes { get; set; }

   //     public virtual EmployeeAllPaymentInfo EmployeeAllPaymentInfoes { get; set; }

   //     public virtual Employee Employee { get; set; }

   //     public virtual EmployeeLoanApproval EmployeeLoanApprovals { get; set; }

   //     public virtual EmployeeLoanPaymentPlan EmployeeLoanPaymentPlans { get; set; }

   // }

   // public class EmployeeLoanApproval
   // {

   //     [Required(ErrorMessage = "Employee Loan Approval is required")]
   //     [Display(AutoGenerateField = false)]
   //     [Key]
   //     public Int32 EmployeeLoanApprovalID { get; set; }

   //     [Required(ErrorMessage = "Employee Loan Application is required")]
   //     [Display(Name = "Employee Loan Application")]
   //     [ForeignKey("EmployeeLoanApplication")]
   //     public Int32 EmployeeLoanApplicationID { get; set; }

   //     [Required(ErrorMessage = "Approved By Employee is required")]
   //     [Display(Name = "Approved By Employee")]
   //     [ForeignKey("ApprovedByEmployee")]
   //     public Int32 ApprovedByEmployeeID { get; set; }

   //     [Display(Name = "Approved Note")]
   //     [StringLength(512)]
   //     public String ApprovedNote { get; set; }

   //     public virtual EmployeeLoanApplication EmployeeLoanApplication { get; set; }

   //     public virtual Employee Employee { get; set; }

   // }

   // public class EmployeeLoanPaymentPlan
   // {

   //     [Required(ErrorMessage = "Employee Loan Payment Plan is required")]
   //     [Display(AutoGenerateField = false)]
   //     [Key]
   //     public Int32 EmployeeLoanPaymentPlanID { get; set; }

   //     [Required(ErrorMessage = "Employee Loan Application is required")]
   //     [Display(Name = "Employee Loan Application")]
   //     [ForeignKey("EmployeeLoanApplication")]
   //     public Int32 EmployeeLoanApplicationID { get; set; }

   //     [Required(ErrorMessage = "Employee is required")]
   //     [Display(Name = "Employee")]
   //     [ForeignKey("Employee")]
   //     public Int32 EmployeeID { get; set; }

   //     [Required(ErrorMessage = "Deduct From Acct Account Head is required")]
   //     [Display(Name = "Deduct From Acct Account Head")]
   //     [ForeignKey("DeductFromAcctAccountHead")]
   //     public Int32 DeductFromAcctAccountHeadID { get; set; }

   //     [Required(ErrorMessage = "Pay To Acct Account Head is required")]
   //     [Display(Name = "Pay To Acct Account Head")]
   //     [ForeignKey("PayToAcctAccountHead")]
   //     public Int32 PayToAcctAccountHeadID { get; set; }

   //     [Display(Name = "Payroll Generation ")]
   //     [ForeignKey("PayrollGeneration")]
   //     public Int32 PayrollGenerationID { get; set; }

   //     [Display(Name = "Installment Ammount")]
   //     public Double InstallmentAmmount { get; set; }

   //     [Display(Name = "Pay Date")]
   //     [DataType(DataType.DateTime)]
   //     public DateTime PayDate { get; set; }

   //     [Display(Name = "Is Received")]
   //     public Boolean IsReceived { get; set; }

   //     public virtual AcctAccountHead AcctAccountHead { get; set; }

   //     public virtual AcctAccountHead AcctAccountHead1 { get; set; }

   //     public virtual EmployeeLoanApplication EmployeeLoanApplication { get; set; }

   //     public virtual Employee Employee { get; set; }

   //     public virtual PayrollGeneration PayrollGeneration { get; set; }

   // }

   // public class LoanApprovalStatus
   // {

   //     [Required(ErrorMessage = "Loan Approval Status is required")]
   //     [Display(AutoGenerateField = false)]
   //     [Key]
   //     public Int32 LoanApprovalStatusID { get; set; }

   //     [Required(ErrorMessage = "Name is required")]
   //     [Display(Name = "Name")]
   //     [StringLength(64)]
   //     public String Name { get; set; }

   //     [Display(Name = "Description")]
   //     [StringLength(256)]
   //     public String Description { get; set; }

   // }


   // public class LoanCategory
   // {

   //     [Required(ErrorMessage = "Loan Category is required")]
   //     [Display(AutoGenerateField = false)]
   //     [Key]
   //     public Int32 LoanCategoryID { get; set; }

   //     [Required(ErrorMessage = "Name is required")]
   //     [Display(Name = "Name")]
   //     [StringLength(64)]
   //     public String Name { get; set; }



   // }


   //public class EmployeeSalary
   //     {

   //         [Required]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeSalaryID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Pay To Acct Account Head is required")]
   //         [Display(Name = "Pay To Acct Account Head")]
   //         [ForeignKey("PayToAcctAccountHead")]
   //         public Int32 PayToAcctAccountHeadID { get; set; }

   //         [Required(ErrorMessage = "Pay From Acct Account Head is required")]
   //         [Display(Name = "Pay From Acct Account Head")]
   //         [ForeignKey("PayFromAcctAccountHead")]
   //         public Int32 PayFromAcctAccountHeadID { get; set; }

   //         [Display(Name = "Is Deposite")]
   //         public Boolean IsDeposite { get; set; }

   //         [Display(Name = "Deposit Acct Account Head")]
   //         [ForeignKey("DepositAcctAccountHead")]
   //         public Int32 DepositAcctAccountHeadID { get; set; }

   //         [Required(ErrorMessage = "Salary Amount is required")]
   //         [Display(Name = "Salary Amount")]
   //         public Double SalaryAmount { get; set; }

   //         [Required(ErrorMessage = "Salary Rate Duration is required")]
   //         [Display(Name = "Salary Rate Duration")]
   //         [ForeignKey("SalaryRateDuration")]
   //         public Int32 SalaryRateDurationID { get; set; }

   //         [Required(ErrorMessage = "Basic Salary Currency is required")]
   //         [Display(Name = "Basic Salary Currency")]
   //         [ForeignKey("BasicSalaryCurrency")]
   //         public Int32 BasicSalaryCurrencyID { get; set; }

   //         [Required(ErrorMessage = "Salary Tax Type is required")]
   //         [Display(Name = "Salary Tax Type")]
   //         [ForeignKey("SalaryTaxType")]
   //         public Int32 SalaryTaxTypeID { get; set; }

   //         [Display(Name = "Pay Cycle")]
   //         [ForeignKey("PayCycle")]
   //         public Int32 PayCycleID { get; set; }

   //         [Display(Name = "Pay Scale")]
   //         [ForeignKey("PayScale")]
   //         public Int32 PayScaleID { get; set; }

   //         [Required(ErrorMessage = "Effective Date is required")]
   //         [Display(Name = "Effective Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime EffectiveDate { get; set; }

   //         [Required(ErrorMessage = "Update By Employee is required")]
   //         [Display(Name = "Update By Employee")]
   //         [ForeignKey("UpdateByEmployee")]
   //         public Int32 UpdateByEmployeeID { get; set; }

   //         [Required(ErrorMessage = "Update Date is required")]
   //         [Display(Name = "Update Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime UpdateDate { get; set; }

   //         [Required(ErrorMessage = "Is Current is required")]
   //         [Display(Name = "Is Current")]
   //         public Boolean IsCurrent { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead1 { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead2 { get; set; }

   //         public virtual EmployeeBasicSalaryBreakdownInfo EmployeeBasicSalaryBreakdownInfoes { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual Employee Employee1 { get; set; }

   //         public virtual PayScale PayScale { get; set; }

   //     }

   //public class EmployeeSalaryDeductionInfo
   //     {

   //         [Required(ErrorMessage = "Employee Salary Deduction Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeSalaryDeductionInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Acct Account Head is required")]
   //         [Display(Name = "Acct Account Head")]
   //         [ForeignKey("AcctAccountHead")]
   //         public Int32 AcctAccountHeadID { get; set; }

   //         [Display(Name = "Deduction Amount")]
   //         public Double DeductionAmount { get; set; }

   //         [Required(ErrorMessage = "Currency is required")]
   //         [Display(Name = "Currency")]
   //         [ForeignKey("Currency")]
   //         public Int32 CurrencyID { get; set; }

   //         [Display(Name = "Percentage Of Basic Salary")]
   //         public Double PercentageOfBasicSalary { get; set; }

   //         [Required(ErrorMessage = "Salary Rate Duration is required")]
   //         [Display(Name = "Salary Rate Duration")]
   //         [ForeignKey("SalaryRateDuration")]
   //         public Int32 SalaryRateDurationID { get; set; }

   //         [Required(ErrorMessage = "Pay Cycle is required")]
   //         [Display(Name = "Pay Cycle")]
   //         [ForeignKey("PayCycle")]
   //         public Int32 PayCycleID { get; set; }

   //         [Display(Name = "Effective Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime EffectiveDate { get; set; }

   //         [Display(Name = "End Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime EndDate { get; set; }

   //         [Display(Name = "Number Of Payments")]
   //         public Int32 NumberOfPayments { get; set; }

   //         [Display(Name = "Note")]
   //         [StringLength(256)]
   //         public String Note { get; set; }

   //         [Required(ErrorMessage = "Is Removed is required")]
   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }

   //public class EmployeeSalaryExceptionAndAlert
   //     {

   //         [Required(ErrorMessage = "Employee Salary Exception And Alert is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeSalaryExceptionAndAlertID { get; set; }

   //         [Required(ErrorMessage = "Salary Exception List is required")]
   //         [Display(Name = "Salary Exception List")]
   //         [ForeignKey("SalaryExceptionList")]
   //         public Int32 SalaryExceptionListID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Is Active is required")]
   //         [Display(Name = "Is Active")]
   //         public Boolean IsActive { get; set; }

   //         [Required(ErrorMessage = "Update By Employee is required")]
   //         [Display(Name = "Update By Employee")]
   //         [ForeignKey("UpdateByEmployee")]
   //         public Int32 UpdateByEmployeeID { get; set; }

   //         [Required(ErrorMessage = "Update Date is required")]
   //         [Display(Name = "Update Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime UpdateDate { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual Employee Employee1 { get; set; }

   //     }
   //public class EmployeeBasicSalaryBreakdownInfo
   //     {

   //         [Required(ErrorMessage = "Employee Basic Salary Breakdown Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeBasicSalaryBreakdownInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Employee Salary Info is required")]
   //         [Display(Name = "Employee Salary Info")]
   //         [ForeignKey("EmployeeSalaryInfo")]
   //         public Int32 EmployeeSalaryInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee Work Hour is required")]
   //         [Display(Name = "Employee Work Hour")]
   //         [ForeignKey("EmployeeWorkHour")]
   //         public Int32 EmployeeWorkHourID { get; set; }

   //         [Required(ErrorMessage = "Houlry Rate is required")]
   //         [Display(Name = "Houlry Rate")]
   //         public Double HoulryRate { get; set; }

   //         [Required(ErrorMessage = "O T Hourly Rate is required")]
   //         [Display(Name = "O T Hourly Rate")]
   //         [DataType(DataType.Url)]
   //         [RegularExpression(@"http://([\w-]+\.)+[\w-]+(/[\w-./%&=]*)", ErrorMessage = "Url is not valid")]
   //         public Double OTHourlyRate { get; set; }

   //         [Required(ErrorMessage = "Daily Rate is required")]
   //         [Display(Name = "Daily Rate")]
   //         public Double DailyRate { get; set; }

   //         [Required(ErrorMessage = "Monthly Rate is required")]
   //         [Display(Name = "Monthly Rate")]
   //         public Double MonthlyRate { get; set; }

   //         [Required(ErrorMessage = "Yearly Rate is required")]
   //         [Display(Name = "Yearly Rate")]
   //         public Double YearlyRate { get; set; }

   //         [Required(ErrorMessage = "Currency is required")]
   //         [Display(Name = "Currency")]
   //         [ForeignKey("Currency")]
   //         public Int32 CurrencyID { get; set; }

   //         public virtual EmployeeSalaryInfo EmployeeSalaryInfo { get; set; }

   //         public virtual EmployeeWorkHour EmployeeWorkHour { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }
   //public class EmployeeCostDistributionInfo
   //     {

   //         [Required(ErrorMessage = "Employee Cost Distribution Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeCostDistributionInfoID { get; set; }

   //         [Required(ErrorMessage = "Internal Employee Cost Distribution Setup is required")]
   //         [Display(Name = "Internal Employee Cost Distribution Setup")]
   //         [ForeignKey("InternalEmployeeCostDistributionSetup")]
   //         public Int32 InternalEmployeeCostDistributionSetupID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Acct Account Head is required")]
   //         [Display(Name = "Acct Account Head")]
   //         [ForeignKey("AcctAccountHead")]
   //         public Int32 AcctAccountHeadID { get; set; }

   //         [Display(Name = "Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime Date { get; set; }

   //         [Required(ErrorMessage = "Amount is required")]
   //         [Display(Name = "Amount")]
   //         public Double Amount { get; set; }

   //         [Required(ErrorMessage = "Currency is required")]
   //         [Display(Name = "Currency")]
   //         [ForeignKey("Currency")]
   //         public Int32 CurrencyID { get; set; }

   //         [Display(Name = "Note")]
   //         [StringLength(512)]
   //         public String Note { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual InternalEmployeeCostDistributionSetup InternalEmployeeCostDistributionSetup { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }
   //public class InternalEmployeeCostDistributionSetup
   //     {

   //         [Required(ErrorMessage = "Internal Employee Cost Distribution Setup is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 InternalEmployeeCostDistributionSetupID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Acct Account Head is required")]
   //         [Display(Name = "Acct Account Head")]
   //         [ForeignKey("AcctAccountHead")]
   //         public Int32 AcctAccountHeadID { get; set; }

   //         [Display(Name = "Percentage Of Salary")]
   //         public Double PercentageOfSalary { get; set; }

   //         [Display(Name = "Amount")]
   //         public Double Amount { get; set; }

   //         [Display(Name = "Currency")]
   //         [ForeignKey("Currency")]
   //         public Int32 CurrencyID { get; set; }

   //         [Display(Name = "Note")]
   //         [StringLength(512)]
   //         public String Note { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual EmployeeCostDistributionInfo EmployeeCostDistributionInfoes { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }
   //public class EmployeeAdditionalPaymentInfo
   //     {

   //         [Required(ErrorMessage = "Employee Additional Payment Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeAdditionalPaymentInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Display(Name = "Reference Acct Account Head")]
   //         [ForeignKey("ReferenceAcctAccountHead")]
   //         public Int32 ReferenceAcctAccountHeadID { get; set; }

   //         [Required(ErrorMessage = "Pay From Acct Account Head is required")]
   //         [Display(Name = "Pay From Acct Account Head")]
   //         [ForeignKey("PayFromAcctAccountHead")]
   //         public Int32 PayFromAcctAccountHeadID { get; set; }

   //         [Required(ErrorMessage = "Pay To Acct Account Head is required")]
   //         [Display(Name = "Pay To Acct Account Head")]
   //         [ForeignKey("PayToAcctAccountHead")]
   //         public Int32 PayToAcctAccountHeadID { get; set; }

   //         [Display(Name = "Employee Loan Application")]
   //         [ForeignKey("EmployeeLoanApplication")]
   //         public Int32 EmployeeLoanApplicationID { get; set; }

   //         [Display(Name = "Pay Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime PayDate { get; set; }

   //         [Required(ErrorMessage = "Pay Amount is required")]
   //         [Display(Name = "Pay Amount")]
   //         public Double PayAmount { get; set; }

   //         [Required(ErrorMessage = "Pay Currency is required")]
   //         [Display(Name = "Pay Currency")]
   //         public Int32 PayCurrency { get; set; }

   //         [Display(Name = "Notes")]
   //         [StringLength(256)]
   //         public String Notes { get; set; }

   //         [Required(ErrorMessage = "Pay Now is required")]
   //         [Display(Name = "Pay Now")]
   //         public Boolean PayNow { get; set; }

   //         [Display(Name = "Pay During Payroll Generation ")]
   //         [ForeignKey("PayDuringPayrollGeneration")]
   //         public Int32 PayDuringPayrollGenerationID { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead1 { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead2 { get; set; }

   //         public virtual EmployeeLoanApplication EmployeeLoanApplication { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual PayrollGeneration PayrollGeneration { get; set; }

   //     }
   //public class EmployeeAllPaymentInfo
   //     {

   //         [Required(ErrorMessage = "Employee All Payment Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeAllPaymentInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Pay To Acct Account Head is required")]
   //         [Display(Name = "Pay To Acct Account Head")]
   //         [ForeignKey("PayToAcctAccountHead")]
   //         public Int32 PayToAcctAccountHeadID { get; set; }

   //         [Required(ErrorMessage = "Pay From Acct Account Head is required")]
   //         [Display(Name = "Pay From Acct Account Head")]
   //         [ForeignKey("PayFromAcctAccountHead")]
   //         public Int32 PayFromAcctAccountHeadID { get; set; }

   //         [Display(Name = "Reference Acct Account Head")]
   //         [ForeignKey("ReferenceAcctAccountHead")]
   //         public Int32 ReferenceAcctAccountHeadID { get; set; }

   //         [Display(Name = "Payroll Generation ")]
   //         [ForeignKey("PayrollGeneration")]
   //         public Int32 PayrollGenerationID { get; set; }

   //         [Display(Name = "Employee Loan Application")]
   //         [ForeignKey("EmployeeLoanApplication")]
   //         public Int32 EmployeeLoanApplicationID { get; set; }

   //         [Display(Name = "Pay Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime PayDate { get; set; }

   //         [Required(ErrorMessage = "Pay Amount is required")]
   //         [Display(Name = "Pay Amount")]
   //         public Double PayAmount { get; set; }

   //         [Required(ErrorMessage = "Pay Currency is required")]
   //         [Display(Name = "Pay Currency")]
   //         public Int32 PayCurrency { get; set; }

   //         [Display(Name = "Check Number")]
   //         [StringLength(64)]
   //         public String CheckNumber { get; set; }

   //         [Display(Name = "Organization Bank Info")]
   //         [ForeignKey("OrganizationBankInfo")]
   //         public Int32 OrganizationBankInfoID { get; set; }

   //         [Required(ErrorMessage = "Is Cash is required")]
   //         [Display(Name = "Is Cash")]
   //         public Boolean IsCash { get; set; }

   //         [Display(Name = "Notes")]
   //         [StringLength(256)]
   //         public String Notes { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead1 { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead2 { get; set; }

   //         public virtual EmployeeLoanApplication EmployeeLoanApplication { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual OrganizationBankInfo OrganizationBankInfo { get; set; }

   //         public virtual PayrollGeneration PayrollGeneration { get; set; }

   //     }
   //public class EmployeePayrollAndPaymentInfo
   //     {

   //         [Required(ErrorMessage = "Employee Payroll And Payment Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeePayrollAndPaymentInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Display(Name = "Payroll Generation ")]
   //         [ForeignKey("PayrollGeneration")]
   //         public Int32 PayrollGenerationID { get; set; }

   //         [Display(Name = "Pay Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime PayDate { get; set; }

   //         [Required(ErrorMessage = "Total Pay Amount is required")]
   //         [Display(Name = "Total Pay Amount")]
   //         public Double TotalPayAmount { get; set; }

   //         [Required(ErrorMessage = "Pay Currency is required")]
   //         [Display(Name = "Pay Currency")]
   //         public Int32 PayCurrency { get; set; }

   //         [Display(Name = "Notes")]
   //         [StringLength(256)]
   //         public String Notes { get; set; }

   //         [Required(ErrorMessage = "Is Paid is required")]
   //         [Display(Name = "Is Paid")]
   //         [ForeignKey("IsPa")]
   //         public Boolean IsPaid { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual PayrollGeneration PayrollGeneration { get; set; }

   //         public virtual EmployeePayrollPaymentDetail EmployeePayrollPaymentDetails { get; set; }

   //         public virtual EmployeeTimesheetPaymentInfo EmployeeTimesheetPaymentInfoes { get; set; }

   //     }
   //public class EmployeePayRollCalculationPolicy
   //     {

   //         [Required(ErrorMessage = "Employee Pay Roll Calculation Policy is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeePayRollCalculationPolicyID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Required Time Sheet is required")]
   //         [Display(Name = "Required Time Sheet")]
   //         public Boolean RequiredTimeSheet { get; set; }

   //         [Required(ErrorMessage = "Based On Daily Time Sheet is required")]
   //         [Display(Name = "Based On Daily Time Sheet")]
   //         public Boolean BasedOnDailyTimeSheet { get; set; }

   //         [Required(ErrorMessage = "Based On Hourly Time Sheet is required")]
   //         [Display(Name = "Based On Hourly Time Sheet")]
   //         [DataType(DataType.Url)]
   //         [RegularExpression(@"http://([\w-]+\.)+[\w-]+(/[\w-./%&=]*)", ErrorMessage = "Url is not valid")]
   //         public Boolean BasedOnHourlyTimeSheet { get; set; }

   //         [Display(Name = "O T Allowed Based On O T Hour")]
   //         public Boolean OTAllowedBasedOnOTHour { get; set; }

   //         [Display(Name = "O T Pay To Acct Account Head")]
   //         [ForeignKey("OTPayToAcctAccountHead")]
   //         public Int32 OTPayToAcctAccountHeadID { get; set; }

   //         [Display(Name = "O T Pay From Acct Account Head")]
   //         [ForeignKey("OTPayFromAcctAccountHead")]
   //         public Int32 OTPayFromAcctAccountHeadID { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead1 { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }
   //public class EmployeePayrollPaymentDetail
   //     {

   //         [Required(ErrorMessage = "Employee Payroll Payment Details is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeePayrollPaymentDetailsID { get; set; }

   //         [Required(ErrorMessage = "Employee Payroll And Payment Info is required")]
   //         [Display(Name = "Employee Payroll And Payment Info")]
   //         [ForeignKey("EmployeePayrollAndPaymentInfo")]
   //         public Int32 EmployeePayrollAndPaymentInfoID { get; set; }

   //         [Required(ErrorMessage = "Pay From Acct Account Head is required")]
   //         [Display(Name = "Pay From Acct Account Head")]
   //         [ForeignKey("PayFromAcctAccountHead")]
   //         public Int32 PayFromAcctAccountHeadID { get; set; }

   //         [Required(ErrorMessage = "Pay To Acct Account Head is required")]
   //         [Display(Name = "Pay To Acct Account Head")]
   //         [ForeignKey("PayToAcctAccountHead")]
   //         public Int32 PayToAcctAccountHeadID { get; set; }

   //         [Required(ErrorMessage = "Amount is required")]
   //         [Display(Name = "Amount")]
   //         public Double Amount { get; set; }

   //         [Required(ErrorMessage = "Currency is required")]
   //         [Display(Name = "Currency")]
   //         public Int32 Currency { get; set; }

   //         [Display(Name = "Notes")]
   //         [StringLength(256)]
   //         public String Notes { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead1 { get; set; }

   //         public virtual EmployeePayrollAndPaymentInfo EmployeePayrollAndPaymentInfo { get; set; }

   //     }
   //public class EmployeePayrollSlip
   //     {

   //         [Required(ErrorMessage = "Employee Payroll Slips is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeePayrollSlipsID { get; set; }

   //         [Required(ErrorMessage = "Employee Payroll Payment Info is required")]
   //         [Display(Name = "Employee Payroll Payment Info")]
   //         [ForeignKey("EmployeePayrollPaymentInfo")]
   //         public Int32 EmployeePayrollPaymentInfoID { get; set; }

   //         [Required(ErrorMessage = "Image File is required")]
   //         [Display(Name = "Image File")]
   //         public Byte[] ImageFile { get; set; }

   //         [Required(ErrorMessage = "Original File Name is required")]
   //         [Display(Name = "Original File Name")]
   //         [StringLength(256)]
   //         public String OriginalFileName { get; set; }

   //         [Required(ErrorMessage = "File Extension is required")]
   //         [Display(Name = "File Extension")]
   //         [StringLength(64)]
   //         public String FileExtension { get; set; }

   //         [Required(ErrorMessage = "File Type is required")]
   //         [Display(Name = "File Type")]
   //         [StringLength(256)]
   //         public String FileType { get; set; }

   //         [Required(ErrorMessage = "File Size is required")]
   //         [Display(Name = "File Size")]
   //         public Int32 FileSize { get; set; }

   //         [Required(ErrorMessage = "Is Removed is required")]
   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //     }
   //public class EmployeeAdditionalCostToCompany
   //     {

   //         [Required(ErrorMessage = "Employee Additional Cost To Company is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeAdditionalCostToCompanyID { get; set; }

   //         [Required(ErrorMessage = "Acct Account Head is required")]
   //         [Display(Name = "Acct Account Head")]
   //         [ForeignKey("AcctAccountHead")]
   //         public Int32 AcctAccountHeadID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Display(Name = "Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime Date { get; set; }

   //         [Required(ErrorMessage = "Amount is required")]
   //         [Display(Name = "Amount")]
   //         public Double Amount { get; set; }

   //         [Required(ErrorMessage = "Currency is required")]
   //         [Display(Name = "Currency")]
   //         [ForeignKey("Currency")]
   //         public Int32 CurrencyID { get; set; }

   //         [Display(Name = "Note")]
   //         [StringLength(512)]
   //         public String Note { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }
   //public class EmployeeAllowancesAndBenefit
   //     {

   //         [Required(ErrorMessage = "Employee Allowances And Benefits is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeAllowancesAndBenefitsID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Employee Allowance And Benefits Package is required")]
   //         [Display(Name = "Employee Allowance And Benefits Package")]
   //         [ForeignKey("EmployeeAllowanceAndBenefitsPackage")]
   //         public Int32 EmployeeAllowanceAndBenefitsPackageID { get; set; }

   //         [Display(Name = "Description")]
   //         [StringLength(512)]
   //         public String Description { get; set; }

   //         [Display(Name = "Is Current")]
   //         public Boolean IsCurrent { get; set; }

   //         [Required(ErrorMessage = "Is Removed is required")]
   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual EmployeeAllowancesAndBenefitsDetail EmployeeAllowancesAndBenefitsDetails { get; set; }

   //     }
   //public class EmployeeAllowancesAndBenefitsDetail
   //     {

   //         [Required(ErrorMessage = "Employee Allowances And Benefits Details is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeAllowancesAndBenefitsDetailsID { get; set; }

   //         [Required(ErrorMessage = "Employee Allowances And Benefits is required")]
   //         [Display(Name = "Employee Allowances And Benefits")]
   //         [ForeignKey("EmployeeAllowancesAndBenefits")]
   //         public Int32 EmployeeAllowancesAndBenefitsID { get; set; }

   //         [Required(ErrorMessage = "Acct Account Head is required")]
   //         [Display(Name = "Acct Account Head")]
   //         [ForeignKey("AcctAccountHead")]
   //         public Int32 AcctAccountHeadID { get; set; }

   //         [Display(Name = "Amount")]
   //         public Double Amount { get; set; }

   //         [Display(Name = "Percentage Of Basic Salary")]
   //         public Double PercentageOfBasicSalary { get; set; }

   //         [Display(Name = "Salary Rate Duration")]
   //         [ForeignKey("SalaryRateDuration")]
   //         public Int32 SalaryRateDurationID { get; set; }

   //         [Display(Name = "Pay Cycle")]
   //         [ForeignKey("PayCycle")]
   //         public Int32 PayCycleID { get; set; }

   //         [Display(Name = "Currency")]
   //         [ForeignKey("Currency")]
   //         public Int32 CurrencyID { get; set; }

   //         [Display(Name = "Effective Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime EffectiveDate { get; set; }

   //         [Display(Name = "End Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime EndDate { get; set; }

   //         [Display(Name = "Note")]
   //         [StringLength(256)]
   //         public String Note { get; set; }

   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //         public virtual EmployeeAllowancesAndBenefit EmployeeAllowancesAndBenefit { get; set; }

   //     }
   //public class EmployeeCostToCompany
   //     {

   //         [Required(ErrorMessage = "Employee Cost To Company is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeCostToCompanyID { get; set; }

   //         [Required(ErrorMessage = "Name is required")]
   //         [Display(Name = "Name")]
   //         [StringLength(128)]
   //         public String Name { get; set; }

   //         [Display(Name = "Description")]
   //         [MaxLength]
   //         public String Description { get; set; }

   //         [Required(ErrorMessage = "Is Removed is required")]
   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //     }
   //public class EmployeeAllowanceAndBenefitsPackage
   //     {

   //         [Required(ErrorMessage = "Employee Allowance And Benefits Package is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeAllowanceAndBenefitsPackageID { get; set; }

   //         [Display(Name = "Name")]
   //         [StringLength(64)]
   //         public String Name { get; set; }

   //         [Display(Name = "Description")]
   //         [StringLength(512)]
   //         public String Description { get; set; }

   //         [Required(ErrorMessage = "Is Removed is required")]
   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //     }
   //public class EmployeeAllowanceAndBenefitsPackageDetail
   //     {

   //         [Required(ErrorMessage = "Employee Allowance And Benefits Package Details is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeAllowanceAndBenefitsPackageDetails { get; set; }

   //         [Required(ErrorMessage = "Employee Allowances And Benefits is required")]
   //         [Display(Name = "Employee Allowances And Benefits")]
   //         [ForeignKey("EmployeeAllowancesAndBenefits")]
   //         public Int32 EmployeeAllowancesAndBenefitsID { get; set; }

   //         [Required(ErrorMessage = "Acct Account Head is required")]
   //         [Display(Name = "Acct Account Head")]
   //         [ForeignKey("AcctAccountHead")]
   //         public Int32 AcctAccountHeadID { get; set; }

   //         [Display(Name = "Amount")]
   //         public Double Amount { get; set; }

   //         [Display(Name = "Percentage Of Basic Salary")]
   //         public Double PercentageOfBasicSalary { get; set; }

   //         [Display(Name = "Salary Rate Duration")]
   //         [ForeignKey("SalaryRateDuration")]
   //         public Int32 SalaryRateDurationID { get; set; }

   //         [Display(Name = "Pay Cycle")]
   //         [ForeignKey("PayCycle")]
   //         public Int32 PayCycleID { get; set; }

   //         [Display(Name = "Currency")]
   //         [ForeignKey("Currency")]
   //         public Int32 CurrencyID { get; set; }

   //         [Display(Name = "Note")]
   //         [StringLength(256)]
   //         public String Note { get; set; }

   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //         public virtual AcctAccountHead AcctAccountHead { get; set; }

   //     }
   //public class SalaryRemunerationInfo
   //     {

   //         [Required(ErrorMessage = "Salary Remuneration Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 SalaryRemunerationInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Is Salary Pay By Client is required")]
   //         [Display(Name = "Is Salary Pay By Client")]
   //         public Boolean IsSalaryPayByClient { get; set; }

   //         [Display(Name = "Client Pay Start Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime ClientPayStartDate { get; set; }

   //         [Display(Name = "Client Pay End Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime ClientPayEndDate { get; set; }

   //         [Display(Name = "Notes")]
   //         [MaxLength]
   //         public String Notes { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }
   //public class EmployeeTeam
   // {
		
   //     [Required(ErrorMessage="Employee Team is required")]
   //     [Display(AutoGenerateField=false)]
   //     [Key]
   //     public Int32 EmployeeTeamID { get; set; }

   //     [Required(ErrorMessage="Employee Team Category is required")]
   //     [Display(Name="Employee Team Category")]
   //     [ForeignKey("EmployeeTeamCategory")]
   //     public Int32 EmployeeTeamCategoryID { get; set; }

   //     [Required(ErrorMessage="Primary Employee Employee is required")]
   //     [Display(Name="Primary Employee Employee")]
   //     [ForeignKey("PrimaryEmployeeEmployee")]
   //     public Int32 PrimaryEmployeeEmployeeID { get; set; }

   //     [Required(ErrorMessage="Team Employee is required")]
   //     [Display(Name="Team Employee")]
   //     [ForeignKey("TeamEmployee")]
   //     public Int32 TeamEmployeeID { get; set; }

   //     [Required(ErrorMessage="Is Removed is required")]
   //     [Display(Name="Is Removed")]
   //     public Boolean IsRemoved { get; set; }

   //     public virtual EmployeeTeamCategory EmployeeTeamCategory { get; set; }

   //     public virtual Employee Employee { get; set; }

   //     public virtual Employee Employee1 { get; set; }

   // }
   //public class EmploymentStatu
   // {

   //     [Required(ErrorMessage = "Employment Status is required")]
   //     [Display(AutoGenerateField = false)]
   //     [Key]
   //     public Int32 EmploymentStatusID { get; set; }

   //     [Required(ErrorMessage = "Name is required")]
   //     [Display(Name = "Name")]
   //     [StringLength(128)]
   //     public String Name { get; set; }

   //     [Required(ErrorMessage = "Is Removed is required")]
   //     [Display(Name = "Is Removed")]
   //     public Boolean IsRemoved { get; set; }

   //     public virtual EmployeeEmploymentStatu EmployeeEmploymentStatus { get; set; }

   // }
   //public class EmployeeHourlyAttendenceInfo
   //     {

   //         [Required(ErrorMessage = "Employee Hourly Attendence Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [DataType(DataType.Url)]
   //         [RegularExpression(@"http://([\w-]+\.)+[\w-]+(/[\w-./%&=]*)", ErrorMessage = "Url is not valid")]
   //         [Key]
   //         public Int32 EmployeeHourlyAttendenceInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Time Sheet Info is required")]
   //         [Display(Name = "Time Sheet Info")]
   //         [ForeignKey("TimeSheetInfo")]
   //         public Int32 TimeSheetInfoID { get; set; }

   //         [Display(Name = "Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime Date { get; set; }

   //         [Display(Name = "Start Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime StartTime { get; set; }

   //         [Display(Name = "End Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime EndTime { get; set; }

   //         [Display(Name = "Total Work Hours")]
   //         public Double TotalWorkHours { get; set; }

   //         [Display(Name = "O T Work Hours")]
   //         public Double OTWorkHours { get; set; }

   //         [Display(Name = "Time Off Work Hours")]
   //         public Double TimeOffWorkHours { get; set; }

   //         [Display(Name = "Attendance Time Off Category")]
   //         [ForeignKey("AttendanceTimeOffCategory")]
   //         public Int32 AttendanceTimeOffCategoryID { get; set; }

   //         [Required(ErrorMessage = "Attendance Leave Holiday List is required")]
   //         [Display(Name = "Attendance Leave Holiday List")]
   //         [ForeignKey("AttendanceLeaveHolidayList")]
   //         public Int32 AttendanceLeaveHolidayListID { get; set; }

   //         [Display(Name = "Notes")]
   //         [MaxLength]
   //         public String Notes { get; set; }

   //         [Required(ErrorMessage = "Submited is required")]
   //         [Display(Name = "Submited")]
   //         public Boolean Submited { get; set; }

   //         public virtual EmployeeHourlyAttendenceApproval EmployeeHourlyAttendenceApprovals { get; set; }

   //         public virtual AttendanceTimeOffCategory AttendanceTimeOffCategory { get; set; }

   //         public virtual AttendanceLeaveHolidayList AttendanceLeaveHolidayList { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }
   //public class EmployeeDailyAttendaceApproval
   //     {

   //         [Required(ErrorMessage = "Employee Daily Attendace Approval is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeDailyAttendaceApprovalID { get; set; }

   //         [Required(ErrorMessage = "Time Sheet Info is required")]
   //         [Display(Name = "Time Sheet Info")]
   //         [ForeignKey("TimeSheetInfo")]
   //         public Int32 TimeSheetInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Employee Timesheet Approval Team is required")]
   //         [Display(Name = "Employee Timesheet Approval Team")]
   //         [ForeignKey("EmployeeTimesheetApprovalTeam")]
   //         public Int32 EmployeeTimesheetApprovalTeamID { get; set; }

   //         [Required(ErrorMessage = "Approved By Employee is required")]
   //         [Display(Name = "Approved By Employee")]
   //         [ForeignKey("ApprovedByEmployee")]
   //         public Int32 ApprovedByEmployeeID { get; set; }

   //         [Display(Name = "Approved Work Days")]
   //         public Double ApprovedWorkDays { get; set; }

   //         [Display(Name = "Approved Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime ApprovedDate { get; set; }

   //         [Display(Name = "Notes")]
   //         [StringLength(128)]
   //         public String Notes { get; set; }

   //         [Required(ErrorMessage = "Approval Code is required")]
   //         [Display(Name = "Approval Code")]
   //         [StringLength(128)]
   //         public String ApprovalCode { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual Employee Employee1 { get; set; }

   //         public virtual PayrollTimesheetDataInfo PayrollTimesheetDataInfoes { get; set; }

   //     }
   //public class EmployeeDailyAttendanceInfo
   //     {

   //         [Required(ErrorMessage = "Employee Daily Attendance Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeDailyAttendanceInfoID { get; set; }

   //         [Required(ErrorMessage = "Time Sheet Info is required")]
   //         [Display(Name = "Time Sheet Info")]
   //         [ForeignKey("TimeSheetInfo")]
   //         public Int32 TimeSheetInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Attendance Leave Holiday List is required")]
   //         [Display(Name = "Attendance Leave Holiday List")]
   //         [ForeignKey("AttendanceLeaveHolidayList")]
   //         public Int32 AttendanceLeaveHolidayListID { get; set; }

   //         [Display(Name = "Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime Date { get; set; }

   //         [Required(ErrorMessage = "Submited is required")]
   //         [Display(Name = "Submited")]
   //         public Boolean Submited { get; set; }

   //         public virtual AttendanceLeaveHolidayList AttendanceLeaveHolidayList { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual ProjectWorkTimeSheetDetail ProjectWorkTimeSheetDetails { get; set; }

   //     }
   //public class EmployeeTimesheetApprovalTeam
   //     {

   //         [Required(ErrorMessage = "Employee Timesheet Approval Team is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeTimesheetApprovalTeamID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Approved By Employee is required")]
   //         [Display(Name = "Approved By Employee")]
   //         [ForeignKey("ApprovedByEmployee")]
   //         public Int32 ApprovedByEmployeeID { get; set; }

   //         [Required(ErrorMessage = "Is Primary is required")]
   //         [Display(Name = "Is Primary")]
   //         public Boolean IsPrimary { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual Employee Employee1 { get; set; }

   //     }
   //public class EmployeeHourlyAttendenceApproval
   //     {

   //         [Required(ErrorMessage = "Employee Hourly Attendence Approvall is required")]
   //         [Display(AutoGenerateField = false)]
   //         [DataType(DataType.Url)]
   //         [RegularExpression(@"http://([\w-]+\.)+[\w-]+(/[\w-./%&=]*)", ErrorMessage = "Url is not valid")]
   //         [Key]
   //         public Int32 EmployeeHourlyAttendenceApprovallID { get; set; }

   //         [Required(ErrorMessage = "Time Sheet Info is required")]
   //         [Display(Name = "Time Sheet Info")]
   //         [ForeignKey("TimeSheetInfo")]
   //         public Int32 TimeSheetInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Employee Hourly Attendence Info is required")]
   //         [Display(Name = "Employee Hourly Attendence Info")]
   //         [DataType(DataType.Url)]
   //         [RegularExpression(@"http://([\w-]+\.)+[\w-]+(/[\w-./%&=]*)", ErrorMessage = "Url is not valid")]
   //         [ForeignKey("EmployeeHourlyAttendenceInfo")]
   //         public Int32 EmployeeHourlyAttendenceInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee Timesheet Approval Team is required")]
   //         [Display(Name = "Employee Timesheet Approval Team")]
   //         [ForeignKey("EmployeeTimesheetApprovalTeam")]
   //         public Int32 EmployeeTimesheetApprovalTeamID { get; set; }

   //         [Required(ErrorMessage = "Approved By Employee is required")]
   //         [Display(Name = "Approved By Employee")]
   //         [ForeignKey("ApprovedByEmployee")]
   //         public Int32 ApprovedByEmployeeID { get; set; }

   //         [Display(Name = "Approved Work Hours")]
   //         public Double ApprovedWorkHours { get; set; }

   //         [Display(Name = "Approved O T Work Hours")]
   //         public Double ApprovedOTWorkHours { get; set; }

   //         [Display(Name = "Notes")]
   //         [StringLength(128)]
   //         public String Notes { get; set; }

   //         public virtual EmployeeHourlyAttendenceInfo EmployeeHourlyAttendenceInfo { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual Employee Employee1 { get; set; }

   //     }
   //public class EmployeeTimesheetPaymentInfo
   //     {

   //         [Required(ErrorMessage = "Employee Timesheet Payment Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeTimesheetPaymentInfoID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Display(Name = "Employee Payroll And Payment Info")]
   //         [ForeignKey("EmployeePayrollAndPaymentInfo")]
   //         public Int32 EmployeePayrollAndPaymentInfoID { get; set; }

   //         [Required(ErrorMessage = "Payroll Generation  is required")]
   //         [Display(Name = "Payroll Generation ")]
   //         [ForeignKey("PayrollGeneration")]
   //         public Int32 PayrollGenerationID { get; set; }

   //         [Display(Name = "Total Approved O T Work Hours")]
   //         public Double TotalApprovedOTWorkHours { get; set; }

   //         [Display(Name = "Total Approved Work Days")]
   //         public Double TotalApprovedWorkDays { get; set; }

   //         [Display(Name = "Total Approved Work Hours")]
   //         public Double TotalApprovedWorkHours { get; set; }

   //         public virtual EmployeePayrollAndPaymentInfo EmployeePayrollAndPaymentInfo { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual PayrollGeneration PayrollGeneration { get; set; }

   //     }
   //public class EmployeeWorkHour
   //     {

   //         [Required(ErrorMessage = "Employee Work Hour is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeWorkHourID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Display(Name = "Work Shift")]
   //         [ForeignKey("WorkShift")]
   //         public Int32 WorkShiftID { get; set; }

   //         [Required(ErrorMessage = "Work Shift Name is required")]
   //         [Display(Name = "Work Shift Name")]
   //         [StringLength(128)]
   //         public String WorkShiftName { get; set; }

   //         [Required(ErrorMessage = "Number Of Work Hours Per Day is required")]
   //         [Display(Name = "Number Of Work Hours Per Day")]
   //         public Int32 NumberOfWorkHoursPerDay { get; set; }

   //         [Required(ErrorMessage = "Number Of Work Hours Per Week is required")]
   //         [Display(Name = "Number Of Work Hours Per Week")]
   //         public Int32 NumberOfWorkHoursPerWeek { get; set; }

   //         [Display(Name = "Number Of Work Hours Per Month")]
   //         public Int32 NumberOfWorkHoursPerMonth { get; set; }

   //         [Required(ErrorMessage = "Number Of Work Days Per Week is required")]
   //         [Display(Name = "Number Of Work Days Per Week")]
   //         public Int32 NumberOfWorkDaysPerWeek { get; set; }

   //         [Display(Name = "Number Of Work Days Per Month")]
   //         public Int32 NumberOfWorkDaysPerMonth { get; set; }

   //         [Required(ErrorMessage = "Is Work Days Calander Month is required")]
   //         [Display(Name = "Is Work Days Calander Month")]
   //         public Boolean IsWorkDaysCalanderMonth { get; set; }

   //         [Required(ErrorMessage = "Is Sunday Work Day is required")]
   //         [Display(Name = "Is Sunday Work Day")]
   //         public Boolean IsSundayWorkDay { get; set; }

   //         [Display(Name = "Sunday Start Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime SundayStartTime { get; set; }

   //         [Display(Name = "Sunday End Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime SundayEndTime { get; set; }

   //         [Required(ErrorMessage = "Is Monday Work Day is required")]
   //         [Display(Name = "Is Monday Work Day")]
   //         public Boolean IsMondayWorkDay { get; set; }

   //         [Display(Name = "Monday Start Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime MondayStartTime { get; set; }

   //         [Display(Name = "Monday End Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime MondayEndTime { get; set; }

   //         [Required(ErrorMessage = "Is Tuesday Work Day is required")]
   //         [Display(Name = "Is Tuesday Work Day")]
   //         public Boolean IsTuesdayWorkDay { get; set; }

   //         [Display(Name = "Tuesday Start Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime TuesdayStartTime { get; set; }

   //         [Display(Name = "Tuesday End Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime TuesdayEndTime { get; set; }

   //         [Required(ErrorMessage = "Is Wednesday Work Day is required")]
   //         [Display(Name = "Is Wednesday Work Day")]
   //         public Boolean IsWednesdayWorkDay { get; set; }

   //         [Display(Name = "Wednesday Start Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime WednesdayStartTime { get; set; }

   //         [Display(Name = "Wednesday End Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime WednesdayEndTime { get; set; }

   //         [Required(ErrorMessage = "Is Thursday Work Day is required")]
   //         [Display(Name = "Is Thursday Work Day")]
   //         public Boolean IsThursdayWorkDay { get; set; }

   //         [Display(Name = "Thursday Start Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime ThursdayStartTime { get; set; }

   //         [Display(Name = "Thursday End Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime ThursdayEndTime { get; set; }

   //         [Required(ErrorMessage = "Is Friday Work Day is required")]
   //         [Display(Name = "Is Friday Work Day")]
   //         [ForeignKey("IsFridayWorkD")]
   //         public Boolean IsFridayWorkDay { get; set; }

   //         [Display(Name = "Friday Start Time")]
   //         [DataType(DataType.DateTime)]
   //         [ForeignKey("FridayStartTi")]
   //         public DateTime FridayStartTime { get; set; }

   //         [Display(Name = "Friday End Time")]
   //         [DataType(DataType.DateTime)]
   //         [ForeignKey("FridayEndTi")]
   //         public DateTime FridayEndTime { get; set; }

   //         [Required(ErrorMessage = "Is Saturday Work Day is required")]
   //         [Display(Name = "Is Saturday Work Day")]
   //         public Boolean IsSaturdayWorkDay { get; set; }

   //         [Display(Name = "Saturday Start Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime SaturdayStartTime { get; set; }

   //         [Display(Name = "Saturday End Time")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime SaturdayEndTime { get; set; }

   //         [Required(ErrorMessage = "Is Removed is required")]
   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //         [Required(ErrorMessage = "Is Current is required")]
   //         [Display(Name = "Is Current")]
   //         public Boolean IsCurrent { get; set; }

   //         public virtual EmployeeBasicSalaryBreakdownInfo EmployeeBasicSalaryBreakdownInfoes { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }
   //public class EmployeeHourlyAttendenceApprovalSummury
   //     {

   //         [Required(ErrorMessage = "Employee Hourly Attendence Approval Summury is required")]
   //         [Display(AutoGenerateField = false)]
   //         [DataType(DataType.Url)]
   //         [RegularExpression(@"http://([\w-]+\.)+[\w-]+(/[\w-./%&=]*)", ErrorMessage = "Url is not valid")]
   //         [Key]
   //         public Int32 EmployeeHourlyAttendenceApprovalSummuryID { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Required(ErrorMessage = "Time Sheet Info is required")]
   //         [Display(Name = "Time Sheet Info")]
   //         [ForeignKey("TimeSheetInfo")]
   //         public Int32 TimeSheetInfoID { get; set; }

   //         [Required(ErrorMessage = "Total Approved Work Hours is required")]
   //         [Display(Name = "Total Approved Work Hours")]
   //         public Double TotalApprovedWorkHours { get; set; }

   //         [Required(ErrorMessage = "Total Approved O T Work Hours is required")]
   //         [Display(Name = "Total Approved O T Work Hours")]
   //         public Double TotalApprovedOTWorkHours { get; set; }

   //         public virtual Employee Employee { get; set; }

   //         public virtual PayrollTimesheetDataInfo PayrollTimesheetDataInfoes { get; set; }

   //     }
   //public class EmployeeFiscalYearInfo
   //     {

   //         [Required(ErrorMessage = "Employee Fiscal Year Info is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 EmployeeFiscalYearInfoID { get; set; }

   //         [Display(Name = "Description")]
   //         [MaxLength]
   //         public String Description { get; set; }

   //         [Required(ErrorMessage = "Employee is required")]
   //         [Display(Name = "Employee")]
   //         [ForeignKey("Employee")]
   //         public Int32 EmployeeID { get; set; }

   //         [Display(Name = "F Y Start Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime FYStartDate { get; set; }

   //         [Display(Name = "F Y End Date")]
   //         [DataType(DataType.DateTime)]
   //         public DateTime FYEndDate { get; set; }

   //         [Display(Name = "Year Number")]
   //         public Int32 YearNumber { get; set; }

   //         [Required(ErrorMessage = "Is Current is required")]
   //         [Display(Name = "Is Current")]
   //         public Boolean IsCurrent { get; set; }

   //         public virtual Employee Employee { get; set; }

   //     }
   //public class AttendanceLeaveAndHolidayCategory
   //     {

   //         [Required(ErrorMessage = "Attendance Leave And Holiday Category is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 AttendanceLeaveAndHolidayCategoryID { get; set; }

   //         [Required(ErrorMessage = "Name is required")]
   //         [Display(Name = "Name")]
   //         [StringLength(64)]
   //         public String Name { get; set; }

   //         [Display(Name = "Description")]
   //         [MaxLength]
   //         public String Description { get; set; }

   //         [Required(ErrorMessage = "Is Removed is required")]
   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //         public virtual AttendanceLeaveHolidayList AttendanceLeaveHolidayLists { get; set; }

   //     }
   //public class AttendanceLeaveHolidayList
   //     {

   //         [Required(ErrorMessage = "Attendance Leave Holiday List is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 AttendanceLeaveHolidayListID { get; set; }

   //         [Required(ErrorMessage = "Attendance Leave And Holiday Category is required")]
   //         [Display(Name = "Attendance Leave And Holiday Category")]
   //         [ForeignKey("AttendanceLeaveAndHolidayCategory")]
   //         public Int32 AttendanceLeaveAndHolidayCategoryID { get; set; }

   //         [Required(ErrorMessage = "Name is required")]
   //         [Display(Name = "Name")]
   //         [StringLength(128)]
   //         public String Name { get; set; }

   //         [Display(Name = "Description")]
   //         [StringLength(256)]
   //         public String Description { get; set; }

   //         [Required(ErrorMessage = "Color is required")]
   //         [Display(Name = "Color")]
   //         [StringLength(64)]
   //         public String Color { get; set; }

   //         [Required(ErrorMessage = "Code is required")]
   //         [Display(Name = "Code")]
   //         [StringLength(64)]
   //         public String Code { get; set; }

   //         public virtual EmployeeDailyAttendanceInfo EmployeeDailyAttendanceInfoes { get; set; }

   //         public virtual EmployeeHourlyAttendenceInfo EmployeeHourlyAttendenceInfoes { get; set; }

   //         public virtual EmployeeLeaveAccount EmployeeLeaveAccounts { get; set; }

   //         public virtual EmployeeLeaveApplicationDetail EmployeeLeaveApplicationDetails { get; set; }

   //         public virtual EmployeeLeaveOpeningBalance EmployeeLeaveOpeningBalances { get; set; }

   //         public virtual EmployeeLeavePackageDetail EmployeeLeavePackageDetails { get; set; }

   //         public virtual ReturnToWorkEmployeeReportDetail ReturnToWorkEmployeeReportDetails { get; set; }

   //         public virtual HolidayCalendarHolidayList HolidayCalendarHolidayLists { get; set; }

   //         public virtual HolidayCalendarWeekEnd HolidayCalendarWeekEnds { get; set; }

   //         public virtual AttendanceLeaveAndHolidayCategory AttendanceLeaveAndHolidayCategory { get; set; }

   //         public virtual LeavePackageDetail LeavePackageDetails { get; set; }

   //     }
   //public class AttendanceTimeOffCategory
   //     {

   //         [Required(ErrorMessage = "Attendance Time Off Category is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 AttendanceTimeOffCategoryID { get; set; }

   //         [Required(ErrorMessage = "Name is required")]
   //         [Display(Name = "Name")]
   //         [StringLength(128)]
   //         public String Name { get; set; }

   //         [Display(Name = "Description")]
   //         [MaxLength]
   //         public String Description { get; set; }

   //         [Required(ErrorMessage = "Is Removed is required")]
   //         [Display(Name = "Is Removed")]
   //         public Boolean IsRemoved { get; set; }

   //         public virtual EmployeeHourlyAttendenceInfo EmployeeHourlyAttendenceInfoes { get; set; }

   //     }
   //public class ProjectWorkTimeSheetDetail
   //     {

   //         [Required(ErrorMessage = "Project Work Time Sheet Details is required")]
   //         [Display(AutoGenerateField = false)]
   //         [Key]
   //         public Int32 ProjectWorkTimeSheetDetailsID { get; set; }

   //         [Required(ErrorMessage = "Employee Daily Attendance Info is required")]
   //         [Display(Name = "Employee Daily Attendance Info")]
   //         [ForeignKey("EmployeeDailyAttendanceInfo")]
   //         public Int32 EmployeeDailyAttendanceInfoID { get; set; }

   //         [Required(ErrorMessage = "P M Employee Project Assign is required")]
   //         [Display(Name = "P M Employee Project Assign")]
   //         [ForeignKey("PMEmployeeProjectAssign")]
   //         public Int32 PMEmployeeProjectAssignID { get; set; }

   //         [Display(Name = "Project Work Percentage")]
   //         public Double ProjectWorkPercentage { get; set; }

   //         public virtual EmployeeDailyAttendanceInfo EmployeeDailyAttendanceInfo { get; set; }

   //         public virtual PMEmployeeProjectAssign PMEmployeeProjectAssign { get; set; }

   //     }
   //public class EmploymentContract
   // {
		
   //     [Required(ErrorMessage="Employment Contract is required")]
   //     [Display(AutoGenerateField=false)]
   //     [Key]
   //     public Int32 EmploymentContractID { get; set; }

   //     [Required(ErrorMessage="Employee is required")]
   //     [Display(Name="Employee")]
   //     [ForeignKey("Employee")]
   //     public Int32 EmployeeID { get; set; }

   //     [Required(ErrorMessage="Contract Duration is required")]
   //     [Display(Name="Contract Duration")]
   //     [StringLength(64)]
   //     public String ContractDuration { get; set; }

   //     [Required(ErrorMessage="Contract Start Date is required")]
   //     [Display(Name="Contract Start Date")]
   //     [DataType(DataType.DateTime)]
   //     public DateTime ContractStartDate { get; set; }

   //     [Required(ErrorMessage="Contract End Date is required")]
   //     [Display(Name="Contract End Date")]
   //     [DataType(DataType.DateTime)]
   //     public DateTime ContractEndDate { get; set; }

   //     [Display(Name="Details")]
   //     public String Details { get; set; }

   //     [Display(Name="Is Renewable")]
   //     public Boolean IsRenewable { get; set; }

   //     public virtual Employee Employee { get; set; }

   // }
   //public class EmployeeWorkLocation
   // {
		
   //     [Required(ErrorMessage="Employee Work Location is required")]
   //     [Display(AutoGenerateField=false)]
   //     [Key]
   //     public Int32 EmployeeWorkLocationID { get; set; }

   //     [Required(ErrorMessage="Employee is required")]
   //     [Display(Name="Employee")]
   //     [ForeignKey("Employee")]
   //     public Int32 EmployeeID { get; set; }

   //     [Required(ErrorMessage="Office Address1 is required")]
   //     [Display(Name="Office Address1")]
   //     [StringLength(256)]
   //     public String OfficeAddress1 { get; set; }

   //     [Display(Name="Office Address2")]
   //     [StringLength(256)]
   //     public String OfficeAddress2 { get; set; }

   //     [Display(Name="City")]
   //     [StringLength(256)]
   //     public String City { get; set; }

   //     [Display(Name="P O Box")]
   //     [StringLength(64)]
   //     public String POBox { get; set; }

   //     [Display(Name="Zip Code")]
   //     public Int32 ZipCode { get; set; }

   //     [Display(Name="Country")]
   //     [ForeignKey("Country")]
   //     public Int32 CountryID { get; set; }

   //     [Display(Name="State")]
   //     [ForeignKey("State")]
   //     public Int32 StateID { get; set; }

   //     [Required(ErrorMessage="Is Primary Office is required")]
   //     [Display(Name="Is Primary Office")]
   //     public Boolean IsPrimaryOffice { get; set; }

   //     [Display(Name="Employee Work Location Type")]
   //     [ForeignKey("EmployeeWorkLocationType")]
   //     public Int32 EmployeeWorkLocationTypeID { get; set; }

   //     [Display(Name="Office Phone")]
   //     [StringLength(64)]
   //     [DataType(DataType.PhoneNumber)]
   //     public String OfficePhone { get; set; }

   //     [Display(Name="Office Phone Extension")]
   //     [StringLength(64)]
   //     [DataType(DataType.PhoneNumber)]
   //     public String OfficePhoneExtension { get; set; }

   //     [Display(Name="Office Fax")]
   //     [StringLength(64)]
   //     public String OfficeFax { get; set; }

   //     [Display(Name="Toll Free Phone")]
   //     [StringLength(64)]
   //     [DataType(DataType.PhoneNumber)]
   //     public String TollFreePhone { get; set; }

   //     [Display(Name="Toll Free Phone Extension")]
   //     [StringLength(64)]
   //     [DataType(DataType.PhoneNumber)]
   //     public String TollFreePhoneExtension { get; set; }

   //     [Display(Name="Office Mobile")]
   //     [StringLength(64)]
   //     public String OfficeMobile { get; set; }

   //     [Display(Name="Office Email")]
   //     [StringLength(64)]
   //     [DataType(DataType.EmailAddress)]
   //     [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" , ErrorMessage = "Email address is not valid")]
   //     public String OfficeEmail { get; set; }

   //     [Display(Name="Start Date")]
   //     [DataType(DataType.DateTime)]
   //     public DateTime StartDate { get; set; }

   //     [Display(Name="End Date")]
   //     [DataType(DataType.DateTime)]
   //     public DateTime EndDate { get; set; }

   //     [Required(ErrorMessage="Is Removed is required")]
   //     [Display(Name="Is Removed")]
   //     public Boolean IsRemoved { get; set; }

   //     public virtual CMSEmail CMSEmails { get; set; }

   //     public virtual CMSEmailSendToAddress CMSEmailSendToAddresses { get; set; }

   //     public virtual CMSNewsLetterRecepientGroupEmployee CMSNewsLetterRecepientGroupEmployees { get; set; }

   //     public virtual Employee Employee { get; set; }

   // }


}