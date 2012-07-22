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
    public class VendorServiceCategoriesController : Controller
    {
		private readonly IVendorServiceCategoryRepository vendorservicecategoryRepository;
        public VendorServiceCategoriesController(IVendorServiceCategoryRepository vendorservicecategoryRepository)
        {
			this.vendorservicecategoryRepository = vendorservicecategoryRepository;
        }

        //
        // GET: /VendorServiceCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendorservicecategoryRepository.All);
        }
		
		public ViewResult Search(VendorServiceCategory searchVendorServiceCategory)
        {
			if(searchVendorServiceCategory!=null)
			{
							}
						return View("Index",vendorservicecategoryRepository.All);
		}

        //
        // GET: /VendorServiceCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendorservicecategoryRepository.Find(id));
        }

        //
        // GET: /VendorServiceCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			VendorServiceCategory vendorservicecategory = new VendorServiceCategory();
            return View(vendorservicecategory);
        } 

        //
        // POST: /VendorServiceCategories/Create
        [HttpPost]
        public ActionResult Create(VendorServiceCategory vendorservicecategory)
        {
            if (ModelState.IsValid) {
                vendorservicecategoryRepository.InsertOrUpdate(vendorservicecategory);
                vendorservicecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorservicecategory);
			}
        }
        
        //
        // GET: /VendorServiceCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(vendorservicecategoryRepository.Find(id));
        }

        //
        // POST: /VendorServiceCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorServiceCategory vendorservicecategory)
        {
            if (ModelState.IsValid) {
                vendorservicecategoryRepository.InsertOrUpdate(vendorservicecategory);
                vendorservicecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorservicecategory);
			}
        }

        //
        // GET: /VendorServiceCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendorservicecategoryRepository.Find(id));
        }

        //
        // POST: /VendorServiceCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendorservicecategoryRepository.Delete(id);
            vendorservicecategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

