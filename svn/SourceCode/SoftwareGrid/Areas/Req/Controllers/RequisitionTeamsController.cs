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
namespace SoftwareGrid.Areas.Req.Controllers
{   
    public class RequisitionTeamsController : Controller
    {
		private readonly IRequisitionRepository requisitionRepository;
		private readonly IRequisitionTeamCategoryRepository requisitionteamcategoryRepository;
		private readonly IUserRepository userRepository;
		private readonly IRequisitionTeamRepository requisitionteamRepository;
        public RequisitionTeamsController(IRequisitionRepository requisitionRepository, IRequisitionTeamCategoryRepository requisitionteamcategoryRepository, IUserRepository userRepository, IRequisitionTeamRepository requisitionteamRepository)
        {
			this.requisitionRepository = requisitionRepository;
			this.requisitionteamcategoryRepository = requisitionteamcategoryRepository;
			this.userRepository = userRepository;
			this.requisitionteamRepository = requisitionteamRepository;
        }

        //
        // GET: /RequisitionTeams/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionteamRepository.AllIncluding(requisitionteam => requisitionteam.Requisition, requisitionteam => requisitionteam.RequisitionTeamCategory, requisitionteam => requisitionteam.RequisitionTeamUser));
        }
		
		public ViewResult Search(RequisitionTeam searchRequisitionTeam)
        {
			if(searchRequisitionTeam!=null)
			{
							}
						return View("Index",requisitionteamRepository.AllIncluding(requisitionteam => requisitionteam.Requisition, requisitionteam => requisitionteam.RequisitionTeamCategory, requisitionteam => requisitionteam.RequisitionTeamUser));
		}

        //
        // GET: /RequisitionTeams/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionteamRepository.Find(id));
        }

        //
        // GET: /RequisitionTeams/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionTeam requisitionteam = new RequisitionTeam();
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleRequisitionTeamCategories = requisitionteamcategoryRepository.All;
			ViewBag.PossibleRequisitionTeamUsers = userRepository.All;
            return View(requisitionteam);
        } 

        //
        // POST: /RequisitionTeams/Create
        [HttpPost]
        public ActionResult Create(RequisitionTeam requisitionteam)
        {
            if (ModelState.IsValid) {
                requisitionteamRepository.InsertOrUpdate(requisitionteam);
                requisitionteamRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleRequisitionTeamCategories = requisitionteamcategoryRepository.All;
				ViewBag.PossibleRequisitionTeamUsers = userRepository.All;
				return View(requisitionteam);
			}
        }
        
        //
        // GET: /RequisitionTeams/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleRequisitionTeamCategories = requisitionteamcategoryRepository.All;
			ViewBag.PossibleRequisitionTeamUsers = userRepository.All;
             return View(requisitionteamRepository.Find(id));
        }

        //
        // POST: /RequisitionTeams/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionTeam requisitionteam)
        {
            if (ModelState.IsValid) {
                requisitionteamRepository.InsertOrUpdate(requisitionteam);
                requisitionteamRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleRequisitionTeamCategories = requisitionteamcategoryRepository.All;
				ViewBag.PossibleRequisitionTeamUsers = userRepository.All;
				return View(requisitionteam);
			}
        }

        //
        // GET: /RequisitionTeams/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionteamRepository.Find(id));
        }

        //
        // POST: /RequisitionTeams/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionteamRepository.Delete(id);
            requisitionteamRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

