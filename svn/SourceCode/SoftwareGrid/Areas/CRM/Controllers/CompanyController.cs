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
using EasySoft.Helper;
using System.IO;
namespace SoftwareGrid.Areas.CRM.Controllers
{
    public class CompanyController : UserBaseController
    {
        private readonly IIndustryRepository industryRepository;
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly ICompanyOwnerRepository companyownerRepository;
        private readonly ICompanyStatusCategoryRepository companystatuscategoryRepository;
        private readonly IUserRepository userRepository;
        private readonly ICompanyRepository companyRepository;
        public CompanyController(IIndustryRepository industryRepository, ICountryRepository countryRepository, IStateRepository stateRepository, ICompanyOwnerRepository companyownerRepository, ICompanyStatusCategoryRepository companystatuscategoryRepository, IUserRepository userRepository, ICompanyRepository companyRepository)
        {
            this.industryRepository = industryRepository;
            this.countryRepository = countryRepository;
            this.stateRepository = stateRepository;
            this.companyownerRepository = companyownerRepository;
            this.companystatuscategoryRepository = companystatuscategoryRepository;
            this.userRepository = userRepository;
            this.companyRepository = companyRepository;
        }

        //
        // GET: /Company/
        [UserAuthorize]
        public ViewResult Index()
        {
            ViewBag.PossibleIndustries = industryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleStates = stateRepository.All;
            ViewBag.PossibleCompanyStatusCategories = companystatuscategoryRepository.All;
            return View(companyRepository.AllIncluding(company => company.Industry, company => company.Country, company => company.State, company => company.CompanyOwner, company => company.CompanyStatusCategory, company => company.CreatedByUser, company => company.VerifiedByUser));
        }

        public ViewResult Search(Company searchCompany)
        {
            if (searchCompany != null)
            {
                ViewData["CompanyName"] = searchCompany.CompanyName;
                ViewData["CompanyDisplayId"] = searchCompany.CompanyDisplayId;
                ViewData["IndustryID"] = searchCompany.IndustryID;
                ViewData["CountryID"] = searchCompany.CountryID;
                ViewData["StateID"] = searchCompany.StateID;
                ViewData["CompanyStatusCategoryID"] = searchCompany.CompanyStatusCategoryID;
            }
            ViewBag.PossibleIndustries = industryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleStates = stateRepository.All;
            ViewBag.PossibleCompanyStatusCategories = companystatuscategoryRepository.All;
            return View("Index", companyRepository.AllIncluding(company => company.Industry, company => company.Country, company => company.State, company => company.CompanyOwner, company => company.CompanyStatusCategory, company => company.CreatedByUser, company => company.VerifiedByUser));
        }

        //
        // GET: /Company/Details/5
        [UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(companyRepository.Find(id));
        }

        //
        // GET: /Company/Create
        [UserAuthorize]
        public ActionResult Create()
        {
            Company company = new Company();
            ViewBag.PossibleIndustries = industryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleStates = stateRepository.All;
            ViewBag.PossibleCompanyOwners = companyownerRepository.All;
            ViewBag.PossibleCompanyStatusCategories = companystatuscategoryRepository.All;
            company.CreatedDate = DateTime.Now;
            company.CreatedByUserID = CurrentLoggedInUser.UserID;
            return View(company);
        }

        //
        // POST: /Company/Create
        [HttpPost]
        public ActionResult Create(Company company)
        {
            if (ModelState.IsValid)
            {
                if (Session["Logo"] != null)
                {
                    var fileName = Session["Logo"].ToString();
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    company.Logo = Utility.ReadFile(physicalPath);
                }
                if (company.CompanyRatingScaleID <= 0)
                {
                    company.CompanyRatingScaleID = null;
                }
                company.CompanyDisplayId = MiscUtility.GetCompanyPersonalizedId();
                companyRepository.InsertOrUpdate(company);
                companyRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.PossibleIndustries = industryRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                ViewBag.PossibleCompanyOwners = companyownerRepository.All;
                ViewBag.PossibleCompanyStatusCategories = companystatuscategoryRepository.All;
                return View(company);
            }
        }

        //
        // GET: /Company/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int companyId)
        {
            ViewBag.PossibleIndustries = industryRepository.All;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleCompanyOwners = companyownerRepository.All;
            ViewBag.PossibleCompanyStatusCategories = companystatuscategoryRepository.All;
            Company company = companyRepository.Find(companyId);
            if (company.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(company.CountryID.Value);
            }
            ViewBag.CompanyId = companyId;
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.CompanyLandingMenu = repository.GetCompanyLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
            ViewBag.CompanyOverviewHead = companyRepository.FindOverviewHead(companyId, company);
            return View(company);
        }

        //
        // POST: /Company/Edit/5
        [HttpPost]
        public ActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                if (Session["Logo"] != null)
                {
                    var fileName = Session["Logo"].ToString();
                    var physicalPath = Path.Combine(Server.MapPath(Constants.Paths.TemporaryFileUploadPath), fileName);
                    company.Logo = Utility.ReadFile(physicalPath);
                }
                if (company.CompanyRatingScaleID <= 0)
                {
                    company.CompanyRatingScaleID = null;
                } 
                if (company.CompanyDisplayId.IsNullOrEmpty())
                {
                    company.CompanyDisplayId = MiscUtility.GetCompanyPersonalizedId();
                }
                companyRepository.InsertOrUpdate(company);
                companyRepository.Save();
                return RedirectToAction("Overview", new { companyId = company.CompanyID });
            }
            else
            {
                ViewBag.PossibleIndustries = industryRepository.All;
                ViewBag.PossibleCountries = countryRepository.All;
                if (company.CountryID.HasValue)
                {
                    ViewBag.PossibleStates = stateRepository.FindAllByCountryID(company.CountryID.Value);
                }
                ViewBag.PossibleCompanyOwners = companyownerRepository.All;
                ViewBag.PossibleCompanyStatusCategories = companystatuscategoryRepository.All;
                return View(company);
            }
        }

        //
        // GET: /Company/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(companyRepository.Find(id));
        }

        //
        // POST: /Company/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            companyRepository.Delete(id);
            companyRepository.Save();

            return RedirectToAction("Index");
        }

        [UserAuthorize]
        public ViewResult Overview(int companyId)
        {
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.CompanyLandingMenu = repository.GetCompanyLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
            ViewBag.CompanyId = companyId;
            if (ViewBag.CompanyOverviewHead == null)
            {
                ViewBag.CompanyOverviewHead = companyRepository.FindOverviewHead(companyId,null);
            }
            return View(ViewBag.CompanyOverviewHead);
        }
    }
}

