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
    public class ApplicantInterviewFeedbackCategoriesController : Controller
    {
		private readonly IApplicantInterviewFeedbackCategoryRepository applicantinterviewfeedbackcategoryRepository;
        public ApplicantInterviewFeedbackCategoriesController(IApplicantInterviewFeedbackCategoryRepository applicantinterviewfeedbackcategoryRepository)
        {
			this.applicantinterviewfeedbackcategoryRepository = applicantinterviewfeedbackcategoryRepository;
        }

        //
        // GET: /ApplicantInterviewFeedbackCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantinterviewfeedbackcategoryRepository.All);
        }
		
		public ViewResult Search(ApplicantInterviewFeedbackCategory searchApplicantInterviewFeedbackCategory)
        {
			if(searchApplicantInterviewFeedbackCategory!=null)
			{
							}
						return View("Index",applicantinterviewfeedbackcategoryRepository.All);
		}

        //
        // GET: /ApplicantInterviewFeedbackCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantinterviewfeedbackcategoryRepository.Find(id));
        }

        //
        // GET: /ApplicantInterviewFeedbackCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantInterviewFeedbackCategory applicantinterviewfeedbackcategory = new ApplicantInterviewFeedbackCategory();
            return View(applicantinterviewfeedbackcategory);
        } 

        //
        // POST: /ApplicantInterviewFeedbackCategories/Create
        [HttpPost]
        public ActionResult Create(ApplicantInterviewFeedbackCategory applicantinterviewfeedbackcategory)
        {
            if (ModelState.IsValid) {
                applicantinterviewfeedbackcategoryRepository.InsertOrUpdate(applicantinterviewfeedbackcategory);
                applicantinterviewfeedbackcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantinterviewfeedbackcategory);
			}
        }
        
        //
        // GET: /ApplicantInterviewFeedbackCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(applicantinterviewfeedbackcategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantInterviewFeedbackCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantInterviewFeedbackCategory applicantinterviewfeedbackcategory)
        {
            if (ModelState.IsValid) {
                applicantinterviewfeedbackcategoryRepository.InsertOrUpdate(applicantinterviewfeedbackcategory);
                applicantinterviewfeedbackcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantinterviewfeedbackcategory);
			}
        }

        //
        // GET: /ApplicantInterviewFeedbackCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantinterviewfeedbackcategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantInterviewFeedbackCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantinterviewfeedbackcategoryRepository.Delete(id);
            applicantinterviewfeedbackcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

