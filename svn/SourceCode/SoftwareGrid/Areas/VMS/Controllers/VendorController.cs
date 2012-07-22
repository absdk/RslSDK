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
using SoftwareGrid.Common;
using System.IO;
using EasySoft.Helper;
namespace SoftwareGrid.Areas.VMS.Controllers
{
    public class VendorController : UserBaseController
    {
        private readonly IIndustryRepository industryRepository;
        private readonly ICompanyOwnerRepository companyownerRepository;
        private readonly IVendorLegalCompanyStructureCategoryRepository vendorlegalcompanystructurecategoryRepository;
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly IVendorStatusCategoryRepository vendorstatuscategoryRepository;
        private readonly IUserRepository userRepository;
        private readonly IVendorRepository vendorRepository;
        public VendorController(IIndustryRepository industryRepository, ICompanyOwnerRepository companyownerRepository, IVendorLegalCompanyStructureCategoryRepository vendorlegalcompanystructurecategoryRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IVendorStatusCategoryRepository vendorstatuscategoryRepository, IUserRepository userRepository, IVendorRepository vendorRepository)
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
        // GET: /Vendor/
        [UserAuthorize]
        public ViewResult Index()
        {
            ViewBag.PossibleIndustries = industryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleStates = stateRepository.All;
            ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
            return View(vendorRepository.AllIncluding(vendor => vendor.Industry, vendor => vendor.VendorOwner, vendor => vendor.VendorLegalCompanyStructureCategory, vendor => vendor.Country, vendor => vendor.State, vendor => vendor.VendorStatusCategory, vendor => vendor.CreatedByUser, vendor => vendor.VerifiedByUser));
        }

        public ViewResult Search(Vendor searchVendor)
        {
            if (searchVendor != null)
            {
                ViewData["VendorDisplayId"] = searchVendor.VendorDisplayId;
                ViewData["VendorName"] = searchVendor.VendorName;
                ViewData["IndustryID"] = searchVendor.IndustryID;
                ViewData["CountryID"] = searchVendor.CountryID;
                ViewData["StateID"] = searchVendor.StateID;
                ViewData["VendorStatusCategoryID"] = searchVendor.VendorStatusCategoryID;
            }
            ViewBag.PossibleIndustries = industryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleStates = stateRepository.All;
            ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
            return View("Index", vendorRepository.AllIncluding(vendor => vendor.Industry, vendor => vendor.VendorOwner, vendor => vendor.VendorLegalCompanyStructureCategory, vendor => vendor.Country, vendor => vendor.State, vendor => vendor.VendorStatusCategory, vendor => vendor.CreatedByUser, vendor => vendor.VerifiedByUser));
        }

        //
        // GET: /Vendor/Details/5
        [UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(vendorRepository.Find(id));
        }

        //
        // GET: /Vendor/Create
        [UserAuthorize]
        public ActionResult Create()
        {
            Vendor vendor = new Vendor();
            ViewBag.PossibleIndustries = industryRepository.All;
            ViewBag.PossibleVendorOwners = companyownerRepository.All;
            ViewBag.PossibleVendorLegalCompanyStructureCategories = vendorlegalcompanystructurecategoryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
            vendor.CreatedDate = DateTime.Now;
            vendor.CreatedByUserID = CurrentLoggedInUser.UserID;
            return View(vendor);
        }

        //
        // POST: /Vendor/Create
        [HttpPost]
        public ActionResult Create(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                if (Session["Logo"] != null)
                {
                    var fileName = Session["Logo"].ToString();
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    vendor.Logo = Utility.ReadFile(physicalPath);
                }
                vendor.VendorDisplayId = MiscUtility.GetVendorPersonalizedId();
                vendorRepository.InsertOrUpdate(vendor);
                vendorRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleIndustries = industryRepository.All;
                ViewBag.PossibleVendorOwners = companyownerRepository.All;
                ViewBag.PossibleVendorLegalCompanyStructureCategories = vendorlegalcompanystructurecategoryRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
                return View(vendor);
            }
        }

        //
        // GET: /Vendor/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int vendorId)
        {
            Vendor vendor = vendorRepository.Find(vendorId);
            ViewBag.PossibleIndustries = industryRepository.All;
            ViewBag.PossibleVendorOwners = companyownerRepository.All;
            ViewBag.PossibleVendorLegalCompanyStructureCategories = vendorlegalcompanystructurecategoryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            if (vendor.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(vendor.CountryID.Value);
            }
            ViewBag.VendorId = vendorId;
            ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.VendorLandingMenu = repository.GetVendorLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
            ViewBag.VendorOverviewHead = vendorRepository.FindOverviewHead(vendorId, vendor);
            return View(vendor);
        }

        //
        // POST: /Vendor/Edit/5
        [HttpPost]
        public ActionResult Edit(Vendor vendor)
        {
            if (ModelState.IsValid)
            {
                if (Session["Logo"] != null)
                {
                    var fileName = Session["Logo"].ToString();
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    vendor.Logo = Utility.ReadFile(physicalPath);
                }
                if (vendor.VendorDisplayId.IsNullOrEmpty())
                {
                    vendor.VendorDisplayId = MiscUtility.GetVendorPersonalizedId();
                }
                vendorRepository.InsertOrUpdate(vendor);
                vendorRepository.Save();
                return RedirectToAction("Overview", new { vendorId = vendor.VendorID });
            }
            else
            {
                ViewBag.PossibleIndustries = industryRepository.All;
                ViewBag.PossibleVendorOwners = companyownerRepository.All;
                ViewBag.PossibleVendorLegalCompanyStructureCategories = vendorlegalcompanystructurecategoryRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                if (vendor.CountryID.HasValue)
                {
                    ViewBag.PossibleStates = stateRepository.FindAllByCountryID(vendor.CountryID.Value);
                }
                ViewBag.PossibleVendorStatusCategories = vendorstatuscategoryRepository.All;
                return View(vendor);
            }
        }

        //
        // GET: /Vendor/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(vendorRepository.Find(id));
        }

        //
        // POST: /Vendor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            vendorRepository.Delete(id);
            vendorRepository.Save();

            return RedirectToAction("Index");
        }

        [UserAuthorize]
        public ViewResult Overview(int vendorId)
        {
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.VendorLandingMenu = repository.GetVendorLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
            ViewBag.VendorId = vendorId;
            if (ViewBag.VendorOverviewHead == null)
            {
                ViewBag.VendorOverviewHead = vendorRepository.FindOverviewHead(vendorId, null);
            }
            return View(ViewBag.VendorOverviewHead);
        }
    }
}

