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
    public class RequisitionStatusForVendorCategoriesController : Controller
    {
		private readonly IRequisitionStatusForVendorCategoryRepository requisitionstatusforvendorcategoryRepository;
        public RequisitionStatusForVendorCategoriesController(IRequisitionStatusForVendorCategoryRepository requisitionstatusforvendorcategoryRepository)
        {
			this.requisitionstatusforvendorcategoryRepository = requisitionstatusforvendorcategoryRepository;
        }

        //
        // GET: /RequisitionStatusForVendorCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionstatusforvendorcategoryRepository.All);
        }
		
		public ViewResult Search(RequisitionStatusForVendorCategory searchRequisitionStatusForVendorCategory)
        {
			if(searchRequisitionStatusForVendorCategory!=null)
			{
							}
						return View("Index",requisitionstatusforvendorcategoryRepository.All);
		}

        //
        // GET: /RequisitionStatusForVendorCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionstatusforvendorcategoryRepository.Find(id));
        }

        //
        // GET: /RequisitionStatusForVendorCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionStatusForVendorCategory requisitionstatusforvendorcategory = new RequisitionStatusForVendorCategory();
            return View(requisitionstatusforvendorcategory);
        } 

        //
        // POST: /RequisitionStatusForVendorCategories/Create
        [HttpPost]
        public ActionResult Create(RequisitionStatusForVendorCategory requisitionstatusforvendorcategory)
        {
            if (ModelState.IsValid) {
                requisitionstatusforvendorcategoryRepository.InsertOrUpdate(requisitionstatusforvendorcategory);
                requisitionstatusforvendorcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitionstatusforvendorcategory);
			}
        }
        
        //
        // GET: /RequisitionStatusForVendorCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(requisitionstatusforvendorcategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionStatusForVendorCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionStatusForVendorCategory requisitionstatusforvendorcategory)
        {
            if (ModelState.IsValid) {
                requisitionstatusforvendorcategoryRepository.InsertOrUpdate(requisitionstatusforvendorcategory);
                requisitionstatusforvendorcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitionstatusforvendorcategory);
			}
        }

        //
        // GET: /RequisitionStatusForVendorCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionstatusforvendorcategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionStatusForVendorCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionstatusforvendorcategoryRepository.Delete(id);
            requisitionstatusforvendorcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

