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
namespace SoftwareGrid.Areas.CRM.Controllers
{   
    public class ContactFolderContactsController : Controller
    {
		private readonly IContactFolderRepository contactfolderRepository;
		private readonly ICompanyRepository companyRepository;
		private readonly IContactRepository contactRepository;
		private readonly IContactFolderContactRepository contactfoldercontactRepository;
        public ContactFolderContactsController(IContactFolderRepository contactfolderRepository, ICompanyRepository companyRepository, IContactRepository contactRepository, IContactFolderContactRepository contactfoldercontactRepository)
        {
			this.contactfolderRepository = contactfolderRepository;
			this.companyRepository = companyRepository;
			this.contactRepository = contactRepository;
			this.contactfoldercontactRepository = contactfoldercontactRepository;
        }

        //
        // GET: /ContactFolderContacts/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(contactfoldercontactRepository.AllIncluding(contactfoldercontact => contactfoldercontact.ContactFolder, contactfoldercontact => contactfoldercontact.Company, contactfoldercontact => contactfoldercontact.Contact));
        }
		
		public ViewResult Search(ContactFolderContact searchContactFolderContact)
        {
			if(searchContactFolderContact!=null)
			{
							}
						return View("Index",contactfoldercontactRepository.AllIncluding(contactfoldercontact => contactfoldercontact.ContactFolder, contactfoldercontact => contactfoldercontact.Company, contactfoldercontact => contactfoldercontact.Contact));
		}

        //
        // GET: /ContactFolderContacts/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(contactfoldercontactRepository.Find(id));
        }

        //
        // GET: /ContactFolderContacts/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ContactFolderContact contactfoldercontact = new ContactFolderContact();
			ViewBag.PossibleContactFolders = contactfolderRepository.All;
			ViewBag.PossibleCompanies = companyRepository.All;
			ViewBag.PossibleContacts = contactRepository.All;
            return View(contactfoldercontact);
        } 

        //
        // POST: /ContactFolderContacts/Create
        [HttpPost]
        public ActionResult Create(ContactFolderContact contactfoldercontact)
        {
            if (ModelState.IsValid) {
                contactfoldercontactRepository.InsertOrUpdate(contactfoldercontact);
                contactfoldercontactRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleContactFolders = contactfolderRepository.All;
				ViewBag.PossibleCompanies = companyRepository.All;
				ViewBag.PossibleContacts = contactRepository.All;
				return View(contactfoldercontact);
			}
        }
        
        //
        // GET: /ContactFolderContacts/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleContactFolders = contactfolderRepository.All;
			ViewBag.PossibleCompanies = companyRepository.All;
			ViewBag.PossibleContacts = contactRepository.All;
             return View(contactfoldercontactRepository.Find(id));
        }

        //
        // POST: /ContactFolderContacts/Edit/5
        [HttpPost]
        public ActionResult Edit(ContactFolderContact contactfoldercontact)
        {
            if (ModelState.IsValid) {
                contactfoldercontactRepository.InsertOrUpdate(contactfoldercontact);
                contactfoldercontactRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleContactFolders = contactfolderRepository.All;
				ViewBag.PossibleCompanies = companyRepository.All;
				ViewBag.PossibleContacts = contactRepository.All;
				return View(contactfoldercontact);
			}
        }

        //
        // GET: /ContactFolderContacts/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(contactfoldercontactRepository.Find(id));
        }

        //
        // POST: /ContactFolderContacts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            contactfoldercontactRepository.Delete(id);
            contactfoldercontactRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

