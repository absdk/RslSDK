using System;
using System.Collections.Generic;
using SoftwareGrid.DataLogic.Models;
using System.ComponentModel.DataAnnotations;
using SoftwareGrid.DataLogic.Attributes;

namespace SoftwareGrid.DataLogic.ViewModels
{
    public class ApplicantSearchViewModel    
    {

        
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 ApplicantSearchID { get; set; }
        
        //public Applicant Applicant { get; set; }
        //public ApplicantAdditionalInfo ApplicantAdditionalInfo { get; set; }
        
        public String Name { get; set; }
        public String ApplicantDisplayId { get; set; }
        public String ResumeKeyword { get; set; }
        public String ZipCode { get; set; }
        public String JobTitle { get; set; }

        public String ZipCodeDistanceRadius { get; set; }   //distance from zipcode, 5 - 10-15-20-30-50-100 miles, samething sera

        public String SearchAddressLatitude { get; set; }
        public String SearchAddressLongitude { get; set; }  //wont show in form, these will enable rdiaus search

        public String City { get; set; }
        public Int32 StateID { get; set; }
        public Int32 CountryID { get; set; }
        public String Email { get; set; }
       
        public DateTime ResumeLastUpdate { get; set; } //

        public String EmployerName { get; set; }
        public Int32 ExperienceLevelCategoryID { get; set; }
        public Int32 SkillsExpertiseID { get; set; }
        public Int32 EducationCerificationLicenseID { get; set; }
        public Boolean VerifiedResume { get; set; }

        public Int32 NationalityID { get; set; }
        public Int32 GenderID { get; set; }
        public Int32 VeteranCategoryID { get; set; }
        public Int32 ApplicantSourceCategoryID { get; set; }
        public Int32 ApplicantAvailabilityStatusCategoryID { get; set; }
        public Int32 EmploymentTypeID { get; set; }

        public String LinkedInProfileAddress { get; set; }
        public String TwitterAddress { get; set; }
        public String GooglePlusAddress { get; set; }


        public ApplicantSearchViewModel()
        {
            ApplicantSearchViewModel ApplicantSearch = new ApplicantSearchViewModel();
        }

        public List<Applicant> SearchApplicant(ApplicantSearchViewModel SearchVM)
        {
            List<Applicant> ResultApplicant = new List<Applicant>();

            try
            {
                
            }
            catch (Exception)
            {
                
                throw;
            }


            return ResultApplicant;

        }

    }
}
