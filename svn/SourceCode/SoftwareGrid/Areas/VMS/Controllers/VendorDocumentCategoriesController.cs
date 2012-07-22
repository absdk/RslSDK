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
    public class VendorDocumentCategoriesController : Controller
    {
		private readonly IVendorDocumentCategoryRepository vendordocumentcategoryRepository;
        public VendorDocumentCategoriesController(IVendorDocumentCategoryRepository vendordocumentcategoryRepository)
        {
			this.vendordocumentcategoryRepository = vendordocumentcategoryRepository;
        }

        //
        // GET: /VendorDocumentCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendordocumentcategoryRepository.All);
        }
		
		public ViewResult Search(VendorDocumentCategory searchVendorDocumentCategory)
        {
			if(searchVendorDocumentCategory!=null)
			{
							}
						return View("Index",vendordocumentcategoryRepository.All);
		}

        //
        // GET: /VendorDocumentCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendordocumentcategoryRepository.Find(id));
        }

        //
        // GET: /VendorDocumentCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			VendorDocumentCategory vendordocumentcategory = new VendorDocumentCategory();
            return View(vendordocumentcategory);
        } 

        //
        // POST: /VendorDocumentCategories/Create
        [HttpPost]
        public ActionResult Create(VendorDocumentCategory vendordocumentcategory)
        {
            if (ModelState.IsValid) {
                vendordocumentcategoryRepository.InsertOrUpdate(vendordocumentcategory);
                vendordocumentcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendordocumentcategory);
			}
        }
        
        //
        // GET: /VendorDocumentCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(vendordocumentcategoryRepository.Find(id));
        }

        //
        // POST: /VendorDocumentCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorDocumentCategory vendordocumentcategory)
        {
            if (ModelState.IsValid) {
                vendordocumentcategoryRepository.InsertOrUpdate(vendordocumentcategory);
                vendordocumentcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendordocumentcategory);
			}
        }

        //
        // GET: /VendorDocumentCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendordocumentcategoryRepository.Find(id));
        }

        //
        // POST: /VendorDocumentCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendordocumentcategoryRepository.Delete(id);
            vendordocumentcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

