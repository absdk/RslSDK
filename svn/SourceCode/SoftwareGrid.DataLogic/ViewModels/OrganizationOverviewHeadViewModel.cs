using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoftwareGrid.DataLogic.ViewModels
{
    public class OrganizationOverviewHeadViewModel
    {
        public Int32 OrganizationID { get; set; }
        public String ParentOrganizationName { get; set; }
        public String Name { get; set; }
        public String OrganizationCategoryName { get; set; }
        public String OrganizationCodeNumber { get; set; }
        public String LegalBusinessName { get; set; }

        public Int32? NumberOfBusinessDivisions { get; set; }
        public Int32? NumberOfDepartments { get; set; }
        public Int32? NumberOfPositions { get; set; }
        public Int32? NumberOfProjects { get; set; }
        public Int32? NumberOfEmployees { get; set; }
    }
}
