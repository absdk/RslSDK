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
    public class VendorSupplierDiversityCertificateInfoController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly IVendorSupplierDiversityCertificationCategoryRepository vendorsupplierdiversitycertificationcategoryRepository;
		private readonly ICountryRepository countryRepository;
		private readonly IStateRepository stateRepository;
		private readonly IVendorSupplierDiversityCertificateInfoRepository vendorsupplierdiversitycertificateinfoRepository;
        public VendorSupplierDiversityCertificateInfoController(IVendorRepository vendorRepository, IVendorSupplierDiversityCertificationCategoryRepository vendorsupplierdiversitycertificationcategoryRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IVendorSupplierDiversityCertificateInfoRepository vendorsupplierdiversitycertificateinfoRepository)
        {
			this.vendorRepository = vendorRepository;
			this.vendorsupplierdiversitycertificationcategoryRepository = vendorsupplierdiversitycertificationcategoryRepository;
			this.countryRepository = countryRepository;
			this.stateRepository = stateRepository;
			this.vendorsupplierdiversitycertificateinfoRepository = vendorsupplierdiversitycertificateinfoRepository;
        }

        //
        // GET: /VendorSupplierDiversityCertificateInfo/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendorsupplierdiversitycertificateinfoRepository.AllIncluding(vendorId,vendorsupplierdiversitycertificateinfo => vendorsupplierdiversitycertificateinfo.Vendor, vendorsupplierdiversitycertificateinfo => vendorsupplierdiversitycertificateinfo.VendorSupplierDiversityCertificationCategory, vendorsupplierdiversitycertificateinfo => vendorsupplierdiversitycertificateinfo.Country, vendorsupplierdiversitycertificateinfo => vendorsupplierdiversitycertificateinfo.State));
        }
		
		public ViewResult Search(VendorSupplierDiversityCertificateInfo searchVendorSupplierDiversityCertificateInfo,int vendorId)
        {
			if(searchVendorSupplierDiversityCertificateInfo!=null)
			{
							}
						return View("Index",vendorsupplierdiversitycertificateinfoRepository.AllIncluding(vendorId,vendorsupplierdiversitycertificateinfo => vendorsupplierdiversitycertificateinfo.Vendor, vendorsupplierdiversitycertificateinfo => vendorsupplierdiversitycertificateinfo.VendorSupplierDiversityCertificationCategory, vendorsupplierdiversitycertificateinfo => vendorsupplierdiversitycertificateinfo.Country, vendorsupplierdiversitycertificateinfo => vendorsupplierdiversitycertificateinfo.State));
		}

        //
        // GET: /VendorSupplierDiversityCertificateInfo/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendorsupplierdiversitycertificateinfoRepository.Find(id));
        }

        //
        // GET: /VendorSupplierDiversityCertificateInfo/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorSupplierDiversityCertificateInfo vendorsupplierdiversitycertificateinfo = new VendorSupplierDiversityCertificateInfo();
			vendorsupplierdiversitycertificateinfo.VendorID = vendorId;
			ViewBag.PossibleVendorSupplierDiversityCertificationCategories = vendorsupplierdiversitycertificationcategoryRepository.All;
			ViewBag.PossibleCountries = countryRepository.All;
            return View(vendorsupplierdiversitycertificateinfo);
        } 

        //
        // POST: /VendorSupplierDiversityCertificateInfo/Create
        [HttpPost]
        public ActionResult Create(VendorSupplierDiversityCertificateInfo vendorsupplierdiversitycertificateinfo,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorsupplierdiversitycertificateinfoRepository.InsertOrUpdate(vendorsupplierdiversitycertificateinfo);
                vendorsupplierdiversitycertificateinfoRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				ViewBag.PossibleVendorSupplierDiversityCertificationCategories = vendorsupplierdiversitycertificationcategoryRepository.All;
				ViewBag.PossibleCountries = countryRepository.All;
				return View(vendorsupplierdiversitycertificateinfo);
			}
        }
        
        //
        // GET: /VendorSupplierDiversityCertificateInfo/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorSupplierDiversityCertificateInfo vendorsupplierdiversitycertificateinfo = vendorsupplierdiversitycertificateinfoRepository.Find(id);
						ViewBag.PossibleVendorSupplierDiversityCertificationCategories = vendorsupplierdiversitycertificationcategoryRepository.All;
						ViewBag.PossibleCountries = countryRepository.All;
						if (vendorsupplierdiversitycertificateinfo.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(vendorsupplierdiversitycertificateinfo.CountryID.Value);
            }
			             return View(vendorsupplierdiversitycertificateinfo);
        }

        //
        // POST: /VendorSupplierDiversityCertificateInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorSupplierDiversityCertificateInfo vendorsupplierdiversitycertificateinfo,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorsupplierdiversitycertificateinfoRepository.InsertOrUpdate(vendorsupplierdiversitycertificateinfo);
                vendorsupplierdiversitycertificateinfoRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
						ViewBag.PossibleVendorSupplierDiversityCertificationCategories = vendorsupplierdiversitycertificationcategoryRepository.All;
						ViewBag.PossibleCountries = countryRepository.All;
						if (vendorsupplierdiversitycertificateinfo.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(vendorsupplierdiversitycertificateinfo.CountryID.Value);
            }
							return View(vendorsupplierdiversitycertificateinfo);
			}
        }

        //
        // GET: /VendorSupplierDiversityCertificateInfo/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendorsupplierdiversitycertificateinfoRepository.Find(id));
        }

        //
        // POST: /VendorSupplierDiversityCertificateInfo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendorsupplierdiversitycertificateinfoRepository.Delete(id);
            vendorsupplierdiversitycertificateinfoRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

