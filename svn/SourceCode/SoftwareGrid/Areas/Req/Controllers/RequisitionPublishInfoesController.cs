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
    public class RequisitionPublishInfoesController : Controller
    {
		private readonly IRequisitionRepository requisitionRepository;
		private readonly IRequisitionPublishInfoRepository requisitionpublishinfoRepository;
        public RequisitionPublishInfoesController(IRequisitionRepository requisitionRepository, IRequisitionPublishInfoRepository requisitionpublishinfoRepository)
        {
			this.requisitionRepository = requisitionRepository;
			this.requisitionpublishinfoRepository = requisitionpublishinfoRepository;
        }

        //
        // GET: /RequisitionPublishInfoes/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionpublishinfoRepository.AllIncluding(requisitionpublishinfo => requisitionpublishinfo.Requisition));
        }
		
		public ViewResult Search(RequisitionPublishInfo searchRequisitionPublishInfo)
        {
			if(searchRequisitionPublishInfo!=null)
			{
							}
						return View("Index",requisitionpublishinfoRepository.AllIncluding(requisitionpublishinfo => requisitionpublishinfo.Requisition));
		}

        //
        // GET: /RequisitionPublishInfoes/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionpublishinfoRepository.Find(id));
        }

        //
        // GET: /RequisitionPublishInfoes/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionPublishInfo requisitionpublishinfo = new RequisitionPublishInfo();
			ViewBag.PossibleRequisitions = requisitionRepository.All;
            return View(requisitionpublishinfo);
        } 

        //
        // POST: /RequisitionPublishInfoes/Create
        [HttpPost]
        public ActionResult Create(RequisitionPublishInfo requisitionpublishinfo)
        {
            if (ModelState.IsValid) {
                requisitionpublishinfoRepository.InsertOrUpdate(requisitionpublishinfo);
                requisitionpublishinfoRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				return View(requisitionpublishinfo);
			}
        }
        
        //
        // GET: /RequisitionPublishInfoes/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleRequisitions = requisitionRepository.All;
             return View(requisitionpublishinfoRepository.Find(id));
        }

        //
        // POST: /RequisitionPublishInfoes/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionPublishInfo requisitionpublishinfo)
        {
            if (ModelState.IsValid) {
                requisitionpublishinfoRepository.InsertOrUpdate(requisitionpublishinfo);
                requisitionpublishinfoRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				return View(requisitionpublishinfo);
			}
        }

        //
        // GET: /RequisitionPublishInfoes/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionpublishinfoRepository.Find(id));
        }

        //
        // POST: /RequisitionPublishInfoes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionpublishinfoRepository.Delete(id);
            requisitionpublishinfoRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

