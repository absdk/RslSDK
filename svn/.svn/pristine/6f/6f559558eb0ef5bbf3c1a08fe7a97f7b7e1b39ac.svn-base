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
    public class OrganizationDepartmentController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationBusinessDivisionRepository organizationbusinessdivisionRepository;
		private readonly IOrganizationDepartmentRepository organizationdepartmentRepository;
        public OrganizationDepartmentController(IOrganizationRepository organizationRepository, IOrganizationBusinessDivisionRepository organizationbusinessdivisionRepository, IOrganizationDepartmentRepository organizationdepartmentRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationbusinessdivisionRepository = organizationbusinessdivisionRepository;
			this.organizationdepartmentRepository = organizationdepartmentRepository;
        }

        //
        // GET: /OrganizationDepartment/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationdepartmentRepository.AllIncluding(organizationId,organizationdepartment => organizationdepartment.Organization, organizationdepartment => organizationdepartment.OrganizationBusinessDivision, organizationdepartment => organizationdepartment.ParentDepartment));
        }
		
		public ViewResult Search(OrganizationDepartment searchOrganizationDepartment,int organizationId)
        {
			if(searchOrganizationDepartment!=null)
			{
							}
						return View("Index",organizationdepartmentRepository.AllIncluding(organizationId,organizationdepartment => organizationdepartment.Organization, organizationdepartment => organizationdepartment.OrganizationBusinessDivision, organizationdepartment => organizationdepartment.ParentDepartment));
		}

        //
        // GET: /OrganizationDepartment/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationdepartmentRepository.Find(id));
        }

        //
        // GET: /OrganizationDepartment/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationDepartment organizationdepartment = new OrganizationDepartment();
			organizationdepartment.OrganizationID = organizationId;
			ViewBag.PossibleOrganizationBusinessDivisions = organizationbusinessdivisionRepository.All;
			ViewBag.PossibleParentDepartments = organizationdepartmentRepository.All;
            return View(organizationdepartment);
        } 

        //
        // POST: /OrganizationDepartment/Create
        [HttpPost]
        public ActionResult Create(OrganizationDepartment organizationdepartment,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationdepartmentRepository.InsertOrUpdate(organizationdepartment);
                organizationdepartmentRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				ViewBag.PossibleOrganizationBusinessDivisions = organizationbusinessdivisionRepository.All;
				ViewBag.PossibleParentDepartments = organizationdepartmentRepository.All;
				return View(organizationdepartment);
			}
        }
        
        //
        // GET: /OrganizationDepartment/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationDepartment organizationdepartment = organizationdepartmentRepository.Find(id);
						ViewBag.PossibleOrganizationBusinessDivisions = organizationbusinessdivisionRepository.All;
						ViewBag.PossibleParentDepartments = organizationdepartmentRepository.All;
             return View(organizationdepartment);
        }

        //
        // POST: /OrganizationDepartment/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationDepartment organizationdepartment,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationdepartmentRepository.InsertOrUpdate(organizationdepartment);
                organizationdepartmentRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
						ViewBag.PossibleOrganizationBusinessDivisions = organizationbusinessdivisionRepository.All;
						ViewBag.PossibleParentDepartments = organizationdepartmentRepository.All;
				return View(organizationdepartment);
			}
        }

        //
        // GET: /OrganizationDepartment/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationdepartmentRepository.Find(id));
        }

        //
        // POST: /OrganizationDepartment/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationdepartmentRepository.Delete(id);
            organizationdepartmentRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

