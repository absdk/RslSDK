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
    public class VendorDocumentStatusCategoriesController : Controller
    {
		private readonly IVendorDocumentStatusCategoryRepository vendordocumentstatuscategoryRepository;
        public VendorDocumentStatusCategoriesController(IVendorDocumentStatusCategoryRepository vendordocumentstatuscategoryRepository)
        {
			this.vendordocumentstatuscategoryRepository = vendordocumentstatuscategoryRepository;
        }

        //
        // GET: /VendorDocumentStatusCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendordocumentstatuscategoryRepository.All);
        }
		
		public ViewResult Search(VendorDocumentStatusCategory searchVendorDocumentStatusCategory)
        {
			if(searchVendorDocumentStatusCategory!=null)
			{
							}
						return View("Index",vendordocumentstatuscategoryRepository.All);
		}

        //
        // GET: /VendorDocumentStatusCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendordocumentstatuscategoryRepository.Find(id));
        }

        //
        // GET: /VendorDocumentStatusCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			VendorDocumentStatusCategory vendordocumentstatuscategory = new VendorDocumentStatusCategory();
            return View(vendordocumentstatuscategory);
        } 

        //
        // POST: /VendorDocumentStatusCategories/Create
        [HttpPost]
        public ActionResult Create(VendorDocumentStatusCategory vendordocumentstatuscategory)
        {
            if (ModelState.IsValid) {
                vendordocumentstatuscategoryRepository.InsertOrUpdate(vendordocumentstatuscategory);
                vendordocumentstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendordocumentstatuscategory);
			}
        }
        
        //
        // GET: /VendorDocumentStatusCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(vendordocumentstatuscategoryRepository.Find(id));
        }

        //
        // POST: /VendorDocumentStatusCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorDocumentStatusCategory vendordocumentstatuscategory)
        {
            if (ModelState.IsValid) {
                vendordocumentstatuscategoryRepository.InsertOrUpdate(vendordocumentstatuscategory);
                vendordocumentstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendordocumentstatuscategory);
			}
        }

        //
        // GET: /VendorDocumentStatusCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendordocumentstatuscategoryRepository.Find(id));
        }

        //
        // POST: /VendorDocumentStatusCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendordocumentstatuscategoryRepository.Delete(id);
            vendordocumentstatuscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

