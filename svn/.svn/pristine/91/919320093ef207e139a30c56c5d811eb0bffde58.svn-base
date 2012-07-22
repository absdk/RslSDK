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
    public class OrganizationDocumentFolderController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationDocumentFolderRepository organizationdocumentfolderRepository;
		private readonly IUserRepository userRepository;
        public OrganizationDocumentFolderController(IOrganizationRepository organizationRepository, IOrganizationDocumentFolderRepository organizationdocumentfolderRepository, IUserRepository userRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationdocumentfolderRepository = organizationdocumentfolderRepository;
			this.userRepository = userRepository;
        }

        //
        // GET: /OrganizationDocumentFolder/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationdocumentfolderRepository.AllIncluding(organizationId,organizationdocumentfolder => organizationdocumentfolder.Organization, organizationdocumentfolder => organizationdocumentfolder.ParentFolder, organizationdocumentfolder => organizationdocumentfolder.CreatedByUser));
        }
		
		public ViewResult Search(OrganizationDocumentFolder searchOrganizationDocumentFolder,int organizationId)
        {
			if(searchOrganizationDocumentFolder!=null)
			{
							}
						return View("Index",organizationdocumentfolderRepository.AllIncluding(organizationId,organizationdocumentfolder => organizationdocumentfolder.Organization, organizationdocumentfolder => organizationdocumentfolder.ParentFolder, organizationdocumentfolder => organizationdocumentfolder.CreatedByUser));
		}

        //
        // GET: /OrganizationDocumentFolder/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationdocumentfolderRepository.Find(id));
        }

        //
        // GET: /OrganizationDocumentFolder/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationDocumentFolder organizationdocumentfolder = new OrganizationDocumentFolder();
			organizationdocumentfolder.OrganizationID = organizationId;
			ViewBag.PossibleParentFolders = organizationdocumentfolderRepository.All;
            return View(organizationdocumentfolder);
        } 

        //
        // POST: /OrganizationDocumentFolder/Create
        [HttpPost]
        public ActionResult Create(OrganizationDocumentFolder organizationdocumentfolder,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationdocumentfolderRepository.InsertOrUpdate(organizationdocumentfolder);
                organizationdocumentfolderRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				ViewBag.PossibleParentFolders = organizationdocumentfolderRepository.All;
				return View(organizationdocumentfolder);
			}
        }
        
        //
        // GET: /OrganizationDocumentFolder/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationDocumentFolder organizationdocumentfolder = organizationdocumentfolderRepository.Find(id);
						ViewBag.PossibleParentFolders = organizationdocumentfolderRepository.All;
             return View(organizationdocumentfolder);
        }

        //
        // POST: /OrganizationDocumentFolder/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationDocumentFolder organizationdocumentfolder,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationdocumentfolderRepository.InsertOrUpdate(organizationdocumentfolder);
                organizationdocumentfolderRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
						ViewBag.PossibleParentFolders = organizationdocumentfolderRepository.All;
				return View(organizationdocumentfolder);
			}
        }

        //
        // GET: /OrganizationDocumentFolder/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationdocumentfolderRepository.Find(id));
        }

        //
        // POST: /OrganizationDocumentFolder/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationdocumentfolderRepository.Delete(id);
            organizationdocumentfolderRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

