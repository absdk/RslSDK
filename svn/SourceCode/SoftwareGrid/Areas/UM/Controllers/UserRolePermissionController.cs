//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  http://www.softwaregrid.com
//
//*********************************************************

using System.Linq;
using System.Web.Mvc;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.Areas.UM.Controllers
{
    public class UserRolePermissionController : UserBaseController
    {
        private readonly IUserRoleRepository userroleRepository;
        private readonly IUserRolePermissionRepository userrolepermissionRepository;
        public UserRolePermissionController(IUserRoleRepository userroleRepository, IUserRolePermissionRepository userrolepermissionRepository)
        {
            this.userroleRepository = userroleRepository;
            this.userrolepermissionRepository = userrolepermissionRepository;
        }

        //
        // GET: /UserRolePermission/
        [UserAuthorize]
        public ViewResult Index()
        {
            ViewBag.RoleList = userroleRepository.All.ToList();
            return View(userrolepermissionRepository.AllForEditor);
        }

        public ViewResult Search(UserRolePermission searchUserRolePermission)
        {
            if (searchUserRolePermission != null)
            {
            }
            return View("Index", userrolepermissionRepository.AllIncluding(userrolepermission => userrolepermission.UserRole));
        }

        //
        // GET: /UserRolePermission/Details/5
        [UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(userrolepermissionRepository.Find(id));
        }

        //
        // GET: /UserRolePermission/Create
        [UserAuthorize]
        public ActionResult Create()
        {
            UserRolePermission userrolepermission = new UserRolePermission();
            ViewBag.PossibleUserRoles = userroleRepository.All;
            return View(userrolepermission);
        }

        //
        // POST: /UserRolePermission/Create
        [UserAuthorize]
        [HttpPost]
        public ActionResult Create(string chkUserRolePermission)
        {
            //2+AppBuilder+AppMenu+Index,3+AppBuilder+AppMenu+Index,4+AppBuilder+AppMenu+Index,2+AppBuilder+AppMenu+Search,1+OM+OrganizationAddressCategory+Create,2+OM+OrganizationAddressCategory+Create,3+OM+OrganizationAddressCategory+Create,4+OM+OrganizationAddressCategory+Create,5+OM+OrganizationAddressCategory+Create
            userrolepermissionRepository.InsertOrUpdate(Request.Form[0], userroleRepository.All.ToList());
            userrolepermissionRepository.Save();
            return RedirectToAction("Index");
        }

        //
        // GET: /UserRolePermission/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id)
        {
            ViewBag.PossibleUserRoles = userroleRepository.All;
            return View(userrolepermissionRepository.Find(id));
        }

        //
        // POST: /UserRolePermission/Edit/5
        [UserAuthorize]
        [HttpPost]
        public ActionResult Edit(UserRolePermission userrolepermission)
        {
            if (ModelState.IsValid)
            {
                userrolepermissionRepository.InsertOrUpdate(userrolepermission);
                userrolepermissionRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleUserRoles = userroleRepository.All;
                return View(userrolepermission);
            }
        }

        //
        // GET: /UserRolePermission/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(userrolepermissionRepository.Find(id));
        }

        //
        // POST: /UserRolePermission/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            userrolepermissionRepository.Delete(id);
            userrolepermissionRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

