using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoftwareGrid.DataLogic.ViewModels;
using SoftwareGrid.BusinessLogic.Repositories;

namespace SoftwareGrid.Areas.ATS.Controllers
{
    public class ApplicantSearchController : Controller
    {
        private readonly IApplicantRepository applicantRepository;
        public ApplicantSearchController(IApplicantRepository applicantRepository)
        {
			this.applicantRepository = applicantRepository;
        }

        //
        // GET: /ATS/ApplicantSearch/

        public ActionResult Search(ApplicantSearchViewModel applicantSearchViewModel)
        {
            var result = applicantRepository.SearchApplicants(applicantSearchViewModel);
            return View(result);
        }
    }
}
