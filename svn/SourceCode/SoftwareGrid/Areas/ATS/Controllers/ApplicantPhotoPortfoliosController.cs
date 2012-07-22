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
    public class ApplicantPhotoPortfoliosController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IApplicantPhotoPortfolioRepository applicantphotoportfolioRepository;
        public ApplicantPhotoPortfoliosController(IApplicantRepository applicantRepository, IApplicantPhotoPortfolioRepository applicantphotoportfolioRepository)
        {
			this.applicantRepository = applicantRepository;
			this.applicantphotoportfolioRepository = applicantphotoportfolioRepository;
        }

        //
        // GET: /ApplicantPhotoPortfolios/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantphotoportfolioRepository.AllIncluding(applicantphotoportfolio => applicantphotoportfolio.Applicant));
        }
		
		public ViewResult Search(ApplicantPhotoPortfolio searchApplicantPhotoPortfolio)
        {
			if(searchApplicantPhotoPortfolio!=null)
			{
							}
						return View("Index",applicantphotoportfolioRepository.AllIncluding(applicantphotoportfolio => applicantphotoportfolio.Applicant));
		}

        //
        // GET: /ApplicantPhotoPortfolios/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantphotoportfolioRepository.Find(id));
        }

        //
        // GET: /ApplicantPhotoPortfolios/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantPhotoPortfolio applicantphotoportfolio = new ApplicantPhotoPortfolio();
			ViewBag.PossibleApplicants = applicantRepository.All;
            return View(applicantphotoportfolio);
        } 

        //
        // POST: /ApplicantPhotoPortfolios/Create
        [HttpPost]
        public ActionResult Create(ApplicantPhotoPortfolio applicantphotoportfolio)
        {
            if (ModelState.IsValid) {
                applicantphotoportfolioRepository.InsertOrUpdate(applicantphotoportfolio);
                applicantphotoportfolioRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				return View(applicantphotoportfolio);
			}
        }
        
        //
        // GET: /ApplicantPhotoPortfolios/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
             return View(applicantphotoportfolioRepository.Find(id));
        }

        //
        // POST: /ApplicantPhotoPortfolios/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantPhotoPortfolio applicantphotoportfolio)
        {
            if (ModelState.IsValid) {
                applicantphotoportfolioRepository.InsertOrUpdate(applicantphotoportfolio);
                applicantphotoportfolioRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				return View(applicantphotoportfolio);
			}
        }

        //
        // GET: /ApplicantPhotoPortfolios/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantphotoportfolioRepository.Find(id));
        }

        //
        // POST: /ApplicantPhotoPortfolios/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantphotoportfolioRepository.Delete(id);
            applicantphotoportfolioRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

