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
    public class CompanyAddressCategoriesController : Controller
    {
		private readonly ICompanyAddressCategoryRepository companyaddresscategoryRepository;
        public CompanyAddressCategoriesController(ICompanyAddressCategoryRepository companyaddresscategoryRepository)
        {
			this.companyaddresscategoryRepository = companyaddresscategoryRepository;
        }

        //
        // GET: /CompanyAddressCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(companyaddresscategoryRepository.All);
        }
		
		public ViewResult Search(CompanyAddressCategory searchCompanyAddressCategory)
        {
			if(searchCompanyAddressCategory!=null)
			{
							}
						return View("Index",companyaddresscategoryRepository.All);
		}

        //
        // GET: /CompanyAddressCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(companyaddresscategoryRepository.Find(id));
        }

        //
        // GET: /CompanyAddressCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			CompanyAddressCategory companyaddresscategory = new CompanyAddressCategory();
            return View(companyaddresscategory);
        } 

        //
        // POST: /CompanyAddressCategories/Create
        [HttpPost]
        public ActionResult Create(CompanyAddressCategory companyaddresscategory)
        {
            if (ModelState.IsValid) {
                companyaddresscategoryRepository.InsertOrUpdate(companyaddresscategory);
                companyaddresscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(companyaddresscategory);
			}
        }
        
        //
        // GET: /CompanyAddressCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(companyaddresscategoryRepository.Find(id));
        }

        //
        // POST: /CompanyAddressCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(CompanyAddressCategory companyaddresscategory)
        {
            if (ModelState.IsValid) {
                companyaddresscategoryRepository.InsertOrUpdate(companyaddresscategory);
                companyaddresscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(companyaddresscategory);
			}
        }

        //
        // GET: /CompanyAddressCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(companyaddresscategoryRepository.Find(id));
        }

        //
        // POST: /CompanyAddressCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            companyaddresscategoryRepository.Delete(id);
            companyaddresscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

