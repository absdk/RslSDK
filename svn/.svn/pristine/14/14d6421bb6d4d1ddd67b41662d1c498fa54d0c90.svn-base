//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  http://www.softwaregrid.com
//
//*********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.BusinessLogic.Helpers;
namespace SoftwareGrid.Areas.ATS.Controllers
{   
    public class ApplicantDisabilitiesController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IDisabilityRepository disabilityRepository;
		private readonly IApplicantDisabilityRepository applicantdisabilityRepository;
        public ApplicantDisabilitiesController(IApplicantRepository applicantRepository, IDisabilityRepository disabilityRepository, IApplicantDisabilityRepository applicantdisabilityRepository)
        {
			this.applicantRepository = applicantRepository;
			this.disabilityRepository = disabilityRepository;
			this.applicantdisabilityRepository = applicantdisabilityRepository;
        }

        //
        // GET: /ApplicantDisabilities/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantdisabilityRepository.AllIncluding(applicantdisability => applicantdisability.Applicant, applicantdisability => applicantdisability.Disability));
        }
		
		public ViewResult Search(ApplicantDisability searchApplicantDisability)
        {
			if(searchApplicantDisability!=null)
			{
							}
						return View("Index",applicantdisabilityRepository.AllIncluding(applicantdisability => applicantdisability.Applicant, applicantdisability => applicantdisability.Disability));
		}

        //
        // GET: /ApplicantDisabilities/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantdisabilityRepository.Find(id));
        }

        //
        // GET: /ApplicantDisabilities/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantDisability applicantdisability = new ApplicantDisability();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleDisabilities = disabilityRepository.All;
            return View(applicantdisability);
        } 

        //
        // POST: /ApplicantDisabilities/Create
        [HttpPost]
        public ActionResult Create(ApplicantDisability applicantdisability)
        {
            if (ModelState.IsValid) {
                applicantdisabilityRepository.InsertOrUpdate(applicantdisability);
                applicantdisabilityRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleDisabilities = disabilityRepository.All;
				return View(applicantdisability);
			}
        }
        
        //
        // GET: /ApplicantDisabilities/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleDisabilities = disabilityRepository.All;
             return View(applicantdisabilityRepository.Find(id));
        }

        //
        // POST: /ApplicantDisabilities/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantDisability applicantdisability)
        {
            if (ModelState.IsValid) {
                applicantdisabilityRepository.InsertOrUpdate(applicantdisability);
                applicantdisabilityRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleDisabilities = disabilityRepository.All;
				return View(applicantdisability);
			}
        }

        //
        // GET: /ApplicantDisabilities/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantdisabilityRepository.Find(id));
        }

        //
        // POST: /ApplicantDisabilities/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantdisabilityRepository.Delete(id);
            applicantdisabilityRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

