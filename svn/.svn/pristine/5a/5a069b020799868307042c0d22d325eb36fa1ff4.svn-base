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
    public class VendorRatingController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly IRatingScaleRepository ratingscaleRepository;
		private readonly IVendorRatingRepository vendorratingRepository;
        public VendorRatingController(IVendorRepository vendorRepository, IRatingScaleRepository ratingscaleRepository, IVendorRatingRepository vendorratingRepository)
        {
			this.vendorRepository = vendorRepository;
			this.ratingscaleRepository = ratingscaleRepository;
			this.vendorratingRepository = vendorratingRepository;
        }

        //
        // GET: /VendorRating/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendorratingRepository.AllIncluding(vendorId,vendorrating => vendorrating.Vendor, vendorrating => vendorrating.VendorRatingScale));
        }
		
		public ViewResult Search(VendorRating searchVendorRating,int vendorId)
        {
			if(searchVendorRating!=null)
			{
							}
						return View("Index",vendorratingRepository.AllIncluding(vendorId,vendorrating => vendorrating.Vendor, vendorrating => vendorrating.VendorRatingScale));
		}

        //
        // GET: /VendorRating/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendorratingRepository.Find(id));
        }

        //
        // GET: /VendorRating/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorRating vendorrating = new VendorRating();
			vendorrating.VendorID = vendorId;
			ViewBag.PossibleVendorRatingScales = ratingscaleRepository.All;
            return View(vendorrating);
        } 

        //
        // POST: /VendorRating/Create
        [HttpPost]
        public ActionResult Create(VendorRating vendorrating,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorratingRepository.InsertOrUpdate(vendorrating);
                vendorratingRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				ViewBag.PossibleVendorRatingScales = ratingscaleRepository.All;
				return View(vendorrating);
			}
        }
        
        //
        // GET: /VendorRating/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorRating vendorrating = vendorratingRepository.Find(id);
						ViewBag.PossibleVendorRatingScales = ratingscaleRepository.All;
             return View(vendorrating);
        }

        //
        // POST: /VendorRating/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorRating vendorrating,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorratingRepository.InsertOrUpdate(vendorrating);
                vendorratingRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
						ViewBag.PossibleVendorRatingScales = ratingscaleRepository.All;
				return View(vendorrating);
			}
        }

        //
        // GET: /VendorRating/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendorratingRepository.Find(id));
        }

        //
        // POST: /VendorRating/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendorratingRepository.Delete(id);
            vendorratingRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

