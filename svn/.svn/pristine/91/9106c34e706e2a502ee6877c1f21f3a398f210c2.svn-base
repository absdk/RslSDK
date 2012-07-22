//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  http://www.softwaregrid.com
//
//*********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.BusinessLogic.Helpers;
namespace SoftwareGrid.Areas.MasterData.Controllers
{   
    public class BloodGroupsController : Controller
    {
		private readonly IBloodGroupRepository bloodgroupRepository;
        public BloodGroupsController(IBloodGroupRepository bloodgroupRepository)
        {
			this.bloodgroupRepository = bloodgroupRepository;
        }

        //
        // GET: /BloodGroups/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(bloodgroupRepository.All);
        }
		
		public ViewResult Search(BloodGroup searchBloodGroup)
        {
			if(searchBloodGroup!=null)
			{
							}
						return View("Index",bloodgroupRepository.All);
		}

        //
        // GET: /BloodGroups/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(bloodgroupRepository.Find(id));
        }

        //
        // GET: /BloodGroups/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			BloodGroup bloodgroup = new BloodGroup();
            return View(bloodgroup);
        } 

        //
        // POST: /BloodGroups/Create
        [HttpPost]
        public ActionResult Create(BloodGroup bloodgroup)
        {
            if (ModelState.IsValid) {
                bloodgroupRepository.InsertOrUpdate(bloodgroup);
                bloodgroupRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(bloodgroup);
			}
        }
        
        //
        // GET: /BloodGroups/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(bloodgroupRepository.Find(id));
        }

        //
        // POST: /BloodGroups/Edit/5
        [HttpPost]
        public ActionResult Edit(BloodGroup bloodgroup)
        {
            if (ModelState.IsValid) {
                bloodgroupRepository.InsertOrUpdate(bloodgroup);
                bloodgroupRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(bloodgroup);
			}
        }

        //
        // GET: /BloodGroups/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(bloodgroupRepository.Find(id));
        }

        //
        // POST: /BloodGroups/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            bloodgroupRepository.Delete(id);
            bloodgroupRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

