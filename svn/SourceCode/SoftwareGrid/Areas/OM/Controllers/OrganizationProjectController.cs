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
    public class OrganizationProjectController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationProjectRepository organizationprojectRepository;
        public OrganizationProjectController(IOrganizationRepository organizationRepository, IOrganizationProjectRepository organizationprojectRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationprojectRepository = organizationprojectRepository;
        }

        //
        // GET: /OrganizationProject/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationprojectRepository.AllIncluding(organizationId,organizationproject => organizationproject.Organization));
        }
		
		public ViewResult Search(OrganizationProject searchOrganizationProject,int organizationId)
        {
			if(searchOrganizationProject!=null)
			{
							}
						return View("Index",organizationprojectRepository.AllIncluding(organizationId,organizationproject => organizationproject.Organization));
		}

        //
        // GET: /OrganizationProject/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationprojectRepository.Find(id));
        }

        //
        // GET: /OrganizationProject/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationProject organizationproject = new OrganizationProject();
			organizationproject.OrganizationID = organizationId;
            return View(organizationproject);
        } 

        //
        // POST: /OrganizationProject/Create
        [HttpPost]
        public ActionResult Create(OrganizationProject organizationproject,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationprojectRepository.InsertOrUpdate(organizationproject);
                organizationprojectRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				return View(organizationproject);
			}
        }
        
        //
        // GET: /OrganizationProject/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationProject organizationproject = organizationprojectRepository.Find(id);
             return View(organizationproject);
        }

        //
        // POST: /OrganizationProject/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationProject organizationproject,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationprojectRepository.InsertOrUpdate(organizationproject);
                organizationprojectRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				return View(organizationproject);
			}
        }

        //
        // GET: /OrganizationProject/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationprojectRepository.Find(id));
        }

        //
        // POST: /OrganizationProject/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationprojectRepository.Delete(id);
            organizationprojectRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

