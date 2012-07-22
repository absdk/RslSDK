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
    public class VendorStatusCategoriesController : Controller
    {
		private readonly IVendorStatusCategoryRepository vendorstatuscategoryRepository;
        public VendorStatusCategoriesController(IVendorStatusCategoryRepository vendorstatuscategoryRepository)
        {
			this.vendorstatuscategoryRepository = vendorstatuscategoryRepository;
        }

        //
        // GET: /VendorStatusCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendorstatuscategoryRepository.All);
        }
		
		public ViewResult Search(VendorStatusCategory searchVendorStatusCategory)
        {
			if(searchVendorStatusCategory!=null)
			{
							}
						return View("Index",vendorstatuscategoryRepository.All);
		}

        //
        // GET: /VendorStatusCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendorstatuscategoryRepository.Find(id));
        }

        //
        // GET: /VendorStatusCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			VendorStatusCategory vendorstatuscategory = new VendorStatusCategory();
            return View(vendorstatuscategory);
        } 

        //
        // POST: /VendorStatusCategories/Create
        [HttpPost]
        public ActionResult Create(VendorStatusCategory vendorstatuscategory)
        {
            if (ModelState.IsValid) {
                vendorstatuscategoryRepository.InsertOrUpdate(vendorstatuscategory);
                vendorstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorstatuscategory);
			}
        }
        
        //
        // GET: /VendorStatusCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(vendorstatuscategoryRepository.Find(id));
        }

        //
        // POST: /VendorStatusCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorStatusCategory vendorstatuscategory)
        {
            if (ModelState.IsValid) {
                vendorstatuscategoryRepository.InsertOrUpdate(vendorstatuscategory);
                vendorstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorstatuscategory);
			}
        }

        //
        // GET: /VendorStatusCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendorstatuscategoryRepository.Find(id));
        }

        //
        // POST: /VendorStatusCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendorstatuscategoryRepository.Delete(id);
            vendorstatuscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

