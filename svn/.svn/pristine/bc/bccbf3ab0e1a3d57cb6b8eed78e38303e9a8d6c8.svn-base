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
    public class RequisitionClientTeamsController : Controller
    {
		private readonly IRequisitionClientInfoRepository requisitionclientinfoRepository;
		private readonly IContactRepository contactRepository;
		private readonly IRequisitionClientTeamRepository requisitionclientteamRepository;
        public RequisitionClientTeamsController(IRequisitionClientInfoRepository requisitionclientinfoRepository, IContactRepository contactRepository, IRequisitionClientTeamRepository requisitionclientteamRepository)
        {
			this.requisitionclientinfoRepository = requisitionclientinfoRepository;
			this.contactRepository = contactRepository;
			this.requisitionclientteamRepository = requisitionclientteamRepository;
        }

        //
        // GET: /RequisitionClientTeams/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionclientteamRepository.AllIncluding(requisitionclientteam => requisitionclientteam.RequisitionClientInfo, requisitionclientteam => requisitionclientteam.Contact));
        }
		
		public ViewResult Search(RequisitionClientTeam searchRequisitionClientTeam)
        {
			if(searchRequisitionClientTeam!=null)
			{
							}
						return View("Index",requisitionclientteamRepository.AllIncluding(requisitionclientteam => requisitionclientteam.RequisitionClientInfo, requisitionclientteam => requisitionclientteam.Contact));
		}

        //
        // GET: /RequisitionClientTeams/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionclientteamRepository.Find(id));
        }

        //
        // GET: /RequisitionClientTeams/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionClientTeam requisitionclientteam = new RequisitionClientTeam();
			ViewBag.PossibleRequisitionClientInfoes = requisitionclientinfoRepository.All;
			ViewBag.PossibleContacts = contactRepository.All;
            return View(requisitionclientteam);
        } 

        //
        // POST: /RequisitionClientTeams/Create
        [HttpPost]
        public ActionResult Create(RequisitionClientTeam requisitionclientteam)
        {
            if (ModelState.IsValid) {
                requisitionclientteamRepository.InsertOrUpdate(requisitionclientteam);
                requisitionclientteamRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitionClientInfoes = requisitionclientinfoRepository.All;
				ViewBag.PossibleContacts = contactRepository.All;
				return View(requisitionclientteam);
			}
        }
        
        //
        // GET: /RequisitionClientTeams/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleRequisitionClientInfoes = requisitionclientinfoRepository.All;
			ViewBag.PossibleContacts = contactRepository.All;
             return View(requisitionclientteamRepository.Find(id));
        }

        //
        // POST: /RequisitionClientTeams/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionClientTeam requisitionclientteam)
        {
            if (ModelState.IsValid) {
                requisitionclientteamRepository.InsertOrUpdate(requisitionclientteam);
                requisitionclientteamRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitionClientInfoes = requisitionclientinfoRepository.All;
				ViewBag.PossibleContacts = contactRepository.All;
				return View(requisitionclientteam);
			}
        }

        //
        // GET: /RequisitionClientTeams/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionclientteamRepository.Find(id));
        }

        //
        // POST: /RequisitionClientTeams/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionclientteamRepository.Delete(id);
            requisitionclientteamRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

