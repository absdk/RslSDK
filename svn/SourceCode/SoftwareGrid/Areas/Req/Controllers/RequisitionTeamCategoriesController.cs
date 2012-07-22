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
    public class RequisitionTeamCategoriesController : Controller
    {
		private readonly IRequisitionTeamCategoryRepository requisitionteamcategoryRepository;
        public RequisitionTeamCategoriesController(IRequisitionTeamCategoryRepository requisitionteamcategoryRepository)
        {
			this.requisitionteamcategoryRepository = requisitionteamcategoryRepository;
        }

        //
        // GET: /RequisitionTeamCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionteamcategoryRepository.All);
        }
		
		public ViewResult Search(RequisitionTeamCategory searchRequisitionTeamCategory)
        {
			if(searchRequisitionTeamCategory!=null)
			{
							}
						return View("Index",requisitionteamcategoryRepository.All);
		}

        //
        // GET: /RequisitionTeamCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionteamcategoryRepository.Find(id));
        }

        //
        // GET: /RequisitionTeamCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionTeamCategory requisitionteamcategory = new RequisitionTeamCategory();
            return View(requisitionteamcategory);
        } 

        //
        // POST: /RequisitionTeamCategories/Create
        [HttpPost]
        public ActionResult Create(RequisitionTeamCategory requisitionteamcategory)
        {
            if (ModelState.IsValid) {
                requisitionteamcategoryRepository.InsertOrUpdate(requisitionteamcategory);
                requisitionteamcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitionteamcategory);
			}
        }
        
        //
        // GET: /RequisitionTeamCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(requisitionteamcategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionTeamCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionTeamCategory requisitionteamcategory)
        {
            if (ModelState.IsValid) {
                requisitionteamcategoryRepository.InsertOrUpdate(requisitionteamcategory);
                requisitionteamcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitionteamcategory);
			}
        }

        //
        // GET: /RequisitionTeamCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionteamcategoryRepository.Find(id));
        }

        //
        // POST: /RequisitionTeamCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionteamcategoryRepository.Delete(id);
            requisitionteamcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

