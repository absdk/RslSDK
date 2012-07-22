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
    public class VendorReferenceController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly IVendorReferenceRepository vendorreferenceRepository;
        public VendorReferenceController(IVendorRepository vendorRepository, IVendorReferenceRepository vendorreferenceRepository)
        {
			this.vendorRepository = vendorRepository;
			this.vendorreferenceRepository = vendorreferenceRepository;
        }

        //
        // GET: /VendorReference/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendorreferenceRepository.AllIncluding(vendorId,vendorreference => vendorreference.Vendor));
        }
		
		public ViewResult Search(VendorReference searchVendorReference,int vendorId)
        {
			if(searchVendorReference!=null)
			{
							}
						return View("Index",vendorreferenceRepository.AllIncluding(vendorId,vendorreference => vendorreference.Vendor));
		}

        //
        // GET: /VendorReference/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendorreferenceRepository.Find(id));
        }

        //
        // GET: /VendorReference/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorReference vendorreference = new VendorReference();
			vendorreference.VendorID = vendorId;
            return View(vendorreference);
        } 

        //
        // POST: /VendorReference/Create
        [HttpPost]
        public ActionResult Create(VendorReference vendorreference,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorreferenceRepository.InsertOrUpdate(vendorreference);
                vendorreferenceRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				return View(vendorreference);
			}
        }
        
        //
        // GET: /VendorReference/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorReference vendorreference = vendorreferenceRepository.Find(id);
             return View(vendorreference);
        }

        //
        // POST: /VendorReference/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorReference vendorreference,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorreferenceRepository.InsertOrUpdate(vendorreference);
                vendorreferenceRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				return View(vendorreference);
			}
        }

        //
        // GET: /VendorReference/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendorreferenceRepository.Find(id));
        }

        //
        // POST: /VendorReference/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendorreferenceRepository.Delete(id);
            vendorreferenceRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

