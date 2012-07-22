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
    public class VendorServiceCapabilityRatingController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly IVendorServiceCategoryRepository vendorservicecategoryRepository;
		private readonly IRatingScaleRepository ratingscaleRepository;
		private readonly IVendorServiceCapabilityRatingRepository vendorservicecapabilityratingRepository;
        public VendorServiceCapabilityRatingController(IVendorRepository vendorRepository, IVendorServiceCategoryRepository vendorservicecategoryRepository, IRatingScaleRepository ratingscaleRepository, IVendorServiceCapabilityRatingRepository vendorservicecapabilityratingRepository)
        {
			this.vendorRepository = vendorRepository;
			this.vendorservicecategoryRepository = vendorservicecategoryRepository;
			this.ratingscaleRepository = ratingscaleRepository;
			this.vendorservicecapabilityratingRepository = vendorservicecapabilityratingRepository;
        }

        //
        // GET: /VendorServiceCapabilityRating/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendorservicecapabilityratingRepository.AllIncluding(vendorId,vendorservicecapabilityrating => vendorservicecapabilityrating.Vendor, vendorservicecapabilityrating => vendorservicecapabilityrating.VendorServiceCategory, vendorservicecapabilityrating => vendorservicecapabilityrating.VendorServiceRatingScale));
        }
		
		public ViewResult Search(VendorServiceCapabilityRating searchVendorServiceCapabilityRating,int vendorId)
        {
			if(searchVendorServiceCapabilityRating!=null)
			{
							}
						return View("Index",vendorservicecapabilityratingRepository.AllIncluding(vendorId,vendorservicecapabilityrating => vendorservicecapabilityrating.Vendor, vendorservicecapabilityrating => vendorservicecapabilityrating.VendorServiceCategory, vendorservicecapabilityrating => vendorservicecapabilityrating.VendorServiceRatingScale));
		}

        //
        // GET: /VendorServiceCapabilityRating/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendorservicecapabilityratingRepository.Find(id));
        }

        //
        // GET: /VendorServiceCapabilityRating/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorServiceCapabilityRating vendorservicecapabilityrating = new VendorServiceCapabilityRating();
			vendorservicecapabilityrating.VendorID = vendorId;
			ViewBag.PossibleVendorServiceCategories = vendorservicecategoryRepository.All;
			ViewBag.PossibleVendorServiceRatingScales = ratingscaleRepository.All;
            return View(vendorservicecapabilityrating);
        } 

        //
        // POST: /VendorServiceCapabilityRating/Create
        [HttpPost]
        public ActionResult Create(VendorServiceCapabilityRating vendorservicecapabilityrating,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorservicecapabilityratingRepository.InsertOrUpdate(vendorservicecapabilityrating);
                vendorservicecapabilityratingRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				ViewBag.PossibleVendorServiceCategories = vendorservicecategoryRepository.All;
				ViewBag.PossibleVendorServiceRatingScales = ratingscaleRepository.All;
				return View(vendorservicecapabilityrating);
			}
        }
        
        //
        // GET: /VendorServiceCapabilityRating/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorServiceCapabilityRating vendorservicecapabilityrating = vendorservicecapabilityratingRepository.Find(id);
						ViewBag.PossibleVendorServiceCategories = vendorservicecategoryRepository.All;
						ViewBag.PossibleVendorServiceRatingScales = ratingscaleRepository.All;
             return View(vendorservicecapabilityrating);
        }

        //
        // POST: /VendorServiceCapabilityRating/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorServiceCapabilityRating vendorservicecapabilityrating,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorservicecapabilityratingRepository.InsertOrUpdate(vendorservicecapabilityrating);
                vendorservicecapabilityratingRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
						ViewBag.PossibleVendorServiceCategories = vendorservicecategoryRepository.All;
						ViewBag.PossibleVendorServiceRatingScales = ratingscaleRepository.All;
				return View(vendorservicecapabilityrating);
			}
        }

        //
        // GET: /VendorServiceCapabilityRating/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendorservicecapabilityratingRepository.Find(id));
        }

        //
        // POST: /VendorServiceCapabilityRating/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendorservicecapabilityratingRepository.Delete(id);
            vendorservicecapabilityratingRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

