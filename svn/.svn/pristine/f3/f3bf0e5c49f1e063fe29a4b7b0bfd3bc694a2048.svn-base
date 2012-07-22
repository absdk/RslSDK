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
    public class RequisitionDocumentsController : Controller
    {
		private readonly IRequisitionRepository requisitionRepository;
		private readonly IRequisitionDocumentRepository requisitiondocumentRepository;
        public RequisitionDocumentsController(IRequisitionRepository requisitionRepository, IRequisitionDocumentRepository requisitiondocumentRepository)
        {
			this.requisitionRepository = requisitionRepository;
			this.requisitiondocumentRepository = requisitiondocumentRepository;
        }

        //
        // GET: /RequisitionDocuments/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitiondocumentRepository.AllIncluding(requisitiondocument => requisitiondocument.Requisition));
        }
		
		public ViewResult Search(RequisitionDocument searchRequisitionDocument)
        {
			if(searchRequisitionDocument!=null)
			{
							}
						return View("Index",requisitiondocumentRepository.AllIncluding(requisitiondocument => requisitiondocument.Requisition));
		}

        //
        // GET: /RequisitionDocuments/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitiondocumentRepository.Find(id));
        }

        //
        // GET: /RequisitionDocuments/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionDocument requisitiondocument = new RequisitionDocument();
			ViewBag.PossibleRequisitions = requisitionRepository.All;
            return View(requisitiondocument);
        } 

        //
        // POST: /RequisitionDocuments/Create
        [HttpPost]
        public ActionResult Create(RequisitionDocument requisitiondocument)
        {
            if (ModelState.IsValid) {
                requisitiondocumentRepository.InsertOrUpdate(requisitiondocument);
                requisitiondocumentRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				return View(requisitiondocument);
			}
        }
        
        //
        // GET: /RequisitionDocuments/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleRequisitions = requisitionRepository.All;
             return View(requisitiondocumentRepository.Find(id));
        }

        //
        // POST: /RequisitionDocuments/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionDocument requisitiondocument)
        {
            if (ModelState.IsValid) {
                requisitiondocumentRepository.InsertOrUpdate(requisitiondocument);
                requisitiondocumentRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				return View(requisitiondocument);
			}
        }

        //
        // GET: /RequisitionDocuments/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitiondocumentRepository.Find(id));
        }

        //
        // POST: /RequisitionDocuments/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitiondocumentRepository.Delete(id);
            requisitiondocumentRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

