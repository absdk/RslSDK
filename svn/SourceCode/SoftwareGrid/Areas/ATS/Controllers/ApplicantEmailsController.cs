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
    public class ApplicantEmailsController : Controller
    {
		private readonly IUserRepository userRepository;
		private readonly IApplicantRepository applicantRepository;
		private readonly IApplicantEmailRepository applicantemailRepository;
        public ApplicantEmailsController(IUserRepository userRepository, IApplicantRepository applicantRepository, IApplicantEmailRepository applicantemailRepository)
        {
			this.userRepository = userRepository;
			this.applicantRepository = applicantRepository;
			this.applicantemailRepository = applicantemailRepository;
        }

        //
        // GET: /ApplicantEmails/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantemailRepository.AllIncluding(applicantemail => applicantemail.EmailSendByUser, applicantemail => applicantemail.EmailSendToApplicant));
        }
		
		public ViewResult Search(ApplicantEmail searchApplicantEmail)
        {
			if(searchApplicantEmail!=null)
			{
							}
						return View("Index",applicantemailRepository.AllIncluding(applicantemail => applicantemail.EmailSendByUser, applicantemail => applicantemail.EmailSendToApplicant));
		}

        //
        // GET: /ApplicantEmails/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantemailRepository.Find(id));
        }

        //
        // GET: /ApplicantEmails/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantEmail applicantemail = new ApplicantEmail();
			ViewBag.PossibleEmailSendByUsers = userRepository.All;
			ViewBag.PossibleEmailSendToApplicants = applicantRepository.All;
            return View(applicantemail);
        } 

        //
        // POST: /ApplicantEmails/Create
        [HttpPost]
        public ActionResult Create(ApplicantEmail applicantemail)
        {
            if (ModelState.IsValid) {
                applicantemailRepository.InsertOrUpdate(applicantemail);
                applicantemailRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleEmailSendByUsers = userRepository.All;
				ViewBag.PossibleEmailSendToApplicants = applicantRepository.All;
				return View(applicantemail);
			}
        }
        
        //
        // GET: /ApplicantEmails/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleEmailSendByUsers = userRepository.All;
			ViewBag.PossibleEmailSendToApplicants = applicantRepository.All;
             return View(applicantemailRepository.Find(id));
        }

        //
        // POST: /ApplicantEmails/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantEmail applicantemail)
        {
            if (ModelState.IsValid) {
                applicantemailRepository.InsertOrUpdate(applicantemail);
                applicantemailRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleEmailSendByUsers = userRepository.All;
				ViewBag.PossibleEmailSendToApplicants = applicantRepository.All;
				return View(applicantemail);
			}
        }

        //
        // GET: /ApplicantEmails/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantemailRepository.Find(id));
        }

        //
        // POST: /ApplicantEmails/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantemailRepository.Delete(id);
            applicantemailRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

