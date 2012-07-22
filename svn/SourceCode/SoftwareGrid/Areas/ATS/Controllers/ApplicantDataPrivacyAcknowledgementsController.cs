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
    public class ApplicantDataPrivacyAcknowledgementsController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IApplicantDataPrivacyTemplateRepository applicantdataprivacytemplateRepository;
		private readonly IApplicantDataPrivacyAcknowledgementRepository applicantdataprivacyacknowledgementRepository;
        public ApplicantDataPrivacyAcknowledgementsController(IApplicantRepository applicantRepository, IApplicantDataPrivacyTemplateRepository applicantdataprivacytemplateRepository, IApplicantDataPrivacyAcknowledgementRepository applicantdataprivacyacknowledgementRepository)
        {
			this.applicantRepository = applicantRepository;
			this.applicantdataprivacytemplateRepository = applicantdataprivacytemplateRepository;
			this.applicantdataprivacyacknowledgementRepository = applicantdataprivacyacknowledgementRepository;
        }

        //
        // GET: /ApplicantDataPrivacyAcknowledgements/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantdataprivacyacknowledgementRepository.AllIncluding(applicantdataprivacyacknowledgement => applicantdataprivacyacknowledgement.Applicant, applicantdataprivacyacknowledgement => applicantdataprivacyacknowledgement.ApplicantDataPrivacyTemplate));
        }
		
		public ViewResult Search(ApplicantDataPrivacyAcknowledgement searchApplicantDataPrivacyAcknowledgement)
        {
			if(searchApplicantDataPrivacyAcknowledgement!=null)
			{
							}
						return View("Index",applicantdataprivacyacknowledgementRepository.AllIncluding(applicantdataprivacyacknowledgement => applicantdataprivacyacknowledgement.Applicant, applicantdataprivacyacknowledgement => applicantdataprivacyacknowledgement.ApplicantDataPrivacyTemplate));
		}

        //
        // GET: /ApplicantDataPrivacyAcknowledgements/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantdataprivacyacknowledgementRepository.Find(id));
        }

        //
        // GET: /ApplicantDataPrivacyAcknowledgements/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantDataPrivacyAcknowledgement applicantdataprivacyacknowledgement = new ApplicantDataPrivacyAcknowledgement();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleApplicantDataPrivacyTemplates = applicantdataprivacytemplateRepository.All;
            return View(applicantdataprivacyacknowledgement);
        } 

        //
        // POST: /ApplicantDataPrivacyAcknowledgements/Create
        [HttpPost]
        public ActionResult Create(ApplicantDataPrivacyAcknowledgement applicantdataprivacyacknowledgement)
        {
            if (ModelState.IsValid) {
                applicantdataprivacyacknowledgementRepository.InsertOrUpdate(applicantdataprivacyacknowledgement);
                applicantdataprivacyacknowledgementRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleApplicantDataPrivacyTemplates = applicantdataprivacytemplateRepository.All;
				return View(applicantdataprivacyacknowledgement);
			}
        }
        
        //
        // GET: /ApplicantDataPrivacyAcknowledgements/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleApplicantDataPrivacyTemplates = applicantdataprivacytemplateRepository.All;
             return View(applicantdataprivacyacknowledgementRepository.Find(id));
        }

        //
        // POST: /ApplicantDataPrivacyAcknowledgements/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantDataPrivacyAcknowledgement applicantdataprivacyacknowledgement)
        {
            if (ModelState.IsValid) {
                applicantdataprivacyacknowledgementRepository.InsertOrUpdate(applicantdataprivacyacknowledgement);
                applicantdataprivacyacknowledgementRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleApplicantDataPrivacyTemplates = applicantdataprivacytemplateRepository.All;
				return View(applicantdataprivacyacknowledgement);
			}
        }

        //
        // GET: /ApplicantDataPrivacyAcknowledgements/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantdataprivacyacknowledgementRepository.Find(id));
        }

        //
        // POST: /ApplicantDataPrivacyAcknowledgements/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantdataprivacyacknowledgementRepository.Delete(id);
            applicantdataprivacyacknowledgementRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

