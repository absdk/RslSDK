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
    public class RequisitionApprovalStatusCategoriesController : Controller
    {
		private readonly IRequisitionApprovalStatusCategoryRepository requisitionapprovalstatuscategoryRepository;
        public RequisitionApprovalStatusCategoriesController(IRequisitionApprovalStatusCategoryRepository requisitionapprovalstatuscategoryRepository)
        {
			this.requisitionapprovalstatuscategoryRepository = requisitionapprovalstatuscategoryRepository;
        }

        //
        // GET: /RequisitionApprovalStatusCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionapprovalstatuscategoryRepository.All);
        }
		
		public ViewResult Search(RequisitionApprovalStatusCategory searchRequisitionApprovalStatusCategory)
        {
			if(searchRequisitionApprovalStatusCategory!=null)
			{
							}
						return View("Index",requisitionapprovalstatuscategoryRepository.All);
		}

        //
        // GET: /RequisitionApprovalStatusCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionapprovalstatuscategoryRepository.Find(id));
        }

        //
        // GET: /RequisitionApprovalStatusCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionApprovalStatusCategory requisitionapprovalstatuscategory = new RequisitionApprovalStatusCategory();
            return View(requisitionapprovalstatuscategory);
        } 

        //
        // POST: /RequisitionApprovalStatusCategories/Create
        [HttpPost]
        public ActionResult Create(RequisitionApprovalStatusCategory requisitionapprovalstatuscategory)
        {
            if (ModelState.IsValid) {
                requisitionapprovalstatuscategoryRepository.InsertOrUpdate(requisitionapprovalstatuscategory);
                requisitionapprovalstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitionapprovalstatuscategory);
			}
        }
        
        //
        // GET: /RequisitionApprovalStatusCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(requisitionapprovalstatuscategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionApprovalStatusCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionApprovalStatusCategory requisitionapprovalstatuscategory)
        {
            if (ModelState.IsValid) {
                requisitionapprovalstatuscategoryRepository.InsertOrUpdate(requisitionapprovalstatuscategory);
                requisitionapprovalstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitionapprovalstatuscategory);
			}
        }

        //
        // GET: /RequisitionApprovalStatusCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionapprovalstatuscategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionApprovalStatusCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionapprovalstatuscategoryRepository.Delete(id);
            requisitionapprovalstatuscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

