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
    public class VendorSupplierDiversityCertificationCategoriesController : Controller
    {
		private readonly IVendorSupplierDiversityCertificationCategoryRepository vendorsupplierdiversitycertificationcategoryRepository;
        public VendorSupplierDiversityCertificationCategoriesController(IVendorSupplierDiversityCertificationCategoryRepository vendorsupplierdiversitycertificationcategoryRepository)
        {
			this.vendorsupplierdiversitycertificationcategoryRepository = vendorsupplierdiversitycertificationcategoryRepository;
        }

        //
        // GET: /VendorSupplierDiversityCertificationCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendorsupplierdiversitycertificationcategoryRepository.All);
        }
		
		public ViewResult Search(VendorSupplierDiversityCertificationCategory searchVendorSupplierDiversityCertificationCategory)
        {
			if(searchVendorSupplierDiversityCertificationCategory!=null)
			{
							}
						return View("Index",vendorsupplierdiversitycertificationcategoryRepository.All);
		}

        //
        // GET: /VendorSupplierDiversityCertificationCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendorsupplierdiversitycertificationcategoryRepository.Find(id));
        }

        //
        // GET: /VendorSupplierDiversityCertificationCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			VendorSupplierDiversityCertificationCategory vendorsupplierdiversitycertificationcategory = new VendorSupplierDiversityCertificationCategory();
            return View(vendorsupplierdiversitycertificationcategory);
        } 

        //
        // POST: /VendorSupplierDiversityCertificationCategories/Create
        [HttpPost]
        public ActionResult Create(VendorSupplierDiversityCertificationCategory vendorsupplierdiversitycertificationcategory)
        {
            if (ModelState.IsValid) {
                vendorsupplierdiversitycertificationcategoryRepository.InsertOrUpdate(vendorsupplierdiversitycertificationcategory);
                vendorsupplierdiversitycertificationcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorsupplierdiversitycertificationcategory);
			}
        }
        
        //
        // GET: /VendorSupplierDiversityCertificationCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(vendorsupplierdiversitycertificationcategoryRepository.Find(id));
        }

        //
        // POST: /VendorSupplierDiversityCertificationCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorSupplierDiversityCertificationCategory vendorsupplierdiversitycertificationcategory)
        {
            if (ModelState.IsValid) {
                vendorsupplierdiversitycertificationcategoryRepository.InsertOrUpdate(vendorsupplierdiversitycertificationcategory);
                vendorsupplierdiversitycertificationcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(vendorsupplierdiversitycertificationcategory);
			}
        }

        //
        // GET: /VendorSupplierDiversityCertificationCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendorsupplierdiversitycertificationcategoryRepository.Find(id));
        }

        //
        // POST: /VendorSupplierDiversityCertificationCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendorsupplierdiversitycertificationcategoryRepository.Delete(id);
            vendorsupplierdiversitycertificationcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

