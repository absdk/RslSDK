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
    public class RequisitionInterviewTypesController : Controller
    {
		private readonly IRequisitionInterviewTypeRepository requisitioninterviewtypeRepository;
        public RequisitionInterviewTypesController(IRequisitionInterviewTypeRepository requisitioninterviewtypeRepository)
        {
			this.requisitioninterviewtypeRepository = requisitioninterviewtypeRepository;
        }

        //
        // GET: /RequisitionInterviewTypes/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitioninterviewtypeRepository.All);
        }
		
		public ViewResult Search(RequisitionInterviewType searchRequisitionInterviewType)
        {
			if(searchRequisitionInterviewType!=null)
			{
							}
						return View("Index",requisitioninterviewtypeRepository.All);
		}

        //
        // GET: /RequisitionInterviewTypes/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitioninterviewtypeRepository.Find(id));
        }

        //
        // GET: /RequisitionInterviewTypes/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionInterviewType requisitioninterviewtype = new RequisitionInterviewType();
            return View(requisitioninterviewtype);
        } 

        //
        // POST: /RequisitionInterviewTypes/Create
        [HttpPost]
        public ActionResult Create(RequisitionInterviewType requisitioninterviewtype)
        {
            if (ModelState.IsValid) {
                requisitioninterviewtypeRepository.InsertOrUpdate(requisitioninterviewtype);
                requisitioninterviewtypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitioninterviewtype);
			}
        }
        
        //
        // GET: /RequisitionInterviewTypes/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(requisitioninterviewtypeRepository.Find(id));
        }

        //
        // POST: /RequisitionInterviewTypes/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionInterviewType requisitioninterviewtype)
        {
            if (ModelState.IsValid) {
                requisitioninterviewtypeRepository.InsertOrUpdate(requisitioninterviewtype);
                requisitioninterviewtypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(requisitioninterviewtype);
			}
        }

        //
        // GET: /RequisitionInterviewTypes/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitioninterviewtypeRepository.Find(id));
        }

        //
        // POST: /RequisitionInterviewTypes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitioninterviewtypeRepository.Delete(id);
            requisitioninterviewtypeRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

