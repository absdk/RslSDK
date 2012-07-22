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
    public class AccountsController : Controller
    {
		private readonly IAccountCategoryRepository accountcategoryRepository;
		private readonly IAccountRepository accountRepository;
        public AccountsController(IAccountCategoryRepository accountcategoryRepository, IAccountRepository accountRepository)
        {
			this.accountcategoryRepository = accountcategoryRepository;
			this.accountRepository = accountRepository;
        }

        //
        // GET: /Accounts/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(accountRepository.AllIncluding(account => account.AccountCategory, account => account.ParentAccount));
        }
		
		public ViewResult Search(Account searchAccount)
        {
			if(searchAccount!=null)
			{
							}
						return View("Index",accountRepository.AllIncluding(account => account.AccountCategory, account => account.ParentAccount));
		}

        //
        // GET: /Accounts/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(accountRepository.Find(id));
        }

        //
        // GET: /Accounts/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			Account account = new Account();
			ViewBag.PossibleAccountCategories = accountcategoryRepository.All;
			ViewBag.PossibleParentAccounts = accountRepository.All;
            return View(account);
        } 

        //
        // POST: /Accounts/Create
        [HttpPost]
        public ActionResult Create(Account account)
        {
            if (ModelState.IsValid) {
                accountRepository.InsertOrUpdate(account);
                accountRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleAccountCategories = accountcategoryRepository.All;
				ViewBag.PossibleParentAccounts = accountRepository.All;
				return View(account);
			}
        }
        
        //
        // GET: /Accounts/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleAccountCategories = accountcategoryRepository.All;
			ViewBag.PossibleParentAccounts = accountRepository.All;
             return View(accountRepository.Find(id));
        }

        //
        // POST: /Accounts/Edit/5
        [HttpPost]
        public ActionResult Edit(Account account)
        {
            if (ModelState.IsValid) {
                accountRepository.InsertOrUpdate(account);
                accountRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleAccountCategories = accountcategoryRepository.All;
				ViewBag.PossibleParentAccounts = accountRepository.All;
				return View(account);
			}
        }

        //
        // GET: /Accounts/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(accountRepository.Find(id));
        }

        //
        // POST: /Accounts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            accountRepository.Delete(id);
            accountRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

