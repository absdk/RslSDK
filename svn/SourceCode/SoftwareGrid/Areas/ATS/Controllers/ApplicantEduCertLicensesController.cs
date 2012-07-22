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
    public class ApplicantEduCertLicensesController : ATSBaseController
    {
        private readonly IApplicantRepository applicantRepository;
        private readonly ISkillsExpEduCategoryRepository skillsexpeducategoryRepository;
        private readonly ISkillsExpEduRepository skillsexpeduRepository;
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly IUserRepository userRepository;
        private readonly IApplicantEduCertLicenseRepository applicanteducertlicenseRepository;
        public ApplicantEduCertLicensesController(IApplicantRepository applicantRepository, ISkillsExpEduCategoryRepository skillsexpeducategoryRepository, ISkillsExpEduRepository skillsexpeduRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IUserRepository userRepository, IApplicantEduCertLicenseRepository applicanteducertlicenseRepository)
        {
            this.applicantRepository = applicantRepository;
            this.skillsexpeducategoryRepository = skillsexpeducategoryRepository;
            this.skillsexpeduRepository = skillsexpeduRepository;
            this.countryRepository = countryRepository;
            this.stateRepository = stateRepository;
            this.userRepository = userRepository;
            this.applicanteducertlicenseRepository = applicanteducertlicenseRepository;
        }

        //
        // GET: /ApplicantEduCertLicenses/
        [UserAuthorize]
        public ViewResult Index(int applicantId)
        {
            return View(applicanteducertlicenseRepository.AllIncluding(applicantId,applicanteducertlicense => applicanteducertlicense.Applicant, applicanteducertlicense => applicanteducertlicense.SkillsExpEduCategory, applicanteducertlicense => applicanteducertlicense.SkillsExpEdu, applicanteducertlicense => applicanteducertlicense.Country, applicanteducertlicense => applicanteducertlicense.State, applicanteducertlicense => applicanteducertlicense.VerifiedByUser));
        }

        public ViewResult Search(ApplicantEduCertLicense searchApplicantEduCertLicense, int applicantId)
        {
            if (searchApplicantEduCertLicense != null)
            {
            }
            return View("Index", applicanteducertlicenseRepository.AllIncluding(applicantId,applicanteducertlicense => applicanteducertlicense.Applicant, applicanteducertlicense => applicanteducertlicense.SkillsExpEduCategory, applicanteducertlicense => applicanteducertlicense.SkillsExpEdu, applicanteducertlicense => applicanteducertlicense.Country, applicanteducertlicense => applicanteducertlicense.State, applicanteducertlicense => applicanteducertlicense.VerifiedByUser));
        }

        //
        // GET: /ApplicantEduCertLicenses/Details/5
        [UserAuthorize]
        public ViewResult Details(int id, int applicantId)
        {
            return View(applicanteducertlicenseRepository.Find(id));
        }

        //
        // GET: /ApplicantEduCertLicenses/Create
        [UserAuthorize]
        public ActionResult Create(int applicantId)
        {
            ApplicantEduCertLicense applicanteducertlicense = new ApplicantEduCertLicense();
            ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
            ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            applicanteducertlicense.ApplicantID = applicantId;
            return View(applicanteducertlicense);
        }

        //
        // POST: /ApplicantEduCertLicenses/Create
        [HttpPost]
        public ActionResult Create(ApplicantEduCertLicense applicanteducertlicense,int applicantId)
        {
            if (ModelState.IsValid)
            {
                applicanteducertlicenseRepository.InsertOrUpdate(applicanteducertlicense);
                applicanteducertlicenseRepository.Save();
                return RedirectToAction("Index", new { applicantId = applicantId });
            }
            else
            {
                ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
                ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                return View(applicanteducertlicense);
            }
        }

        //
        // GET: /ApplicantEduCertLicenses/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id, int applicantId)
        {
            ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
            ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            return View(applicanteducertlicenseRepository.Find(id));
        }

        //
        // POST: /ApplicantEduCertLicenses/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantEduCertLicense applicanteducertlicense, int applicantId)
        {
            if (ModelState.IsValid)
            {
                applicanteducertlicenseRepository.InsertOrUpdate(applicanteducertlicense);
                applicanteducertlicenseRepository.Save();
                return RedirectToAction("Index", new { applicantId = applicantId });
            }
            else
            {
                ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
                ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                return View(applicanteducertlicense);
            }
        }

        //
        // GET: /ApplicantEduCertLicenses/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id, int applicantId)
        {
            return View(applicanteducertlicenseRepository.Find(id));
        }

        //
        // POST: /ApplicantEduCertLicenses/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id, int applicantId)
        {
            applicanteducertlicenseRepository.Delete(id);
            applicanteducertlicenseRepository.Save();

            return RedirectToAction("Index", new { applicantId = applicantId });
        }
    }
}

