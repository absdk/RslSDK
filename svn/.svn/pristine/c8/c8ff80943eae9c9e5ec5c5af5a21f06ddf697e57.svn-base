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
    public class ContactFoldersController : Controller
    {
		private readonly IUserRepository userRepository;
		private readonly IContactFolderRepository contactfolderRepository;
        public ContactFoldersController(IUserRepository userRepository, IContactFolderRepository contactfolderRepository)
        {
			this.userRepository = userRepository;
			this.contactfolderRepository = contactfolderRepository;
        }

        //
        // GET: /ContactFolders/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(contactfolderRepository.AllIncluding(contactfolder => contactfolder.CreatedByUser));
        }
		
		public ViewResult Search(ContactFolder searchContactFolder)
        {
			if(searchContactFolder!=null)
			{
							}
						return View("Index",contactfolderRepository.AllIncluding(contactfolder => contactfolder.CreatedByUser));
		}

        //
        // GET: /ContactFolders/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(contactfolderRepository.Find(id));
        }

        //
        // GET: /ContactFolders/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ContactFolder contactfolder = new ContactFolder();
			ViewBag.PossibleCreatedByUsers = userRepository.All;
            return View(contactfolder);
        } 

        //
        // POST: /ContactFolders/Create
        [HttpPost]
        public ActionResult Create(ContactFolder contactfolder)
        {
            if (ModelState.IsValid) {
                contactfolderRepository.InsertOrUpdate(contactfolder);
                contactfolderRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				return View(contactfolder);
			}
        }
        
        //
        // GET: /ContactFolders/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleCreatedByUsers = userRepository.All;
             return View(contactfolderRepository.Find(id));
        }

        //
        // POST: /ContactFolders/Edit/5
        [HttpPost]
        public ActionResult Edit(ContactFolder contactfolder)
        {
            if (ModelState.IsValid) {
                contactfolderRepository.InsertOrUpdate(contactfolder);
                contactfolderRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				return View(contactfolder);
			}
        }

        //
        // GET: /ContactFolders/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(contactfolderRepository.Find(id));
        }

        //
        // POST: /ContactFolders/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            contactfolderRepository.Delete(id);
            contactfolderRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

