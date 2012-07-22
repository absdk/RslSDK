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
namespace SoftwareGrid.Areas.ATS.Controllers
{
    public class ApplicantAdditionalAddressesController : ATSBaseController
    {
        private readonly IApplicantRepository applicantRepository;
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly IApplicantAdditionalAddressRepository applicantadditionaladdressRepository;
        public ApplicantAdditionalAddressesController(IApplicantRepository applicantRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IApplicantAdditionalAddressRepository applicantadditionaladdressRepository)
        {
            this.applicantRepository = applicantRepository;
            this.countryRepository = countryRepository;
            this.stateRepository = stateRepository;
            this.applicantadditionaladdressRepository = applicantadditionaladdressRepository;
        }

        //
        // GET: /ApplicantAdditionalAddresses/
        [UserAuthorize]
        public ViewResult Index(int applicantId)
        {
            return View(applicantadditionaladdressRepository.AllIncluding(applicantId, applicantadditionaladdress => applicantadditionaladdress.Applicant, applicantadditionaladdress => applicantadditionaladdress.Country, applicantadditionaladdress => applicantadditionaladdress.State));
        }

        public ViewResult Search(ApplicantAdditionalAddress searchApplicantAdditionalAddress, int applicantId)
        {
            if (searchApplicantAdditionalAddress != null)
            {
            }
            return View("Index", applicantadditionaladdressRepository.AllIncluding(applicantId, applicantadditionaladdress => applicantadditionaladdress.Applicant, applicantadditionaladdress => applicantadditionaladdress.Country, applicantadditionaladdress => applicantadditionaladdress.State));
        }

        //
        // GET: /ApplicantAdditionalAddresses/Details/5
        [UserAuthorize]
        public ViewResult Details(int id, int applicantId)
        {
            return View(applicantadditionaladdressRepository.Find(id));
        }

        //
        // GET: /ApplicantAdditionalAddresses/Create
        [UserAuthorize]
        public ActionResult Create(int applicantId)
        {
            ApplicantAdditionalAddress applicantadditionaladdress = new ApplicantAdditionalAddress();
            ViewBag.PossibleCountries = countryRepository.All;
            applicantadditionaladdress.ApplicantID = applicantId;
            return View(applicantadditionaladdress);
        }

        //
        // POST: /ApplicantAdditionalAddresses/Create
        [HttpPost]
        public ActionResult Create(ApplicantAdditionalAddress applicantadditionaladdress, int applicantId)
        {
            if (ModelState.IsValid)
            {
                applicantadditionaladdressRepository.InsertOrUpdate(applicantadditionaladdress);
                applicantadditionaladdressRepository.Save();
                return RedirectToAction("Index", new { applicantId = applicantId });
            }
            else
            {
                ViewBag.PossibleCountries = countryRepository.All;
                return View(applicantadditionaladdress);
            }
        }

        //
        // GET: /ApplicantAdditionalAddresses/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id, int applicantId)
        {
            ApplicantAdditionalAddress applicantAdditionalAddress = applicantadditionaladdressRepository.Find(id);
            ViewBag.PossibleCountries = countryRepository.All;
            if (applicantAdditionalAddress.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(applicantAdditionalAddress.CountryID.Value);
            }
            return View(applicantAdditionalAddress);
        }

        //
        // POST: /ApplicantAdditionalAddresses/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantAdditionalAddress applicantadditionaladdress, int applicantId)
        {
            if (ModelState.IsValid)
            {
                applicantadditionaladdressRepository.InsertOrUpdate(applicantadditionaladdress);
                applicantadditionaladdressRepository.Save();
                return RedirectToAction("Index", new { applicantId = applicantId });
            }
            else
            {
                ViewBag.PossibleCountries = countryRepository.All;
                return View(applicantadditionaladdress);
            }
        }

        //
        // GET: /ApplicantAdditionalAddresses/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id, int applicantId)
        {
            return View(applicantadditionaladdressRepository.Find(id));
        }

        //
        // POST: /ApplicantAdditionalAddresses/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id, int applicantId)
        {
            applicantadditionaladdressRepository.Delete(id);
            applicantadditionaladdressRepository.Save();

            return RedirectToAction("Index", new { applicantId = applicantId });
        }
    }
}

