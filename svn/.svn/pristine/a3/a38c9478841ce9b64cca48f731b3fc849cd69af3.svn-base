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
namespace SoftwareGrid.Areas.CRM.Controllers
{
    public class CompanyAddressesController : CRMBaseController
    {
        private readonly ICompanyRepository companyRepository;
        private readonly ICompanyAddressCategoryRepository companyaddresscategoryRepository;
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly ICompanyAddressRepository companyaddressRepository;
        public CompanyAddressesController(ICompanyRepository companyRepository, ICompanyAddressCategoryRepository companyaddresscategoryRepository, ICountryRepository countryRepository, IStateRepository stateRepository, ICompanyAddressRepository companyaddressRepository)
        {
            this.companyRepository = companyRepository;
            this.companyaddresscategoryRepository = companyaddresscategoryRepository;
            this.countryRepository = countryRepository;
            this.stateRepository = stateRepository;
            this.companyaddressRepository = companyaddressRepository;
        }

        //
        // GET: /CompanyAddresses/
        [UserAuthorize]
        public ViewResult Index(int companyId)
        {
            return View(companyaddressRepository.AllIncluding(companyId, companyaddress => companyaddress.Company, companyaddress => companyaddress.CompanyAddressCategory, companyaddress => companyaddress.Country, companyaddress => companyaddress.State));
        }

        public ViewResult Search(CompanyAddress searchCompanyAddress, int companyId)
        {
            if (searchCompanyAddress != null)
            {
            }
            return View("Index", companyaddressRepository.AllIncluding(companyId, companyaddress => companyaddress.Company, companyaddress => companyaddress.CompanyAddressCategory, companyaddress => companyaddress.Country, companyaddress => companyaddress.State));
        }

        //
        // GET: /CompanyAddresses/Details/5
        [UserAuthorize]
        public ViewResult Details(int id, int companyId)
        {
            return View(companyaddressRepository.Find(id));
        }

        //
        // GET: /CompanyAddresses/Create
        [UserAuthorize]
        public ActionResult Create(int companyId)
        {
            CompanyAddress companyaddress = new CompanyAddress();
            companyaddress.CompanyID = companyId;
            ViewBag.PossibleCompanyAddressCategories = companyaddresscategoryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            return View(companyaddress);
        }

        //
        // POST: /CompanyAddresses/Create
        [HttpPost]
        public ActionResult Create(CompanyAddress companyaddress, int companyId)
        {
            if (ModelState.IsValid)
            {
                companyaddressRepository.InsertOrUpdate(companyaddress);
                companyaddressRepository.Save();
                return RedirectToAction("Index", new { companyId=companyId });
            }
            else
            {
                ViewBag.PossibleCompanyAddressCategories = companyaddresscategoryRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                return View(companyaddress);
            }
        }

        //
        // GET: /CompanyAddresses/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id, int companyId)
        {
            CompanyAddress companyAddress = companyaddressRepository.Find(id);
            ViewBag.PossibleCompanyAddressCategories = companyaddresscategoryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            if(companyAddress.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(companyAddress.CountryID.Value);
            }
            return View(companyAddress);
        }

        //
        // POST: /CompanyAddresses/Edit/5
        [HttpPost]
        public ActionResult Edit(CompanyAddress companyAddress, int companyId)
        {
            if (ModelState.IsValid)
            {
                companyaddressRepository.InsertOrUpdate(companyAddress);
                companyaddressRepository.Save();
                return RedirectToAction("Index", new { companyId = companyId });
            }
            else
            {
                ViewBag.PossibleCompanyAddressCategories = companyaddresscategoryRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                if (companyAddress.CountryID.HasValue)
                {
                    ViewBag.PossibleStates = stateRepository.FindAllByCountryID(companyAddress.CountryID.Value);
                }
                return View(companyAddress);
            }
        }

        //
        // GET: /CompanyAddresses/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id, int companyId)
        {
            return View(companyaddressRepository.Find(id));
        }

        //
        // POST: /CompanyAddresses/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id, int companyId)
        {
            companyaddressRepository.Delete(id);
            companyaddressRepository.Save();

            return RedirectToAction("Index", new { companyId = companyId });
        }
    }
}

