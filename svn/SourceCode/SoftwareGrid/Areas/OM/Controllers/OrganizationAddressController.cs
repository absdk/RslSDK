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
namespace SoftwareGrid.Areas.OM.Controllers
{   
    public class OrganizationAddressController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationAddressCategoryRepository organizationaddresscategoryRepository;
		private readonly ICountryRepository countryRepository;
		private readonly IStateRepository stateRepository;
		private readonly IOrganizationAddressRepository organizationaddressRepository;
        public OrganizationAddressController(IOrganizationRepository organizationRepository, IOrganizationAddressCategoryRepository organizationaddresscategoryRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IOrganizationAddressRepository organizationaddressRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationaddresscategoryRepository = organizationaddresscategoryRepository;
			this.countryRepository = countryRepository;
			this.stateRepository = stateRepository;
			this.organizationaddressRepository = organizationaddressRepository;
        }

        //
        // GET: /OrganizationAddress/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationaddressRepository.AllIncluding(organizationId,organizationaddress => organizationaddress.Organization, organizationaddress => organizationaddress.OrganizationAddressCategory, organizationaddress => organizationaddress.Country, organizationaddress => organizationaddress.State));
        }
		
		public ViewResult Search(OrganizationAddress searchOrganizationAddress,int organizationId)
        {
			if(searchOrganizationAddress!=null)
			{
							}
						return View("Index",organizationaddressRepository.AllIncluding(organizationId,organizationaddress => organizationaddress.Organization, organizationaddress => organizationaddress.OrganizationAddressCategory, organizationaddress => organizationaddress.Country, organizationaddress => organizationaddress.State));
		}

        //
        // GET: /OrganizationAddress/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationaddressRepository.Find(id));
        }

        //
        // GET: /OrganizationAddress/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationAddress organizationaddress = new OrganizationAddress();
			organizationaddress.OrganizationID = organizationId;
			ViewBag.PossibleOrganizationAddressCategories = organizationaddresscategoryRepository.All;
			ViewBag.PossibleCountries = countryRepository.All;
            return View(organizationaddress);
        } 

        //
        // POST: /OrganizationAddress/Create
        [HttpPost]
        public ActionResult Create(OrganizationAddress organizationaddress,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationaddressRepository.InsertOrUpdate(organizationaddress);
                organizationaddressRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				ViewBag.PossibleOrganizationAddressCategories = organizationaddresscategoryRepository.All;
				ViewBag.PossibleCountries = countryRepository.All;
				return View(organizationaddress);
			}
        }
        
        //
        // GET: /OrganizationAddress/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationAddress organizationaddress = organizationaddressRepository.Find(id);
						ViewBag.PossibleOrganizationAddressCategories = organizationaddresscategoryRepository.All;
						ViewBag.PossibleCountries = countryRepository.All;
						if (organizationaddress.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(organizationaddress.CountryID.Value);
            }
			             return View(organizationaddress);
        }

        //
        // POST: /OrganizationAddress/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationAddress organizationaddress,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationaddressRepository.InsertOrUpdate(organizationaddress);
                organizationaddressRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
						ViewBag.PossibleOrganizationAddressCategories = organizationaddresscategoryRepository.All;
						ViewBag.PossibleCountries = countryRepository.All;
						if (organizationaddress.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(organizationaddress.CountryID.Value);
            }
							return View(organizationaddress);
			}
        }

        //
        // GET: /OrganizationAddress/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationaddressRepository.Find(id));
        }

        //
        // POST: /OrganizationAddress/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationaddressRepository.Delete(id);
            organizationaddressRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

