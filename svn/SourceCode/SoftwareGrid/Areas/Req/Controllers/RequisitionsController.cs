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
namespace SoftwareGrid.Areas.Req.Controllers
{   
    public class RequisitionsController : Controller
    {
		private readonly IUserRepository userRepository;
		private readonly IRequisitionJDLibraryCategoryRepository requisitionjdlibrarycategoryRepository;
		private readonly IEmploymentTypeRepository employmenttypeRepository;
		private readonly IExperienceLevelCategoryRepository experiencelevelcategoryRepository;
		private readonly ICurrencyRepository currencyRepository;
		private readonly ISalaryRateTypeRepository salaryratetypeRepository;
		private readonly ICountryRepository countryRepository;
		private readonly IStateRepository stateRepository;
		private readonly IRequisitionStatusCategoryRepository requisitionstatuscategoryRepository;
		private readonly IRequisitionRepository requisitionRepository;
        public RequisitionsController(IUserRepository userRepository, IRequisitionJDLibraryCategoryRepository requisitionjdlibrarycategoryRepository, IEmploymentTypeRepository employmenttypeRepository, IExperienceLevelCategoryRepository experiencelevelcategoryRepository, ICurrencyRepository currencyRepository, ISalaryRateTypeRepository salaryratetypeRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IRequisitionStatusCategoryRepository requisitionstatuscategoryRepository, IRequisitionRepository requisitionRepository)
        {
			this.userRepository = userRepository;
			this.requisitionjdlibrarycategoryRepository = requisitionjdlibrarycategoryRepository;
			this.employmenttypeRepository = employmenttypeRepository;
			this.experiencelevelcategoryRepository = experiencelevelcategoryRepository;
			this.currencyRepository = currencyRepository;
			this.salaryratetypeRepository = salaryratetypeRepository;
			this.countryRepository = countryRepository;
			this.stateRepository = stateRepository;
			this.requisitionstatuscategoryRepository = requisitionstatuscategoryRepository;
			this.requisitionRepository = requisitionRepository;
        }

        //
        // GET: /Requisitions/
		[UserAuthorize]
        public ViewResult Index()
        {
									ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
						ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
						ViewBag.PossibleCountries = countryRepository.All;
						ViewBag.PossibleStates = stateRepository.All;
						ViewBag.PossibleRequisitionStatusCategories = requisitionstatuscategoryRepository.All;
			            return View(requisitionRepository.AllIncluding(requisition => requisition.CreatedByUser, requisition => requisition.RequisitionJDLibraryCategory, requisition => requisition.EmploymentType, requisition => requisition.ExperienceLevelCategory, requisition => requisition.Currency, requisition => requisition.SalaryRateType, requisition => requisition.Country, requisition => requisition.State, requisition => requisition.RequisitionStatusCategory));
        }
		
		public ViewResult Search(Requisition searchRequisition)
        {
			if(searchRequisition!=null)
			{
							ViewData["RequisitionDisplayId"]=searchRequisition.RequisitionDisplayId;
							ViewData["JobTitle"]=searchRequisition.JobTitle;
							ViewData["NumberOfOpenings"]=searchRequisition.NumberOfOpenings;
							ViewData["EmploymentTypeID"]=searchRequisition.EmploymentTypeID;
							ViewData["ExperienceLevelCategoryID"]=searchRequisition.ExperienceLevelCategoryID;
							ViewData["HireByDate"]=searchRequisition.HireByDate;
							ViewData["CountryID"]=searchRequisition.CountryID;
							ViewData["StateID"]=searchRequisition.StateID;
							ViewData["City"]=searchRequisition.City;
							ViewData["ZipCode"]=searchRequisition.ZipCode;
							ViewData["RequisitionStatusCategoryID"]=searchRequisition.RequisitionStatusCategoryID;
							}
						ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
						ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
						ViewBag.PossibleCountries = countryRepository.All;
						ViewBag.PossibleStates = stateRepository.All;
						ViewBag.PossibleRequisitionStatusCategories = requisitionstatuscategoryRepository.All;
						return View("Index",requisitionRepository.AllIncluding(requisition => requisition.CreatedByUser, requisition => requisition.RequisitionJDLibraryCategory, requisition => requisition.EmploymentType, requisition => requisition.ExperienceLevelCategory, requisition => requisition.Currency, requisition => requisition.SalaryRateType, requisition => requisition.Country, requisition => requisition.State, requisition => requisition.RequisitionStatusCategory));
		}

        //
        // GET: /Requisitions/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionRepository.Find(id));
        }

        //
        // GET: /Requisitions/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			Requisition requisition = new Requisition();
			ViewBag.PossibleCreatedByUsers = userRepository.All;
			ViewBag.PossibleRequisitionJDLibraryCategories = requisitionjdlibrarycategoryRepository.All;
			ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
			ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
			ViewBag.PossibleCurrencies = currencyRepository.All;
			ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
			ViewBag.PossibleCountries = countryRepository.All;
			ViewBag.PossibleStates = stateRepository.All;
			ViewBag.PossibleRequisitionStatusCategories = requisitionstatuscategoryRepository.All;
            return View(requisition);
        } 

        //
        // POST: /Requisitions/Create
        [HttpPost]
        public ActionResult Create(Requisition requisition)
        {
            if (ModelState.IsValid) {
                requisitionRepository.InsertOrUpdate(requisition);
                requisitionRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				ViewBag.PossibleRequisitionJDLibraryCategories = requisitionjdlibrarycategoryRepository.All;
				ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
				ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
				ViewBag.PossibleCurrencies = currencyRepository.All;
				ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
				ViewBag.PossibleCountries = countryRepository.All;
				ViewBag.PossibleStates = stateRepository.All;
				ViewBag.PossibleRequisitionStatusCategories = requisitionstatuscategoryRepository.All;
				return View(requisition);
			}
        }
        
        //
        // GET: /Requisitions/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleCreatedByUsers = userRepository.All;
			ViewBag.PossibleRequisitionJDLibraryCategories = requisitionjdlibrarycategoryRepository.All;
			ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
			ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
			ViewBag.PossibleCurrencies = currencyRepository.All;
			ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
			ViewBag.PossibleCountries = countryRepository.All;
			ViewBag.PossibleStates = stateRepository.All;
			ViewBag.PossibleRequisitionStatusCategories = requisitionstatuscategoryRepository.All;
             return View(requisitionRepository.Find(id));
        }

        //
        // POST: /Requisitions/Edit/5
        [HttpPost]
        public ActionResult Edit(Requisition requisition)
        {
            if (ModelState.IsValid) {
                requisitionRepository.InsertOrUpdate(requisition);
                requisitionRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				ViewBag.PossibleRequisitionJDLibraryCategories = requisitionjdlibrarycategoryRepository.All;
				ViewBag.PossibleEmploymentTypes = employmenttypeRepository.All;
				ViewBag.PossibleExperienceLevelCategories = experiencelevelcategoryRepository.All;
				ViewBag.PossibleCurrencies = currencyRepository.All;
				ViewBag.PossibleSalaryRateTypes = salaryratetypeRepository.All;
				ViewBag.PossibleCountries = countryRepository.All;
				ViewBag.PossibleStates = stateRepository.All;
				ViewBag.PossibleRequisitionStatusCategories = requisitionstatuscategoryRepository.All;
				return View(requisition);
			}
        }

        //
        // GET: /Requisitions/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionRepository.Find(id));
        }

        //
        // POST: /Requisitions/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionRepository.Delete(id);
            requisitionRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

