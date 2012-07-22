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
namespace SoftwareGrid.Areas.CRM.Controllers
{   
    public class CompanyStatusCategoriesController : Controller
    {
		private readonly ICompanyStatusCategoryRepository companystatuscategoryRepository;
        public CompanyStatusCategoriesController(ICompanyStatusCategoryRepository companystatuscategoryRepository)
        {
			this.companystatuscategoryRepository = companystatuscategoryRepository;
        }

        //
        // GET: /CompanyStatusCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(companystatuscategoryRepository.All);
        }
		
		public ViewResult Search(CompanyStatusCategory searchCompanyStatusCategory)
        {
			if(searchCompanyStatusCategory!=null)
			{
							}
						return View("Index",companystatuscategoryRepository.All);
		}

        //
        // GET: /CompanyStatusCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(companystatuscategoryRepository.Find(id));
        }

        //
        // GET: /CompanyStatusCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			CompanyStatusCategory companystatuscategory = new CompanyStatusCategory();
            return View(companystatuscategory);
        } 

        //
        // POST: /CompanyStatusCategories/Create
        [HttpPost]
        public ActionResult Create(CompanyStatusCategory companystatuscategory)
        {
            if (ModelState.IsValid) {
                companystatuscategoryRepository.InsertOrUpdate(companystatuscategory);
                companystatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(companystatuscategory);
			}
        }
        
        //
        // GET: /CompanyStatusCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(companystatuscategoryRepository.Find(id));
        }

        //
        // POST: /CompanyStatusCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(CompanyStatusCategory companystatuscategory)
        {
            if (ModelState.IsValid) {
                companystatuscategoryRepository.InsertOrUpdate(companystatuscategory);
                companystatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(companystatuscategory);
			}
        }

        //
        // GET: /CompanyStatusCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(companystatuscategoryRepository.Find(id));
        }

        //
        // POST: /CompanyStatusCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            companystatuscategoryRepository.Delete(id);
            companystatuscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

