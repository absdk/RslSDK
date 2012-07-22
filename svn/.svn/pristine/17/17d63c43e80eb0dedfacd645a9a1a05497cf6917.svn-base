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
namespace SoftwareGrid.Areas.ATS.Controllers
{
    public class ApplicantController : UserBaseController
    {
        private readonly IContactProfessionTypeRepository contactprofessiontypeRepository;
        private readonly IExperienceLevelCategoryRepository experiencelevelcategoryRepository;
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly IApplicantAvailabilityStatusCategoryRepository applicantavailabilitystatuscategoryRepository;
        private readonly IApplicantSourceCategoryRepository applicantsourcecategoryRepository;
        private readonly IUserRepository userRepository;
        private readonly IApplicantRepository applicantRepository;
        public ApplicantController(IContactProfessionTypeRepository contactprofessiontypeRepository, IExperienceLevelCategoryRepository experiencelevelcategoryRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IApplicantAvailabilityStatusCategoryRepository applicantavailabilitystatuscategoryRepository, IApplicantSourceCategoryRepository applicantsourcecategoryRepository, IUserRepository userRepository, IApplicantRepository applicantRepository)
        {
            this.contactprofessiontypeRepository = contactprofessiontypeRepository;
            this.experiencelevelcategoryRepository = experiencelevelcategoryRepository;
            this.countryRepository = countryRepository;
            this.stateRepository = stateRepository;
            this.applicantavailabilitystatuscategoryRepository = applicantavailabilitystatuscategoryRepository;
            this.applicantsourcecategoryRepository = applicantsourcecategoryRepository;
            this.userRepository = userRepository;
            this.applicantRepository = applicantRepository;
        }

        //
        // GET: /Applicants/
        [UserAuthorize]
        public ViewResult Index()
        {
            ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
            ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleNationalities = ViewBag.PossibleCountries;
            ViewBag.PossibleApplicantAvailabilityStatusCategories = applicantavailabilitystatuscategoryRepository.All;
            ViewBag.PossibleApplicantSourceCategories = applicantsourcecategoryRepository.All;
            return View(applicantRepository.AllIncluding(applicant => applicant.ContactProfessionType, applicant => applicant.ExperienceLevelCategory, applicant => applicant.Country, applicant => applicant.State, applicant => applicant.Nationality, applicant => applicant.ApplicantAvailabilityStatusCategory, applicant => applicant.ApplicantSourceCategory, applicant => applicant.CreatedByUser, applicant => applicant.VerifiedByUser));
        }

        public ViewResult Search(Applicant searchApplicant)
        {
            if (searchApplicant != null)
            {
                ViewData["ApplicantDisplayId"] = searchApplicant.ApplicantDisplayId;
                ViewData["FirstName"] = searchApplicant.FirstName;
                ViewData["LastName"] = searchApplicant.LastName;
                ViewData["ContactProfessionTypeID"] = searchApplicant.ContactProfessionTypeID;
                ViewData["ExperienceLevelCategoryID"] = searchApplicant.ExperienceLevelCategoryID;
                ViewData["ProfessionalSummary"] = searchApplicant.ProfessionalSummary;
                ViewData["City"] = searchApplicant.City;
                ViewData["CountryID"] = searchApplicant.CountryID;
                ViewData["StateID"] = searchApplicant.StateID;
                if (searchApplicant.ApplicantAvailabilityStatusCategoryID > 0)
                {
                    ViewData["ApplicantAvailabilityStatusCategoryID"] = searchApplicant.ApplicantAvailabilityStatusCategoryID;
                }
                if (searchApplicant.ApplicantSourceCategoryID > 0)
                {
                    ViewData["ApplicantSourceCategoryID"] = searchApplicant.ApplicantSourceCategoryID;
                }
            }
            ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
            ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleNationalities = ViewBag.PossibleCountries;
            ViewBag.PossibleApplicantAvailabilityStatusCategories = applicantavailabilitystatuscategoryRepository.All;
            ViewBag.PossibleApplicantSourceCategories = applicantsourcecategoryRepository.All;
            ModelState.Clear();
            return View("Index", applicantRepository.AllIncluding(applicant => applicant.ContactProfessionType, applicant => applicant.ExperienceLevelCategory, applicant => applicant.Country, applicant => applicant.State, applicant => applicant.Nationality, applicant => applicant.ApplicantAvailabilityStatusCategory, applicant => applicant.ApplicantSourceCategory, applicant => applicant.CreatedByUser, applicant => applicant.VerifiedByUser));
        }

