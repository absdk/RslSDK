//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  http://www.softwaregrid.com
//
//*********************************************************

using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.Common;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.Areas.AppBuilder.Controllers
{
    public class AppMenuController : UserBaseController
    {
        private readonly IAppMenuCategoryRepository appmenucategoryRepository;
        private readonly IAppMenuRepository appmenuRepository;
        public AppMenuController(IAppMenuCategoryRepository appmenucategoryRepository, IAppMenuRepository appmenuRepository)
        {
            this.appmenucategoryRepository = appmenucategoryRepository;
            this.appmenuRepository = appmenuRepository;
        }

        //
        // GET: /AppMenu/
        [UserAuthorize]
        public ViewResult Index()
        {
            ViewBag.PossibleAppMenuCategories = appmenucategoryRepository.All;
            ViewBag.PossibleAppParentMenus = appmenuRepository.AllParent;
            return View(appmenuRepository.AllIncluding(appmenu => appmenu.AppMenuCategory));
        }

        public ViewResult Search(AppMenu searchAppMenu)
        {
            if (searchAppMenu != null)
            {
                if (searchAppMenu.AppMenuCategoryID > 0)
                {
                    ViewData["AppMenuCategoryID"] = searchAppMenu.AppMenuCategoryID;
                }
                ViewData["Name"] = searchAppMenu.Name;
                ViewData["AreaName"] = searchAppMenu.AreaName;
                ViewData["ControllerName"] = searchAppMenu.ControllerName;
                ViewData["ActionName"] = searchAppMenu.ActionName;
                if (searchAppMenu.AppParentMenuID > 0)
                {
                    ViewData["AppParentMenuID"] = searchAppMenu.AppParentMenuID;
                }
            }
            ViewBag.PossibleAppMenuCategories = appmenucategoryRepository.All;
            ViewBag.PossibleAppParentMenus = appmenuRepository.AllParent;
            return View("Index", appmenuRepository.AllIncluding(appmenu => appmenu.AppMenuCategory));
        }

        //
        // GET: /AppMenu/Details/5
        [UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(appmenuRepository.Find(id));
        }

        //
        // GET: /AppMenu/Create
        [UserAuthorize]
        public ActionResult Create()
        {
            AppMenu appmenu = new AppMenu();
            ViewBag.PossibleAppMenuCategories = appmenucategoryRepository.All;
            ViewBag.PossibleAppParentMenus = appmenuRepository.AllParent;
            ViewBag.PossibleAreaNames = MiscUtility.GetAreas();
            ViewBag.PossibleControllerNames = MiscUtility.GetControllers(string.Empty);
            ViewBag.PossibleActionNames = MiscUtility.GetActions(string.Empty);
            appmenu.MenuSequenceNumber = 0;
            return View(appmenu);
        }

        //
        // POST: /AppMenu/Create
        [HttpPost]
        public ActionResult Create(AppMenu appmenu)
        {
            if (ModelState.IsValid)
            {
                if (Session["MenuIcon"] != null)
                {
                    appmenu.MenuIconName = Session["MenuIcon"].ToString();
                    var fileName = appmenu.MenuIconName;
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    if (System.IO.File.Exists(physicalPath))
                    {
                        appmenu.MenuIcon = Utility.ReadFile(physicalPath);
                    }
                }
                appmenuRepository.InsertOrUpdate(appmenu);
                appmenuRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleAppMenuCategories = appmenucategoryRepository.All;
                return View(appmenu);
            }
        }

        //
        // GET: /AppMenu/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id)
        {
            AppMenu appMenu=appmenuRepository.Find(id);
            ViewBag.PossibleAppMenuCategories = appmenucategoryRepository.All;
            ViewBag.PossibleAppParentMenus = appmenuRepository.AllParent;
            
            ViewBag.PossibleAreaNames = MiscUtility.GetAreas();
            ViewBag.PossibleControllerNames = MiscUtility.GetControllers(appMenu.AreaName);
            ViewBag.PossibleActionNames = MiscUtility.GetActions(appMenu.ControllerName);

            return View(appMenu);
        }

        //
        // POST: /AppMenu/Edit/5
        [HttpPost]
        public ActionResult Edit(AppMenu appmenu)
        {
            if (ModelState.IsValid)
            {
                if (Session["MenuIcon"] != null)
                {
                    appmenu.MenuIconName = Session["MenuIcon"].ToString();
                    var fileName = appmenu.MenuIconName;
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    if (System.IO.File.Exists(physicalPath))
                    {
                        appmenu.MenuIcon = Utility.ReadFile(physicalPath);
                    }
                }
                appmenuRepository.InsertOrUpdate(appmenu);
                appmenuRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleAppMenuCategories = appmenucategoryRepository.All;
                return View(appmenu);
            }
        }

        [HttpPost]
        public ActionResult Cancel()
        {
            return RedirectToAction("Index");
        }

        //
        // GET: /AppMenu/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(appmenuRepository.Find(id));
        }

        //
        // POST: /AppMenu/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            appmenuRepository.Delete(id);
            appmenuRepository.Save();

            return RedirectToAction("Index");
        }

        public ActionResult SelectControllers(string AreaName)
        {
            ViewBag.PossibleControllerNames = MiscUtility.GetControllers(AreaName);
            if (Request.IsAjaxRequest())
            {
                return Json(new { data = this.RenderPartialViewToString(Constants.PartialViews.DropDownList_Controller, new AppMenu()) });
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult SelectActions(string ControllerName)
        {
            ViewBag.PossibleActionNames = MiscUtility.GetActions(ControllerName);
            if (Request.IsAjaxRequest())
            {
                return Json(new { data = this.RenderPartialViewToString(Constants.PartialViews.DropDownList_Action, new AppMenu()) });
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult SelectParentMenus(string AppMenuCategoryID)
        {
            ViewBag.PossibleAppParentMenus = appmenuRepository.GetAllParentByAppMenuCategoryID(AppMenuCategoryID.ToInteger(true));
            if (Request.IsAjaxRequest())
            {
                return Json(new { data = this.RenderPartialViewToString(Constants.PartialViews.DropDownList_ParentMenus, new AppMenu()) });
            }
            else
            {
                return Json(new { data = this.RenderPartialViewToString(Constants.PartialViews.DropDownList_ParentMenus, new AppMenu()) });
            }
        }
    }
}

