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
namespace SoftwareGrid.Areas.VMS.Controllers
{   
    public class VendorLegalCompanyStructureCategoriesController : Controller
    {
		private readonly IVendorLegalCompanyStructureCategoryRepository vendorlegalcompanystructurecategoryRepository;
        public VendorLegalCompanyStructureCategoriesController(IVendorLegalCompanyStructureCategoryRepository vendorlegalcompanystructurecategoryRepository)
        {
			this.vendorlegalcompanystructurecategoryRepository = vendorlegalcompanystructurecategoryRepository;
        }

        //
        // GET: /VendorLegalCompanyStructureCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendorlegalcompanystructurecategoryRepository.All);
        }
		
		public ViewResult Search(VendorLegalCompanyStructureCategory searchVendorLegalCompanyStructureCategory)
        {
			if(searchVendorLegalCompanyStructureCategory!=null)
			{
							}
						return View("Index",vendorlegalcompanystructurecategoryRepository.All);
		}

        //
        // GET: /VendorLegalCompanyStructureCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendorlegalcompanystructurecategoryRepository.Find(id));
        }

        //
        // GET: /VendorLegalCompanyStructureCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			VendorLegalCompanyStructureCategory vendorlegalcompanystructurecategory = new VendorLegalCompanyStructureCategory();
            return View(vendorlegalcompanystructurecategory);
        } 

        //
        // POST: /VendorLegalCompanyStructureCategories/Create
        [HttpPost]
        public ActionResult Create(VendorLegalCompanyStructureCategory vendorlegalcompanystructurecategory)
        {
            if (ModelState.IsValid) {
                vendorlegalcompanystructurecategoryRepository.InsertOrUpdate(vendorlegalcompanystructurecategory);
                vendorlegalcompanystructurecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorlegalcompanystructurecategory);
			}
        }
        
        //
        // GET: /VendorLegalCompanyStructureCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(vendorlegalcompanystructurecategoryRepository.Find(id));
        }

        //
        // POST: /VendorLegalCompanyStructureCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorLegalCompanyStructureCategory vendorlegalcompanystructurecategory)
        {
            if (ModelState.IsValid) {
                vendorlegalcompanystructurecategoryRepository.InsertOrUpdate(vendorlegalcompanystructurecategory);
                vendorlegalcompanystructurecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorlegalcompanystructurecategory);
			}
        }

        //
        // GET: /VendorLegalCompanyStructureCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendorlegalcompanystructurecategoryRepository.Find(id));
        }

        //
        // POST: /VendorLegalCompanyStructureCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendorlegalcompanystructurecategoryRepository.Delete(id);
            vendorlegalcompanystructurecategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

