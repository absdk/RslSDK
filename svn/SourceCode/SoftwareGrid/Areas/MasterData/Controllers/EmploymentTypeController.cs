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
    public class EmploymentTypeController : Controller
    {
		private readonly IEmploymentTypeRepository employmenttypeRepository;
        public EmploymentTypeController(IEmploymentTypeRepository employmenttypeRepository)
        {
			this.employmenttypeRepository = employmenttypeRepository;
        }

        //
        // GET: /EmploymentType/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(employmenttypeRepository.All);
        }
		
		public ViewResult Search(EmploymentType searchEmploymentType)
        {
			if(searchEmploymentType!=null)
			{
							}
						return View("Index",employmenttypeRepository.All);
		}

        //
        // GET: /EmploymentType/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(employmenttypeRepository.Find(id));
        }

        //
        // GET: /EmploymentType/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /EmploymentType/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(EmploymentType employmenttype)
        {
            if (ModelState.IsValid) {
                employmenttypeRepository.InsertOrUpdate(employmenttype);
                employmenttypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /EmploymentType/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(employmenttypeRepository.Find(id));
        }

        //
        // POST: /EmploymentType/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(EmploymentType employmenttype)
        {
            if (ModelState.IsValid) {
                employmenttypeRepository.InsertOrUpdate(employmenttype);
                employmenttypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /EmploymentType/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(employmenttypeRepository.Find(id));
        }

        //
        // POST: /EmploymentType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            employmenttypeRepository.Delete(id);
            employmenttypeRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

