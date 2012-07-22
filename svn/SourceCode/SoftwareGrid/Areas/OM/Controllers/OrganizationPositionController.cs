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
namespace SoftwareGrid.Areas.OM.Controllers
{   
    public class OrganizationPositionController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationBusinessDivisionRepository organizationbusinessdivisionRepository;
		private readonly IOrganizationDepartmentRepository organizationdepartmentRepository;
		private readonly IOrganizationPositionRepository organizationpositionRepository;
        public OrganizationPositionController(IOrganizationRepository organizationRepository, IOrganizationBusinessDivisionRepository organizationbusinessdivisionRepository, IOrganizationDepartmentRepository organizationdepartmentRepository, IOrganizationPositionRepository organizationpositionRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationbusinessdivisionRepository = organizationbusinessdivisionRepository;
			this.organizationdepartmentRepository = organizationdepartmentRepository;
			this.organizationpositionRepository = organizationpositionRepository;
        }

        //
        // GET: /OrganizationPosition/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationpositionRepository.AllIncluding(organizationId,organizationposition => organizationposition.Organization, organizationposition => organizationposition.OrganizationBusinessDivision, organizationposition => organizationposition.OrganizationDepartment));
        }
		
		public ViewResult Search(OrganizationPosition searchOrganizationPosition,int organizationId)
        {
			if(searchOrganizationPosition!=null)
			{
							}
						return View("Index",organizationpositionRepository.AllIncluding(organizationId,organizationposition => organizationposition.Organization, organizationposition => organizationposition.OrganizationBusinessDivision, organizationposition => organizationposition.OrganizationDepartment));
		}

        //
        // GET: /OrganizationPosition/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationpositionRepository.Find(id));
        }

        //
        // GET: /OrganizationPosition/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationPosition organizationposition = new OrganizationPosition();
			organizationposition.OrganizationID = organizationId;
			ViewBag.PossibleOrganizationBusinessDivisions = organizationbusinessdivisionRepository.All;
			ViewBag.PossibleOrganizationDepartments = organizationdepartmentRepository.All;
            return View(organizationposition);
        } 

        //
        // POST: /OrganizationPosition/Create
        [HttpPost]
        public ActionResult Create(OrganizationPosition organizationposition,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationpositionRepository.InsertOrUpdate(organizationposition);
                organizationpositionRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				ViewBag.PossibleOrganizationBusinessDivisions = organizationbusinessdivisionRepository.All;
				ViewBag.PossibleOrganizationDepartments = organizationdepartmentRepository.All;
				return View(organizationposition);
			}
        }
        
        //
        // GET: /OrganizationPosition/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationPosition organizationposition = organizationpositionRepository.Find(id);
						ViewBag.PossibleOrganizationBusinessDivisions = organizationbusinessdivisionRepository.All;
						ViewBag.PossibleOrganizationDepartments = organizationdepartmentRepository.All;
             return View(organizationposition);
        }

        //
        // POST: /OrganizationPosition/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationPosition organizationposition,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationpositionRepository.InsertOrUpdate(organizationposition);
                organizationpositionRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
						ViewBag.PossibleOrganizationBusinessDivisions = organizationbusinessdivisionRepository.All;
						ViewBag.PossibleOrganizationDepartments = organizationdepartmentRepository.All;
				return View(organizationposition);
			}
        }

        //
        // GET: /OrganizationPosition/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationpositionRepository.Find(id));
        }

        //
        // POST: /OrganizationPosition/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationpositionRepository.Delete(id);
            organizationpositionRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

