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
    public class SalesProductServiceCategoriesController : Controller
    {
		private readonly ISalesProductServiceCategoryRepository salesproductservicecategoryRepository;
        public SalesProductServiceCategoriesController(ISalesProductServiceCategoryRepository salesproductservicecategoryRepository)
        {
			this.salesproductservicecategoryRepository = salesproductservicecategoryRepository;
        }

        //
        // GET: /SalesProductServiceCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(salesproductservicecategoryRepository.All);
        }
		
		public ViewResult Search(SalesProductServiceCategory searchSalesProductServiceCategory)
        {
			if(searchSalesProductServiceCategory!=null)
			{
							}
						return View("Index",salesproductservicecategoryRepository.All);
		}

        //
        // GET: /SalesProductServiceCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(salesproductservicecategoryRepository.Find(id));
        }

        //
        // GET: /SalesProductServiceCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			SalesProductServiceCategory salesproductservicecategory = new SalesProductServiceCategory();
            return View(salesproductservicecategory);
        } 

        //
        // POST: /SalesProductServiceCategories/Create
        [HttpPost]
        public ActionResult Create(SalesProductServiceCategory salesproductservicecategory)
        {
            if (ModelState.IsValid) {
                salesproductservicecategoryRepository.InsertOrUpdate(salesproductservicecategory);
                salesproductservicecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(salesproductservicecategory);
			}
        }
        
        //
        // GET: /SalesProductServiceCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(salesproductservicecategoryRepository.Find(id));
        }

        //
        // POST: /SalesProductServiceCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(SalesProductServiceCategory salesproductservicecategory)
        {
            if (ModelState.IsValid) {
                salesproductservicecategoryRepository.InsertOrUpdate(salesproductservicecategory);
                salesproductservicecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(salesproductservicecategory);
			}
        }

        //
        // GET: /SalesProductServiceCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(salesproductservicecategoryRepository.Find(id));
        }

        //
        // POST: /SalesProductServiceCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            salesproductservicecategoryRepository.Delete(id);
            salesproductservicecategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

