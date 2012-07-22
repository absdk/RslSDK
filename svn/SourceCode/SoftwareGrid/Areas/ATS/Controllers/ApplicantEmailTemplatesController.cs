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
    public class ApplicantEmailTemplatesController : Controller
    {
		private readonly IUserRepository userRepository;
		private readonly IApplicantEmailTemplateRepository applicantemailtemplateRepository;
        public ApplicantEmailTemplatesController(IUserRepository userRepository, IApplicantEmailTemplateRepository applicantemailtemplateRepository)
        {
			this.userRepository = userRepository;
			this.applicantemailtemplateRepository = applicantemailtemplateRepository;
        }

        //
        // GET: /ApplicantEmailTemplates/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantemailtemplateRepository.AllIncluding(applicantemailtemplate => applicantemailtemplate.TemplateCreatedByUser));
        }
		
		public ViewResult Search(ApplicantEmailTemplate searchApplicantEmailTemplate)
        {
			if(searchApplicantEmailTemplate!=null)
			{
							}
						return View("Index",applicantemailtemplateRepository.AllIncluding(applicantemailtemplate => applicantemailtemplate.TemplateCreatedByUser));
		}

        //
        // GET: /ApplicantEmailTemplates/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantemailtemplateRepository.Find(id));
        }

        //
        // GET: /ApplicantEmailTemplates/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantEmailTemplate applicantemailtemplate = new ApplicantEmailTemplate();
			ViewBag.PossibleTemplateCreatedByUsers = userRepository.All;
            return View(applicantemailtemplate);
        } 

        //
        // POST: /ApplicantEmailTemplates/Create
        [HttpPost]
        public ActionResult Create(ApplicantEmailTemplate applicantemailtemplate)
        {
            if (ModelState.IsValid) {
                applicantemailtemplateRepository.InsertOrUpdate(applicantemailtemplate);
                applicantemailtemplateRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleTemplateCreatedByUsers = userRepository.All;
				return View(applicantemailtemplate);
			}
        }
        
        //
        // GET: /ApplicantEmailTemplates/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleTemplateCreatedByUsers = userRepository.All;
             return View(applicantemailtemplateRepository.Find(id));
        }

        //
        // POST: /ApplicantEmailTemplates/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantEmailTemplate applicantemailtemplate)
        {
            if (ModelState.IsValid) {
                applicantemailtemplateRepository.InsertOrUpdate(applicantemailtemplate);
                applicantemailtemplateRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleTemplateCreatedByUsers = userRepository.All;
				return View(applicantemailtemplate);
			}
        }

        //
        // GET: /ApplicantEmailTemplates/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantemailtemplateRepository.Find(id));
        }

        //
        // POST: /ApplicantEmailTemplates/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantemailtemplateRepository.Delete(id);
            applicantemailtemplateRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

