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
namespace SoftwareGrid.Areas.Req.Controllers
{   
    public class RequisitionStatusCategoriesController : Controller
    {
		private readonly IRequisitionStatusCategoryRepository requisitionstatuscategoryRepository;
        public RequisitionStatusCategoriesController(IRequisitionStatusCategoryRepository requisitionstatuscategoryRepository)
        {
			this.requisitionstatuscategoryRepository = requisitionstatuscategoryRepository;
        }

        //
        // GET: /RequisitionStatusCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionstatuscategoryRepository.All);
        }
		
		public ViewResult Search(RequisitionStatusCategory searchRequisitionStatusCategory)
        {
			if(searchRequisitionStatusCategory!=null)
			{
							}
						return View("Index",requisitionstatuscategoryRepository.All);
		}

        //
        // GET: /RequisitionStatusCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionstatuscategoryRepository.Find(id));
        }

        //
        // GET: /RequisitionStatusCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionStatusCategory requisitionstatuscategory = new RequisitionStatusCategory();
            return View(requisitionstatuscategory);
        } 

        //
        // POST: /RequisitionStatusCategories/Create
        [HttpPost]
        public ActionResult Create(RequisitionStatusCategory requisitionstatuscategory)
        {
            if (ModelState.IsValid) {
                requisitionstatuscategoryRepository.InsertOrUpdate(requisitionstatuscategory);
                requisitionstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitionstatuscategory);
			}
        }
        
        //
        // GET: /RequisitionStatusCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(requisitionstatuscategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionStatusCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionStatusCategory requisitionstatuscategory)
        {
            if (ModelState.IsValid) {
                requisitionstatuscategoryRepository.InsertOrUpdate(requisitionstatuscategory);
                requisitionstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitionstatuscategory);
			}
        }

        //
        // GET: /RequisitionStatusCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionstatuscategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionStatusCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionstatuscategoryRepository.Delete(id);
            requisitionstatuscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

