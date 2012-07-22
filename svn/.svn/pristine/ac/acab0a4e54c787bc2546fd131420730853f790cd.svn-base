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
    public class GenderController : Controller
    {
		private readonly IGenderRepository genderRepository;
        public GenderController(IGenderRepository genderRepository)
        {
			this.genderRepository = genderRepository;
        }

        //
        // GET: /Gender/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(genderRepository.All);
        }
		
		public ViewResult Search(Gender searchGender)
        {
			if(searchGender!=null)
			{
							}
						return View("Index",genderRepository.All);
		}

        //
        // GET: /Gender/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(genderRepository.Find(id));
        }

        //
        // GET: /Gender/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Gender/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(Gender gender)
        {
            if (ModelState.IsValid) {
                genderRepository.InsertOrUpdate(gender);
                genderRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Gender/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(genderRepository.Find(id));
        }

        //
        // POST: /Gender/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Gender gender)
        {
            if (ModelState.IsValid) {
                genderRepository.InsertOrUpdate(gender);
                genderRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Gender/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(genderRepository.Find(id));
        }

        //
        // POST: /Gender/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            genderRepository.Delete(id);
            genderRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

