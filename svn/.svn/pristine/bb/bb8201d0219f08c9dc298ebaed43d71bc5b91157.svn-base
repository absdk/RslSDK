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
namespace SoftwareGrid.Areas.MasterData.Controllers
{   
    public class BusinessDivisionsController : Controller
    {
		private readonly IIndustryRepository industryRepository;
		private readonly IBusinessDivisionRepository businessdivisionRepository;
        public BusinessDivisionsController(IIndustryRepository industryRepository, IBusinessDivisionRepository businessdivisionRepository)
        {
			this.industryRepository = industryRepository;
			this.businessdivisionRepository = businessdivisionRepository;
        }

        //
        // GET: /BusinessDivisions/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(businessdivisionRepository.AllIncluding(businessdivision => businessdivision.Industry));
        }
		
		public ViewResult Search(BusinessDivision searchBusinessDivision)
        {
			if(searchBusinessDivision!=null)
			{
							}
						return View("Index",businessdivisionRepository.AllIncluding(businessdivision => businessdivision.Industry));
		}

        //
        // GET: /BusinessDivisions/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(businessdivisionRepository.Find(id));
        }

        //
        // GET: /BusinessDivisions/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			BusinessDivision businessdivision = new BusinessDivision();
			ViewBag.PossibleIndustries = industryRepository.All;
            return View(businessdivision);
        } 

        //
        // POST: /BusinessDivisions/Create
        [HttpPost]
        public ActionResult Create(BusinessDivision businessdivision)
        {
            if (ModelState.IsValid) {
                businessdivisionRepository.InsertOrUpdate(businessdivision);
                businessdivisionRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleIndustries = industryRepository.All;
				return View(businessdivision);
			}
        }
        
        //
        // GET: /BusinessDivisions/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleIndustries = industryRepository.All;
             return View(businessdivisionRepository.Find(id));
        }

        //
        // POST: /BusinessDivisions/Edit/5
        [HttpPost]
        public ActionResult Edit(BusinessDivision businessdivision)
        {
            if (ModelState.IsValid) {
                businessdivisionRepository.InsertOrUpdate(businessdivision);
                businessdivisionRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleIndustries = industryRepository.All;
				return View(businessdivision);
			}
        }

        //
        // GET: /BusinessDivisions/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(businessdivisionRepository.Find(id));
        }

        //
        // POST: /BusinessDivisions/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            businessdivisionRepository.Delete(id);
            businessdivisionRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

