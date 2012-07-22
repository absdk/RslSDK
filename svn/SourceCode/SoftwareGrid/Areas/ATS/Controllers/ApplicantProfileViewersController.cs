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
    public class ApplicantProfileViewersController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IUserRepository userRepository;
		private readonly IApplicantProfileViewerRepository applicantprofileviewerRepository;
        public ApplicantProfileViewersController(IApplicantRepository applicantRepository, IUserRepository userRepository, IApplicantProfileViewerRepository applicantprofileviewerRepository)
        {
			this.applicantRepository = applicantRepository;
			this.userRepository = userRepository;
			this.applicantprofileviewerRepository = applicantprofileviewerRepository;
        }

        //
        // GET: /ApplicantProfileViewers/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantprofileviewerRepository.AllIncluding(applicantprofileviewer => applicantprofileviewer.Applicant, applicantprofileviewer => applicantprofileviewer.ViewedByUser));
        }
		
		public ViewResult Search(ApplicantProfileViewer searchApplicantProfileViewer)
        {
			if(searchApplicantProfileViewer!=null)
			{
							}
						return View("Index",applicantprofileviewerRepository.AllIncluding(applicantprofileviewer => applicantprofileviewer.Applicant, applicantprofileviewer => applicantprofileviewer.ViewedByUser));
		}

        //
        // GET: /ApplicantProfileViewers/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantprofileviewerRepository.Find(id));
        }

        //
        // GET: /ApplicantProfileViewers/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantProfileViewer applicantprofileviewer = new ApplicantProfileViewer();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleViewedByUsers = userRepository.All;
            return View(applicantprofileviewer);
        } 

        //
        // POST: /ApplicantProfileViewers/Create
        [HttpPost]
        public ActionResult Create(ApplicantProfileViewer applicantprofileviewer)
        {
            if (ModelState.IsValid) {
                applicantprofileviewerRepository.InsertOrUpdate(applicantprofileviewer);
                applicantprofileviewerRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleViewedByUsers = userRepository.All;
				return View(applicantprofileviewer);
			}
        }
        
        //
        // GET: /ApplicantProfileViewers/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleViewedByUsers = userRepository.All;
             return View(applicantprofileviewerRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileViewers/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantProfileViewer applicantprofileviewer)
        {
            if (ModelState.IsValid) {
                applicantprofileviewerRepository.InsertOrUpdate(applicantprofileviewer);
                applicantprofileviewerRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleViewedByUsers = userRepository.All;
				return View(applicantprofileviewer);
			}
        }

        //
        // GET: /ApplicantProfileViewers/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantprofileviewerRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileViewers/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantprofileviewerRepository.Delete(id);
            applicantprofileviewerRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

