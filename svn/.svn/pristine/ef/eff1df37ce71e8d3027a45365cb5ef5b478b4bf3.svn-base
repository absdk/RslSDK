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
    public class RequisitionClientInfoesController : Controller
    {
		private readonly IRequisitionRepository requisitionRepository;
		private readonly ICompanyRepository companyRepository;
		private readonly ISalaryRateTypeRepository salaryratetypeRepository;
		private readonly IRequisitionClientInfoRepository requisitionclientinfoRepository;
        public RequisitionClientInfoesController(IRequisitionRepository requisitionRepository, ICompanyRepository companyRepository, ISalaryRateTypeRepository salaryratetypeRepository, IRequisitionClientInfoRepository requisitionclientinfoRepository)
        {
			this.requisitionRepository = requisitionRepository;
			this.companyRepository = companyRepository;
			this.salaryratetypeRepository = salaryratetypeRepository;
			this.requisitionclientinfoRepository = requisitionclientinfoRepository;
        }

        //
        // GET: /RequisitionClientInfoes/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionclientinfoRepository.AllIncluding(requisitionclientinfo => requisitionclientinfo.Requisition, requisitionclientinfo => requisitionclientinfo.Company, requisitionclientinfo => requisitionclientinfo.SalaryRateType));
        }
		
		public ViewResult Search(RequisitionClientInfo searchRequisitionClientInfo)
        {
			if(searchRequisitionClientInfo!=null)
			{
							}
						return View("Index",requisitionclientinfoRepository.AllIncluding(requisitionclientinfo => requisitionclientinfo.Requisition, requisitionclientinfo => requisitionclientinfo.Company, requisitionclientinfo => requisitionclientinfo.SalaryRateType));
		}

        //
        // GET: /RequisitionClientInfoes/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionclientinfoRepository.Find(id));
        }

        //
        // GET: /RequisitionClientInfoes/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionClientInfo requisitionclientinfo = new RequisitionClientInfo();
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleCompanies = companyRepository.All;
			ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
            return View(requisitionclientinfo);
        } 

        //
        // POST: /RequisitionClientInfoes/Create
        [HttpPost]
        public ActionResult Create(RequisitionClientInfo requisitionclientinfo)
        {
            if (ModelState.IsValid) {
                requisitionclientinfoRepository.InsertOrUpdate(requisitionclientinfo);
                requisitionclientinfoRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleCompanies = companyRepository.All;
				ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
				return View(requisitionclientinfo);
			}
        }
        
        //
        // GET: /RequisitionClientInfoes/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleCompanies = companyRepository.All;
			ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
             return View(requisitionclientinfoRepository.Find(id));
        }

        //
        // POST: /RequisitionClientInfoes/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionClientInfo requisitionclientinfo)
        {
            if (ModelState.IsValid) {
                requisitionclientinfoRepository.InsertOrUpdate(requisitionclientinfo);
                requisitionclientinfoRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleCompanies = companyRepository.All;
				ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
				return View(requisitionclientinfo);
			}
        }

        //
        // GET: /RequisitionClientInfoes/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionclientinfoRepository.Find(id));
        }

        //
        // POST: /RequisitionClientInfoes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionclientinfoRepository.Delete(id);
            requisitionclientinfoRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

