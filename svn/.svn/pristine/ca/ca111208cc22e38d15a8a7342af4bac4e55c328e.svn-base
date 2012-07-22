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
    public class ExperienceLevelCategoryController : Controller
    {
		private readonly IExperienceLevelCategoryRepository experiencelevelcategoryRepository;
        public ExperienceLevelCategoryController(IExperienceLevelCategoryRepository experiencelevelcategoryRepository)
        {
			this.experiencelevelcategoryRepository = experiencelevelcategoryRepository;
        }

        //
        // GET: /ExperienceLevelCategory/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(experiencelevelcategoryRepository.All);
        }
		
		public ViewResult Search(ExperienceLevelCategory searchExperienceLevelCategory)
        {
			if(searchExperienceLevelCategory!=null)
			{
							}
						return View("Index",experiencelevelcategoryRepository.All);
		}

        //
        // GET: /ExperienceLevelCategory/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(experiencelevelcategoryRepository.Find(id));
        }

        //
        // GET: /ExperienceLevelCategory/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ExperienceLevelCategory/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(ExperienceLevelCategory experiencelevelcategory)
        {
            if (ModelState.IsValid) {
                experiencelevelcategoryRepository.InsertOrUpdate(experiencelevelcategory);
                experiencelevelcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /ExperienceLevelCategory/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(experiencelevelcategoryRepository.Find(id));
        }

        //
        // POST: /ExperienceLevelCategory/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(ExperienceLevelCategory experiencelevelcategory)
        {
            if (ModelState.IsValid) {
                experiencelevelcategoryRepository.InsertOrUpdate(experiencelevelcategory);
                experiencelevelcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /ExperienceLevelCategory/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(experiencelevelcategoryRepository.Find(id));
        }

        //
        // POST: /ExperienceLevelCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            experiencelevelcategoryRepository.Delete(id);
            experiencelevelcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

