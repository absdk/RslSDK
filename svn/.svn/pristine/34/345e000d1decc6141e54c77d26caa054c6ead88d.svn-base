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
    public class ReligionController : Controller
    {
		private readonly IReligionRepository religionRepository;
        public ReligionController(IReligionRepository religionRepository)
        {
			this.religionRepository = religionRepository;
        }

        //
        // GET: /Religion/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(religionRepository.All);
        }
		
		public ViewResult Search(Religion searchReligion)
        {
			if(searchReligion!=null)
			{
							}
						return View("Index",religionRepository.All);
		}

        //
        // GET: /Religion/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(religionRepository.Find(id));
        }

        //
        // GET: /Religion/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Religion/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(Religion religion)
        {
            if (ModelState.IsValid) {
                religionRepository.InsertOrUpdate(religion);
                religionRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Religion/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(religionRepository.Find(id));
        }

        //
        // POST: /Religion/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Religion religion)
        {
            if (ModelState.IsValid) {
                religionRepository.InsertOrUpdate(religion);
                religionRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Religion/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(religionRepository.Find(id));
        }

        //
        // POST: /Religion/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            religionRepository.Delete(id);
            religionRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

