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
    public class ApplicantProfilePublishesController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IApplicantProfileThemeLibraryRepository applicantprofilethemelibraryRepository;
		private readonly IUserRepository userRepository;
		private readonly IApplicantProfilePublishRepository applicantprofilepublishRepository;
        public ApplicantProfilePublishesController(IApplicantRepository applicantRepository, IApplicantProfileThemeLibraryRepository applicantprofilethemelibraryRepository, IUserRepository userRepository, IApplicantProfilePublishRepository applicantprofilepublishRepository)
        {
			this.applicantRepository = applicantRepository;
			this.applicantprofilethemelibraryRepository = applicantprofilethemelibraryRepository;
			this.userRepository = userRepository;
			this.applicantprofilepublishRepository = applicantprofilepublishRepository;
        }

        //
        // GET: /ApplicantProfilePublishes/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantprofilepublishRepository.AllIncluding(applicantprofilepublish => applicantprofilepublish.Applicant, applicantprofilepublish => applicantprofilepublish.ApplicantProfileThemeLibrary, applicantprofilepublish => applicantprofilepublish.PublishedByUser));
        }
		
		public ViewResult Search(ApplicantProfilePublish searchApplicantProfilePublish)
        {
			if(searchApplicantProfilePublish!=null)
			{
							}
						return View("Index",applicantprofilepublishRepository.AllIncluding(applicantprofilepublish => applicantprofilepublish.Applicant, applicantprofilepublish => applicantprofilepublish.ApplicantProfileThemeLibrary, applicantprofilepublish => applicantprofilepublish.PublishedByUser));
		}

        //
        // GET: /ApplicantProfilePublishes/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantprofilepublishRepository.Find(id));
        }

        //
        // GET: /ApplicantProfilePublishes/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantProfilePublish applicantprofilepublish = new ApplicantProfilePublish();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleApplicantProfileThemeLibraries = applicantprofilethemelibraryRepository.All;
			ViewBag.PossiblePublishedByUsers = userRepository.All;
            return View(applicantprofilepublish);
        } 

        //
        // POST: /ApplicantProfilePublishes/Create
        [HttpPost]
        public ActionResult Create(ApplicantProfilePublish applicantprofilepublish)
        {
            if (ModelState.IsValid) {
                applicantprofilepublishRepository.InsertOrUpdate(applicantprofilepublish);
                applicantprofilepublishRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleApplicantProfileThemeLibraries = applicantprofilethemelibraryRepository.All;
				ViewBag.PossiblePublishedByUsers = userRepository.All;
				return View(applicantprofilepublish);
			}
        }
        
        //
        // GET: /ApplicantProfilePublishes/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleApplicantProfileThemeLibraries = applicantprofilethemelibraryRepository.All;
			ViewBag.PossiblePublishedByUsers = userRepository.All;
             return View(applicantprofilepublishRepository.Find(id));
        }

        //
        // POST: /ApplicantProfilePublishes/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantProfilePublish applicantprofilepublish)
        {
            if (ModelState.IsValid) {
                applicantprofilepublishRepository.InsertOrUpdate(applicantprofilepublish);
                applicantprofilepublishRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleApplicantProfileThemeLibraries = applicantprofilethemelibraryRepository.All;
				ViewBag.PossiblePublishedByUsers = userRepository.All;
				return View(applicantprofilepublish);
			}
        }

        //
        // GET: /ApplicantProfilePublishes/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantprofilepublishRepository.Find(id));
        }

        //
        // POST: /ApplicantProfilePublishes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantprofilepublishRepository.Delete(id);
            applicantprofilepublishRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

