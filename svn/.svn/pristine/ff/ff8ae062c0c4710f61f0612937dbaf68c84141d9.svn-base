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
    public class VendorInsuranceCategoriesController : Controller
    {
		private readonly IVendorInsuranceCategoryRepository vendorinsurancecategoryRepository;
        public VendorInsuranceCategoriesController(IVendorInsuranceCategoryRepository vendorinsurancecategoryRepository)
        {
			this.vendorinsurancecategoryRepository = vendorinsurancecategoryRepository;
        }

        //
        // GET: /VendorInsuranceCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendorinsurancecategoryRepository.All);
        }
		
		public ViewResult Search(VendorInsuranceCategory searchVendorInsuranceCategory)
        {
			if(searchVendorInsuranceCategory!=null)
			{
							}
						return View("Index",vendorinsurancecategoryRepository.All);
		}

        //
        // GET: /VendorInsuranceCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendorinsurancecategoryRepository.Find(id));
        }

        //
        // GET: /VendorInsuranceCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			VendorInsuranceCategory vendorinsurancecategory = new VendorInsuranceCategory();
            return View(vendorinsurancecategory);
        } 

        //
        // POST: /VendorInsuranceCategories/Create
        [HttpPost]
        public ActionResult Create(VendorInsuranceCategory vendorinsurancecategory)
        {
            if (ModelState.IsValid) {
                vendorinsurancecategoryRepository.InsertOrUpdate(vendorinsurancecategory);
                vendorinsurancecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorinsurancecategory);
			}
        }
        
        //
        // GET: /VendorInsuranceCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(vendorinsurancecategoryRepository.Find(id));
        }

        //
        // POST: /VendorInsuranceCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorInsuranceCategory vendorinsurancecategory)
        {
            if (ModelState.IsValid) {
                vendorinsurancecategoryRepository.InsertOrUpdate(vendorinsurancecategory);
                vendorinsurancecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorinsurancecategory);
			}
        }

        //
        // GET: /VendorInsuranceCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendorinsurancecategoryRepository.Find(id));
        }

        //
        // POST: /VendorInsuranceCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendorinsurancecategoryRepository.Delete(id);
            vendorinsurancecategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

