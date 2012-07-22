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
    public class VendorNoteCategoriesController : Controller
    {
		private readonly IVendorNoteCategoryRepository vendornotecategoryRepository;
        public VendorNoteCategoriesController(IVendorNoteCategoryRepository vendornotecategoryRepository)
        {
			this.vendornotecategoryRepository = vendornotecategoryRepository;
        }

        //
        // GET: /VendorNoteCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendornotecategoryRepository.All);
        }
		
		public ViewResult Search(VendorNoteCategory searchVendorNoteCategory)
        {
			if(searchVendorNoteCategory!=null)
			{
							}
						return View("Index",vendornotecategoryRepository.All);
		}

        //
        // GET: /VendorNoteCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendornotecategoryRepository.Find(id));
        }

        //
        // GET: /VendorNoteCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			VendorNoteCategory vendornotecategory = new VendorNoteCategory();
            return View(vendornotecategory);
        } 

        //
        // POST: /VendorNoteCategories/Create
        [HttpPost]
        public ActionResult Create(VendorNoteCategory vendornotecategory)
        {
            if (ModelState.IsValid) {
                vendornotecategoryRepository.InsertOrUpdate(vendornotecategory);
                vendornotecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendornotecategory);
			}
        }
        
        //
        // GET: /VendorNoteCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(vendornotecategoryRepository.Find(id));
        }

        //
        // POST: /VendorNoteCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorNoteCategory vendornotecategory)
        {
            if (ModelState.IsValid) {
                vendornotecategoryRepository.InsertOrUpdate(vendornotecategory);
                vendornotecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendornotecategory);
			}
        }

        //
        // GET: /VendorNoteCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendornotecategoryRepository.Find(id));
        }

        //
        // POST: /VendorNoteCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendornotecategoryRepository.Delete(id);
            vendornotecategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

