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
    public class DriverLicenseController : Controller
    {
		private readonly IDriverLicenseRepository driverlicenseRepository;
        public DriverLicenseController(IDriverLicenseRepository driverlicenseRepository)
        {
			this.driverlicenseRepository = driverlicenseRepository;
        }

        //
        // GET: /DriverLicense/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(driverlicenseRepository.All);
        }
		
		public ViewResult Search(DriverLicense searchDriverLicense)
        {
			if(searchDriverLicense!=null)
			{
							}
						return View("Index",driverlicenseRepository.All);
		}

        //
        // GET: /DriverLicense/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(driverlicenseRepository.Find(id));
        }

        //
        // GET: /DriverLicense/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /DriverLicense/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(DriverLicense driverlicense)
        {
            if (ModelState.IsValid) {
                driverlicenseRepository.InsertOrUpdate(driverlicense);
                driverlicenseRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /DriverLicense/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(driverlicenseRepository.Find(id));
        }

        //
        // POST: /DriverLicense/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(DriverLicense driverlicense)
        {
            if (ModelState.IsValid) {
                driverlicenseRepository.InsertOrUpdate(driverlicense);
                driverlicenseRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /DriverLicense/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(driverlicenseRepository.Find(id));
        }

        //
        // POST: /DriverLicense/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            driverlicenseRepository.Delete(id);
            driverlicenseRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

