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
    public class ApplicantSecurityClearancesController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly ISecurityClearanceRepository securityclearanceRepository;
		private readonly IApplicantSecurityClearanceRepository applicantsecurityclearanceRepository;
        public ApplicantSecurityClearancesController(IApplicantRepository applicantRepository, ISecurityClearanceRepository securityclearanceRepository, IApplicantSecurityClearanceRepository applicantsecurityclearanceRepository)
        {
			this.applicantRepository = applicantRepository;
			this.securityclearanceRepository = securityclearanceRepository;
			this.applicantsecurityclearanceRepository = applicantsecurityclearanceRepository;
        }

        //
        // GET: /ApplicantSecurityClearances/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantsecurityclearanceRepository.AllIncluding(applicantsecurityclearance => applicantsecurityclearance.Applicant, applicantsecurityclearance => applicantsecurityclearance.SecurityClearance));
        }
		
		public ViewResult Search(ApplicantSecurityClearance searchApplicantSecurityClearance)
        {
			if(searchApplicantSecurityClearance!=null)
			{
							}
						return View("Index",applicantsecurityclearanceRepository.AllIncluding(applicantsecurityclearance => applicantsecurityclearance.Applicant, applicantsecurityclearance => applicantsecurityclearance.SecurityClearance));
		}

        //
        // GET: /ApplicantSecurityClearances/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantsecurityclearanceRepository.Find(id));
        }

        //
        // GET: /ApplicantSecurityClearances/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantSecurityClearance applicantsecurityclearance = new ApplicantSecurityClearance();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleSecurityClearances = securityclearanceRepository.All;
            return View(applicantsecurityclearance);
        } 

        //
        // POST: /ApplicantSecurityClearances/Create
        [HttpPost]
        public ActionResult Create(ApplicantSecurityClearance applicantsecurityclearance)
        {
            if (ModelState.IsValid) {
                applicantsecurityclearanceRepository.InsertOrUpdate(applicantsecurityclearance);
                applicantsecurityclearanceRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleSecurityClearances = securityclearanceRepository.All;
				return View(applicantsecurityclearance);
			}
        }
        
        //
        // GET: /ApplicantSecurityClearances/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleSecurityClearances = securityclearanceRepository.All;
             return View(applicantsecurityclearanceRepository.Find(id));
        }

        //
        // POST: /ApplicantSecurityClearances/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantSecurityClearance applicantsecurityclearance)
        {
            if (ModelState.IsValid) {
                applicantsecurityclearanceRepository.InsertOrUpdate(applicantsecurityclearance);
                applicantsecurityclearanceRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleSecurityClearances = securityclearanceRepository.All;
				return View(applicantsecurityclearance);
			}
        }

        //
        // GET: /ApplicantSecurityClearances/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantsecurityclearanceRepository.Find(id));
        }

        //
        // POST: /ApplicantSecurityClearances/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantsecurityclearanceRepository.Delete(id);
            applicantsecurityclearanceRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

