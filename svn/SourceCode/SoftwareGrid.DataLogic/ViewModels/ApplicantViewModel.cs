using System;
using System.Collections.Generic;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.DataLogic.ViewModels
{
    public class ApplicantViewModel
    {
        public Applicant Applicant { get;set; }

        public ApplicantViewModel()
        {
            Applicant = new Applicant();
        }
    }
}
