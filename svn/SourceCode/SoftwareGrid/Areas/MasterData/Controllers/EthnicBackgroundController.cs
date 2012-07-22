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
    public class EthnicBackgroundController : Controller
    {
		private readonly IEthnicBackgroundRepository ethnicbackgroundRepository;
        public EthnicBackgroundController(IEthnicBackgroundRepository ethnicbackgroundRepository)
        {
			this.ethnicbackgroundRepository = ethnicbackgroundRepository;
        }

        //
        // GET: /EthnicBackground/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(ethnicbackgroundRepository.All);
        }
		
		public ViewResult Search(EthnicBackground searchEthnicBackground)
        {
			if(searchEthnicBackground!=null)
			{
							}
						return View("Index",ethnicbackgroundRepository.All);
		}

        //
        // GET: /EthnicBackground/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(ethnicbackgroundRepository.Find(id));
        }

        //
        // GET: /EthnicBackground/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /EthnicBackground/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(EthnicBackground ethnicbackground)
        {
            if (ModelState.IsValid) {
                ethnicbackgroundRepository.InsertOrUpdate(ethnicbackground);
                ethnicbackgroundRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /EthnicBackground/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(ethnicbackgroundRepository.Find(id));
        }

        //
        // POST: /EthnicBackground/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(EthnicBackground ethnicbackground)
        {
            if (ModelState.IsValid) {
                ethnicbackgroundRepository.InsertOrUpdate(ethnicbackground);
                ethnicbackgroundRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /EthnicBackground/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(ethnicbackgroundRepository.Find(id));
        }

        //
        // POST: /EthnicBackground/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ethnicbackgroundRepository.Delete(id);
            ethnicbackgroundRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

