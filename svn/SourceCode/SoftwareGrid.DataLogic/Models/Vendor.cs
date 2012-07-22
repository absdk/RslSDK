

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
using System.Web.Mvc;
namespace SoftwareGrid.DataLogic.Models
{
    public class Vendor
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorID { get; set; }

        [Display(Name = "Display ID")]
        [StringLength(64)]
        //[DataType("DataType.DisplayId ")]
        [IncludeInList(Sequence = 1, AllowSearch = true, Width = 5, AllowWidthInPercentage = true)]
        public String VendorDisplayId { get; set; }

        [Required(ErrorMessage = "Vendor Name is required")]
        [Display(Name = "Vendor Name")]
        [StringLength(256)]
        [IncludeInList(Sequence = 2, Width = 20, AllowSearch = true, AllowWidthInPercentage = true, AllowFiltering = true, AllowGrouping = true, AllowSorting = true)]
        public String VendorName { get; set; }

        [Display(Name = "Industry Category")]
        [ForeignKey("Industry")]
        [IncludeInList(Sequence = 3, Width = 20, AllowSearch = true, AllowWidthInPercentage = true, AllowFiltering = true, AllowGrouping = true, AllowSorting = true)]
        public Int32? IndustryID { get; set; }

        [Display(Name = "Vendor Owner Type")]
        [ForeignKey("VendorOwner")]
        public Int32? VendorOwnerID { get; set; }

        [Display(Name = "Vendor Legal Company Structure")]
        [ForeignKey("VendorLegalCompanyStructureCategory")]
        public Int32? VendorLegalCompanyStructureCategoryID { get; set; }

        [Display(Name = "Employee Size")]
        public Int32? EmployeeSize { get; set; }

        [Display(Name = "Tax Identification Number")]
        [StringLength(32)]
        public String TaxNumber { get; set; }

        [Display(Name = "Duns Number")]
        [StringLength(32)]
        public String DunsNumber { get; set; }

        [Display(Name = "Address1")]
        [StringLength(256)]
        public String Address1 { get; set; }

        [Display(Name = "Address2")]
        [StringLength(256)]
        public String Address2 { get; set; }

        [Display(Name = "City")]
        [StringLength(128)]
        [IncludeInList(Sequence = 4, Width = 10, AllowWidthInPercentage = true, AllowSearch = false, AllowFiltering = true, AllowGrouping = true, AllowSorting = true)]
        public String City { get; set; }

        [Display(Name = "Post Box Number")]
        [StringLength(16)]
        public String PostBoxNumber { get; set; }

        [Display(Name = "Country")]
        [ForeignKey("Country")]
        [IncludeInList(Sequence = 6, Width = 10, AllowSearch = true, AllowWidthInPercentage = true, AllowFiltering = true, AllowGrouping = true, AllowSorting = true)]
        public Int32? CountryID { get; set; }

        [Display(Name = "State")]
        [ForeignKey("State")]
        [IncludeInList(Sequence = 5, Width = 10, AllowSearch = true, AllowWidthInPercentage = true, AllowFiltering = true, AllowGrouping = true, AllowSorting = true)]
        public Int32? StateID { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(32)]
        public String ZipCode { get; set; }

