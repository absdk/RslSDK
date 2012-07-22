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
namespace SoftwareGrid.Areas.VMS.Controllers
{   
    public class VendorNoteController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly IVendorNoteCategoryRepository vendornotecategoryRepository;
		private readonly IVendorNoteRepository vendornoteRepository;
        public VendorNoteController(IVendorRepository vendorRepository, IVendorNoteCategoryRepository vendornotecategoryRepository, IVendorNoteRepository vendornoteRepository)
        {
			this.vendorRepository = vendorRepository;
			this.vendornotecategoryRepository = vendornotecategoryRepository;
			this.vendornoteRepository = vendornoteRepository;
        }

        //
        // GET: /VendorNote/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendornoteRepository.AllIncluding(vendorId,vendornote => vendornote.Vendor, vendornote => vendornote.VendorNoteCategory));
        }
		
		public ViewResult Search(VendorNote searchVendorNote,int vendorId)
        {
			if(searchVendorNote!=null)
			{
							}
						return View("Index",vendornoteRepository.AllIncluding(vendorId,vendornote => vendornote.Vendor, vendornote => vendornote.VendorNoteCategory));
		}

        //
        // GET: /VendorNote/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendornoteRepository.Find(id));
        }

        //
        // GET: /VendorNote/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorNote vendornote = new VendorNote();
			vendornote.VendorID = vendorId;
			ViewBag.PossibleVendorNoteCategories = vendornotecategoryRepository.All;
            return View(vendornote);
        } 

        //
        // POST: /VendorNote/Create
        [HttpPost]
        public ActionResult Create(VendorNote vendornote,int vendorId)
        {
            if (ModelState.IsValid) {
                vendornoteRepository.InsertOrUpdate(vendornote);
                vendornoteRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				ViewBag.PossibleVendorNoteCategories = vendornotecategoryRepository.All;
				return View(vendornote);
			}
        }
        
        //
        // GET: /VendorNote/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorNote vendornote = vendornoteRepository.Find(id);
						ViewBag.PossibleVendorNoteCategories = vendornotecategoryRepository.All;
             return View(vendornote);
        }

        //
        // POST: /VendorNote/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorNote vendornote,int vendorId)
        {
            if (ModelState.IsValid) {
                vendornoteRepository.InsertOrUpdate(vendornote);
                vendornoteRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
						ViewBag.PossibleVendorNoteCategories = vendornotecategoryRepository.All;
				return View(vendornote);
			}
        }

        //
        // GET: /VendorNote/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendornoteRepository.Find(id));
        }

        //
        // POST: /VendorNote/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendornoteRepository.Delete(id);
            vendornoteRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

