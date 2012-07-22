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
    public class VendorsController : Controller
    {
		private readonly IIndustryRepository industryRepository;
		private readonly ICompanyOwnerRepository companyownerRepository;
		private readonly IVendorLegalCompanyStructureCategoryRepository vendorlegalcompanystructurecategoryRepository;
		private readonly ICountryRepository countryRepository;
		private readonly IStateRepository stateRepository;
		private readonly IVendorStatusCategoryRepository vendorstatuscategoryRepository;
		private readonly IUserRepository userRepository;
		private readonly IVendorRepository vendorRepository;
        public VendorsController(IIndustryRepository industryRepository, ICompanyOwnerRepository companyownerRepository, IVendorLegalCompanyStructureCategoryRepository vendorlegalcompanystructurecategoryRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IVendorStatusCategoryRepository vendorstatuscategoryRepository, IUserRepository userRepository, IVendorRepository vendorRepository)
        {
			this.industryRepository = industryRepository;
			this.companyownerRepository = companyownerRepository;
			this.vendorlegalcompanystructurecategoryRepository = vendorlegalcompanystructurecategoryRepository;
			this.countryRepository = countryRepository;
			this.stateRepository = stateRepository;
			this.vendorstatuscategoryRepository = vendorstatuscategoryRepository;
			this.userRepository = userRepository;
			this.vendorRepository = vendorRepository;
        }

        //
        // GET: /Vendors/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(vendorRepository.AllIncluding(vendor => vendor.Industry, vendor => vendor.CompanyOwner, vendor => vendor.VendorLegalCompanyStructureCategory, vendor => vendor.Country, vendor => vendor.State, vendor => vendor.VendorStatusCategory, vendor => vendor.CreatedByUser, vendor => vendor.VerifiedByUser));
        }
		
		public ViewResult Search(Vendor searchVendor)
        {
			if(searchVendor!=null)
			{
							ViewData["VendorDisplayId"]=searchVendor.VendorDisplayId;
							}
						return View("Index",vendorRepository.AllIncluding(vendor => vendor.Industry, vendor => vendor.CompanyOwner, vendor => vendor.VendorLegalCompanyStructureCategory, vendor => vendor.Country, vendor => vendor.State, vendor => vendor.VendorStatusCategory, vendor => vendor.CreatedByUser, vendor => vendor.VerifiedByUser));
		}

        //
        // GET: /Vendors/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendorRepository.Find(id));
        }

        //
        // GET: /Vendors/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			Vendor vendor = new Vendor();
			ViewBag.PossibleIndustries = industryRepository.All;
			ViewBag.PossibleCompanyOwners = companyownerRepository.All;
			ViewBag.PossibleVendorLegalCompanyStructureCategories = vendorlegalcompanystructurecategoryRepository.All;
			ViewBag.PossibleCountries = countryRepository.All;
			ViewBag.PossibleStates = stateRepository.All;
			ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
			ViewBag.PossibleCreatedByUsers = userRepository.All;
			ViewBag.PossibleVerifiedByUsers = userRepository.All;
            return View(vendor);
        } 

        //
        // POST: /Vendors/Create
        [HttpPost]
        public ActionResult Create(Vendor vendor)
        {
            if (ModelState.IsValid) {
                vendorRepository.InsertOrUpdate(vendor);
                vendorRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleIndustries = industryRepository.All;
				ViewBag.PossibleCompanyOwners = companyownerRepository.All;
				ViewBag.PossibleVendorLegalCompanyStructureCategories = vendorlegalcompanystructurecategoryRepository.All;
				ViewBag.PossibleCountries = countryRepository.All;
				ViewBag.PossibleStates = stateRepository.All;
				ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				ViewBag.PossibleVerifiedByUsers = userRepository.All;
				return View(vendor);
			}
        }
        
        //
        // GET: /Vendors/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleIndustries = industryRepository.All;
			ViewBag.PossibleCompanyOwners = companyownerRepository.All;
			ViewBag.PossibleVendorLegalCompanyStructureCategories = vendorlegalcompanystructurecategoryRepository.All;
			ViewBag.PossibleCountries = countryRepository.All;
			ViewBag.PossibleStates = stateRepository.All;
			ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
			ViewBag.PossibleCreatedByUsers = userRepository.All;
			ViewBag.PossibleVerifiedByUsers = userRepository.All;
             return View(vendorRepository.Find(id));
        }

        //
        // POST: /Vendors/Edit/5
        [HttpPost]
        public ActionResult Edit(Vendor vendor)
        {
            if (ModelState.IsValid) {
                vendorRepository.InsertOrUpdate(vendor);
                vendorRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleIndustries = industryRepository.All;
				ViewBag.PossibleCompanyOwners = companyownerRepository.All;
				ViewBag.PossibleVendorLegalCompanyStructureCategories = vendorlegalcompanystructurecategoryRepository.All;
				ViewBag.PossibleCountries = countryRepository.All;
				ViewBag.PossibleStates = stateRepository.All;
				ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				ViewBag.PossibleVerifiedByUsers = userRepository.All;
				return View(vendor);
			}
        }

        //
        // GET: /Vendors/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendorRepository.Find(id));
        }

        //
        // POST: /Vendors/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendorRepository.Delete(id);
            vendorRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

