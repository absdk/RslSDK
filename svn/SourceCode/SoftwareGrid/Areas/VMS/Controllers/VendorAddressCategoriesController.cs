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
    public class VendorAddressCategoriesController : Controller
    {
		private readonly IVendorAddressCategoryRepository vendoraddresscategoryRepository;
        public VendorAddressCategoriesController(IVendorAddressCategoryRepository vendoraddresscategoryRepository)
        {
			this.vendoraddresscategoryRepository = vendoraddresscategoryRepository;
        }

        //
        // GET: /VendorAddressCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendoraddresscategoryRepository.All);
        }
		
		public ViewResult Search(VendorAddressCategory searchVendorAddressCategory)
        {
			if(searchVendorAddressCategory!=null)
			{
							}
						return View("Index",vendoraddresscategoryRepository.All);
		}

        //
        // GET: /VendorAddressCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendoraddresscategoryRepository.Find(id));
        }

        //
        // GET: /VendorAddressCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			VendorAddressCategory vendoraddresscategory = new VendorAddressCategory();
            return View(vendoraddresscategory);
        } 

        //
        // POST: /VendorAddressCategories/Create
        [HttpPost]
        public ActionResult Create(VendorAddressCategory vendoraddresscategory)
        {
            if (ModelState.IsValid) {
                vendoraddresscategoryRepository.InsertOrUpdate(vendoraddresscategory);
                vendoraddresscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendoraddresscategory);
			}
        }
        
        //
        // GET: /VendorAddressCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(vendoraddresscategoryRepository.Find(id));
        }

        //
        // POST: /VendorAddressCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorAddressCategory vendoraddresscategory)
        {
            if (ModelState.IsValid) {
                vendoraddresscategoryRepository.InsertOrUpdate(vendoraddresscategory);
                vendoraddresscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendoraddresscategory);
			}
        }

        //
        // GET: /VendorAddressCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendoraddresscategoryRepository.Find(id));
        }

        //
        // POST: /VendorAddressCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendoraddresscategoryRepository.Delete(id);
            vendoraddresscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

