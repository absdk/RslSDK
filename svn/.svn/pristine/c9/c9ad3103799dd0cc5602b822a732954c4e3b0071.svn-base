//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  http://www.softwaregrid.com
//
//*********************************************************

using System.Web.Mvc;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.Areas.MasterData.Controllers
{   
    public class CurrencyController : Controller
    {
		private readonly ICurrencyRepository currencyRepository;
        public CurrencyController(ICurrencyRepository currencyRepository)
        {
			this.currencyRepository = currencyRepository;
        }

        //
        // GET: /Currency/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(currencyRepository.All);
        }
		
		public ViewResult Search(Currency searchCurrency)
        {
			if(searchCurrency!=null)
			{
							}
						return View("Index",currencyRepository.All);
		}

        //
        // GET: /Currency/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(currencyRepository.Find(id));
        }

        //
        // GET: /Currency/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Currency/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(Currency currency)
        {
            if (ModelState.IsValid) {
                currencyRepository.InsertOrUpdate(currency);
                currencyRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Currency/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(currencyRepository.Find(id));
        }

        //
        // POST: /Currency/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Currency currency)
        {
            if (ModelState.IsValid) {
                currencyRepository.InsertOrUpdate(currency);
                currencyRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Currency/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(currencyRepository.Find(id));
        }

        //
        // POST: /Currency/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            currencyRepository.Delete(id);
            currencyRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

