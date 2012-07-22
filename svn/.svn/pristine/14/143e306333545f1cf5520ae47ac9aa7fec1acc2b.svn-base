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
namespace SoftwareGrid.Areas.MasterData.Controllers
{   
    public class ContactProfessionTypesController : Controller
    {
		private readonly IContactProfessionTypeRepository contactprofessiontypeRepository;
        public ContactProfessionTypesController(IContactProfessionTypeRepository contactprofessiontypeRepository)
        {
			this.contactprofessiontypeRepository = contactprofessiontypeRepository;
        }

        //
        // GET: /ContactProfessionTypes/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(contactprofessiontypeRepository.All);
        }
		
		public ViewResult Search(ContactProfessionType searchContactProfessionType)
        {
			if(searchContactProfessionType!=null)
			{
							}
						return View("Index",contactprofessiontypeRepository.All);
		}

        //
        // GET: /ContactProfessionTypes/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(contactprofessiontypeRepository.Find(id));
        }

        //
        // GET: /ContactProfessionTypes/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ContactProfessionType contactprofessiontype = new ContactProfessionType();
            return View(contactprofessiontype);
        } 

        //
        // POST: /ContactProfessionTypes/Create
        [HttpPost]
        public ActionResult Create(ContactProfessionType contactprofessiontype)
        {
            if (ModelState.IsValid) {
                contactprofessiontypeRepository.InsertOrUpdate(contactprofessiontype);
                contactprofessiontypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(contactprofessiontype);
			}
        }
        
        //
        // GET: /ContactProfessionTypes/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(contactprofessiontypeRepository.Find(id));
        }

        //
        // POST: /ContactProfessionTypes/Edit/5
        [HttpPost]
        public ActionResult Edit(ContactProfessionType contactprofessiontype)
        {
            if (ModelState.IsValid) {
                contactprofessiontypeRepository.InsertOrUpdate(contactprofessiontype);
                contactprofessiontypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(contactprofessiontype);
			}
        }

        //
        // GET: /ContactProfessionTypes/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(contactprofessiontypeRepository.Find(id));
        }

        //
        // POST: /ContactProfessionTypes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            contactprofessiontypeRepository.Delete(id);
            contactprofessiontypeRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

