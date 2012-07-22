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
    public class AccountCategoriesController : Controller
    {
		private readonly IAccountCategoryRepository accountcategoryRepository;
        public AccountCategoriesController(IAccountCategoryRepository accountcategoryRepository)
        {
			this.accountcategoryRepository = accountcategoryRepository;
        }

        //
        // GET: /AccountCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(accountcategoryRepository.All);
        }
		
		public ViewResult Search(AccountCategory searchAccountCategory)
        {
			if(searchAccountCategory!=null)
			{
							}
						return View("Index",accountcategoryRepository.All);
		}

        //
        // GET: /AccountCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(accountcategoryRepository.Find(id));
        }

        //
        // GET: /AccountCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			AccountCategory accountcategory = new AccountCategory();
            return View(accountcategory);
        } 

        //
        // POST: /AccountCategories/Create
        [HttpPost]
        public ActionResult Create(AccountCategory accountcategory)
        {
            if (ModelState.IsValid) {
                accountcategoryRepository.InsertOrUpdate(accountcategory);
                accountcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(accountcategory);
			}
        }
        
        //
        // GET: /AccountCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(accountcategoryRepository.Find(id));
        }

        //
        // POST: /AccountCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(AccountCategory accountcategory)
        {
            if (ModelState.IsValid) {
                accountcategoryRepository.InsertOrUpdate(accountcategory);
                accountcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(accountcategory);
			}
        }

        //
        // GET: /AccountCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(accountcategoryRepository.Find(id));
        }

        //
        // POST: /AccountCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            accountcategoryRepository.Delete(id);
            accountcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

