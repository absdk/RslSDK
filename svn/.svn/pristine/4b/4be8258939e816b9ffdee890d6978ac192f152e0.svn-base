//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  http://www.softwaregrid.com
//
//*********************************************************

using System.Web.Mvc;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.Areas.ATS.Controllers
{
    public class ApplicantDataPrivacyTemplateController : Controller
    {
        private readonly IApplicantDataPrivacyTemplateRepository applicantdataprivacytemplateRepository;
        public ApplicantDataPrivacyTemplateController(IApplicantDataPrivacyTemplateRepository applicantdataprivacytemplateRepository)
        {
            this.applicantdataprivacytemplateRepository = applicantdataprivacytemplateRepository;
        }

        //
        // GET: /ApplicantDataPrivacyTemplate/
        [UserAuthorize]
        public ViewResult Index()
        {
            return View(applicantdataprivacytemplateRepository.All);
        }

        public ViewResult Search(ApplicantDataPrivacyTemplate searchApplicantDataPrivacyTemplate)
        {
            if (searchApplicantDataPrivacyTemplate != null)
            {
            }
            return View("Index", applicantdataprivacytemplateRepository.All);
        }

        //
        // GET: /ApplicantDataPrivacyTemplate/Details/5
        [UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantdataprivacytemplateRepository.Find(id));
        }

        //
        // GET: /ApplicantDataPrivacyTemplate/Create
        [UserAuthorize]
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ApplicantDataPrivacyTemplate/Create
        [UserAuthorize]
        [HttpPost]
        public ActionResult Create(ApplicantDataPrivacyTemplate applicantdataprivacytemplate)
        {
            if (ModelState.IsValid)
            {
                applicantdataprivacytemplateRepository.InsertOrUpdate(applicantdataprivacytemplate);
                applicantdataprivacytemplateRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /ApplicantDataPrivacyTemplate/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id)
        {
            return View(applicantdataprivacytemplateRepository.Find(id));
        }

        //
        // POST: /ApplicantDataPrivacyTemplate/Edit/5
        [UserAuthorize]
        [HttpPost]
        public ActionResult Edit(ApplicantDataPrivacyTemplate applicantdataprivacytemplate)
        {
            if (ModelState.IsValid)
            {
                applicantdataprivacytemplateRepository.InsertOrUpdate(applicantdataprivacytemplate);
                applicantdataprivacytemplateRepository.Save();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //
        // GET: /ApplicantDataPrivacyTemplate/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantdataprivacytemplateRepository.Find(id));
        }

        //
        // POST: /ApplicantDataPrivacyTemplate/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantdataprivacytemplateRepository.Delete(id);
            applicantdataprivacytemplateRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

