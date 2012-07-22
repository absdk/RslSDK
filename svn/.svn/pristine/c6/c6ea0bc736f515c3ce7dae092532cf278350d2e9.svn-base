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
    public class ApplicantRecruitmentTeamsController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IUserRepository userRepository;
		private readonly IApplicantRecruitmentTeamRepository applicantrecruitmentteamRepository;
        public ApplicantRecruitmentTeamsController(IApplicantRepository applicantRepository, IUserRepository userRepository, IApplicantRecruitmentTeamRepository applicantrecruitmentteamRepository)
        {
			this.applicantRepository = applicantRepository;
			this.userRepository = userRepository;
			this.applicantrecruitmentteamRepository = applicantrecruitmentteamRepository;
        }

        //
        // GET: /ApplicantRecruitmentTeams/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantrecruitmentteamRepository.AllIncluding(applicantrecruitmentteam => applicantrecruitmentteam.Applicant, applicantrecruitmentteam => applicantrecruitmentteam.AssignRecruiterUser));
        }
		
		public ViewResult Search(ApplicantRecruitmentTeam searchApplicantRecruitmentTeam)
        {
			if(searchApplicantRecruitmentTeam!=null)
			{
							}
						return View("Index",applicantrecruitmentteamRepository.AllIncluding(applicantrecruitmentteam => applicantrecruitmentteam.Applicant, applicantrecruitmentteam => applicantrecruitmentteam.AssignRecruiterUser));
		}

        //
        // GET: /ApplicantRecruitmentTeams/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantrecruitmentteamRepository.Find(id));
        }

        //
        // GET: /ApplicantRecruitmentTeams/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantRecruitmentTeam applicantrecruitmentteam = new ApplicantRecruitmentTeam();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleAssignRecruiterUsers = userRepository.All;
            return View(applicantrecruitmentteam);
        } 

        //
        // POST: /ApplicantRecruitmentTeams/Create
        [HttpPost]
        public ActionResult Create(ApplicantRecruitmentTeam applicantrecruitmentteam)
        {
            if (ModelState.IsValid) {
                applicantrecruitmentteamRepository.InsertOrUpdate(applicantrecruitmentteam);
                applicantrecruitmentteamRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleAssignRecruiterUsers = userRepository.All;
				return View(applicantrecruitmentteam);
			}
        }
        
        //
        // GET: /ApplicantRecruitmentTeams/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleAssignRecruiterUsers = userRepository.All;
             return View(applicantrecruitmentteamRepository.Find(id));
        }

        //
        // POST: /ApplicantRecruitmentTeams/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantRecruitmentTeam applicantrecruitmentteam)
        {
            if (ModelState.IsValid) {
                applicantrecruitmentteamRepository.InsertOrUpdate(applicantrecruitmentteam);
                applicantrecruitmentteamRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleAssignRecruiterUsers = userRepository.All;
				return View(applicantrecruitmentteam);
			}
        }

        //
        // GET: /ApplicantRecruitmentTeams/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantrecruitmentteamRepository.Find(id));
        }

        //
        // POST: /ApplicantRecruitmentTeams/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantrecruitmentteamRepository.Delete(id);
            applicantrecruitmentteamRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

