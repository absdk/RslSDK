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
    public class OrganizationDocumentController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationDocumentFolderRepository organizationdocumentfolderRepository;
		private readonly IOrganizationDocumentCategoryRepository organizationdocumentcategoryRepository;
		private readonly IOrganizationDocumentRepository organizationdocumentRepository;
        public OrganizationDocumentController(IOrganizationRepository organizationRepository, IOrganizationDocumentFolderRepository organizationdocumentfolderRepository, IOrganizationDocumentCategoryRepository organizationdocumentcategoryRepository, IOrganizationDocumentRepository organizationdocumentRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationdocumentfolderRepository = organizationdocumentfolderRepository;
			this.organizationdocumentcategoryRepository = organizationdocumentcategoryRepository;
			this.organizationdocumentRepository = organizationdocumentRepository;
        }

        //
        // GET: /OrganizationDocument/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationdocumentRepository.AllIncluding(organizationId,organizationdocument => organizationdocument.Organization, organizationdocument => organizationdocument.OrganizationDocumentFolder, organizationdocument => organizationdocument.OrganizationDocumentCategory));
        }
		
		public ViewResult Search(OrganizationDocument searchOrganizationDocument,int organizationId)
        {
			if(searchOrganizationDocument!=null)
			{
							}
						return View("Index",organizationdocumentRepository.AllIncluding(organizationId,organizationdocument => organizationdocument.Organization, organizationdocument => organizationdocument.OrganizationDocumentFolder, organizationdocument => organizationdocument.OrganizationDocumentCategory));
		}

        //
        // GET: /OrganizationDocument/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationdocumentRepository.Find(id));
        }

        //
        // GET: /OrganizationDocument/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationDocument organizationdocument = new OrganizationDocument();
			organizationdocument.OrganizationID = organizationId;
			ViewBag.PossibleOrganizationDocumentFolders = organizationdocumentfolderRepository.All;
			ViewBag.PossibleOrganizationDocumentCategories = organizationdocumentcategoryRepository.All;
            return View(organizationdocument);
        } 

        //
        // POST: /OrganizationDocument/Create
        [HttpPost]
        public ActionResult Create(OrganizationDocument organizationdocument,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationdocumentRepository.InsertOrUpdate(organizationdocument);
                organizationdocumentRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				ViewBag.PossibleOrganizationDocumentFolders = organizationdocumentfolderRepository.All;
				ViewBag.PossibleOrganizationDocumentCategories = organizationdocumentcategoryRepository.All;
				return View(organizationdocument);
			}
        }
        
        //
        // GET: /OrganizationDocument/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationDocument organizationdocument = organizationdocumentRepository.Find(id);
						ViewBag.PossibleOrganizationDocumentFolders = organizationdocumentfolderRepository.All;
						ViewBag.PossibleOrganizationDocumentCategories = organizationdocumentcategoryRepository.All;
             return View(organizationdocument);
        }

        //
        // POST: /OrganizationDocument/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationDocument organizationdocument,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationdocumentRepository.InsertOrUpdate(organizationdocument);
                organizationdocumentRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
						ViewBag.PossibleOrganizationDocumentFolders = organizationdocumentfolderRepository.All;
						ViewBag.PossibleOrganizationDocumentCategories = organizationdocumentcategoryRepository.All;
				return View(organizationdocument);
			}
        }

        //
        // GET: /OrganizationDocument/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationdocumentRepository.Find(id));
        }

        //
        // POST: /OrganizationDocument/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationdocumentRepository.Delete(id);
            organizationdocumentRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

