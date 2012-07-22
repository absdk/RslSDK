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
    public class VendorInsuranceController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly IVendorInsuranceCategoryRepository vendorinsurancecategoryRepository;
		private readonly IVendorInsuranceRepository vendorinsuranceRepository;
        public VendorInsuranceController(IVendorRepository vendorRepository, IVendorInsuranceCategoryRepository vendorinsurancecategoryRepository, IVendorInsuranceRepository vendorinsuranceRepository)
        {
			this.vendorRepository = vendorRepository;
			this.vendorinsurancecategoryRepository = vendorinsurancecategoryRepository;
			this.vendorinsuranceRepository = vendorinsuranceRepository;
        }

        //
        // GET: /VendorInsurance/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendorinsuranceRepository.AllIncluding(vendorId,vendorinsurance => vendorinsurance.Vendor, vendorinsurance => vendorinsurance.VendorInsuranceCategory));
        }
		
		public ViewResult Search(VendorInsurance searchVendorInsurance,int vendorId)
        {
			if(searchVendorInsurance!=null)
			{
							}
						return View("Index",vendorinsuranceRepository.AllIncluding(vendorId,vendorinsurance => vendorinsurance.Vendor, vendorinsurance => vendorinsurance.VendorInsuranceCategory));
		}

        //
        // GET: /VendorInsurance/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendorinsuranceRepository.Find(id));
        }

        //
        // GET: /VendorInsurance/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorInsurance vendorinsurance = new VendorInsurance();
			vendorinsurance.VendorID = vendorId;
			ViewBag.PossibleVendorInsuranceCategories = vendorinsurancecategoryRepository.All;
            return View(vendorinsurance);
        } 

        //
        // POST: /VendorInsurance/Create
        [HttpPost]
        public ActionResult Create(VendorInsurance vendorinsurance,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorinsuranceRepository.InsertOrUpdate(vendorinsurance);
                vendorinsuranceRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				ViewBag.PossibleVendorInsuranceCategories = vendorinsurancecategoryRepository.All;
				return View(vendorinsurance);
			}
        }
        
        //
        // GET: /VendorInsurance/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorInsurance vendorinsurance = vendorinsuranceRepository.Find(id);
						ViewBag.PossibleVendorInsuranceCategories = vendorinsurancecategoryRepository.All;
             return View(vendorinsurance);
        }

        //
        // POST: /VendorInsurance/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorInsurance vendorinsurance,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorinsuranceRepository.InsertOrUpdate(vendorinsurance);
                vendorinsuranceRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
						ViewBag.PossibleVendorInsuranceCategories = vendorinsurancecategoryRepository.All;
				return View(vendorinsurance);
			}
        }

        //
        // GET: /VendorInsurance/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendorinsuranceRepository.Find(id));
        }

        //
        // POST: /VendorInsurance/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendorinsuranceRepository.Delete(id);
            vendorinsuranceRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

