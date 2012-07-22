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
    public class RequisitionOrganizationsController : Controller
    {
		private readonly IRequisitionRepository requisitionRepository;
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationProjectRepository organizationprojectRepository;
		private readonly IOrganizationDepartmentRepository organizationdepartmentRepository;
		private readonly IOrganizationPositionRepository organizationpositionRepository;
		private readonly IRequisitionOrganizationRepository requisitionorganizationRepository;
        public RequisitionOrganizationsController(IRequisitionRepository requisitionRepository, IOrganizationRepository organizationRepository, IOrganizationProjectRepository organizationprojectRepository, IOrganizationDepartmentRepository organizationdepartmentRepository, IOrganizationPositionRepository organizationpositionRepository, IRequisitionOrganizationRepository requisitionorganizationRepository)
        {
			this.requisitionRepository = requisitionRepository;
			this.organizationRepository = organizationRepository;
			this.organizationprojectRepository = organizationprojectRepository;
			this.organizationdepartmentRepository = organizationdepartmentRepository;
			this.organizationpositionRepository = organizationpositionRepository;
			this.requisitionorganizationRepository = requisitionorganizationRepository;
        }

        //
        // GET: /RequisitionOrganizations/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionorganizationRepository.AllIncluding(requisitionorganization => requisitionorganization.Requisition, requisitionorganization => requisitionorganization.Organization, requisitionorganization => requisitionorganization.OrganizationProject, requisitionorganization => requisitionorganization.OrganizationDepartment, requisitionorganization => requisitionorganization.OrganizationPosition));
        }
		
		public ViewResult Search(RequisitionOrganization searchRequisitionOrganization)
        {
			if(searchRequisitionOrganization!=null)
			{
							}
						return View("Index",requisitionorganizationRepository.AllIncluding(requisitionorganization => requisitionorganization.Requisition, requisitionorganization => requisitionorganization.Organization, requisitionorganization => requisitionorganization.OrganizationProject, requisitionorganization => requisitionorganization.OrganizationDepartment, requisitionorganization => requisitionorganization.OrganizationPosition));
		}

        //
        // GET: /RequisitionOrganizations/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionorganizationRepository.Find(id));
        }

        //
        // GET: /RequisitionOrganizations/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionOrganization requisitionorganization = new RequisitionOrganization();
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleOrganizations = organizationRepository.All;
			ViewBag.PossibleOrganizationProjects = organizationprojectRepository.All;
			ViewBag.PossibleOrganizationDepartments = organizationdepartmentRepository.All;
			ViewBag.PossibleOrganizationPositions = organizationpositionRepository.All;
            return View(requisitionorganization);
        } 

        //
        // POST: /RequisitionOrganizations/Create
        [HttpPost]
        public ActionResult Create(RequisitionOrganization requisitionorganization)
        {
            if (ModelState.IsValid) {
                requisitionorganizationRepository.InsertOrUpdate(requisitionorganization);
                requisitionorganizationRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleOrganizations = organizationRepository.All;
				ViewBag.PossibleOrganizationProjects = organizationprojectRepository.All;
				ViewBag.PossibleOrganizationDepartments = organizationdepartmentRepository.All;
				ViewBag.PossibleOrganizationPositions = organizationpositionRepository.All;
				return View(requisitionorganization);
			}
        }
        
        //
        // GET: /RequisitionOrganizations/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleOrganizations = organizationRepository.All;
			ViewBag.PossibleOrganizationProjects = organizationprojectRepository.All;
			ViewBag.PossibleOrganizationDepartments = organizationdepartmentRepository.All;
			ViewBag.PossibleOrganizationPositions = organizationpositionRepository.All;
             return View(requisitionorganizationRepository.Find(id));
        }

        //
        // POST: /RequisitionOrganizations/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionOrganization requisitionorganization)
        {
            if (ModelState.IsValid) {
                requisitionorganizationRepository.InsertOrUpdate(requisitionorganization);
                requisitionorganizationRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleOrganizations = organizationRepository.All;
				ViewBag.PossibleOrganizationProjects = organizationprojectRepository.All;
				ViewBag.PossibleOrganizationDepartments = organizationdepartmentRepository.All;
				ViewBag.PossibleOrganizationPositions = organizationpositionRepository.All;
				return View(requisitionorganization);
			}
        }

        //
        // GET: /RequisitionOrganizations/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionorganizationRepository.Find(id));
        }

        //
        // POST: /RequisitionOrganizations/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionorganizationRepository.Delete(id);
            requisitionorganizationRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

