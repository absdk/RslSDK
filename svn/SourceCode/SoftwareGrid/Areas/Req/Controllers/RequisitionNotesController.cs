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
    public class RequisitionNotesController : Controller
    {
		private readonly IRequisitionRepository requisitionRepository;
		private readonly IUserRepository userRepository;
		private readonly IRequisitionNoteRepository requisitionnoteRepository;
        public RequisitionNotesController(IRequisitionRepository requisitionRepository, IUserRepository userRepository, IRequisitionNoteRepository requisitionnoteRepository)
        {
			this.requisitionRepository = requisitionRepository;
			this.userRepository = userRepository;
			this.requisitionnoteRepository = requisitionnoteRepository;
        }

        //
        // GET: /RequisitionNotes/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionnoteRepository.AllIncluding(requisitionnote => requisitionnote.Requisition, requisitionnote => requisitionnote.User));
        }
		
		public ViewResult Search(RequisitionNote searchRequisitionNote)
        {
			if(searchRequisitionNote!=null)
			{
							}
						return View("Index",requisitionnoteRepository.AllIncluding(requisitionnote => requisitionnote.Requisition, requisitionnote => requisitionnote.User));
		}

        //
        // GET: /RequisitionNotes/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionnoteRepository.Find(id));
        }

        //
        // GET: /RequisitionNotes/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionNote requisitionnote = new RequisitionNote();
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleUsers = userRepository.All;
            return View(requisitionnote);
        } 

        //
        // POST: /RequisitionNotes/Create
        [HttpPost]
        public ActionResult Create(RequisitionNote requisitionnote)
        {
            if (ModelState.IsValid) {
                requisitionnoteRepository.InsertOrUpdate(requisitionnote);
                requisitionnoteRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleUsers = userRepository.All;
				return View(requisitionnote);
			}
        }
        
        //
        // GET: /RequisitionNotes/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleUsers = userRepository.All;
             return View(requisitionnoteRepository.Find(id));
        }

        //
        // POST: /RequisitionNotes/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionNote requisitionnote)
        {
            if (ModelState.IsValid) {
                requisitionnoteRepository.InsertOrUpdate(requisitionnote);
                requisitionnoteRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleUsers = userRepository.All;
				return View(requisitionnote);
			}
        }

        //
        // GET: /RequisitionNotes/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionnoteRepository.Find(id));
        }

        //
        // POST: /RequisitionNotes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionnoteRepository.Delete(id);
            requisitionnoteRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

