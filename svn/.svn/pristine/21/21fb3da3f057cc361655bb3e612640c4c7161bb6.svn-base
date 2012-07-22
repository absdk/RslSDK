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
    public class ApplicantDocumentTrackingsController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IApplicantDocumentCategoryRepository applicantdocumentcategoryRepository;
		private readonly IApplicantDocumentRepository applicantdocumentRepository;
		private readonly IUserRepository userRepository;
		private readonly IApplicantDocumentStatusCategoryRepository applicantdocumentstatuscategoryRepository;
		private readonly IApplicantDocumentTrackingRepository applicantdocumenttrackingRepository;
        public ApplicantDocumentTrackingsController(IApplicantRepository applicantRepository, IApplicantDocumentCategoryRepository applicantdocumentcategoryRepository, IApplicantDocumentRepository applicantdocumentRepository, IUserRepository userRepository, IApplicantDocumentStatusCategoryRepository applicantdocumentstatuscategoryRepository, IApplicantDocumentTrackingRepository applicantdocumenttrackingRepository)
        {
			this.applicantRepository = applicantRepository;
			this.applicantdocumentcategoryRepository = applicantdocumentcategoryRepository;
			this.applicantdocumentRepository = applicantdocumentRepository;
			this.userRepository = userRepository;
			this.applicantdocumentstatuscategoryRepository = applicantdocumentstatuscategoryRepository;
			this.applicantdocumenttrackingRepository = applicantdocumenttrackingRepository;
        }

        //
        // GET: /ApplicantDocumentTrackings/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantdocumenttrackingRepository.AllIncluding(applicantdocumenttracking => applicantdocumenttracking.Applicant, applicantdocumenttracking => applicantdocumenttracking.ApplicantDocumentCategory, applicantdocumenttracking => applicantdocumenttracking.ApplicantDocument, applicantdocumenttracking => applicantdocumenttracking.VerifiedByUser, applicantdocumenttracking => applicantdocumenttracking.ApplicantDocumentStatusCategory));
        }
		
		public ViewResult Search(ApplicantDocumentTracking searchApplicantDocumentTracking)
        {
			if(searchApplicantDocumentTracking!=null)
			{
							}
						return View("Index",applicantdocumenttrackingRepository.AllIncluding(applicantdocumenttracking => applicantdocumenttracking.Applicant, applicantdocumenttracking => applicantdocumenttracking.ApplicantDocumentCategory, applicantdocumenttracking => applicantdocumenttracking.ApplicantDocument, applicantdocumenttracking => applicantdocumenttracking.VerifiedByUser, applicantdocumenttracking => applicantdocumenttracking.ApplicantDocumentStatusCategory));
		}

        //
        // GET: /ApplicantDocumentTrackings/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantdocumenttrackingRepository.Find(id));
        }

        //
        // GET: /ApplicantDocumentTrackings/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantDocumentTracking applicantdocumenttracking = new ApplicantDocumentTracking();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleApplicantDocumentCategories = applicantdocumentcategoryRepository.All;
			ViewBag.PossibleApplicantDocuments = applicantdocumentRepository.All;
			ViewBag.PossibleVerifiedByUsers = userRepository.All;
			ViewBag.PossibleApplicantDocumentStatusCategories = applicantdocumentstatuscategoryRepository.All;
            return View(applicantdocumenttracking);
        } 

        //
        // POST: /ApplicantDocumentTrackings/Create
        [HttpPost]
        public ActionResult Create(ApplicantDocumentTracking applicantdocumenttracking)
        {
            if (ModelState.IsValid) {
                applicantdocumenttrackingRepository.InsertOrUpdate(applicantdocumenttracking);
                applicantdocumenttrackingRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleApplicantDocumentCategories = applicantdocumentcategoryRepository.All;
				ViewBag.PossibleApplicantDocuments = applicantdocumentRepository.All;
				ViewBag.PossibleVerifiedByUsers = userRepository.All;
				ViewBag.PossibleApplicantDocumentStatusCategories = applicantdocumentstatuscategoryRepository.All;
				return View(applicantdocumenttracking);
			}
        }
        
        //
        // GET: /ApplicantDocumentTrackings/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleApplicantDocumentCategories = applicantdocumentcategoryRepository.All;
			ViewBag.PossibleApplicantDocuments = applicantdocumentRepository.All;
			ViewBag.PossibleVerifiedByUsers = userRepository.All;
			ViewBag.PossibleApplicantDocumentStatusCategories = applicantdocumentstatuscategoryRepository.All;
             return View(applicantdocumenttrackingRepository.Find(id));
        }

        //
        // POST: /ApplicantDocumentTrackings/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantDocumentTracking applicantdocumenttracking)
        {
            if (ModelState.IsValid) {
                applicantdocumenttrackingRepository.InsertOrUpdate(applicantdocumenttracking);
                applicantdocumenttrackingRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleApplicantDocumentCategories = applicantdocumentcategoryRepository.All;
				ViewBag.PossibleApplicantDocuments = applicantdocumentRepository.All;
				ViewBag.PossibleVerifiedByUsers = userRepository.All;
				ViewBag.PossibleApplicantDocumentStatusCategories = applicantdocumentstatuscategoryRepository.All;
				return View(applicantdocumenttracking);
			}
        }

        //
        // GET: /ApplicantDocumentTrackings/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantdocumenttrackingRepository.Find(id));
        }

        //
        // POST: /ApplicantDocumentTrackings/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantdocumenttrackingRepository.Delete(id);
            applicantdocumenttrackingRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

