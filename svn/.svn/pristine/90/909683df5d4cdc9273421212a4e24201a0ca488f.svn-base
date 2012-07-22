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
    public class OrganizationBusinessDivisionController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationBusinessDivisionRepository organizationbusinessdivisionRepository;
        public OrganizationBusinessDivisionController(IOrganizationRepository organizationRepository, IOrganizationBusinessDivisionRepository organizationbusinessdivisionRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationbusinessdivisionRepository = organizationbusinessdivisionRepository;
        }

        //
        // GET: /OrganizationBusinessDivision/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationbusinessdivisionRepository.AllIncluding(organizationId,organizationbusinessdivision => organizationbusinessdivision.Organization));
        }
		
		public ViewResult Search(OrganizationBusinessDivision searchOrganizationBusinessDivision,int organizationId)
        {
			if(searchOrganizationBusinessDivision!=null)
			{
							}
						return View("Index",organizationbusinessdivisionRepository.AllIncluding(organizationId,organizationbusinessdivision => organizationbusinessdivision.Organization));
		}

        //
        // GET: /OrganizationBusinessDivision/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationbusinessdivisionRepository.Find(id));
        }

        //
        // GET: /OrganizationBusinessDivision/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationBusinessDivision organizationbusinessdivision = new OrganizationBusinessDivision();
			organizationbusinessdivision.OrganizationID = organizationId;
            return View(organizationbusinessdivision);
        } 

        //
        // POST: /OrganizationBusinessDivision/Create
        [HttpPost]
        public ActionResult Create(OrganizationBusinessDivision organizationbusinessdivision,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationbusinessdivisionRepository.InsertOrUpdate(organizationbusinessdivision);
                organizationbusinessdivisionRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				return View(organizationbusinessdivision);
			}
        }
        
        //
        // GET: /OrganizationBusinessDivision/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationBusinessDivision organizationbusinessdivision = organizationbusinessdivisionRepository.Find(id);
             return View(organizationbusinessdivision);
        }

        //
        // POST: /OrganizationBusinessDivision/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationBusinessDivision organizationbusinessdivision,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationbusinessdivisionRepository.InsertOrUpdate(organizationbusinessdivision);
                organizationbusinessdivisionRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				return View(organizationbusinessdivision);
			}
        }

        //
        // GET: /OrganizationBusinessDivision/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationbusinessdivisionRepository.Find(id));
        }

        //
        // POST: /OrganizationBusinessDivision/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationbusinessdivisionRepository.Delete(id);
            organizationbusinessdivisionRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

