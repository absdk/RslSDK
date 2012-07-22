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
    public class EmploymentStatusController : Controller
    {
		private readonly IEmploymentStatusRepository employmentstatusRepository;
        public EmploymentStatusController(IEmploymentStatusRepository employmentstatusRepository)
        {
			this.employmentstatusRepository = employmentstatusRepository;
        }

        //
        // GET: /EmploymentStatus/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(employmentstatusRepository.All);
        }
		
		public ViewResult Search(EmploymentStatus searchEmploymentStatus)
        {
			if(searchEmploymentStatus!=null)
			{
							}
						return View("Index",employmentstatusRepository.All);
		}

        //
        // GET: /EmploymentStatus/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(employmentstatusRepository.Find(id));
        }

        //
        // GET: /EmploymentStatus/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /EmploymentStatus/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(EmploymentStatus employmentstatus)
        {
            if (ModelState.IsValid) {
                employmentstatusRepository.InsertOrUpdate(employmentstatus);
                employmentstatusRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /EmploymentStatus/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(employmentstatusRepository.Find(id));
        }

        //
        // POST: /EmploymentStatus/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(EmploymentStatus employmentstatus)
        {
            if (ModelState.IsValid) {
                employmentstatusRepository.InsertOrUpdate(employmentstatus);
                employmentstatusRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /EmploymentStatus/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(employmentstatusRepository.Find(id));
        }

        //
        // POST: /EmploymentStatus/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            employmentstatusRepository.Delete(id);
            employmentstatusRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

