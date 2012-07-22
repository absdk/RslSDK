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
    public class SecurityClearanceController : Controller
    {
		private readonly ISecurityClearanceRepository securityclearanceRepository;
        public SecurityClearanceController(ISecurityClearanceRepository securityclearanceRepository)
        {
			this.securityclearanceRepository = securityclearanceRepository;
        }

        //
        // GET: /SecurityClearance/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(securityclearanceRepository.All);
        }
		
		public ViewResult Search(SecurityClearance searchSecurityClearance)
        {
			if(searchSecurityClearance!=null)
			{
							}
						return View("Index",securityclearanceRepository.All);
		}

        //
        // GET: /SecurityClearance/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(securityclearanceRepository.Find(id));
        }

        //
        // GET: /SecurityClearance/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /SecurityClearance/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(SecurityClearance securityclearance)
        {
            if (ModelState.IsValid) {
                securityclearanceRepository.InsertOrUpdate(securityclearance);
                securityclearanceRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /SecurityClearance/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(securityclearanceRepository.Find(id));
        }

        //
        // POST: /SecurityClearance/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(SecurityClearance securityclearance)
        {
            if (ModelState.IsValid) {
                securityclearanceRepository.InsertOrUpdate(securityclearance);
                securityclearanceRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /SecurityClearance/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(securityclearanceRepository.Find(id));
        }

        //
        // POST: /SecurityClearance/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            securityclearanceRepository.Delete(id);
            securityclearanceRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

