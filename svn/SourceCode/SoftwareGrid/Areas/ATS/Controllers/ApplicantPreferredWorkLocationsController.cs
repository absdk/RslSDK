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
    public class ApplicantPreferredWorkLocationsController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly ICountryRepository countryRepository;
		private readonly IStateRepository stateRepository;
		private readonly ICityRepository cityRepository;
		private readonly IApplicantPreferredWorkLocationRepository applicantpreferredworklocationRepository;
        public ApplicantPreferredWorkLocationsController(IApplicantRepository applicantRepository, ICountryRepository countryRepository, IStateRepository stateRepository, ICityRepository cityRepository, IApplicantPreferredWorkLocationRepository applicantpreferredworklocationRepository)
        {
			this.applicantRepository = applicantRepository;
			this.countryRepository = countryRepository;
			this.stateRepository = stateRepository;
			this.cityRepository = cityRepository;
			this.applicantpreferredworklocationRepository = applicantpreferredworklocationRepository;
        }

        //
        // GET: /ApplicantPreferredWorkLocations/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantpreferredworklocationRepository.AllIncluding(applicantpreferredworklocation => applicantpreferredworklocation.Applicant, applicantpreferredworklocation => applicantpreferredworklocation.Country, applicantpreferredworklocation => applicantpreferredworklocation.State, applicantpreferredworklocation => applicantpreferredworklocation.City));
        }
		
		public ViewResult Search(ApplicantPreferredWorkLocation searchApplicantPreferredWorkLocation)
        {
			if(searchApplicantPreferredWorkLocation!=null)
			{
							}
						return View("Index",applicantpreferredworklocationRepository.AllIncluding(applicantpreferredworklocation => applicantpreferredworklocation.Applicant, applicantpreferredworklocation => applicantpreferredworklocation.Country, applicantpreferredworklocation => applicantpreferredworklocation.State, applicantpreferredworklocation => applicantpreferredworklocation.City));
		}

        //
        // GET: /ApplicantPreferredWorkLocations/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantpreferredworklocationRepository.Find(id));
        }

        //
        // GET: /ApplicantPreferredWorkLocations/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantPreferredWorkLocation applicantpreferredworklocation = new ApplicantPreferredWorkLocation();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleCountries = countryRepository.All;
			ViewBag.PossibleStates = stateRepository.All;
			ViewBag.PossibleCities = cityRepository.All;
            return View(applicantpreferredworklocation);
        } 

        //
        // POST: /ApplicantPreferredWorkLocations/Create
        [HttpPost]
        public ActionResult Create(ApplicantPreferredWorkLocation applicantpreferredworklocation)
        {
            if (ModelState.IsValid) {
                applicantpreferredworklocationRepository.InsertOrUpdate(applicantpreferredworklocation);
                applicantpreferredworklocationRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleCountries = countryRepository.All;
				ViewBag.PossibleStates = stateRepository.All;
				ViewBag.PossibleCities = cityRepository.All;
				return View(applicantpreferredworklocation);
			}
        }
        
        //
        // GET: /ApplicantPreferredWorkLocations/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleCountries = countryRepository.All;
			ViewBag.PossibleStates = stateRepository.All;
			ViewBag.PossibleCities = cityRepository.All;
             return View(applicantpreferredworklocationRepository.Find(id));
        }

        //
        // POST: /ApplicantPreferredWorkLocations/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantPreferredWorkLocation applicantpreferredworklocation)
        {
            if (ModelState.IsValid) {
                applicantpreferredworklocationRepository.InsertOrUpdate(applicantpreferredworklocation);
                applicantpreferredworklocationRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleCountries = countryRepository.All;
				ViewBag.PossibleStates = stateRepository.All;
				ViewBag.PossibleCities = cityRepository.All;
				return View(applicantpreferredworklocation);
			}
        }

        //
        // GET: /ApplicantPreferredWorkLocations/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantpreferredworklocationRepository.Find(id));
        }

        //
        // POST: /ApplicantPreferredWorkLocations/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantpreferredworklocationRepository.Delete(id);
            applicantpreferredworklocationRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

