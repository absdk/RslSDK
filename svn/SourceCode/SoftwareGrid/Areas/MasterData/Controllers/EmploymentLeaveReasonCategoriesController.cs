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
namespace SoftwareGrid.Areas.MasterData.Controllers
{   
    public class EmploymentLeaveReasonCategoriesController : Controller
    {
		private readonly IEmploymentLeaveReasonCategoryRepository employmentleavereasoncategoryRepository;
        public EmploymentLeaveReasonCategoriesController(IEmploymentLeaveReasonCategoryRepository employmentleavereasoncategoryRepository)
        {
			this.employmentleavereasoncategoryRepository = employmentleavereasoncategoryRepository;
        }

        //
        // GET: /EmploymentLeaveReasonCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(employmentleavereasoncategoryRepository.All);
        }
		
		public ViewResult Search(EmploymentLeaveReasonCategory searchEmploymentLeaveReasonCategory)
        {
			if(searchEmploymentLeaveReasonCategory!=null)
			{
							}
						return View("Index",employmentleavereasoncategoryRepository.All);
		}

        //
        // GET: /EmploymentLeaveReasonCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(employmentleavereasoncategoryRepository.Find(id));
        }

        //
        // GET: /EmploymentLeaveReasonCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			EmploymentLeaveReasonCategory employmentleavereasoncategory = new EmploymentLeaveReasonCategory();
            return View(employmentleavereasoncategory);
        } 

        //
        // POST: /EmploymentLeaveReasonCategories/Create
        [HttpPost]
        public ActionResult Create(EmploymentLeaveReasonCategory employmentleavereasoncategory)
        {
            if (ModelState.IsValid) {
                employmentleavereasoncategoryRepository.InsertOrUpdate(employmentleavereasoncategory);
                employmentleavereasoncategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(employmentleavereasoncategory);
			}
        }
        
        //
        // GET: /EmploymentLeaveReasonCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(employmentleavereasoncategoryRepository.Find(id));
        }

        //
        // POST: /EmploymentLeaveReasonCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(EmploymentLeaveReasonCategory employmentleavereasoncategory)
        {
            if (ModelState.IsValid) {
                employmentleavereasoncategoryRepository.InsertOrUpdate(employmentleavereasoncategory);
                employmentleavereasoncategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(employmentleavereasoncategory);
			}
        }

        //
        // GET: /EmploymentLeaveReasonCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(employmentleavereasoncategoryRepository.Find(id));
        }

        //
        // POST: /EmploymentLeaveReasonCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            employmentleavereasoncategoryRepository.Delete(id);
            employmentleavereasoncategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

