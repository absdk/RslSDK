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
    public class PayCycleController : Controller
    {
		private readonly IPayCycleRepository paycycleRepository;
        public PayCycleController(IPayCycleRepository paycycleRepository)
        {
			this.paycycleRepository = paycycleRepository;
        }

        //
        // GET: /PayCycle/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(paycycleRepository.All);
        }
		
		public ViewResult Search(PayCycle searchPayCycle)
        {
			if(searchPayCycle!=null)
			{
							}
						return View("Index",paycycleRepository.All);
		}

        //
        // GET: /PayCycle/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(paycycleRepository.Find(id));
        }

        //
        // GET: /PayCycle/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /PayCycle/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(PayCycle paycycle)
        {
            if (ModelState.IsValid) {
                paycycleRepository.InsertOrUpdate(paycycle);
                paycycleRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /PayCycle/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(paycycleRepository.Find(id));
        }

        //
        // POST: /PayCycle/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(PayCycle paycycle)
        {
            if (ModelState.IsValid) {
                paycycleRepository.InsertOrUpdate(paycycle);
                paycycleRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /PayCycle/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(paycycleRepository.Find(id));
        }

        //
        // POST: /PayCycle/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            paycycleRepository.Delete(id);
            paycycleRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

