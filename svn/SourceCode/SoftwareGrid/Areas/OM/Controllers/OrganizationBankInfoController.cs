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
    public class OrganizationBankInfoController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IStateRepository stateRepository;
		private readonly ICountryRepository countryRepository;
		private readonly IOrganizationBankInfoRepository organizationbankinfoRepository;
        public OrganizationBankInfoController(IOrganizationRepository organizationRepository, IStateRepository stateRepository, ICountryRepository countryRepository, IOrganizationBankInfoRepository organizationbankinfoRepository)
        {
			this.organizationRepository = organizationRepository;
			this.stateRepository = stateRepository;
			this.countryRepository = countryRepository;
			this.organizationbankinfoRepository = organizationbankinfoRepository;
        }

        //
        // GET: /OrganizationBankInfo/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationbankinfoRepository.AllIncluding(organizationId,organizationbankinfo => organizationbankinfo.Organization));
        }
		
		public ViewResult Search(OrganizationBankInfo searchOrganizationBankInfo,int organizationId)
        {
			if(searchOrganizationBankInfo!=null)
			{
							}
						return View("Index",organizationbankinfoRepository.AllIncluding(organizationId,organizationbankinfo => organizationbankinfo.Organization));
		}

        //
        // GET: /OrganizationBankInfo/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationbankinfoRepository.Find(id));
        }

        //
        // GET: /OrganizationBankInfo/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationBankInfo organizationbankinfo = new OrganizationBankInfo();
			organizationbankinfo.OrganizationID = organizationId;
			ViewBag.PossibleCountries = countryRepository.All;
            return View(organizationbankinfo);
        } 

        //
        // POST: /OrganizationBankInfo/Create
        [HttpPost]
        public ActionResult Create(OrganizationBankInfo organizationbankinfo,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationbankinfoRepository.InsertOrUpdate(organizationbankinfo);
                organizationbankinfoRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				ViewBag.PossibleCountries = countryRepository.All;
				return View(organizationbankinfo);
			}
        }
        
        //
        // GET: /OrganizationBankInfo/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationBankInfo organizationbankinfo = organizationbankinfoRepository.Find(id);
						if (organizationbankinfo.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(organizationbankinfo.CountryID.Value);
            }
									ViewBag.PossibleCountries = countryRepository.All;
             return View(organizationbankinfo);
        }

        //
        // POST: /OrganizationBankInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationBankInfo organizationbankinfo,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationbankinfoRepository.InsertOrUpdate(organizationbankinfo);
                organizationbankinfoRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
						if (organizationbankinfo.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(organizationbankinfo.CountryID.Value);
            }
									ViewBag.PossibleCountries = countryRepository.All;
				return View(organizationbankinfo);
			}
        }

        //
        // GET: /OrganizationBankInfo/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationbankinfoRepository.Find(id));
        }

        //
        // POST: /OrganizationBankInfo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationbankinfoRepository.Delete(id);
            organizationbankinfoRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

