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

namespace SoftwareGrid.Areas.AppBuilder.Controllers
{
    public class AppMenuCategoryController : UserBaseController
    {
        private readonly IAppMenuCategoryRepository appmenucategoryRepository;
        public AppMenuCategoryController(IAppMenuCategoryRepository appmenucategoryRepository)
        {
            this.appmenucategoryRepository = appmenucategoryRepository;
        }

        //
        // GET: /AppMenuCategory/
        [UserAuthorize]
        public ViewResult Index()
        {
            return View(appmenucategoryRepository.All);
        }

        public ViewResult Search(AppMenuCategory searchAppMenuCategory)
        {
            if (searchAppMenuCategory != null)
            {
            }
            return View("Index", appmenucategoryRepository.All);
        }

        //
        // GET: /AppMenuCategory/Details/5
        [UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(appmenucategoryRepository.Find(id));
        }

        //
        // GET: /AppMenuCategory/Create
        [UserAuthorize]
        public ActionResult Create()
        {
            AppMenuCategory appmenucategory = new AppMenuCategory();
            return View(appmenucategory);
        }

        //
        // POST: /AppMenuCategory/Create
        [HttpPost]
        public ActionResult Create(AppMenuCategory appmenucategory)
        {
            if (ModelState.IsValid)
            {
                appmenucategoryRepository.InsertOrUpdate(appmenucategory);
                appmenucategoryRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(appmenucategory);
            }
        }

        //
        // GET: /AppMenuCategory/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id)
        {
            return View(appmenucategoryRepository.Find(id));
        }

        //
        // POST: /AppMenuCategory/Edit/5
        [HttpPost]
        public ActionResult Edit(AppMenuCategory appmenucategory)
        {
            if (ModelState.IsValid)
            {
                appmenucategoryRepository.InsertOrUpdate(appmenucategory);
                appmenucategoryRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View(appmenucategory);
            }
        }

        //
        // GET: /AppMenuCategory/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(appmenucategoryRepository.Find(id));
        }

        //
        // POST: /AppMenuCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            appmenucategoryRepository.Delete(id);
            appmenucategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

