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
    public class ApplicantAvailabilityStatusCategoriesController : Controller
    {
		private readonly IApplicantAvailabilityStatusCategoryRepository applicantavailabilitystatuscategoryRepository;
        public ApplicantAvailabilityStatusCategoriesController(IApplicantAvailabilityStatusCategoryRepository applicantavailabilitystatuscategoryRepository)
        {
			this.applicantavailabilitystatuscategoryRepository = applicantavailabilitystatuscategoryRepository;
        }

        //
        // GET: /ApplicantAvailabilityStatusCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantavailabilitystatuscategoryRepository.All);
        }
		
		public ViewResult Search(ApplicantAvailabilityStatusCategory searchApplicantAvailabilityStatusCategory)
        {
			if(searchApplicantAvailabilityStatusCategory!=null)
			{
							}
						return View("Index",applicantavailabilitystatuscategoryRepository.All);
		}

        //
        // GET: /ApplicantAvailabilityStatusCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantavailabilitystatuscategoryRepository.Find(id));
        }

        //
        // GET: /ApplicantAvailabilityStatusCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantAvailabilityStatusCategory applicantavailabilitystatuscategory = new ApplicantAvailabilityStatusCategory();
            return View(applicantavailabilitystatuscategory);
        } 

        //
        // POST: /ApplicantAvailabilityStatusCategories/Create
        [HttpPost]
        public ActionResult Create(ApplicantAvailabilityStatusCategory applicantavailabilitystatuscategory)
        {
            if (ModelState.IsValid) {
                applicantavailabilitystatuscategoryRepository.InsertOrUpdate(applicantavailabilitystatuscategory);
                applicantavailabilitystatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantavailabilitystatuscategory);
			}
        }
        
        //
        // GET: /ApplicantAvailabilityStatusCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(applicantavailabilitystatuscategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantAvailabilityStatusCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantAvailabilityStatusCategory applicantavailabilitystatuscategory)
        {
            if (ModelState.IsValid) {
                applicantavailabilitystatuscategoryRepository.InsertOrUpdate(applicantavailabilitystatuscategory);
                applicantavailabilitystatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantavailabilitystatuscategory);
			}
        }

        //
        // GET: /ApplicantAvailabilityStatusCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantavailabilitystatuscategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantAvailabilityStatusCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantavailabilitystatuscategoryRepository.Delete(id);
            applicantavailabilitystatuscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

