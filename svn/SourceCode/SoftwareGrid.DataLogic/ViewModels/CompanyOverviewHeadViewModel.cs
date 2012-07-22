using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SoftwareGrid.DataLogic.ViewModels
{
    public class CompanyOverviewHeadViewModel
    {
        public Int32 CompanyID { get; set; }
        public String CompanyName { get; set; }
        public String CompanyDisplayId { get; set; }
        public String IndustryName { get; set; }
        public String Address { get; set; }
        public String WebAddress { get; set; }
        public String Location { get; set; }
        public String CompanyEmailAddress { get; set; }
        public String MainOfficePhone { get; set; }
        public String FaxNumber { get; set; }
        [DataType("Rating")]
        public Int32? CompanyRatingScaleIDForHeader { get; set; }
        public String CompanyStatusCategoryName { get; set; }
        public Int32? EmployeeSize { get; set; }
    }
}
