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
    public class MaritalStatusController : Controller
    {
		private readonly IMaritalStatusRepository maritalstatusRepository;
        public MaritalStatusController(IMaritalStatusRepository maritalstatusRepository)
        {
			this.maritalstatusRepository = maritalstatusRepository;
        }

        //
        // GET: /MaritalStatus/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(maritalstatusRepository.All);
        }
		
		public ViewResult Search(MaritalStatus searchMaritalStatus)
        {
			if(searchMaritalStatus!=null)
			{
							}
						return View("Index",maritalstatusRepository.All);
		}

        //
        // GET: /MaritalStatus/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(maritalstatusRepository.Find(id));
        }

        //
        // GET: /MaritalStatus/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /MaritalStatus/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(MaritalStatus maritalstatus)
        {
            if (ModelState.IsValid) {
                maritalstatusRepository.InsertOrUpdate(maritalstatus);
                maritalstatusRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /MaritalStatus/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(maritalstatusRepository.Find(id));
        }

        //
        // POST: /MaritalStatus/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(MaritalStatus maritalstatus)
        {
            if (ModelState.IsValid) {
                maritalstatusRepository.InsertOrUpdate(maritalstatus);
                maritalstatusRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /MaritalStatus/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(maritalstatusRepository.Find(id));
        }

        //
        // POST: /MaritalStatus/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            maritalstatusRepository.Delete(id);
            maritalstatusRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