        //
        // GET: /Applicants/Details/5
        [UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantRepository.Find(id));
        }

        //
        // GET: /Applicants/Create
        [UserAuthorize]
        public ActionResult Create()
        {
            Applicant applicant = new Applicant();
            ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
            ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleNationalities = ViewBag.PossibleCountries;
            ViewBag.PossibleApplicantAvailabilityStatusCategories = applicantavailabilitystatuscategoryRepository.All;
            ViewBag.PossibleApplicantSourceCategories = applicantsourcecategoryRepository.All;
            applicant.CreatedDate = DateTime.Now;
            applicant.CreatedByUserID = CurrentLoggedInUser.UserID;
            return View(applicant);
        }

        //
        // POST: /Applicants/Create
        [HttpPost]
        public ActionResult Create(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                if (Session["WordResume"] != null)
                {
                    var fileName = Session["WordResume"].ToString();
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    applicant.WordResume = Utility.ReadFile(physicalPath);
                }
                if (Session["Photo"] != null)
                {
                    var fileName = Session["Photo"].ToString();
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    applicant.Photo = Utility.ReadFile(physicalPath);
                }
                applicant.LastUpdateDate = DateTime.Now;
                applicantRepository.InsertOrUpdate(applicant);
                applicantRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
                ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                ViewBag.PossibleNationalities = ViewBag.PossibleCountries;
                ViewBag.PossibleApplicantAvailabilityStatusCategories = applicantavailabilitystatuscategoryRepository.All;
                ViewBag.PossibleApplicantSourceCategories = applicantsourcecategoryRepository.All;
                return View(applicant);
            }
        }

        //
        // GET: /Applicants/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int applicantId)
        {
            
            ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
            ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleNationalities = ViewBag.PossibleCountries;
            ViewBag.PossibleApplicantAvailabilityStatusCategories = applicantavailabilitystatuscategoryRepository.All;
            ViewBag.PossibleApplicantSourceCategories = applicantsourcecategoryRepository.All;
            Applicant applicant = applicantRepository.Find(applicantId);
            if (applicant.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(applicant.CountryID.Value);
            }
            ViewBag.ApplicantId = applicantId;
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.ApplicantLandingMenu = repository.GetApplicantLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
            ViewBag.OverviewApplicant = applicant;
            return View(applicant);
        }

        //
        // POST: /Applicants/Edit/5
        [HttpPost]
        public ActionResult Edit(Applicant applicant)
        {
            if (ModelState.IsValid)
            {
                if (Session["WordResume"] != null)
                {
                    var fileName = Session["WordResume"].ToString();
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    applicant.WordResume = Utility.ReadFile(physicalPath);
                }
                if (Session["Photo"] != null)
                {
                    var fileName = Session["Photo"].ToString();
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    applicant.Photo = Utility.ReadFile(physicalPath);
                }
                applicant.LastUpdateDate = DateTime.Now;
                if (applicant.ApplicantDisplayId.IsNullOrEmpty())
                {
                    applicant.ApplicantDisplayId = MiscUtility.GetApplicantPersonalizedId();
                }
                applicantRepository.InsertOrUpdate(applicant);
                applicantRepository.Save();
                return RedirectToAction("Overview", new { id = applicant.ApplicantID });
            }
            else
            {
                ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
                ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                if (applicant.CountryID.HasValue)
                {
                    ViewBag.PossibleStates = stateRepository.FindAllByCountryID(applicant.CountryID.Value);
                }
                ViewBag.PossibleNationalities = ViewBag.PossibleCountries;
                ViewBag.PossibleApplicantAvailabilityStatusCategories = applicantavailabilitystatuscategoryRepository.All;
                ViewBag.PossibleApplicantSourceCategories = applicantsourcecategoryRepository.All;
                return View(applicant);
            }
        }

        //
        // GET: /Applicants/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantRepository.Find(id));
        }

        //
        // POST: /Applicants/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantRepository.Delete(id);
            applicantRepository.Save();

            return RedirectToAction("Index");
        }

        //
        // GET: /Applicants/Details/5
        [UserAuthorize]
        public ViewResult Overview(int id)
        {
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.ApplicantLandingMenu = repository.GetApplicantLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
            ViewBag.ApplicantId = id;
            if (ViewBag.OverviewApplicant != null)
            {
                return View(ViewBag.OverviewApplicant);
            }
            else
            {
                ViewBag.OverviewApplicant = applicantRepository.Find(id);
                return View(ViewBag.OverviewApplicant);
            }
        }
    }
}

