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
    public class ApplicantSkillsExpertisesController : ATSBaseController
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly ISkillsExpEduCategoryRepository skillsexpeducategoryRepository;
		private readonly ISkillsExpEduRepository skillsexpeduRepository;
		private readonly IRatingScaleRepository ratingscaleRepository;
		private readonly IUserRepository userRepository;
		private readonly IApplicantSkillsExpertiseRepository applicantskillsexpertiseRepository;
        public ApplicantSkillsExpertisesController(IApplicantRepository applicantRepository, ISkillsExpEduCategoryRepository skillsexpeducategoryRepository, ISkillsExpEduRepository skillsexpeduRepository, IRatingScaleRepository ratingscaleRepository, IUserRepository userRepository, IApplicantSkillsExpertiseRepository applicantskillsexpertiseRepository)
        {
			this.applicantRepository = applicantRepository;
			this.skillsexpeducategoryRepository = skillsexpeducategoryRepository;
			this.skillsexpeduRepository = skillsexpeduRepository;
			this.ratingscaleRepository = ratingscaleRepository;
			this.userRepository = userRepository;
			this.applicantskillsexpertiseRepository = applicantskillsexpertiseRepository;
        }

        //
        // GET: /ApplicantSkillsExpertises/
		[UserAuthorize]
        public ViewResult Index(int applicantId)
        {
						            return View(applicantskillsexpertiseRepository.AllIncluding(applicantId, applicantskillsexpertise => applicantskillsexpertise.Applicant, applicantskillsexpertise => applicantskillsexpertise.SkillsExpEduCategory, applicantskillsexpertise => applicantskillsexpertise.SkillsExpEdu, applicantskillsexpertise => applicantskillsexpertise.ManagerRatingScale, applicantskillsexpertise => applicantskillsexpertise.VerifiedByUser));
        }

        public ViewResult Search(ApplicantSkillsExpertise searchApplicantSkillsExpertise, int applicantId)
        {
			if(searchApplicantSkillsExpertise!=null)
			{
							}
						return View("Index",applicantskillsexpertiseRepository.AllIncluding(applicantId, applicantskillsexpertise => applicantskillsexpertise.Applicant, applicantskillsexpertise => applicantskillsexpertise.SkillsExpEduCategory, applicantskillsexpertise => applicantskillsexpertise.SkillsExpEdu, applicantskillsexpertise => applicantskillsexpertise.ManagerRatingScale, applicantskillsexpertise => applicantskillsexpertise.VerifiedByUser));
		}

        //
        // GET: /ApplicantSkillsExpertises/Details/5
		[UserAuthorize]
        public ViewResult Details(int id, int applicantId)
        {
            return View(applicantskillsexpertiseRepository.Find(id));
        }

        //
        // GET: /ApplicantSkillsExpertises/Create
		[UserAuthorize]
        public ActionResult Create(int applicantId)
        {
			ApplicantSkillsExpertise applicantskillsexpertise = new ApplicantSkillsExpertise();
            applicantskillsexpertise.ApplicantID = applicantId;
			ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
			ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
			ViewBag.PossibleManagerRatingScales = ratingscaleRepository.All;
			return View(applicantskillsexpertise);
        } 

        //
        // POST: /ApplicantSkillsExpertises/Create
        [HttpPost]
        public ActionResult Create(ApplicantSkillsExpertise applicantskillsexpertise, int applicantId)
        {
            if (ModelState.IsValid) {
                applicantskillsexpertiseRepository.InsertOrUpdate(applicantskillsexpertise);
                applicantskillsexpertiseRepository.Save();
                return RedirectToAction("Index", new { applicantId=applicantId });
            } else {
				ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
				ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
				ViewBag.PossibleManagerRatingScales = ratingscaleRepository.All;
				return View(applicantskillsexpertise);
			}
        }
        
        //
        // GET: /ApplicantSkillsExpertises/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int applicantId)
        {
			ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
			ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
			ViewBag.PossibleManagerRatingScales = ratingscaleRepository.All;
			 return View(applicantskillsexpertiseRepository.Find(id));
        }

        //
        // POST: /ApplicantSkillsExpertises/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantSkillsExpertise applicantskillsexpertise,int applicantId)
        {
            if (ModelState.IsValid) {
                applicantskillsexpertiseRepository.InsertOrUpdate(applicantskillsexpertise);
                applicantskillsexpertiseRepository.Save();
                return RedirectToAction("Index", new { applicantId=applicantId });
            } else {
				ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
				ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
				ViewBag.PossibleManagerRatingScales = ratingscaleRepository.All;
				return View(applicantskillsexpertise);
			}
        }

        //
        // GET: /ApplicantSkillsExpertises/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int applicantId)
        {
            return View(applicantskillsexpertiseRepository.Find(id));
        }

        //
        // POST: /ApplicantSkillsExpertises/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id, int applicantId)
        {
            applicantskillsexpertiseRepository.Delete(id);
            applicantskillsexpertiseRepository.Save();

            return RedirectToAction("Index", new { applicantId = applicantId });
        }
    }
}

