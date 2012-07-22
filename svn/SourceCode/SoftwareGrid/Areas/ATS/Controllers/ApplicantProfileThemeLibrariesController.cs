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
    public class ApplicantProfileThemeLibrariesController : Controller
    {
		private readonly IApplicantProfileThemeLibraryRepository applicantprofilethemelibraryRepository;
        public ApplicantProfileThemeLibrariesController(IApplicantProfileThemeLibraryRepository applicantprofilethemelibraryRepository)
        {
			this.applicantprofilethemelibraryRepository = applicantprofilethemelibraryRepository;
        }

        //
        // GET: /ApplicantProfileThemeLibraries/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantprofilethemelibraryRepository.All);
        }
		
		public ViewResult Search(ApplicantProfileThemeLibrary searchApplicantProfileThemeLibrary)
        {
			if(searchApplicantProfileThemeLibrary!=null)
			{
							}
						return View("Index",applicantprofilethemelibraryRepository.All);
		}

        //
        // GET: /ApplicantProfileThemeLibraries/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantprofilethemelibraryRepository.Find(id));
        }

        //
        // GET: /ApplicantProfileThemeLibraries/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantProfileThemeLibrary applicantprofilethemelibrary = new ApplicantProfileThemeLibrary();
            return View(applicantprofilethemelibrary);
        } 

        //
        // POST: /ApplicantProfileThemeLibraries/Create
        [HttpPost]
        public ActionResult Create(ApplicantProfileThemeLibrary applicantprofilethemelibrary)
        {
            if (ModelState.IsValid) {
                applicantprofilethemelibraryRepository.InsertOrUpdate(applicantprofilethemelibrary);
                applicantprofilethemelibraryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantprofilethemelibrary);
			}
        }
        
        //
        // GET: /ApplicantProfileThemeLibraries/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(applicantprofilethemelibraryRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileThemeLibraries/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantProfileThemeLibrary applicantprofilethemelibrary)
        {
            if (ModelState.IsValid) {
                applicantprofilethemelibraryRepository.InsertOrUpdate(applicantprofilethemelibrary);
                applicantprofilethemelibraryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(applicantprofilethemelibrary);
			}
        }

        //
        // GET: /ApplicantProfileThemeLibraries/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantprofilethemelibraryRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileThemeLibraries/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantprofilethemelibraryRepository.Delete(id);
            applicantprofilethemelibraryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

