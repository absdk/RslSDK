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
    public class SalesProductServiceCatelogsController : Controller
    {
		private readonly ISalesProductServiceCategoryRepository salesproductservicecategoryRepository;
		private readonly ISalesProductServiceCatelogRepository salesproductservicecatelogRepository;
        public SalesProductServiceCatelogsController(ISalesProductServiceCategoryRepository salesproductservicecategoryRepository, ISalesProductServiceCatelogRepository salesproductservicecatelogRepository)
        {
			this.salesproductservicecategoryRepository = salesproductservicecategoryRepository;
			this.salesproductservicecatelogRepository = salesproductservicecatelogRepository;
        }

        //
        // GET: /SalesProductServiceCatelogs/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(salesproductservicecatelogRepository.AllIncluding(salesproductservicecatelog => salesproductservicecatelog.SalesProductServiceCategory));
        }
		
		public ViewResult Search(SalesProductServiceCatelog searchSalesProductServiceCatelog)
        {
			if(searchSalesProductServiceCatelog!=null)
			{
							}
						return View("Index",salesproductservicecatelogRepository.AllIncluding(salesproductservicecatelog => salesproductservicecatelog.SalesProductServiceCategory));
		}

        //
        // GET: /SalesProductServiceCatelogs/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(salesproductservicecatelogRepository.Find(id));
        }

        //
        // GET: /SalesProductServiceCatelogs/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			SalesProductServiceCatelog salesproductservicecatelog = new SalesProductServiceCatelog();
			ViewBag.PossibleSalesProductServiceCategories = salesproductservicecategoryRepository.All;
            return View(salesproductservicecatelog);
        } 

        //
        // POST: /SalesProductServiceCatelogs/Create
        [HttpPost]
        public ActionResult Create(SalesProductServiceCatelog salesproductservicecatelog)
        {
            if (ModelState.IsValid) {
                salesproductservicecatelogRepository.InsertOrUpdate(salesproductservicecatelog);
                salesproductservicecatelogRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSalesProductServiceCategories = salesproductservicecategoryRepository.All;
				return View(salesproductservicecatelog);
			}
        }
        
        //
        // GET: /SalesProductServiceCatelogs/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleSalesProductServiceCategories = salesproductservicecategoryRepository.All;
             return View(salesproductservicecatelogRepository.Find(id));
        }

        //
        // POST: /SalesProductServiceCatelogs/Edit/5
        [HttpPost]
        public ActionResult Edit(SalesProductServiceCatelog salesproductservicecatelog)
        {
            if (ModelState.IsValid) {
                salesproductservicecatelogRepository.InsertOrUpdate(salesproductservicecatelog);
                salesproductservicecatelogRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSalesProductServiceCategories = salesproductservicecategoryRepository.All;
				return View(salesproductservicecatelog);
			}
        }

        //
        // GET: /SalesProductServiceCatelogs/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(salesproductservicecatelogRepository.Find(id));
        }

        //
        // POST: /SalesProductServiceCatelogs/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            salesproductservicecatelogRepository.Delete(id);
            salesproductservicecatelogRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

