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

namespace SoftwareGrid.Areas.UM.Controllers
{   
    public class UserRoleController : UserBaseController
    {
		private readonly IUserRoleRepository userroleRepository;
        public UserRoleController(IUserRoleRepository userroleRepository)
        {
			this.userroleRepository = userroleRepository;
        }

        //
        // GET: /UserRole/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(userroleRepository.All);
        }
		
		public ViewResult Search(UserRole searchUserRole)
        {
			if(searchUserRole!=null)
			{
							}
						return View("Index",userroleRepository.All);
		}

        //
        // GET: /UserRole/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(userroleRepository.Find(id));
        }

        //
        // GET: /UserRole/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			UserRole userrole = new UserRole();
            return View(userrole);
        } 

        //
        // POST: /UserRole/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(UserRole userrole)
        {
            if (ModelState.IsValid) {
                userroleRepository.InsertOrUpdate(userrole);
                userroleRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(userrole);
			}
        }
        
        //
        // GET: /UserRole/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(userroleRepository.Find(id));
        }

        //
        // POST: /UserRole/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(UserRole userrole)
        {
            if (ModelState.IsValid) {
                userroleRepository.InsertOrUpdate(userrole);
                userroleRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(userrole);
			}
        }

        //
        // GET: /UserRole/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(userroleRepository.Find(id));
        }

        //
        // POST: /UserRole/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            userroleRepository.Delete(id);
            userroleRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

