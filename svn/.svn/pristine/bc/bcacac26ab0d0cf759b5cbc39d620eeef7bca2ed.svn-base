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
    public class ApplicantResumeFoldersController : Controller
    {
		private readonly IUserRepository userRepository;
		private readonly IApplicantResumeFolderRepository applicantresumefolderRepository;
        public ApplicantResumeFoldersController(IUserRepository userRepository, IApplicantResumeFolderRepository applicantresumefolderRepository)
        {
			this.userRepository = userRepository;
			this.applicantresumefolderRepository = applicantresumefolderRepository;
        }

        //
        // GET: /ApplicantResumeFolders/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantresumefolderRepository.AllIncluding(applicantresumefolder => applicantresumefolder.CreatedByUser));
        }
		
		public ViewResult Search(ApplicantResumeFolder searchApplicantResumeFolder)
        {
			if(searchApplicantResumeFolder!=null)
			{
							}
						return View("Index",applicantresumefolderRepository.AllIncluding(applicantresumefolder => applicantresumefolder.CreatedByUser));
		}

        //
        // GET: /ApplicantResumeFolders/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantresumefolderRepository.Find(id));
        }

        //
        // GET: /ApplicantResumeFolders/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantResumeFolder applicantresumefolder = new ApplicantResumeFolder();
			ViewBag.PossibleCreatedByUsers = userRepository.All;
            return View(applicantresumefolder);
        } 

        //
        // POST: /ApplicantResumeFolders/Create
        [HttpPost]
        public ActionResult Create(ApplicantResumeFolder applicantresumefolder)
        {
            if (ModelState.IsValid) {
                applicantresumefolderRepository.InsertOrUpdate(applicantresumefolder);
                applicantresumefolderRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				return View(applicantresumefolder);
			}
        }
        
        //
        // GET: /ApplicantResumeFolders/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleCreatedByUsers = userRepository.All;
             return View(applicantresumefolderRepository.Find(id));
        }

        //
        // POST: /ApplicantResumeFolders/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantResumeFolder applicantresumefolder)
        {
            if (ModelState.IsValid) {
                applicantresumefolderRepository.InsertOrUpdate(applicantresumefolder);
                applicantresumefolderRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				return View(applicantresumefolder);
			}
        }

        //
        // GET: /ApplicantResumeFolders/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantresumefolderRepository.Find(id));
        }

        //
        // POST: /ApplicantResumeFolders/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantresumefolderRepository.Delete(id);
            applicantresumefolderRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

