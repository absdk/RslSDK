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
    public class OrganizationWorkforcePlanController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationWorkforcePlanRepository organizationworkforceplanRepository;
        public OrganizationWorkforcePlanController(IOrganizationRepository organizationRepository, IOrganizationWorkforcePlanRepository organizationworkforceplanRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationworkforceplanRepository = organizationworkforceplanRepository;
        }

        //
        // GET: /OrganizationWorkforcePlan/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationworkforceplanRepository.AllIncluding(organizationId,organizationworkforceplan => organizationworkforceplan.Organization));
        }
		
		public ViewResult Search(OrganizationWorkforcePlan searchOrganizationWorkforcePlan,int organizationId)
        {
			if(searchOrganizationWorkforcePlan!=null)
			{
							}
						return View("Index",organizationworkforceplanRepository.AllIncluding(organizationId,organizationworkforceplan => organizationworkforceplan.Organization));
		}

        //
        // GET: /OrganizationWorkforcePlan/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationworkforceplanRepository.Find(id));
        }

        //
        // GET: /OrganizationWorkforcePlan/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationWorkforcePlan organizationworkforceplan = new OrganizationWorkforcePlan();
			organizationworkforceplan.OrganizationID = organizationId;
            return View(organizationworkforceplan);
        } 

        //
        // POST: /OrganizationWorkforcePlan/Create
        [HttpPost]
        public ActionResult Create(OrganizationWorkforcePlan organizationworkforceplan,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationworkforceplanRepository.InsertOrUpdate(organizationworkforceplan);
                organizationworkforceplanRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				return View(organizationworkforceplan);
			}
        }
        
        //
        // GET: /OrganizationWorkforcePlan/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationWorkforcePlan organizationworkforceplan = organizationworkforceplanRepository.Find(id);
             return View(organizationworkforceplan);
        }

        //
        // POST: /OrganizationWorkforcePlan/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationWorkforcePlan organizationworkforceplan,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationworkforceplanRepository.InsertOrUpdate(organizationworkforceplan);
                organizationworkforceplanRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				return View(organizationworkforceplan);
			}
        }

        //
        // GET: /OrganizationWorkforcePlan/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationworkforceplanRepository.Find(id));
        }

        //
        // POST: /OrganizationWorkforcePlan/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationworkforceplanRepository.Delete(id);
            organizationworkforceplanRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