        [Display(Name = "Main Office Phone")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String MainOfficePhone { get; set; }

        [Display(Name = "Fax Number")]
        [StringLength(64)]
        public String FaxNumber { get; set; }

        [Display(Name = "Vendor Email Address")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        [IncludeInList(Sequence = 7, Width = 20, AllowWidthInPercentage = true, AllowSearch = false, AllowFiltering = true, AllowGrouping = true, AllowSorting = true)]
        public String VendorEmailAddress { get; set; }

        [Display(Name = "Web Address")]
        [StringLength(256)]
        public String WebAddress { get; set; }

        [Display(Name = "About The Vendor")]
        [MaxLength]
        [DataType(DataType.Html)]
        [AllowHtml]
        public String AboutTheVendor { get; set; }

        [Display(Name = "Logo")]
        public Byte[] Logo { get; set; }

        [Display(Name = "Internal Remarks")]
        [MaxLength]
        public String InternalRemarks { get; set; }

        [Display(Name = "Vendor Status Category")]
        [ForeignKey("VendorStatusCategory")]
        [IncludeInList(Sequence = 8, AllowSearch = true, Width = 10, AllowWidthInPercentage = true, AllowFiltering = true, AllowGrouping = true, AllowSorting = true)]
        public Int32? VendorStatusCategoryID { get; set; }

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

        public virtual Industry Industry { get; set; }
        public virtual CompanyOwner VendorOwner { get; set; }
        public virtual VendorLegalCompanyStructureCategory VendorLegalCompanyStructureCategory { get; set; }

        public virtual State State { get; set; }
        public virtual Country Country { get; set; }
        public virtual VendorStatusCategory VendorStatusCategory { get; set; }
    }
    public class VendorContact
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorContactID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

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
        [IncludeInList(Sequence = 1, IncludeInGrid = true, AllowSearch = false, Width = 25, AllowWidthInPercentage = true)]
        public String FullName { get; set; }

        [Display(Name = "Job Title")]
        [StringLength(256)]
        [IncludeInList(Sequence = 2, IncludeInGrid = true, AllowSearch = false, Width = 25, AllowWidthInPercentage = true)]
        public String JobTitle { get; set; }

        [Display(Name = "Department")]
        [StringLength(256)]
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

        [Display(Name = "Receive Requisition")]
        public Boolean IsReceiveRequisition { get; set; }

        [Display(Name = "Alternative Email")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public String AlternativeEmail { get; set; }

        [Display(Name = "Linkedin Profile Address")]
        [StringLength(256)]
        public String LinkedInProfileAddress { get; set; }

        [Display(Name = "Twitter Address")]
        [StringLength(256)]
        public String TwitterAccountAddress { get; set; }

        [ForeignKey("ContactProfessionType")]
        [Display(Name = "Primary Professional Category")]
        public Int32? ContactProfessionTypeID { get; set; }

        [Display(Name = "Photo")]
        public Byte[] Photo { get; set; }

        [Display(Name = "Internal Remarks")]
        [StringLength(512)]
        public String InternalRemarks { get; set; }

        [Display(Name = "Resume")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Resume { get; set; }

        [Display(Name = "Sequence in Vendor Oganizational Chart")]
        public Double SequenceInVendorOrganizationalChart { get; set; }

        [ForeignKey("EthnicBackground")]
        [Display(Name = "Ethnic Background")]
        public Int32? EthnicBackgroundID { get; set; }

        [ForeignKey("Gender")]
        [Display(Name = "Gender")]
        public Int32? GenderID { get; set; }

        [ForeignKey("VeteranCategory")]
        [Display(Name = "Veternan")]
        public Int32? VeteranCategoryID { get; set; }

        [Display(Name = "Birth Country")]
        [ForeignKey("BirthCountry")]
        public Int32? BirthCountryID { get; set; }

        [Display(Name = "Nationality")]
        [ForeignKey("NationalityCountry")]
        public Int32? NationlityCountryID { get; set; }

        [Display(Name = "Is Owner of The Company")]
        public Boolean? IsCompanyOwner { get; set; }

        [Display(Name = "Company Ownership Percentage")]
        [DataType("Percent")]
        public Double? CompanyOwnershipPercentage { get; set; }

        [Display(Name = "Created By")]
        [ForeignKey("CreatedByUser")]
        public Int32 CreatedByUserID { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Is Verified")]
        [DataType("Verified")]
        public Boolean? IsVerified { get; set; }

        [Display(Name = "Verified By")]
        [ForeignKey("VerifiedByUser")]
        public Int32? VerifiedByUserID { get; set; }

        [Display(Name = "Verification Date")]
        [DataType(DataType.Date)]
        public DateTime? VerificationDate { get; set; }

        public virtual User CreatedByUser { get; set; }
        public virtual User VerifiedByUser { get; set; }

        public virtual State State { get; set; }
        public virtual Country Country { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual ContactProfessionType ContactProfessionType { get; set; }
        public virtual Country NationalityCountry { get; set; }
        public virtual Country BirthCountry { get; set; }
        public virtual VeteranCategory VeteranCategory { get; set; }
        public virtual EthnicBackground EthnicBackground { get; set; }
        public virtual Gender Gender { get; set; }

    }

    public class VendorAddress
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorAddressID { get; set; }

        [Required]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required(ErrorMessage = "Address Category is required")]
        [ForeignKey("VendorAddressCategory")]
        [Display(Name = "Address Category")]
        [IncludeInList(Sequence = 1, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32? VendorAddressCategoryID { get; set; }

        [Required(ErrorMessage = "Address Line1 is required")]
        [Display(Name = "Address Line1")]
        [StringLength(256)]
        public String AddressLine1 { get; set; }

        [Display(Name = "Address Line2")]
        [StringLength(256)]
        public String AddressLine2 { get; set; }

        [Display(Name = "Post Office Box Number")]
        public Double PostBoxNumber { get; set; }

        [Required(ErrorMessage = "City Name is required")]
        [Display(Name = "City Name")]
        [StringLength(128)]
        [IncludeInList(Sequence = 2, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String CityName { get; set; }

        [ForeignKey("Country")]
        [Display(Name = "Country")]
        [IncludeInList(Sequence = 4, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32? CountryID { get; set; }

        [ForeignKey("State")]
        [Display(Name = "State")]
        [IncludeInList(Sequence = 3, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32? StateID { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(16)]
        public String ZipCode { get; set; }

        [Display(Name = "Home Phone")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        public String HomePhone { get; set; }

        [Display(Name = "Mobile Phone")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        [IncludeInList(Sequence = 5, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String MobilePhone { get; set; }

        [Display(Name = "Personal Email")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        [IncludeInList(Sequence = 6, IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String PersonalEmail { get; set; }

        [Display(Name = "Is Bulk Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        public Boolean IsBulkEmail { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual VendorAddressCategory VendorAddressCategory { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }

    }

    public class VendorFinancialData
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorFinancialDataID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required(ErrorMessage = "Financial Year is required")]
        [Display(Name = "Financial Year")]
        [IncludeInList(Sequence = 1, IncludeInGrid = true, AllowSearch = false, Width = 25, AllowWidthInPercentage = true)]
        public Int32 FinancialYear { get; set; }

        [Display(Name = "Revenue Amount")]
        [IncludeInList(Sequence = 2, IncludeInGrid = true, AllowSearch = false, Width = 25, AllowWidthInPercentage = true)]
        public Double RevenueAmount { get; set; }

        [Display(Name = "Net Profit")]
        [IncludeInList(Sequence = 3, IncludeInGrid = true, AllowSearch = false, Width = 25, AllowWidthInPercentage = true)]
        public Double NetProfit { get; set; }

        [Required(ErrorMessage = "Currency is required")]
        [Display(Name = "Currency")]
        [IncludeInList(Sequence = 4, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32? CurrencyID { get; set; }

        [Display(Name = "Is Verified")]
        public Boolean IsVerified { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual Currency Currency { get; set; }

    }

    public class VendorInsurance
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorInsuranceID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required(ErrorMessage = "Vendor Insurance Category is required")]
        [Display(Name = "Insurance Category")]
        [ForeignKey("VendorInsuranceCategory")]
        [IncludeInList(Sequence = 1, DisplayName = "Category", IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32 VendorInsuranceCategoryID { get; set; }

        [Required(ErrorMessage = "Insurance Provider Company Name is required")]
        [Display(Name = "Provider Company Name")]
        [StringLength(256)]
        [IncludeInList(Sequence = 2, DisplayName = "Provider Name", IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String InsuranceProviderCompanyName { get; set; }

        [Display(Name = "Provider Phone Number")]
        [StringLength(128)]
        [IncludeInList(Sequence = 3, DisplayName = "Provider Phone", IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String InsuranceProviderPhoneName { get; set; }

        [Required(ErrorMessage = "Insurance Number is required")]
        [Display(Name = "Insurance Number")]
        [StringLength(128)]
        [IncludeInList(Sequence = 4, IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String InsuranceNumber { get; set; }

        [Required(ErrorMessage = "Certificate Issue Date is required")]
        [Display(Name = "Certificate Issue Date")]
        [DataType(DataType.Date)]
        [IncludeInList(Sequence = 5, DisplayName = "Issue Date", IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public DateTime CertificateIssueDate { get; set; }

        [Required(ErrorMessage = "Certification Expire Date is required")]
        [Display(Name = "Certification Expire Date")]
        [DataType(DataType.Date)]
        [IncludeInList(Sequence = 6, DisplayName = "Expire Date", IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public DateTime CertificationExpireDate { get; set; }

        [Display(Name = "Insurance Coverage Information")]
        [StringLength(512)]
        public String InsuranceCoverageInformation { get; set; }


        [Display(Name = "Is Verified")]
        public Boolean IsVerified { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual VendorInsuranceCategory VendorInsuranceCategory { get; set; }

    }

    public class VendorServiceCapabilityRating
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorServiceCapabilityRatingID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Display(Name = "Select Service")]
        [ForeignKey("VendorServiceCategory")]
        [IncludeInList(Sequence = 1, DisplayName = "Category", IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Int32 VendorServiceCategoryID { get; set; }

        [Display(Name = "Descriptions")]
        [StringLength(512)]
        public String Description { get; set; }

        [Display(Name = "Internal Rating")]
        [ForeignKey("VendorServiceRatingScale")]
        [DataType("Rating")]
        [IncludeInList(Sequence = 2, DisplayName = "Rating", IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public Int32? VendorServiceRatingScaleID { get; set; }

        [Display(Name = "Rating Remarks")]
        [StringLength(512)]
        [IncludeInList(Sequence = 3, DisplayName = "Remarks", IncludeInGrid = true, AllowSearch = false, Width = 60, AllowWidthInPercentage = true)]
        public String RatingRemarks { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual VendorServiceCategory VendorServiceCategory { get; set; }
        public virtual RatingScale VendorServiceRatingScale { get; set; }

    }

    public class VendorReference
    {
        [Required(ErrorMessage = "Vendor Reference is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorReferenceID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required(ErrorMessage = "Company Name is required")]
        [Display(Name = "Reference Company Name")]
        [StringLength(256)]
        [IncludeInList(Sequence = 1, DisplayName = "Company Name", IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String CompanyName { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Contact First Name")]
        [StringLength(128)]
        [IncludeInList(Sequence = 2, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Conatct Last Name")]
        [StringLength(128)]
        [IncludeInList(Sequence = 3, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String LastName { get; set; }

        [Display(Name = "Job Title")]
        [StringLength(256)]
        [IncludeInList(Sequence = 4, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String JobTitle { get; set; }

        [Display(Name = "Phone")]
        [StringLength(64)]
        [DataType(DataType.PhoneNumber)]
        [IncludeInList(Sequence = 5, IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public String Phone { get; set; }

        [Display(Name = "Email")]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email address is not valid")]
        [IncludeInList(Sequence = 6, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String Email { get; set; }

        [Display(Name = "Reference Service Info")]
        [MaxLength]
        public String ReferenceServiceInfo { get; set; }

        [Display(Name = "Is Verified")]
        public Boolean IsVerified { get; set; }

        [Display(Name = "Verification Notes")]
        [StringLength(512)]
        public String VerificationNotes { get; set; }

        public virtual Vendor Vendor { get; set; }

    }

    public class VendorSupplierDiversityCertificateInfo
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorSupplierDiversityCertificateInfoID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required]
        [Display(Name = "Select Supplier Diversity Certification")]
        [ForeignKey("VendorSupplierDiversityCertificationCategory")]
        [IncludeInList(Sequence = 1, DisplayName = "Category", IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32 VendorSupplierDiversityCertificationCategoryID { get; set; }

        [Display(Name = "Certificate Title")]
        [StringLength(256)]
        [IncludeInList(Sequence = 2, IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String Title { get; set; }

        [Display(Name = "Certificate Issue Date")]
        [DataType(DataType.DateTime)]
        [IncludeInList(Sequence = 4, DisplayName = "Issue Date", IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public DateTime CertificateIssueDate { get; set; }

        [Display(Name = "Certification Expire Date")]
        [DataType(DataType.DateTime)]
        [IncludeInList(Sequence = 5, DisplayName = "Expire Date", IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public DateTime CertificationExpireDate { get; set; }

        [Display(Name = "Issue City")]
        [StringLength(128)]
        [IncludeInList(Sequence = 6, IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public String IssueCity { get; set; }

        [ForeignKey("Country")]
        [Display(Name = "Country")]
        [IncludeInList(Sequence = 7, IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public Int32? CountryID { get; set; }

        [ForeignKey("State")]
        [Display(Name = "State")]
        public Int32? StateID { get; set; }

        [Display(Name = "Certificate Number")]
        [StringLength(64)]
        [IncludeInList(Sequence = 3, IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public String CertificateNumber { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }

        [Display(Name = "Is Verified")]
        public Boolean IsVerified { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual VendorSupplierDiversityCertificationCategory VendorSupplierDiversityCertificationCategory { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }

    }

    public class VendorAccountManager
    {
        [Required(ErrorMessage = "Vendor Account Manager is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorAccountManagerID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required(ErrorMessage = "Vendor Manager is required")]
        [Display(Name = "Vendor Manager")]
        [ForeignKey("VendorManagerUser")]
        [IncludeInList(Sequence = 1, DisplayName = "Manager Name", IncludeInGrid = true, AllowSearch = false, Width = 80, AllowWidthInPercentage = true)]
        public Int32 VendorManagerUserID { get; set; }

        [Display(Name = "Is Primary Manager")]
        [IncludeInList(Sequence = 2, IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public Boolean IsPrimaryManager { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual User VendorManagerUser { get; set; }

    }

    public class VendorNote
    {

        [Required(ErrorMessage = "Vendor Notes is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorNoteID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required(ErrorMessage = "Vendor Note Category is required")]
        [Display(Name = "Vendor Note Category")]
        [ForeignKey("VendorNoteCategory")]
        [IncludeInList(Sequence = 1, DisplayName = "Category", IncludeInGrid = true, AllowSearch = false, Width = 15, AllowWidthInPercentage = true)]
        public Int32? VendorNoteCategoryID { get; set; }

        [Required(ErrorMessage = "Written By User is required")]
        [Display(Name = "Written By User")]
        [ForeignKey("User")]
        [IncludeInList(Sequence = 2, DisplayName = "Written By", IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Int32 WrittenByUserID { get; set; }

        [Display(Name = "Date Time")]
        [DataType(DataType.Date)]
        [IncludeInList(Sequence = 3, DisplayName = "Written On", IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Notes is required")]
        [Display(Name = "Notes")]
        [MaxLength]
        [DataType(DataType.Html)]
        [IncludeInList(Sequence = 4, IncludeInGrid = true, AllowSearch = false, Width = 45, AllowWidthInPercentage = true)]
        public String Notes { get; set; }

        public virtual User User { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual VendorNoteCategory VendorNoteCategory { get; set; }

    }
    //vednor email
    public class VendorRating
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorRatingID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required(ErrorMessage = "Vendor Rate Category is required")]
        [Display(Name = "Vendor Rate Category")]
        [ForeignKey("VendorRatingScale")]
        [DataType("RatingScale")]
        [IncludeInList(Sequence = 3, DisplayName = "Rating", IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public Int32 VendorRatingScaleID { get; set; }

        [Required(ErrorMessage = "Written By User is required")]
        [Display(Name = "Rated By")]
        [ForeignKey("User")]
        [IncludeInList(Sequence = 1, IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Int32 RatedByUserID { get; set; }

        [Display(Name = "Rating Date Time")]
        [DataType(DataType.Date)]
        [IncludeInList(Sequence = 2, DisplayName = "Rated On", IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public DateTime RatingDateTime { get; set; }

        [Display(Name = "Raing Notes")]
        [MaxLength]
        [IncludeInList(Sequence = 4, DisplayName = "Notes", IncludeInGrid = true, AllowSearch = false, Width = 50, AllowWidthInPercentage = true)]
        public String Notes { get; set; }

        public virtual User User { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual RatingScale VendorRatingScale { get; set; }

    }

    public class VendorDocument
    {

        [Required(ErrorMessage = "Vendor Document is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorDocumentID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required(ErrorMessage = "Vendor Document Category is required")]
        [Display(Name = "Vendor Document Category")]
        [ForeignKey("VendorDocumentCategory")]
        [IncludeInList(Sequence = 1, DisplayName = "Document Category", IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public Int32? VendorDocumentCategoryID { get; set; }

        [Required(ErrorMessage = "Document Title is required")]
        [Display(Name = "Document Title")]
        [StringLength(128)]
        [IncludeInList(Sequence = 2, IncludeInGrid = true, AllowSearch = false, Width = 40, AllowWidthInPercentage = true)]
        public String DocumentTitle { get; set; }

        [Required(ErrorMessage = "File Content is required")]
        [Display(Name = "File Content")]
        public Byte[] FileContent { get; set; }

        [Display(Name = "File Name")]
        [StringLength(256)]
        [IncludeInList(Sequence = 3, IncludeInGrid = true, AllowSearch = false, Width = 20, AllowWidthInPercentage = true)]
        public String FileName { get; set; }

        [Display(Name = "Upload Date")]
        [DataType(DataType.Date)]
        [IncludeInList(Sequence = 4, IncludeInGrid = true, AllowSearch = false, Width = 10, AllowWidthInPercentage = true)]
        public DateTime UploadDate { get; set; }

        public virtual VendorDocumentCategory VendorDocumentCategory { get; set; }
        public virtual Vendor Vendor { get; set; }

    }

    public class VendorDocumentTracking
    {
        [Required(ErrorMessage = "Vendor Document Tracking is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorDocumentTrackingID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        [Required(ErrorMessage = "Vendor Document Category is required")]
        [Display(Name = "Vendor Document Category")]
        [ForeignKey("VendorDocumentCategory")]
        public Int32? VendorDocumentCategoryID { get; set; }

        [Display(Name = "Instruction")]
        [StringLength(512)]
        public String Instruction { get; set; }

        [Required(ErrorMessage = "Is Mandatory is required")]
        [Display(Name = "Is Mandatory")]
        public Boolean IsMandatory { get; set; }

        [Display(Name = "Is Original Required")]
        public Boolean IsOriginalRequired { get; set; }

        [Display(Name = "Is Received")]
        public Boolean IsReceived { get; set; }

        [Display(Name = "Receive Date")]
        [DataType(DataType.Date)]
        public DateTime ReceiveDate { get; set; }

        [Display(Name = "Is Verified")]
        public Boolean IsVerified { get; set; }

        [Required(ErrorMessage = "Applicant Document Status Category is required")]
        [Display(Name = "Vendor Document Status Category")]
        [ForeignKey("VendorDocumentStatusCategory")]
        public Int32? VendorDocumentStatusCategoryID { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual VendorDocumentCategory VendorDocumentCategory { get; set; }
        public virtual VendorDocumentStatusCategory VendorDocumentStatusCategory { get; set; }
    }

    public class VendorGroup
    {
        [Required(ErrorMessage = "Vendor Group Editor is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorGroupID { get; set; }

        [Required(ErrorMessage = "Vendor Group Name is required")]
        [Display(Name = "Vendor Group Name")]
        [StringLength(128)]
        public String VendorGroupName { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Display(Name = "Group Grade")]
        [StringLength(64)]
        public String GroupGrade { get; set; }
    }

    public class VendorGroupSelectedVendor
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorGroupSelectedVendorID { get; set; }

        [Required(ErrorMessage = "Vendor Group is required")]
        [Display(Name = "Vendor Group ")]
        [ForeignKey("VendorGroup")]
        public Int32 VendorGroupID { get; set; }

        [Display(Name = "Vendor Id")]
        [ForeignKey("Vendor")]
        public Int32 VendorID { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual VendorGroup VendorGroup { get; set; }
    }

    #region vendor master data
    public class VendorStatusCategory
    {

        [Required(ErrorMessage = "Vendor Status Category is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }


    }
    public class VendorServiceCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorServiceCategoryID { get; set; }

        [Display(Name = "Organization Service Code")]
        [StringLength(256)]
        public String OrganizationServiceCode { get; set; }

        [Display(Name = "NACIS Code")]
        [StringLength(256)]
        public String NACISCode { get; set; }

        [Display(Name = "Expense Code")]
        [StringLength(256)]
        public String ExpenseCode { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class VendorNoteCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorNoteCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class VendorLegalCompanyStructureCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorLegalCompanyStructureCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }
    public class VendorSupplierDiversityCertificationCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorSupplierDiversityCertificationCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }


    }
    public class VendorInsuranceCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorInsuranceCategoryID { get; set; }

        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }



    }
    public class VendorDocumentCategory
    {

        [Required(ErrorMessage = "Vendor Document Category is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorDocumentCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }




    }
    public class VendorDocumentStatusCategory
    {

        [Required(ErrorMessage = "Applicant Document Status Category is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorDocumentStatusCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }




    }
    public class VendorAddressCategory
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorAddressCategoryID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(128)]
        public String Name { get; set; }

    }

    public class VendorEmailTemplate
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorEmailTemplateID { get; set; }

        [Display(Name = "Template Created By")]
        [ForeignKey("TemplateCreatedByUser")]
        public Int32 TemplateCreatedByUserID { get; set; }

        [Display(Name = "Template Title")]
        [StringLength(256)]
        public String TemplateTitle { get; set; }

        [Display(Name = "Subject")]
        [StringLength(512)]
        public String EmailSubject { get; set; }

        [Display(Name = "Email Message")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String EmailMessage { get; set; }

        public virtual User TemplateCreatedByUser { get; set; }

    }

    #endregion

    //if organization staffing rate not inlcuded, use these classess.
    public class VendorStaffingRateCard
    {

        [Required(ErrorMessage = "Rate Card is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorStaffingRateCardID { get; set; }

        [Required(ErrorMessage = "Rate Card Title is required")]
        [Display(Name = "Rate Card Title")]
        [StringLength(256)]
        public String RateCardTitle { get; set; }

        [Display(Name = "Description")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Description { get; set; }

        [Required(ErrorMessage = "Start Date is required")]
        [Display(Name = "Start Date")]
        [DataType(DataType.DateTime)]

        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End Date is required")]
        [Display(Name = "End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }


    }
    public class VendorStaffingRateCardDetail
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorStaffingRateCardDetailID { get; set; }

        [Required(ErrorMessage = "Rate Card is required")]
        [ForeignKey("VendorStaffingRateCard")]
        [Display(Name = "Select Staffing Rate Card")]
        public Int32 VendorStaffingRateCardID { get; set; }

        [Required(ErrorMessage = "Organization is required")]
        [Display(Name = "Organization")]
        [ForeignKey("Organization")]
        public Int32 OrganizationID { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [Display(Name = "Department")]
        [ForeignKey("OrganizationDepartment")]
        public Int32 OrganizationDepartmentID { get; set; }

        [Required(ErrorMessage = "Position is required")]
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

        public virtual Organization Organization { get; set; }
        public virtual VendorStaffingRateCard VendorStaffingRateCard { get; set; }
        public virtual OrganizationDepartment OrganizationDepartment { get; set; }
        public virtual OrganizationPosition OrganizationPosition { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual SalaryRateType SalaryRateType { get; set; }

    }
    public class VendorRateCardHotSkillWiseVariation
    {

        [Required(ErrorMessage = "Rate Card Hot Skill Wise Variation is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorRateCardHotSkillWiseVariationID { get; set; }

        [Required(ErrorMessage = "Rate Card is required")]
        [ForeignKey("VendorRateCard")]
        [Display(Name = "Rate Card")]
        public Int32 VendorRateCardID { get; set; }

        [Required(ErrorMessage = "SkillsExpEdu is required")]
        [Display(Name = "SkillsExpEdu or Hot Skill")]
        [ForeignKey("SkillsExpEdu")]
        public Int32 SkillsExpEduID { get; set; }

        [Required(ErrorMessage = "Variation Amount is required")]
        [Display(Name = "Variation Percentage or Amount")]
        public Double VariationAmount { get; set; }

        [Display(Name = "Rate Remarks")]
        [StringLength(128)]
        public String RateRemarks { get; set; }

        public virtual VendorStaffingRateCard VendorStaffingRateCard { get; set; }
        public virtual SkillsExpEdu SkillsExpEdu { get; set; }
    }
    public class VendorRateCardLocationWiseVariation
    {

        [Required(ErrorMessage = "Rate Card Location Wise Variation is required")]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 VendorRateCardLocationWiseVariationID { get; set; }

        [Required(ErrorMessage = "Rate Card is required")]
        [ForeignKey("VendorRateCard")]
        [Display(Name = "Rate Card")]
        public Int32 VendorRateCardID { get; set; }

        [Display(Name = "Country")]
        [ForeignKey("Country")]
        public Int32 CountryID { get; set; }

        [Display(Name = "State")]
        [ForeignKey("State")]
        public Int32 StateID { get; set; }

        [Required(ErrorMessage = "City is required")]
        [Display(Name = "City")]
        [StringLength(128)]
        public String City { get; set; }

        [Required(ErrorMessage = "Variation Amount is required")]
        [Display(Name = "Variation Percentage or Amount")]
        public Double VariationAmount { get; set; }

        [Display(Name = "Rate Remarks")]
        [StringLength(128)]
        public String RateRemarks { get; set; }

        public virtual VendorStaffingRateCard VendorStaffingRateCard { get; set; }
        public virtual State State { get; set; }
        public virtual Country Country { get; set; }

    }
}
	