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
    public class ContactFolderOwnersController : Controller
    {
		private readonly IContactFolderRepository contactfolderRepository;
		private readonly IUserRepository userRepository;
		private readonly IContactFolderOwnerRepository contactfolderownerRepository;
        public ContactFolderOwnersController(IContactFolderRepository contactfolderRepository, IUserRepository userRepository, IContactFolderOwnerRepository contactfolderownerRepository)
        {
			this.contactfolderRepository = contactfolderRepository;
			this.userRepository = userRepository;
			this.contactfolderownerRepository = contactfolderownerRepository;
        }

        //
        // GET: /ContactFolderOwners/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(contactfolderownerRepository.AllIncluding(contactfolderowner => contactfolderowner.ContactFolder, contactfolderowner => contactfolderowner.ShareWithUser));
        }
		
		public ViewResult Search(ContactFolderOwner searchContactFolderOwner)
        {
			if(searchContactFolderOwner!=null)
			{
							}
						return View("Index",contactfolderownerRepository.AllIncluding(contactfolderowner => contactfolderowner.ContactFolder, contactfolderowner => contactfolderowner.ShareWithUser));
		}

        //
        // GET: /ContactFolderOwners/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(contactfolderownerRepository.Find(id));
        }

        //
        // GET: /ContactFolderOwners/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ContactFolderOwner contactfolderowner = new ContactFolderOwner();
			ViewBag.PossibleContactFolders = contactfolderRepository.All;
			ViewBag.PossibleShareWithUsers = userRepository.All;
            return View(contactfolderowner);
        } 

        //
        // POST: /ContactFolderOwners/Create
        [HttpPost]
        public ActionResult Create(ContactFolderOwner contactfolderowner)
        {
            if (ModelState.IsValid) {
                contactfolderownerRepository.InsertOrUpdate(contactfolderowner);
                contactfolderownerRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleContactFolders = contactfolderRepository.All;
				ViewBag.PossibleShareWithUsers = userRepository.All;
				return View(contactfolderowner);
			}
        }
        
        //
        // GET: /ContactFolderOwners/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleContactFolders = contactfolderRepository.All;
			ViewBag.PossibleShareWithUsers = userRepository.All;
             return View(contactfolderownerRepository.Find(id));
        }

        //
        // POST: /ContactFolderOwners/Edit/5
        [HttpPost]
        public ActionResult Edit(ContactFolderOwner contactfolderowner)
        {
            if (ModelState.IsValid) {
                contactfolderownerRepository.InsertOrUpdate(contactfolderowner);
                contactfolderownerRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleContactFolders = contactfolderRepository.All;
				ViewBag.PossibleShareWithUsers = userRepository.All;
				return View(contactfolderowner);
			}
        }

        //
        // GET: /ContactFolderOwners/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(contactfolderownerRepository.Find(id));
        }

        //
        // POST: /ContactFolderOwners/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            contactfolderownerRepository.Delete(id);
            contactfolderownerRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

