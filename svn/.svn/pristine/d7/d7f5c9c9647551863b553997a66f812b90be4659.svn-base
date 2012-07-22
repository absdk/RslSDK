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
    public class VendorAddressController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly IVendorAddressCategoryRepository vendoraddresscategoryRepository;
		private readonly ICountryRepository countryRepository;
		private readonly IStateRepository stateRepository;
		private readonly IVendorAddressRepository vendoraddressRepository;
        public VendorAddressController(IVendorRepository vendorRepository, IVendorAddressCategoryRepository vendoraddresscategoryRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IVendorAddressRepository vendoraddressRepository)
        {
			this.vendorRepository = vendorRepository;
			this.vendoraddresscategoryRepository = vendoraddresscategoryRepository;
			this.countryRepository = countryRepository;
			this.stateRepository = stateRepository;
			this.vendoraddressRepository = vendoraddressRepository;
        }

        //
        // GET: /VendorAddress/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendoraddressRepository.AllIncluding(vendorId,vendoraddress => vendoraddress.Vendor, vendoraddress => vendoraddress.VendorAddressCategory, vendoraddress => vendoraddress.Country, vendoraddress => vendoraddress.State));
        }
		
		public ViewResult Search(VendorAddress searchVendorAddress,int vendorId)
        {
			if(searchVendorAddress!=null)
			{
							}
						return View("Index",vendoraddressRepository.AllIncluding(vendorId,vendoraddress => vendoraddress.Vendor, vendoraddress => vendoraddress.VendorAddressCategory, vendoraddress => vendoraddress.Country, vendoraddress => vendoraddress.State));
		}

        //
        // GET: /VendorAddress/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendoraddressRepository.Find(id));
        }

        //
        // GET: /VendorAddress/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorAddress vendoraddress = new VendorAddress();
			vendoraddress.VendorID = vendorId;
			ViewBag.PossibleVendorAddressCategories = vendoraddresscategoryRepository.All;
			ViewBag.PossibleCountries = countryRepository.All;
            return View(vendoraddress);
        } 

        //
        // POST: /VendorAddress/Create
        [HttpPost]
        public ActionResult Create(VendorAddress vendoraddress,int vendorId)
        {
            if (ModelState.IsValid) {
                vendoraddressRepository.InsertOrUpdate(vendoraddress);
                vendoraddressRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				ViewBag.PossibleVendorAddressCategories = vendoraddresscategoryRepository.All;
				ViewBag.PossibleCountries = countryRepository.All;
				return View(vendoraddress);
			}
        }
        
        //
        // GET: /VendorAddress/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorAddress vendoraddress = vendoraddressRepository.Find(id);
						ViewBag.PossibleVendorAddressCategories = vendoraddresscategoryRepository.All;
						ViewBag.PossibleCountries = countryRepository.All;
						if (vendoraddress.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(vendoraddress.CountryID.Value);
            }
			             return View(vendoraddress);
        }

        //
        // POST: /VendorAddress/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorAddress vendoraddress,int vendorId)
        {
            if (ModelState.IsValid) {
                vendoraddressRepository.InsertOrUpdate(vendoraddress);
                vendoraddressRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
						ViewBag.PossibleVendorAddressCategories = vendoraddresscategoryRepository.All;
						ViewBag.PossibleCountries = countryRepository.All;
						if (vendoraddress.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(vendoraddress.CountryID.Value);
            }
							return View(vendoraddress);
			}
        }

        //
        // GET: /VendorAddress/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendoraddressRepository.Find(id));
        }

        //
        // POST: /VendorAddress/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendoraddressRepository.Delete(id);
            vendoraddressRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

