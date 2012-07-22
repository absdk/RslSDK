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
    public class SalesProductServiceDocumentsController : Controller
    {
		private readonly ISalesProductServiceCatelogRepository salesproductservicecatelogRepository;
		private readonly ISalesProductServiceDocumentRepository salesproductservicedocumentRepository;
        public SalesProductServiceDocumentsController(ISalesProductServiceCatelogRepository salesproductservicecatelogRepository, ISalesProductServiceDocumentRepository salesproductservicedocumentRepository)
        {
			this.salesproductservicecatelogRepository = salesproductservicecatelogRepository;
			this.salesproductservicedocumentRepository = salesproductservicedocumentRepository;
        }

        //
        // GET: /SalesProductServiceDocuments/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(salesproductservicedocumentRepository.AllIncluding(salesproductservicedocument => salesproductservicedocument.SalesProductServiceCatelog));
        }
		
		public ViewResult Search(SalesProductServiceDocument searchSalesProductServiceDocument)
        {
			if(searchSalesProductServiceDocument!=null)
			{
							}
						return View("Index",salesproductservicedocumentRepository.AllIncluding(salesproductservicedocument => salesproductservicedocument.SalesProductServiceCatelog));
		}

        //
        // GET: /SalesProductServiceDocuments/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(salesproductservicedocumentRepository.Find(id));
        }

        //
        // GET: /SalesProductServiceDocuments/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			SalesProductServiceDocument salesproductservicedocument = new SalesProductServiceDocument();
			ViewBag.PossibleSalesProductServiceCatelogs = salesproductservicecatelogRepository.All;
            return View(salesproductservicedocument);
        } 

        //
        // POST: /SalesProductServiceDocuments/Create
        [HttpPost]
        public ActionResult Create(SalesProductServiceDocument salesproductservicedocument)
        {
            if (ModelState.IsValid) {
                salesproductservicedocumentRepository.InsertOrUpdate(salesproductservicedocument);
                salesproductservicedocumentRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSalesProductServiceCatelogs = salesproductservicecatelogRepository.All;
				return View(salesproductservicedocument);
			}
        }
        
        //
        // GET: /SalesProductServiceDocuments/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleSalesProductServiceCatelogs = salesproductservicecatelogRepository.All;
             return View(salesproductservicedocumentRepository.Find(id));
        }

        //
        // POST: /SalesProductServiceDocuments/Edit/5
        [HttpPost]
        public ActionResult Edit(SalesProductServiceDocument salesproductservicedocument)
        {
            if (ModelState.IsValid) {
                salesproductservicedocumentRepository.InsertOrUpdate(salesproductservicedocument);
                salesproductservicedocumentRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSalesProductServiceCatelogs = salesproductservicecatelogRepository.All;
				return View(salesproductservicedocument);
			}
        }

        //
        // GET: /SalesProductServiceDocuments/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(salesproductservicedocumentRepository.Find(id));
        }

        //
        // POST: /SalesProductServiceDocuments/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            salesproductservicedocumentRepository.Delete(id);
            salesproductservicedocumentRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

