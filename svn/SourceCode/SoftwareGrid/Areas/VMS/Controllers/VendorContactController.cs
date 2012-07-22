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
    public class VendorContactController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly ICountryRepository countryRepository;
		private readonly IStateRepository stateRepository;
		private readonly IContactProfessionTypeRepository contactprofessiontypeRepository;
		private readonly IEthnicBackgroundRepository ethnicbackgroundRepository;
		private readonly IGenderRepository genderRepository;
		private readonly IVeteranCategoryRepository veterancategoryRepository;
		private readonly IUserRepository userRepository;
		private readonly IVendorContactRepository vendorcontactRepository;
        public VendorContactController(IVendorRepository vendorRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IContactProfessionTypeRepository contactprofessiontypeRepository, IEthnicBackgroundRepository ethnicbackgroundRepository, IGenderRepository genderRepository, IVeteranCategoryRepository veterancategoryRepository, IUserRepository userRepository, IVendorContactRepository vendorcontactRepository)
        {
			this.vendorRepository = vendorRepository;
			this.countryRepository = countryRepository;
			this.stateRepository = stateRepository;
			this.contactprofessiontypeRepository = contactprofessiontypeRepository;
			this.ethnicbackgroundRepository = ethnicbackgroundRepository;
			this.genderRepository = genderRepository;
			this.veterancategoryRepository = veterancategoryRepository;
			this.userRepository = userRepository;
			this.vendorcontactRepository = vendorcontactRepository;
        }

        //
        // GET: /VendorContact/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendorcontactRepository.AllIncluding(vendorId,vendorcontact => vendorcontact.Vendor, vendorcontact => vendorcontact.Country, vendorcontact => vendorcontact.State, vendorcontact => vendorcontact.ContactProfessionType, vendorcontact => vendorcontact.EthnicBackground, vendorcontact => vendorcontact.Gender, vendorcontact => vendorcontact.VeteranCategory, vendorcontact => vendorcontact.BirthCountry, vendorcontact => vendorcontact.CreatedByUser, vendorcontact => vendorcontact.VerifiedByUser));
        }
		
		public ViewResult Search(VendorContact searchVendorContact,int vendorId)
        {
			if(searchVendorContact!=null)
			{
							}
						return View("Index",vendorcontactRepository.AllIncluding(vendorId,vendorcontact => vendorcontact.Vendor, vendorcontact => vendorcontact.Country, vendorcontact => vendorcontact.State, vendorcontact => vendorcontact.ContactProfessionType, vendorcontact => vendorcontact.EthnicBackground, vendorcontact => vendorcontact.Gender, vendorcontact => vendorcontact.VeteranCategory, vendorcontact => vendorcontact.BirthCountry, vendorcontact => vendorcontact.CreatedByUser, vendorcontact => vendorcontact.VerifiedByUser));
		}

        //
        // GET: /VendorContact/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendorcontactRepository.Find(id));
        }

        //
        // GET: /VendorContact/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorContact vendorcontact = new VendorContact();
			vendorcontact.VendorID = vendorId;
			ViewBag.PossibleCountries = countryRepository.All;
			ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
			ViewBag.PossibleEthnicBackgrounds = ethnicbackgroundRepository.All;
			ViewBag.PossibleGenders = genderRepository.All;
			ViewBag.PossibleVeteranCategories = veterancategoryRepository.All;
			ViewBag.PossibleBirthCountries = countryRepository.All;
            return View(vendorcontact);
        } 

        //
        // POST: /VendorContact/Create
        [HttpPost]
        public ActionResult Create(VendorContact vendorcontact,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorcontactRepository.InsertOrUpdate(vendorcontact);
                vendorcontactRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				ViewBag.PossibleCountries = countryRepository.All;
				ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
				ViewBag.PossibleEthnicBackgrounds = ethnicbackgroundRepository.All;
				ViewBag.PossibleGenders = genderRepository.All;
				ViewBag.PossibleVeteranCategories = veterancategoryRepository.All;
				ViewBag.PossibleBirthCountries = countryRepository.All;
				return View(vendorcontact);
			}
        }
        
        //
        // GET: /VendorContact/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorContact vendorcontact = vendorcontactRepository.Find(id);
						ViewBag.PossibleCountries = countryRepository.All;
						if (vendorcontact.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(vendorcontact.CountryID.Value);
            }
									ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
						ViewBag.PossibleEthnicBackgrounds = ethnicbackgroundRepository.All;
						ViewBag.PossibleGenders = genderRepository.All;
						ViewBag.PossibleVeteranCategories = veterancategoryRepository.All;
						ViewBag.PossibleBirthCountries = countryRepository.All;
             return View(vendorcontact);
        }

        //
        // POST: /VendorContact/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorContact vendorcontact,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorcontactRepository.InsertOrUpdate(vendorcontact);
                vendorcontactRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
						ViewBag.PossibleCountries = countryRepository.All;
						if (vendorcontact.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(vendorcontact.CountryID.Value);
            }
									ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
						ViewBag.PossibleEthnicBackgrounds = ethnicbackgroundRepository.All;
						ViewBag.PossibleGenders = genderRepository.All;
						ViewBag.PossibleVeteranCategories = veterancategoryRepository.All;
						ViewBag.PossibleBirthCountries = countryRepository.All;
				return View(vendorcontact);
			}
        }

        //
        // GET: /VendorContact/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendorcontactRepository.Find(id));
        }

        //
        // POST: /VendorContact/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendorcontactRepository.Delete(id);
            vendorcontactRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

