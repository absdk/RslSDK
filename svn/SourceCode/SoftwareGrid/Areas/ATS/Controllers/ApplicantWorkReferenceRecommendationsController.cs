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
    public class ApplicantWorkReferenceRecommendationsController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IApplicantExperienceRepository applicantexperienceRepository;
		private readonly IUserRepository userRepository;
		private readonly IApplicantWorkReferenceRecommendationRepository applicantworkreferencerecommendationRepository;
        public ApplicantWorkReferenceRecommendationsController(IApplicantRepository applicantRepository, IApplicantExperienceRepository applicantexperienceRepository, IUserRepository userRepository, IApplicantWorkReferenceRecommendationRepository applicantworkreferencerecommendationRepository)
        {
			this.applicantRepository = applicantRepository;
			this.applicantexperienceRepository = applicantexperienceRepository;
			this.userRepository = userRepository;
			this.applicantworkreferencerecommendationRepository = applicantworkreferencerecommendationRepository;
        }

        //
        // GET: /ApplicantWorkReferenceRecommendations/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantworkreferencerecommendationRepository.AllIncluding(applicantworkreferencerecommendation => applicantworkreferencerecommendation.Applicant, applicantworkreferencerecommendation => applicantworkreferencerecommendation.ApplicantExperience, applicantworkreferencerecommendation => applicantworkreferencerecommendation.VerifiedByUser));
        }
		
		public ViewResult Search(ApplicantWorkReferenceRecommendation searchApplicantWorkReferenceRecommendation)
        {
			if(searchApplicantWorkReferenceRecommendation!=null)
			{
							}
						return View("Index",applicantworkreferencerecommendationRepository.AllIncluding(applicantworkreferencerecommendation => applicantworkreferencerecommendation.Applicant, applicantworkreferencerecommendation => applicantworkreferencerecommendation.ApplicantExperience, applicantworkreferencerecommendation => applicantworkreferencerecommendation.VerifiedByUser));
		}

        //
        // GET: /ApplicantWorkReferenceRecommendations/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantworkreferencerecommendationRepository.Find(id));
        }

        //
        // GET: /ApplicantWorkReferenceRecommendations/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantWorkReferenceRecommendation applicantworkreferencerecommendation = new ApplicantWorkReferenceRecommendation();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleApplicantExperiences = applicantexperienceRepository.All;
			ViewBag.PossibleVerifiedByUsers = userRepository.All;
            return View(applicantworkreferencerecommendation);
        } 

        //
        // POST: /ApplicantWorkReferenceRecommendations/Create
        [HttpPost]
        public ActionResult Create(ApplicantWorkReferenceRecommendation applicantworkreferencerecommendation)
        {
            if (ModelState.IsValid) {
                applicantworkreferencerecommendationRepository.InsertOrUpdate(applicantworkreferencerecommendation);
                applicantworkreferencerecommendationRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleApplicantExperiences = applicantexperienceRepository.All;
				ViewBag.PossibleVerifiedByUsers = userRepository.All;
				return View(applicantworkreferencerecommendation);
			}
        }
        
        //
        // GET: /ApplicantWorkReferenceRecommendations/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleApplicantExperiences = applicantexperienceRepository.All;
			ViewBag.PossibleVerifiedByUsers = userRepository.All;
             return View(applicantworkreferencerecommendationRepository.Find(id));
        }

        //
        // POST: /ApplicantWorkReferenceRecommendations/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantWorkReferenceRecommendation applicantworkreferencerecommendation)
        {
            if (ModelState.IsValid) {
                applicantworkreferencerecommendationRepository.InsertOrUpdate(applicantworkreferencerecommendation);
                applicantworkreferencerecommendationRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleApplicantExperiences = applicantexperienceRepository.All;
				ViewBag.PossibleVerifiedByUsers = userRepository.All;
				return View(applicantworkreferencerecommendation);
			}
        }

        //
        // GET: /ApplicantWorkReferenceRecommendations/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantworkreferencerecommendationRepository.Find(id));
        }

        //
        // POST: /ApplicantWorkReferenceRecommendations/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantworkreferencerecommendationRepository.Delete(id);
            applicantworkreferencerecommendationRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

