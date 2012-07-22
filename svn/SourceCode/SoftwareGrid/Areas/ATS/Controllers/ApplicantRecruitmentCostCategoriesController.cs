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
    public class ApplicantRecruitmentCostCategoriesController : Controller
    {
		private readonly IApplicantRecruitmentCostCategoryRepository applicantrecruitmentcostcategoryRepository;
        public ApplicantRecruitmentCostCategoriesController(IApplicantRecruitmentCostCategoryRepository applicantrecruitmentcostcategoryRepository)
        {
			this.applicantrecruitmentcostcategoryRepository = applicantrecruitmentcostcategoryRepository;
        }

        //
        // GET: /ApplicantRecruitmentCostCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantrecruitmentcostcategoryRepository.All);
        }
		
		public ViewResult Search(ApplicantRecruitmentCostCategory searchApplicantRecruitmentCostCategory)
        {
			if(searchApplicantRecruitmentCostCategory!=null)
			{
							}
						return View("Index",applicantrecruitmentcostcategoryRepository.All);
		}

        //
        // GET: /ApplicantRecruitmentCostCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantrecruitmentcostcategoryRepository.Find(id));
        }

        //
        // GET: /ApplicantRecruitmentCostCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantRecruitmentCostCategory applicantrecruitmentcostcategory = new ApplicantRecruitmentCostCategory();
            return View(applicantrecruitmentcostcategory);
        } 

        //
        // POST: /ApplicantRecruitmentCostCategories/Create
        [HttpPost]
        public ActionResult Create(ApplicantRecruitmentCostCategory applicantrecruitmentcostcategory)
        {
            if (ModelState.IsValid) {
                applicantrecruitmentcostcategoryRepository.InsertOrUpdate(applicantrecruitmentcostcategory);
                applicantrecruitmentcostcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantrecruitmentcostcategory);
			}
        }
        
        //
        // GET: /ApplicantRecruitmentCostCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(applicantrecruitmentcostcategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantRecruitmentCostCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantRecruitmentCostCategory applicantrecruitmentcostcategory)
        {
            if (ModelState.IsValid) {
                applicantrecruitmentcostcategoryRepository.InsertOrUpdate(applicantrecruitmentcostcategory);
                applicantrecruitmentcostcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantrecruitmentcostcategory);
			}
        }

        //
        // GET: /ApplicantRecruitmentCostCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantrecruitmentcostcategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantRecruitmentCostCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantrecruitmentcostcategoryRepository.Delete(id);
            applicantrecruitmentcostcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

