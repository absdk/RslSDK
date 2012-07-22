

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
  #region Company and Contact Editor Done [need new from link]

    public class Company
	{		
		[Required]
		[Display(AutoGenerateField=false)]
		[Key]
    	public Int32 CompanyID { get; set; }

		[Required(ErrorMessage="Company Name is required")]
		[Display(Name="Company Name")]
		[StringLength(256)]
        [IncludeInList(Sequence = 2, AllowSearch = true, Width = 20, AllowWidthInPercentage = true)]
    	public String CompanyName { get; set; }

        [Display(Name = "Display ID")]
        [StringLength(64)]
        [IncludeInList(Sequence = 1, AllowSearch = true, Width = 5, AllowWidthInPercentage = true)]
        public String CompanyDisplayId { get; set; }

        [Display(Name = "Industry Category")]
        [ForeignKey("Industry")]
        [IncludeInList(Sequence = 3, AllowSearch = true, Width = 20, AllowWidthInPercentage = true)]
        public Int32? IndustryID { get; set; }

        [Display(Name="Address1")]
		[StringLength(256)]
    	public String Address1 { get; set; }

		[Display(Name="Address2")]
		[StringLength(256)]
    	public String Address2 { get; set; }

		[Display(Name="City")]
		[StringLength(128)]
        [IncludeInList(Sequence = 4, Width = 10, AllowWidthInPercentage = true)]
    	public String City { get; set; }

		[Display(Name="Post Box Number")]
		[StringLength(16)]
    	public String PostBoxNumber { get; set; }

		[Display(Name="Country")]
        [ForeignKey("Country")]
        [IncludeInList(Sequence = 6, AllowSearch = true, Width = 10, AllowWidthInPercentage = true)]
    	public Int32? CountryID { get; set; }

		[Display(Name="State")]
        [ForeignKey("State")]
        [IncludeInList(Sequence = 5, AllowSearch = true, Width = 10, AllowWidthInPercentage = true)]
    	public Int32? StateID { get; set; }

		[Display(Name="Zip Code")]
		[StringLength(32)]
    	public String ZipCode { get; set; }

		[Display(Name="Main Office Phone")]
		[StringLength(64)]
		[DataType(DataType.PhoneNumber)]
		public String MainOfficePhone { get; set; }

		[Display(Name="Fax Number")]
		[StringLength(64)]
    	public String FaxNumber { get; set; }

		[Display(Name="Company Email Address")]
		[StringLength(128)]
		[DataType(DataType.EmailAddress)]
		[RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" , ErrorMessage = "Email address is not valid")]
        [IncludeInList(Sequence = 7, Width = 20, AllowWidthInPercentage = true,AllowFiltering=true, AllowGrouping=true, AllowSorting=true)]
    	public String CompanyEmailAddress { get; set; }

        [Display(Name = "Send Email")]
        public Boolean IsEmailSubscriber { get; set; }

        [Display(Name = "Is Email Validated")]
        public Boolean IsEmailValidated { get; set; }

		[Display(Name="Web Address")]
		[StringLength(256)]
    	public String WebAddress { get; set; }

        [Display(Name = "Company Owner Type")]
        [ForeignKey("CompanyOwner")]
        public Int32? CompanyOwnerID { get; set; }

        [Display(Name = "Employee Size")]
        public Int32? EmployeeSize { get; set; }

        [Display(Name = "Tax Identification Number")]
        [StringLength(32)]
        public String TaxNumber { get; set; }

        [Display(Name = "Duns Number")]
        [StringLength(32)]
        public String DunsNumber { get; set; }

		[Display(Name="About The Company")]
		[MaxLength]
        [DataType(DataType.Html)]
    	public String AboutTheCompany { get; set; }

        [Display(Name = "Logo")]
        public Byte[] Logo { get; set; }

        [Display(Name = "Internal Remarks")]
        [StringLength(256)]
        public String InternalRemarks { get; set; }

		[Display(Name="Company Rating")]
        [ForeignKey("CompanyRatingCategory")]
        [DataType("Rating")]
        public Int32? CompanyRatingScaleID { get; set; }
          
        [Display(Name="Company Status")]
        [ForeignKey("CompanyStatusCategory")]
        [IncludeInList(Sequence = 8, AllowSearch = true, Width = 10, AllowWidthInPercentage = true)]
        public Int32? CompanyStatusCategoryID { get; set; }

        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }


        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }


        [Display(Name = "Is Verified")]
        [DataType("Verified")]
        public Boolean IsVerified { get; set; }

        [Display(Name = "Verified By")]
        [ForeignKey("VerifiedByUser")]
        public Int32? VerifiedByUserID { get; set; }

        [Display(Name = "Verification Date")]
        [DataType(DataType.Date)]
        public DateTime? VerificationDate { get; set; }

     

        public virtual User CreatedByUser { get; set; }
        public virtual User VerifiedByUser { get; set; }
                    
        public virtual State   State   { get; set; }
        public virtual Country Country { get; set; }
        public virtual CompanyStatusCategory CompanyStatusCategory { get; set; }
        public virtual RatingScale CompanyRatingCategory { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual CompanyOwner CompanyOwner { get; set; }
        
    }
    public class CompanyAddress
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CompanyAddressID { get; set; }

        [Required]
        [ForeignKey("Company")]
        [Display(AutoGenerateField = false)]
        public Int32 CompanyID { get; set; }

        [Required(ErrorMessage = "Company Address Category is required")]
        [ForeignKey("CompanyAddressCategory")]
        [Display(Name = "Address Category")]
        public Int32 CompanyAddressCategoryID { get; set; }
        //dropdown to select category by name

        [Required(ErrorMessage = "Address Line1 is required")]
        [Display(Name = "Address Line1")]
        [StringLength(256)]
        public String AddressLine1 { get; set; }

        [Display(Name = "Address Line2")]
        [StringLength(256)]
        public String AddressLine2 { get; set; }

        [Display(Name = "Post Office Box Number")]
        public Int32 PostBoxNumber { get; set; }

        [Required(ErrorMessage = "City Name is required")]
        [Display(Name = "City Name")]
        [StringLength(128)]
        public String CityName { get; set; }

        [ForeignKey("Country")]
        [Display(Name = "Country")]
        public Int32? CountryID { get; set; }

        [ForeignKey("State")]
        [Display(Name = "State")]
        public Int32? StateID { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(16)]
        public String ZipCode { get; set; }

        [Display(Name = "OfficePhone")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        //phone validation code
        public String OfficePhone { get; set; }

        [Display(Name = "Fax Number")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String FaxPhone { get; set; }

        [Display(Name = "Personal Email")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public String PersonalEmail { get; set; }

        [Display(Name = "Is Bulk Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public Boolean IsBulkEmail { get; set; }

        public virtual Company Company { get; set; }
        public virtual CompanyAddressCategory CompanyAddressCategory { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }

    }
    public class Contact
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 ContactID { get; set; }

        [Display(Name = "Company" )]
        [ForeignKey("Company")]
        public Int32? CompanyID { get; set; }
        //contact can be added under company later or similar name with same company name and same domian address

        [Display(Name = "Company Name")]
        [StringLength(256)]
        public String CompanyName { get; set; }
        //Hidden - Show as or Copy from Company > Contact

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        [StringLength(128)]
        public String FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(128)]
        public String MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(128)]
        public String LastName { get; set; }

        [Display(Name = "Full Name")]
        [StringLength(512)]
        [IncludeInList(Sequence = 1, IncludeInGrid=true, AllowSearch = false, Width=25, AllowWidthInPercentage=true  )]
        public String FullName { get; set; }

        [Display(Name = "Job Title")]
        [StringLength(256)]
        [IncludeInList(Sequence = 2, IncludeInGrid = true, AllowSearch = false, Width = 25, AllowWidthInPercentage = true)]
        public String JobTitle { get; set; }

        [Display(Name = "Department")]
        [StringLength(128)]
        public String Department { get; set; }

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
        public Int32? CountryID { get; set; }

        [Display(Name = "State")]
        [ForeignKey("State")]
        public Int32? StateID { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(32)]
        public String ZipCode { get; set; }

        [Display(Name = "Office Phone")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        [IncludeInList(Sequence = 3, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String OfficePhone { get; set; }

        [Display(Name = "Mobile")]
        [StringLength(64)]
        [IncludeInList(Sequence = 4, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String Mobile { get; set; }

        [Display(Name = "Fax Number")]
        [StringLength(64)]
        public String FaxNumber { get; set; }

        [Display(Name = "Primary Email Address")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        [IncludeInList(Sequence = 5, IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String EmailAddress { get; set; }

        [Display(Name = "Send Email")]
        public Boolean IsEmailSubscriber { get; set; }

        [Display(Name = "Is Email Validated")]
        public Boolean IsEmailValidated { get; set; }

        [Display(Name = "Alternative Email")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public String AlternativeEmail { get; set; }

        [ForeignKey("ContactProfessionType")]
        [Display(Name = "Primary Professional Category")]
        public Int32? ContactProfessionTypeID { get; set; }


        [Display(Name = "Linkedin Profile Address")]
        [StringLength(256)]
        public String LinkedInProfileAddress { get; set; }

        [Display(Name = "Facebok Profile Address")]
        [StringLength(256)]
        public String FacebokProfileAddress { get; set; }

        [Display(Name = "Twitter Address")]
        [StringLength(256)]
        public String TwitterAccount { get; set; }

        [Display(Name = "GooglePlus Address")]
        [StringLength(256)]
        public String GooglePlusAccountAddress { get; set; }

        [Display(Name = "Personal Blog Address")]
        [StringLength(256)]
        public String PersonalBlogAddress { get; set; }

        [Display(Name = "Photo")]
        public Byte[] Photo { get; set; }

        [Display(Name = "Internal Remarks")]
        [StringLength(256)]
        public String InternalRemarks { get; set; }

        [Display(Name = "Profile Or Resume")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String ContactProfile { get; set; }
        //copy paste from Linkedin

        [Display(Name = "Contact Rating")]
        [ForeignKey("ContactRatingScale")]
        public Int32? ContactRatingScaleID { get; set; }

        [Display(Name = "Sequence in Company Oganizational Chart")]
        public Double SequenceInCompanyOrganizationalChart { get; set; }

        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }


        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }


        [Display(Name = "Is Verified")]
        [DataType("Verified")]
        public Boolean IsVerified { get; set; }

        [Display(Name = "Verified By")]
        [ForeignKey("VerifiedByUser")]
        public Int32? VerifiedByUserID { get; set; }

        [Display(Name = "Verification Date")]
        [DataType(DataType.Date)]
        public DateTime? VerificationDate { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual User VerifiedByUser { get; set; }
        public virtual State State { get; set; }
        public virtual Company Company { get; set; }
        public virtual Country Country { get; set; }
        public virtual RatingScale ContactRatingScale { get; set; }
        public virtual ContactProfessionType ContactProfessionType { get; set; }

    }
    
  #endregion

  #region  Company Email Editor

    public class CompanyEmail
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CompanyEmailID { get; set; }

        [ForeignKey("EmailSendToCompany")]
        public Int32 EmailSendToCompanyID { get; set; }

        [ForeignKey("EmailSendToContact")]
        public Int32 EmailSendToContactID { get; set; }

        [Required(ErrorMessage = "Comments By Name is required")]
        [Display(Name = "Send By")]
        [ForeignKey("EmailSendByUser")]
        public Int32 EmailSendByUserID { get; set; }

        [Display(Name = "Date Time")]
        [DataType(DataType.DateTime)]
        public DateTime SendDateTime { get; set; }

        [Display(Name = "Subject")]
        [StringLength(256)]
        public String EmailSubject { get; set; }

        [Display(Name = "Email Message")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String EmailMessage { get; set; }

        [Display(Name = "Is Email Viewed ")]
        public Boolean IsEmailViewedByApplicant { get; set; }

        public virtual Company EmailSendToCompany { get; set; }
        public virtual Contact EmailSendToContact { get; set; }
        public virtual User EmailSendByUser { get; set; }


    }
    public class CompanyEmailTemplate
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CompanyEmailTemplateID { get; set; }

        [Display(Name = "Template Created By")]
        [ForeignKey("TemplateCreatedByUser")]
        public Int32 TemplateCreatedByUserID { get; set; }

        [Display(Name = "Template Title")]
        [StringLength(256)]
        public String TemplateTitle { get; set; }

        [Display(Name = "Subject")]
        [StringLength(256)]
        public String EmailSubject { get; set; }

        [Display(Name = "Email Message")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String EmailMessage { get; set; }

        public virtual User TemplateCreatedByUser { get; set; }

    }

  #endregion
 
  #region Folder wise contact and company data management

    public class ContactFolder
    {

        [Required(ErrorMessage = "Contact Folder is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 ContactFolderID { get; set; }

        [Required(ErrorMessage = "Created By User is required")]
        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }

        [Required(ErrorMessage = "Folder Name is required")]
        [Display(Name = "Folder Name")]
        [StringLength(128)]
        public String FolderName { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }

      

        public virtual User CreatedByUser { get; set; }


    }
    public class ContactFolderContact
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 ContactFolderContactID { get; set; }

        [Required(ErrorMessage = "Contact Folder is required")]
        [Display(Name = "Contact Folder")]
        [ForeignKey("ContactFolder")]
        public Int32 ContactFolderID { get; set; }

        [Display(Name = "Company")]
        [ForeignKey("Company")]
        public Int32? CompanyID { get; set; }

        [Display(Name = "Contact")]
        [ForeignKey("Contact")]
        public Int32? ContactID { get; set; }

        public virtual ContactFolder ContactFolder { get; set; }
        public virtual Company Company { get; set; }
        public virtual Contact Contact { get; set; }



    }
    public class ContactFolderOwner
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 ContactFolderOwnerID { get; set; }

        [Required(ErrorMessage = "Contact Folder is required")]
        [Display(Name = "Contact Folder")]
        [ForeignKey("ContactFolder")]
        public Int32 ContactFolderID { get; set; }

        [Required(ErrorMessage = "Share With User is required")]
        [Display(Name = "Share Contact With User")]
        [ForeignKey("ShareWithUser")]
        public Int32 ShareWithUserID { get; set; }

        [Required(ErrorMessage = "Added Date is required")]
        [Display(Name = "Added Date")]
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }

        public virtual ContactFolder ContactFolder { get; set; }
        public virtual User ShareWithUser { get; set; }

    }

  #endregion

  #region  SFA - Sales Campaign Management

    public class SalesCampaign
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesCampaignID { get; set; }

        [ForeignKey("ParentSalesCampaign")]
        [Display(Name = "Parent Sales Campaign")]
        public Int32? ParentSalesCampaignID { get; set; }

        [Required(ErrorMessage = "Campaign Name is required")]
        [Display(Name = "Campaign Name")]
        [StringLength(256)]
        public String CampaignName { get; set; }

        [Display(Name = "Campaign Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String CampaignDescription { get; set; }

        [Display(Name = "Primary Campaign Location")]
        [StringLength(128)]
        public String CampaignLocation { get; set; }

        [Required(ErrorMessage = "Product or Service is required")]
        [Display(Name = "Primary Product or Service")]
        [ForeignKey("SalesProductServiceCatelog")]
        public Int32? PrimarySalesProductServiceID { get; set; }

        [Display(Name = "Expected Number Of Product/Service Sale")]
        public Double ExpectedNumberOfSale { get; set; }

        [Display(Name = "Expected Revenue")]
        public Double ExpectedRevenue { get; set; }

        [Display(Name = "Currency")]
        [ForeignKey("Currency")]
        public Int32? CurrencyID { get; set; }

        [Display(Name = "Created By User")]
        [ForeignKey("CreatedByUser")]
        public Int32? CreatedByUserID { get; set; }

        [Required(ErrorMessage = "Created Date is required")]
        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required")]
        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "Sales Campaign Status Category is required")]
        [ForeignKey("SalesCampaignStatusCategory")]
        [Display(Name = "Sales Campaign Status")]
        public Int32 SalesCampaignStatusCategoryID { get; set; }

        public virtual SalesCampaign ParentSalesCampaign { get; set; }
        public virtual User CreatedByUser { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual SalesCampaignStatusCategory SalesCampaignStatusCategory { get; set; }
        public virtual SalesProductServiceCatelog SalesProductServiceCatelog { get; set; }
    }
    public class SalesCampaignCompanyContact
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesCampaignContactID { get; set; }

        [Required(ErrorMessage = "Sales Campaign is required")]
        [ForeignKey("SalesCampaign")]
        [Display(Name = "Sales Campaign")]
        public Int32 SalesCampaignID { get; set; }

        [Display(Name = "Company")]
        [ForeignKey("Company")]
        public Int32? CompanyID { get; set; }

        [Display(Name = "Prospective Contact")]
        [ForeignKey("ProspectiveContact")]
        public Int32? ProspectiveContactID { get; set; }
        //under one company may be multiple contacts


        public virtual SalesCampaign SalesCampaign { get; set; }
        public virtual Contact ProspectiveContact { get; set; }
        public virtual Company Company { get; set; }


    }
    public class SalesCampaignDocument
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesCampaignDocumentsD { get; set; }

        [Required(ErrorMessage = "Sales Campaign is required")]
        [ForeignKey("SalesCampaign")]
        [Display(Name = "Sales Campaign")]
        public Int32 SalesCampaignID { get; set; }

        [Display(Name = "Document Title")]
        [StringLength(256)]
        public String DocumentName { get; set; }

        [Required(ErrorMessage = "File Content is required")]
        [Display(Name = "File Content")]
        public Byte[] FileContent { get; set; }

        [Display(Name = "Orginal File Info")]
        [StringLength(256)]
        public String OriginalFileInfo { get; set; }

        [Display(Name = "Upload Date")]
        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }

        public virtual SalesCampaign SalesCampaign { get; set; }


    }
    public class SalesCampaignLocation
    {

        [Required(ErrorMessage = "Sales Campaign Location is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesCampaignLocationID { get; set; }

        [Required(ErrorMessage = "Sales Campaign is required")]
        [ForeignKey("SalesCampaign")]
        [Display(Name = "Sales Campaign")]
        public Int32 SalesCampaignID { get; set; }

        [ForeignKey("Region")]
        public Int32? RegionID { get; set; }

        [ForeignKey("Country")]
        public Int32? CountryID { get; set; }

        [ForeignKey("State")]
        public Int32? StateID { get; set; }

        [ForeignKey("City")]
        public Int32? CityID { get; set; }

        public virtual SalesCampaign SalesCampaign { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual City City { get; set; }
        public virtual Region Region { get; set; }


    }
    public class SalesCampaignNotes
    {

        [Required(ErrorMessage = "Sales Campaign Notes is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesCampaignNotesID { get; set; }

        [Required(ErrorMessage = "Sales Campaign is required")]
        [ForeignKey("SalesCampaign")]
        [Display(Name = "Sales Campaign")]
        public Int32 SalesCampaignID { get; set; }

        [Display(Name = "Written By User")]
        [ForeignKey("WrittenByUser")]
        public Int32 WrittenByUserID { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Notes")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Notes { get; set; }

        public virtual SalesCampaign SalesCampaign { get; set; }
        public virtual User WrittenByUser { get; set; }

    }
    public class SalesCampaignRevenueByProduct
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesCampaignRevenueByProductID { get; set; }

        [Required(ErrorMessage = "Sales Campaign is required")]
        [ForeignKey("SalesCampaign")]
        [Display(Name = "Sales Campaign")]
        public Int32 SalesCampaignID { get; set; }

        [Required(ErrorMessage = "Product And Service is required")]
        [Display(Name = "Select Product And Service")]
        [ForeignKey("SalesProductServiceCatelog")]
        public Int32 SalesProductServiceCatelogID { get; set; }

        [Display(Name = "Expected Number Of Sale")]
        public Int32 ExpectedNumberOfProductSale { get; set; }

        [Display(Name = "Average Price Per Sale")]
        public Double PerItemPrice { get; set; }

        [Display(Name = "Expected Revenue")]
        public Double ExpectedRevenue { get; set; }

        [Display(Name = "Currency")]
        [ForeignKey ("Currency")]
        public Int32? CurrencyID { get; set; }

        [Display(Name = "Actual Number Of Sale")]
        public Double ActualNumberOfSale { get; set; }

        [Display(Name = "Actual Revenue")]
        public Double ActualRevenue { get; set; }

        public virtual SalesCampaign SalesCampaign { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual SalesProductServiceCatelog SalesProductServiceCatelog { get; set; }

    }
    public class SalesCampaignTeam
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesCampaignTeamID { get; set; }

        [Required(ErrorMessage = "Sales Campaign is required")]
        [ForeignKey("SalesCampaign")]
        [Display(Name = "Sales Campaign")]
        public Int32 SalesCampaignID { get; set; }

        [Display(Name = "Sales Campaign Team Member")]
        [ForeignKey("CampaignTeamUser")]
        public Int32 CampaignTeamUserID { get; set; }

        [Required(ErrorMessage = "Added Date is required")]
        [Display(Name = "Added Date")]
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }

        [Required(ErrorMessage = "Is Primary Manager is required")]
        [Display(Name = "Is Primary Manager")]
        public Boolean IsPrimaryManager { get; set; }

        [Display(Name = "Notes")]
        [StringLength(512)]
        public String Notes { get; set; }

        public virtual SalesCampaign SalesCampaign { get; set; }
        public virtual User CampaignTeamUser { get; set; }

    }

  #endregion

  #region SFA - Sales Lead Management

    public class SalesLead
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesLeadID { get; set; }

        [Display(Name = "Created By User")]
        [ForeignKey("CreatedByUser")]
        public Int32 UserID { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Lead Title is required")]
        [Display(Name = "Title")]
        [StringLength(128)]
        public String Title { get; set; }

        [Display(Name = "Lead Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String LeadDescription { get; set; }

        [Display(Name = "Primary Product or Service")]
        [ForeignKey("SalesProductServiceCatelog")]
        public Int32 SalesProductServiceCatelogID { get; set; }

        [Display(Name = "Expected Revenue")]
        public Double ExpectedRevenue { get; set; }

        [Display(Name = "Expected Sale By Date")]
        [DataType(DataType.Date)]
        public DateTime ExpectedSaleByDate { get; set; }

        [Required(ErrorMessage = "Lead Status Category is required")]
        [Display(Name = "Lead Status Category")]
        [ForeignKey("SalesLeadStatusCategory")]
        public Int32 SalesLeadStatusCategoryID { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual SalesLeadStatusCategory SalesLeadStatusCategory { get; set; }
        public virtual SalesProductServiceCatelog SalesProductServiceCatelog { get; set; }



    }
    public class SalesLeadCompany
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesLeadCompanyID { get; set; }

        [Required(ErrorMessage = "Sales Lead is required")]
        [Display(Name = "Sales Lead")]
        [ForeignKey("SalesLead")]
        public Int32 SalesLeadID { get; set; }

        [Required(ErrorMessage = "Company is required")]
        [Display(Name = "Company Name")]
        [ForeignKey("Company")]
        public Int32? CompanyID { get; set; }

        [Required(ErrorMessage = "Contact is required")]
        [Display(Name = "Name Info")]
        [ForeignKey("Contact")]
        public Int32? ContactID { get; set; }

        [Required(ErrorMessage = "Is Primary is required")]
        [Display(Name = "Is Primary")]
        public Boolean IsPrimary { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Company Company { get; set; }
        public virtual SalesLead SalesLead { get; set; }

    }
   
    public class SalesLeadOwnerTeam
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesLeadOwnerTeamID { get; set; }

        [Required(ErrorMessage = "Sales Lead is required")]
        [Display(Name = "Sales Lead")]
        [ForeignKey("SalesLead")]
        public Int32 SalesLeadID { get; set; }

        [Display(Name = "Lead Owner Team Member")]
        [ForeignKey("LeadOwnerUser")]
        public Int32 LeadOwnerUserID { get; set; }

        [Required(ErrorMessage = "Is Primary Lead Owner is required")]
        [Display(Name = "Is Primary Lead Owner")]
        public Boolean IsPrimaryLeadOwner { get; set; }

        public virtual SalesLead SalesLead { get; set; }
        public virtual User LeadOwnerUser { get; set; }

    }
    public class SalesLeadProductService
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesLeadProductServiceID { get; set; }

        [Required(ErrorMessage = "Sales Lead is required")]
        [Display(Name = "Sales Lead")]
        [ForeignKey("SalesLead")]
        public Int32 SalesLeadID { get; set; }

        [Required(ErrorMessage = "Product or Service is required")]
        [Display(Name = "Product or Service")]
        [ForeignKey("SalesProductServiceCatelog")]
        public Int32 SalesProductServiceCatelogID { get; set; }

        [Display(Name = "Expected Number Of Product Sale")]
        public Int32 ExpectedNumberOfProductSale { get; set; }

        [Display(Name = "Per Item Price")]
        public Double PerItemPrice { get; set; }

        [Display(Name = "Expected Number Of Sale")]
        public Int32 ExpectedNumberOfSale { get; set; }

        [Display(Name = "Expected Revenue")]
        public Double ExpectedRevenue { get; set; }

        [Display(Name = "Currency")]
        [ForeignKey("Currency")]
        public Int32? CurrencyID { get; set; }

        [Display(Name = "Actual Number Of Sale")]
        public Double ActualNumberOfSale { get; set; }

        [Display(Name = "Actual Revenue")]
        public Double ActualRevenue { get; set; }

        public virtual SalesLead SalesLead { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual SalesProductServiceCatelog SalesProductServiceCatelog { get; set; }

    }
    public class SalesLeadStatusCategory
    {

        [Required(ErrorMessage = "Lead Status Category is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesLeadStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }


    }

  #endregion

  #region Contact SFS Master Data

    public class SalesProductServiceCategory
    {

        [Required(ErrorMessage = "Product Service Category is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesProductServiceCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }


    }
    public class SalesProductServiceCatelog
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesProductServiceCatelogID { get; set; }

        [Required]
        [Display(Name = "Product And Service Category")]
        [ForeignKey("SalesProductServiceCategory")]
        public Int32 SalesProductServiceCategoryID { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        [StringLength(128)]
        public String Title { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        public virtual SalesProductServiceCategory SalesProductServiceCategory { get; set; }

    }
    public class SalesProductServiceDocument
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesProductServiceDocumentID { get; set; }

        [Display(Name = "Document Title")]
        [ForeignKey("SalesProductServiceCatelog")]
        public Int32 SalesProductServiceCatelogID { get; set; }

        [Display(Name = "Document Title")]
        [StringLength(256)]
        public String DocumentTitle { get; set; }

        [Required(ErrorMessage = "File Content is required")]
        [Display(Name = "File Content")]
        public Byte[] FileContent { get; set; }

        public virtual SalesProductServiceCatelog SalesProductServiceCatelog { get; set; }

    }
    public class CompanyAddressCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CompanyAddressCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class CompanyStatusCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CompanyStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }

    }
    public class SalesCampaignStatusCategory
    {

        [Required(ErrorMessage = "Sales Campaign Status Category is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 SalesCampaignStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }

       
    }

  #endregion 
 }












	