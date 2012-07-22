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
    public class RequisitionJDLibraryCategoriesController : Controller
    {
		private readonly IRequisitionJDLibraryCategoryRepository requisitionjdlibrarycategoryRepository;
        public RequisitionJDLibraryCategoriesController(IRequisitionJDLibraryCategoryRepository requisitionjdlibrarycategoryRepository)
        {
			this.requisitionjdlibrarycategoryRepository = requisitionjdlibrarycategoryRepository;
        }

        //
        // GET: /RequisitionJDLibraryCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionjdlibrarycategoryRepository.AllIncluding(requisitionjdlibrarycategory => requisitionjdlibrarycategory.ParentRequisitionJDLibraryCategory));
        }
		
		public ViewResult Search(RequisitionJDLibraryCategory searchRequisitionJDLibraryCategory)
        {
			if(searchRequisitionJDLibraryCategory!=null)
			{
							}
						return View("Index",requisitionjdlibrarycategoryRepository.AllIncluding(requisitionjdlibrarycategory => requisitionjdlibrarycategory.ParentRequisitionJDLibraryCategory));
		}

        //
        // GET: /RequisitionJDLibraryCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionjdlibrarycategoryRepository.Find(id));
        }

        //
        // GET: /RequisitionJDLibraryCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionJDLibraryCategory requisitionjdlibrarycategory = new RequisitionJDLibraryCategory();
			ViewBag.PossibleParentRequisitionJDLibraryCategories = requisitionjdlibrarycategoryRepository.All;
            return View(requisitionjdlibrarycategory);
        } 

        //
        // POST: /RequisitionJDLibraryCategories/Create
        [HttpPost]
        public ActionResult Create(RequisitionJDLibraryCategory requisitionjdlibrarycategory)
        {
            if (ModelState.IsValid) {
                requisitionjdlibrarycategoryRepository.InsertOrUpdate(requisitionjdlibrarycategory);
                requisitionjdlibrarycategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleParentRequisitionJDLibraryCategories = requisitionjdlibrarycategoryRepository.All;
				return View(requisitionjdlibrarycategory);
			}
        }
        
        //
        // GET: /RequisitionJDLibraryCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleParentRequisitionJDLibraryCategories = requisitionjdlibrarycategoryRepository.All;
             return View(requisitionjdlibrarycategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionJDLibraryCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionJDLibraryCategory requisitionjdlibrarycategory)
        {
            if (ModelState.IsValid) {
                requisitionjdlibrarycategoryRepository.InsertOrUpdate(requisitionjdlibrarycategory);
                requisitionjdlibrarycategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleParentRequisitionJDLibraryCategories = requisitionjdlibrarycategoryRepository.All;
				return View(requisitionjdlibrarycategory);
			}
        }

        //
        // GET: /RequisitionJDLibraryCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionjdlibrarycategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionJDLibraryCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionjdlibrarycategoryRepository.Delete(id);
            requisitionjdlibrarycategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

