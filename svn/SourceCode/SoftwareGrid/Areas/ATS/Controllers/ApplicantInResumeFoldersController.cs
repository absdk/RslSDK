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
    public class ApplicantInResumeFoldersController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IApplicantInResumeFolderRepository applicantinresumefolderRepository;
        public ApplicantInResumeFoldersController(IApplicantRepository applicantRepository, IApplicantInResumeFolderRepository applicantinresumefolderRepository)
        {
			this.applicantRepository = applicantRepository;
			this.applicantinresumefolderRepository = applicantinresumefolderRepository;
        }

        //
        // GET: /ApplicantInResumeFolders/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantinresumefolderRepository.AllIncluding(applicantinresumefolder => applicantinresumefolder.Applicant));
        }
		
		public ViewResult Search(ApplicantInResumeFolder searchApplicantInResumeFolder)
        {
			if(searchApplicantInResumeFolder!=null)
			{
							}
						return View("Index",applicantinresumefolderRepository.AllIncluding(applicantinresumefolder => applicantinresumefolder.Applicant));
		}

        //
        // GET: /ApplicantInResumeFolders/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantinresumefolderRepository.Find(id));
        }

        //
        // GET: /ApplicantInResumeFolders/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantInResumeFolder applicantinresumefolder = new ApplicantInResumeFolder();
			ViewBag.PossibleApplicants = applicantRepository.All;
            return View(applicantinresumefolder);
        } 

        //
        // POST: /ApplicantInResumeFolders/Create
        [HttpPost]
        public ActionResult Create(ApplicantInResumeFolder applicantinresumefolder)
        {
            if (ModelState.IsValid) {
                applicantinresumefolderRepository.InsertOrUpdate(applicantinresumefolder);
                applicantinresumefolderRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				return View(applicantinresumefolder);
			}
        }
        
        //
        // GET: /ApplicantInResumeFolders/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
             return View(applicantinresumefolderRepository.Find(id));
        }

        //
        // POST: /ApplicantInResumeFolders/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantInResumeFolder applicantinresumefolder)
        {
            if (ModelState.IsValid) {
                applicantinresumefolderRepository.InsertOrUpdate(applicantinresumefolder);
                applicantinresumefolderRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				return View(applicantinresumefolder);
			}
        }

        //
        // GET: /ApplicantInResumeFolders/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantinresumefolderRepository.Find(id));
        }

        //
        // POST: /ApplicantInResumeFolders/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantinresumefolderRepository.Delete(id);
            applicantinresumefolderRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

