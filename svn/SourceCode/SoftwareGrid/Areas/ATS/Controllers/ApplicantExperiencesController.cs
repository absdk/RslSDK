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
    public class ApplicantExperiencesController : ATSBaseController
    {
        private readonly IApplicantRepository applicantRepository;
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly IEmploymentLeaveReasonCategoryRepository employmentleavereasoncategoryRepository;
        private readonly IUserRepository userRepository;
        private readonly IApplicantExperienceRepository applicantexperienceRepository;
        public ApplicantExperiencesController(IApplicantRepository applicantRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IEmploymentLeaveReasonCategoryRepository employmentleavereasoncategoryRepository, IUserRepository userRepository, IApplicantExperienceRepository applicantexperienceRepository)
        {
            this.applicantRepository = applicantRepository;
            this.countryRepository = countryRepository;
            this.stateRepository = stateRepository;
            this.employmentleavereasoncategoryRepository = employmentleavereasoncategoryRepository;
            this.userRepository = userRepository;
            this.applicantexperienceRepository = applicantexperienceRepository;
        }

        //
        // GET: /ApplicantExperiences/
        [UserAuthorize]
        public ViewResult Index(int applicantId)
        {
            return View(applicantexperienceRepository.AllIncluding(applicantId,applicantexperience => applicantexperience.Applicant, applicantexperience => applicantexperience.Country, applicantexperience => applicantexperience.State, applicantexperience => applicantexperience.EmploymentLeaveReasonCategory, applicantexperience => applicantexperience.VerifiedByUser));
        }

        public ViewResult Search(int applicantId,ApplicantExperience searchApplicantExperience)
        {
            if (searchApplicantExperience != null)
            {
            }
            return View("Index", applicantexperienceRepository.AllIncluding(applicantId,applicantexperience => applicantexperience.Applicant, applicantexperience => applicantexperience.Country, applicantexperience => applicantexperience.State, applicantexperience => applicantexperience.EmploymentLeaveReasonCategory, applicantexperience => applicantexperience.VerifiedByUser));
        }

        //
        // GET: /ApplicantExperiences/Details/5
        [UserAuthorize]
        public ViewResult Details(int id, int applicantId)
        {
            return View(applicantexperienceRepository.Find(id));
        }

        //
        // GET: /ApplicantExperiences/Create
        [UserAuthorize]
        public ActionResult Create(int applicantId)
        {
            ApplicantExperience applicantexperience = new ApplicantExperience();
            applicantexperience.ApplicantID = applicantId;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleStates = stateRepository.All;
            ViewBag.PossibleEmploymentLeaveReasonCategories = employmentleavereasoncategoryRepository.All;
            return View(applicantexperience);
        }

        //
        // POST: /ApplicantExperiences/Create
        [HttpPost]
        public ActionResult Create(ApplicantExperience applicantexperience, int applicantId)
        {
            if (ModelState.IsValid)
            {
                applicantexperienceRepository.InsertOrUpdate(applicantexperience);
                applicantexperienceRepository.Save();
                return RedirectToAction("Index", new { applicantId = applicantexperience.ApplicantID });
            }
            else
            {
                ViewBag.PossibleCountries = countryRepository.All;
                ViewBag.PossibleStates = stateRepository.All;
                ViewBag.PossibleEmploymentLeaveReasonCategories = employmentleavereasoncategoryRepository.All;
                return View(applicantexperience);
            }
        }

        //
        // GET: /ApplicantExperiences/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id,int applicantId)
        {
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleStates = stateRepository.All;
            ViewBag.PossibleEmploymentLeaveReasonCategories = employmentleavereasoncategoryRepository.All;
            return View(applicantexperienceRepository.Find(id));
        }

        //
        // POST: /ApplicantExperiences/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantExperience applicantexperience)
        {
            if (ModelState.IsValid)
            {
                applicantexperienceRepository.InsertOrUpdate(applicantexperience);
                applicantexperienceRepository.Save();
                return RedirectToAction("Index", new { applicantId = applicantexperience.ApplicantID });
            }
            else
            {
                ViewBag.PossibleCountries = countryRepository.All;
                ViewBag.PossibleStates = stateRepository.All;
                ViewBag.PossibleEmploymentLeaveReasonCategories = employmentleavereasoncategoryRepository.All;
                return View(applicantexperience);
            }
        }

        //
        // GET: /ApplicantExperiences/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id, int applicantId)
        {
            return View(applicantexperienceRepository.Find(id));
        }

        //
        // POST: /ApplicantExperiences/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id, int applicantId)
        {
            applicantexperienceRepository.Delete(id);
            applicantexperienceRepository.Save();

            return RedirectToAction("Index", new { applicantId = applicantId });
        }
    }
}

