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
    public class ApplicantNotesController : ATSBaseController
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IUserRepository userRepository;
		private readonly IApplicantNoteRepository applicantnoteRepository;
        public ApplicantNotesController(IApplicantRepository applicantRepository, IUserRepository userRepository, IApplicantNoteRepository applicantnoteRepository)
        {
			this.applicantRepository = applicantRepository;
			this.userRepository = userRepository;
			this.applicantnoteRepository = applicantnoteRepository;
        }

        //
        // GET: /ApplicantNotes/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantnoteRepository.AllIncluding(applicantnote => applicantnote.Applicant, applicantnote => applicantnote.WrittenByUser));
        }
		
		public ViewResult Search(ApplicantNote searchApplicantNote)
        {
			if(searchApplicantNote!=null)
			{
							}
						return View("Index",applicantnoteRepository.AllIncluding(applicantnote => applicantnote.Applicant, applicantnote => applicantnote.WrittenByUser));
		}

        //
        // GET: /ApplicantNotes/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantnoteRepository.Find(id));
        }

        //
        // GET: /ApplicantNotes/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantNote applicantnote = new ApplicantNote();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleWrittenByUsers = userRepository.All;
            return View(applicantnote);
        } 

        //
        // POST: /ApplicantNotes/Create
        [HttpPost]
        public ActionResult Create(ApplicantNote applicantnote)
        {
            if (ModelState.IsValid) {
                applicantnoteRepository.InsertOrUpdate(applicantnote);
                applicantnoteRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleWrittenByUsers = userRepository.All;
				return View(applicantnote);
			}
        }
        
        //
        // GET: /ApplicantNotes/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleWrittenByUsers = userRepository.All;
             return View(applicantnoteRepository.Find(id));
        }

        //
        // POST: /ApplicantNotes/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantNote applicantnote)
        {
            if (ModelState.IsValid) {
                applicantnoteRepository.InsertOrUpdate(applicantnote);
                applicantnoteRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleWrittenByUsers = userRepository.All;
				return View(applicantnote);
			}
        }

        //
        // GET: /ApplicantNotes/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantnoteRepository.Find(id));
        }

        //
        // POST: /ApplicantNotes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantnoteRepository.Delete(id);
            applicantnoteRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

