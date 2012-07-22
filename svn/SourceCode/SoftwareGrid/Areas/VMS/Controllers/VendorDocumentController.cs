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
    public class VendorDocumentController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly IVendorDocumentCategoryRepository vendordocumentcategoryRepository;
		private readonly IVendorDocumentRepository vendordocumentRepository;
        public VendorDocumentController(IVendorRepository vendorRepository, IVendorDocumentCategoryRepository vendordocumentcategoryRepository, IVendorDocumentRepository vendordocumentRepository)
        {
			this.vendorRepository = vendorRepository;
			this.vendordocumentcategoryRepository = vendordocumentcategoryRepository;
			this.vendordocumentRepository = vendordocumentRepository;
        }

        //
        // GET: /VendorDocument/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendordocumentRepository.AllIncluding(vendorId,vendordocument => vendordocument.Vendor, vendordocument => vendordocument.VendorDocumentCategory));
        }
		
		public ViewResult Search(VendorDocument searchVendorDocument,int vendorId)
        {
			if(searchVendorDocument!=null)
			{
							}
						return View("Index",vendordocumentRepository.AllIncluding(vendorId,vendordocument => vendordocument.Vendor, vendordocument => vendordocument.VendorDocumentCategory));
		}

        //
        // GET: /VendorDocument/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendordocumentRepository.Find(id));
        }

        //
        // GET: /VendorDocument/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorDocument vendordocument = new VendorDocument();
			vendordocument.VendorID = vendorId;
			ViewBag.PossibleVendorDocumentCategories = vendordocumentcategoryRepository.All;
            return View(vendordocument);
        } 

        //
        // POST: /VendorDocument/Create
        [HttpPost]
        public ActionResult Create(VendorDocument vendordocument,int vendorId)
        {
            if (ModelState.IsValid) {
                vendordocumentRepository.InsertOrUpdate(vendordocument);
                vendordocumentRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				ViewBag.PossibleVendorDocumentCategories = vendordocumentcategoryRepository.All;
				return View(vendordocument);
			}
        }
        
        //
        // GET: /VendorDocument/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorDocument vendordocument = vendordocumentRepository.Find(id);
						ViewBag.PossibleVendorDocumentCategories = vendordocumentcategoryRepository.All;
             return View(vendordocument);
        }

        //
        // POST: /VendorDocument/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorDocument vendordocument,int vendorId)
        {
            if (ModelState.IsValid) {
                vendordocumentRepository.InsertOrUpdate(vendordocument);
                vendordocumentRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
						ViewBag.PossibleVendorDocumentCategories = vendordocumentcategoryRepository.All;
				return View(vendordocument);
			}
        }

        //
        // GET: /VendorDocument/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendordocumentRepository.Find(id));
        }

        //
        // POST: /VendorDocument/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendordocumentRepository.Delete(id);
            vendordocumentRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

