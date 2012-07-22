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
    public class ApplicantAdditionalInfoesController : ATSBaseController
    {
        private readonly IApplicantRepository applicantRepository;
        private readonly IVeteranCategoryRepository veterancategoryRepository;
        private readonly IMaritalStatusRepository maritalstatusRepository;
        private readonly IGenderRepository genderRepository;
        private readonly IReligionRepository religionRepository;
        private readonly ICurrencyRepository currencyRepository;
        private readonly ISalaryRateTypeRepository salaryratetypeRepository;
        private readonly IEmploymentTypeRepository employmenttypeRepository;
        private readonly IApplicantAdditionalInfoRepository applicantadditionalinfoRepository;
        public ApplicantAdditionalInfoesController(IApplicantRepository applicantRepository, IVeteranCategoryRepository veterancategoryRepository, IMaritalStatusRepository maritalstatusRepository, IGenderRepository genderRepository, IReligionRepository religionRepository, ICurrencyRepository currencyRepository, ISalaryRateTypeRepository salaryratetypeRepository, IEmploymentTypeRepository employmenttypeRepository, IApplicantAdditionalInfoRepository applicantadditionalinfoRepository)
        {
            this.applicantRepository = applicantRepository;
            this.veterancategoryRepository = veterancategoryRepository;
            this.maritalstatusRepository = maritalstatusRepository;
            this.genderRepository = genderRepository;
            this.religionRepository = religionRepository;
            this.currencyRepository = currencyRepository;
            this.salaryratetypeRepository = salaryratetypeRepository;
            this.employmenttypeRepository = employmenttypeRepository;
            this.applicantadditionalinfoRepository = applicantadditionalinfoRepository;
        }

        //
        // GET: /ApplicantAdditionalInfoes/
        [UserAuthorize]
        public ViewResult Index()
        {
            return View(applicantadditionalinfoRepository.AllIncluding(applicantadditionalinfo => applicantadditionalinfo.Applicant, applicantadditionalinfo => applicantadditionalinfo.VeteranCategory, applicantadditionalinfo => applicantadditionalinfo.MaritalStatus, applicantadditionalinfo => applicantadditionalinfo.Gender, applicantadditionalinfo => applicantadditionalinfo.Religion, applicantadditionalinfo => applicantadditionalinfo.Currency, applicantadditionalinfo => applicantadditionalinfo.SalaryRateType, applicantadditionalinfo => applicantadditionalinfo.EmploymentType));
        }

        public ViewResult Search(ApplicantAdditionalInfo searchApplicantAdditionalInfo)
        {
            if (searchApplicantAdditionalInfo != null)
            {
            }
            return View("Index", applicantadditionalinfoRepository.AllIncluding(applicantadditionalinfo => applicantadditionalinfo.Applicant, applicantadditionalinfo => applicantadditionalinfo.VeteranCategory, applicantadditionalinfo => applicantadditionalinfo.MaritalStatus, applicantadditionalinfo => applicantadditionalinfo.Gender, applicantadditionalinfo => applicantadditionalinfo.Religion, applicantadditionalinfo => applicantadditionalinfo.Currency, applicantadditionalinfo => applicantadditionalinfo.SalaryRateType, applicantadditionalinfo => applicantadditionalinfo.EmploymentType));
        }

        //
        // GET: /ApplicantAdditionalInfoes/Details/5
        [UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantadditionalinfoRepository.Find(id));
        }

        //
        // GET: /ApplicantAdditionalInfoes/Create
        [UserAuthorize]
        public ActionResult Create()
        {
            ApplicantAdditionalInfo applicantadditionalinfo = new ApplicantAdditionalInfo();
            ViewBag.PossibleApplicants = applicantRepository.All;
            ViewBag.PossibleVeteranCategories = veterancategoryRepository.All;
            ViewBag.PossibleMaritalStatus = maritalstatusRepository.All;
            ViewBag.PossibleGenders = genderRepository.All;
            ViewBag.PossibleReligions = religionRepository.All;
            ViewBag.PossibleCurrencies = currencyRepository.All;
            ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
            ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
            return View(applicantadditionalinfo);
        }

        //
        // POST: /ApplicantAdditionalInfoes/Create
        [HttpPost]
        public ActionResult Create(ApplicantAdditionalInfo applicantadditionalinfo)
        {
            if (ModelState.IsValid)
            {
                applicantadditionalinfoRepository.InsertOrUpdate(applicantadditionalinfo);
                applicantadditionalinfoRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleVeteranCategories = veterancategoryRepository.All;
                ViewBag.PossibleMaritalStatus = maritalstatusRepository.All;
                ViewBag.PossibleGenders = genderRepository.All;
                ViewBag.PossibleReligions = religionRepository.All;
                ViewBag.PossibleCurrencies = currencyRepository.All;
                ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
                ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
                return View(applicantadditionalinfo);
            }
        }

        //
        // GET: /ApplicantAdditionalInfoes/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int applicantId)
        {
            ViewBag.PossibleVeteranCategories = veterancategoryRepository.All;
            ViewBag.PossibleMaritalStatus = maritalstatusRepository.All;
            ViewBag.PossibleGenders = genderRepository.All;
            ViewBag.PossibleReligions = religionRepository.All;
            ViewBag.PossibleCurrencies = currencyRepository.All;
            ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
            ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
            return View(applicantadditionalinfoRepository.FindByApplicantId(applicantId));
        }

        //
        // POST: /ApplicantAdditionalInfoes/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantAdditionalInfo applicantadditionalinfo)
        {
            if (ModelState.IsValid)
            {
                applicantadditionalinfoRepository.InsertOrUpdate(applicantadditionalinfo);
                applicantadditionalinfoRepository.Save();
                return RedirectToAction("Overview","Applicant", new { id = applicantadditionalinfo.ApplicantID });
            }
            else
            {
                ViewBag.PossibleVeteranCategories = veterancategoryRepository.All;
                ViewBag.PossibleMaritalStatus = maritalstatusRepository.All;
                ViewBag.PossibleGenders = genderRepository.All;
                ViewBag.PossibleReligions = religionRepository.All;
                ViewBag.PossibleCurrencies = currencyRepository.All;
                ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
                ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
                return View(applicantadditionalinfo);
            }
        }

        //
        // GET: /ApplicantAdditionalInfoes/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantadditionalinfoRepository.Find(id));
        }

        //
        // POST: /ApplicantAdditionalInfoes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantadditionalinfoRepository.Delete(id);
            applicantadditionalinfoRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

