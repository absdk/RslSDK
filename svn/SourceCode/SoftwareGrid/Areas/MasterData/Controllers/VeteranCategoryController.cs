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
    public class VeteranCategoryController : Controller
    {
		private readonly IVeteranCategoryRepository veterancategoryRepository;
        public VeteranCategoryController(IVeteranCategoryRepository veterancategoryRepository)
        {
			this.veterancategoryRepository = veterancategoryRepository;
        }

        //
        // GET: /VeteranCategory/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(veterancategoryRepository.All);
        }
		
		public ViewResult Search(VeteranCategory searchVeteranCategory)
        {
			if(searchVeteranCategory!=null)
			{
							}
						return View("Index",veterancategoryRepository.All);
		}

        //
        // GET: /VeteranCategory/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(veterancategoryRepository.Find(id));
        }

        //
        // GET: /VeteranCategory/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /VeteranCategory/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(VeteranCategory veterancategory)
        {
            if (ModelState.IsValid) {
                veterancategoryRepository.InsertOrUpdate(veterancategory);
                veterancategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /VeteranCategory/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(veterancategoryRepository.Find(id));
        }

        //
        // POST: /VeteranCategory/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(VeteranCategory veterancategory)
        {
            if (ModelState.IsValid) {
                veterancategoryRepository.InsertOrUpdate(veterancategory);
                veterancategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /VeteranCategory/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(veterancategoryRepository.Find(id));
        }

        //
        // POST: /VeteranCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            veterancategoryRepository.Delete(id);
            veterancategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

