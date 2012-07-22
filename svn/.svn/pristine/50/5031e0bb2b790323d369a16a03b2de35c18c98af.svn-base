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
    public class ApplicantSubmissionFeedbackCategoriesController : Controller
    {
		private readonly IApplicantSubmissionFeedbackCategoryRepository applicantsubmissionfeedbackcategoryRepository;
        public ApplicantSubmissionFeedbackCategoriesController(IApplicantSubmissionFeedbackCategoryRepository applicantsubmissionfeedbackcategoryRepository)
        {
			this.applicantsubmissionfeedbackcategoryRepository = applicantsubmissionfeedbackcategoryRepository;
        }

        //
        // GET: /ApplicantSubmissionFeedbackCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantsubmissionfeedbackcategoryRepository.All);
        }
		
		public ViewResult Search(ApplicantSubmissionFeedbackCategory searchApplicantSubmissionFeedbackCategory)
        {
			if(searchApplicantSubmissionFeedbackCategory!=null)
			{
							}
						return View("Index",applicantsubmissionfeedbackcategoryRepository.All);
		}

        //
        // GET: /ApplicantSubmissionFeedbackCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantsubmissionfeedbackcategoryRepository.Find(id));
        }

        //
        // GET: /ApplicantSubmissionFeedbackCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantSubmissionFeedbackCategory applicantsubmissionfeedbackcategory = new ApplicantSubmissionFeedbackCategory();
            return View(applicantsubmissionfeedbackcategory);
        } 

        //
        // POST: /ApplicantSubmissionFeedbackCategories/Create
        [HttpPost]
        public ActionResult Create(ApplicantSubmissionFeedbackCategory applicantsubmissionfeedbackcategory)
        {
            if (ModelState.IsValid) {
                applicantsubmissionfeedbackcategoryRepository.InsertOrUpdate(applicantsubmissionfeedbackcategory);
                applicantsubmissionfeedbackcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantsubmissionfeedbackcategory);
			}
        }
        
        //
        // GET: /ApplicantSubmissionFeedbackCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(applicantsubmissionfeedbackcategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantSubmissionFeedbackCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantSubmissionFeedbackCategory applicantsubmissionfeedbackcategory)
        {
            if (ModelState.IsValid) {
                applicantsubmissionfeedbackcategoryRepository.InsertOrUpdate(applicantsubmissionfeedbackcategory);
                applicantsubmissionfeedbackcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantsubmissionfeedbackcategory);
			}
        }

        //
        // GET: /ApplicantSubmissionFeedbackCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantsubmissionfeedbackcategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantSubmissionFeedbackCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantsubmissionfeedbackcategoryRepository.Delete(id);
            applicantsubmissionfeedbackcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

