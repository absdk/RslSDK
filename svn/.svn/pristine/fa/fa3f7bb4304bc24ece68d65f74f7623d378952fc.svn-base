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
using System.Web.Security;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.Common;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.Areas.UM.Controllers
{
    public class UserController : UserBaseController
    {
        private readonly IUserRoleRepository userroleRepository;
        private readonly IUserRepository userRepository;
        public UserController(IUserRoleRepository userroleRepository, IUserRepository userRepository)
        {
            this.userroleRepository = userroleRepository;
            this.userRepository = userRepository;
        }

        //
        // GET: /User/
        [UserAuthorize]
        public ViewResult Index()
        {
            ViewBag.PossibleUserRoles = userroleRepository.All;
            return View(userRepository.AllIncluding(user => user.UserRole));
        }

        public ViewResult Search(User searchUser)
        {
            if (searchUser != null)
            {
            }
            return View("Index", userRepository.AllIncluding(user => user.UserRole));
        }

        //
        // GET: /User/Details/5
        [UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(userRepository.Find(id));
        }

        //
        // GET: /User/Create
        [UserAuthorize]
        public ActionResult Create()
        {
            User user = new User();
            ViewBag.PossibleUserRoles = userroleRepository.All;
            return View(user);
        }

        //
        // POST: /User/Create
        [UserAuthorize]
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                if (Session["FileName"] != null)
                {
                    var physicalPath = MiscUtility.GetPhysicalFilePath(Constants.Paths.TemporaryFileUploadPath, Session["FileName"].ToString());
                    user.Photo = Utility.ReadFile(physicalPath);
                }
                userRepository.InsertOrUpdate(user);
                userRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleUserRoles = userroleRepository.All;
                return View(user);
            }
        }

        //
        // GET: /User/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id)
        {
            ViewBag.PossibleUserRoles = userroleRepository.All;
            return View(userRepository.Find(id));
        }

        //
        // POST: /User/Edit/5
        [UserAuthorize]
        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                if (Session["FileName"] != null)
                {
                    string physicalPath = MiscUtility.GetPhysicalFilePath(Constants.Paths.TemporaryFileUploadPath, Session["FileName"].ToString());
                    user.Photo = Utility.ReadFile(physicalPath);
                }
                userRepository.InsertOrUpdate(user);
                userRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleUserRoles = userroleRepository.All;
                return View(user);
            }
        }

        //
        // GET: /User/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(userRepository.Find(id));
        }

        //
        // POST: /User/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            userRepository.Delete(id);
            userRepository.Save();

            return RedirectToAction("Index");
        }

        public ActionResult LogOn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogOn(User user)
        {
            if (UserAuthentication.AuthenticateUser(user.UserLoginName, user.Password, true, userRepository))
            {
                string returnUrl = string.Empty;
                if (Request.UrlReferrer != null)
                {
                    returnUrl = Request.UrlReferrer.Query.Replace("?ReturnUrl=", string.Empty);
                    returnUrl = HttpUtility.UrlDecode(returnUrl);
                }
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { Area = string.Empty });
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            WebHelper.CurrentSession.Clear();
            return RedirectToAction("Index", "Home", new { Area = string.Empty });
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult ShowProfileIcon(int id)
        {
            User user = null;
            if (id == 0)
            {
                user = CurrentLoggedInUser;
            }
            else
            {
                user = userRepository.Find(id);
            }
            if (user.Photo!=null)
            {
                ImageResult result = new ImageResult(user.Photo, "image/jpeg");
                return result;
            }
            return null;
        }
    }
}

