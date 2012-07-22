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
    public class OrganizationNoteController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationNoteCategoryRepository organizationnotecategoryRepository;
		private readonly IUserRepository userRepository;
		private readonly IOrganizationNoteRepository organizationnoteRepository;
        public OrganizationNoteController(IOrganizationRepository organizationRepository, IOrganizationNoteCategoryRepository organizationnotecategoryRepository, IUserRepository userRepository, IOrganizationNoteRepository organizationnoteRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationnotecategoryRepository = organizationnotecategoryRepository;
			this.userRepository = userRepository;
			this.organizationnoteRepository = organizationnoteRepository;
        }

        //
        // GET: /OrganizationNote/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationnoteRepository.AllIncluding(organizationId,organizationnote => organizationnote.Organization, organizationnote => organizationnote.OrganizationNoteCategory, organizationnote => organizationnote.WrittenByUser));
        }
		
		public ViewResult Search(OrganizationNote searchOrganizationNote,int organizationId)
        {
			if(searchOrganizationNote!=null)
			{
							}
						return View("Index",organizationnoteRepository.AllIncluding(organizationId,organizationnote => organizationnote.Organization, organizationnote => organizationnote.OrganizationNoteCategory, organizationnote => organizationnote.WrittenByUser));
		}

        //
        // GET: /OrganizationNote/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationnoteRepository.Find(id));
        }

        //
        // GET: /OrganizationNote/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationNote organizationnote = new OrganizationNote();
			organizationnote.OrganizationID = organizationId;
			ViewBag.PossibleOrganizationNoteCategories = organizationnotecategoryRepository.All;
            return View(organizationnote);
        } 

        //
        // POST: /OrganizationNote/Create
        [HttpPost]
        public ActionResult Create(OrganizationNote organizationnote,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationnoteRepository.InsertOrUpdate(organizationnote);
                organizationnoteRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				ViewBag.PossibleOrganizationNoteCategories = organizationnotecategoryRepository.All;
				return View(organizationnote);
			}
        }
        
        //
        // GET: /OrganizationNote/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationNote organizationnote = organizationnoteRepository.Find(id);
						ViewBag.PossibleOrganizationNoteCategories = organizationnotecategoryRepository.All;
             return View(organizationnote);
        }

        //
        // POST: /OrganizationNote/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationNote organizationnote,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationnoteRepository.InsertOrUpdate(organizationnote);
                organizationnoteRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
						ViewBag.PossibleOrganizationNoteCategories = organizationnotecategoryRepository.All;
				return View(organizationnote);
			}
        }

        //
        // GET: /OrganizationNote/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationnoteRepository.Find(id));
        }

        //
        // POST: /OrganizationNote/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationnoteRepository.Delete(id);
            organizationnoteRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

