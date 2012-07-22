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
    public class ApplicantProfileWidgetAccessesController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IUserRepository userRepository;
		private readonly IApplicantProfileWidgetAccessRepository applicantprofilewidgetaccessRepository;
        public ApplicantProfileWidgetAccessesController(IApplicantRepository applicantRepository, IUserRepository userRepository, IApplicantProfileWidgetAccessRepository applicantprofilewidgetaccessRepository)
        {
			this.applicantRepository = applicantRepository;
			this.userRepository = userRepository;
			this.applicantprofilewidgetaccessRepository = applicantprofilewidgetaccessRepository;
        }

        //
        // GET: /ApplicantProfileWidgetAccesses/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantprofilewidgetaccessRepository.AllIncluding(applicantprofilewidgetaccess => applicantprofilewidgetaccess.Applicant, applicantprofilewidgetaccess => applicantprofilewidgetaccess.ProfileAccessUser));
        }
		
		public ViewResult Search(ApplicantProfileWidgetAccess searchApplicantProfileWidgetAccess)
        {
			if(searchApplicantProfileWidgetAccess!=null)
			{
							}
						return View("Index",applicantprofilewidgetaccessRepository.AllIncluding(applicantprofilewidgetaccess => applicantprofilewidgetaccess.Applicant, applicantprofilewidgetaccess => applicantprofilewidgetaccess.ProfileAccessUser));
		}

        //
        // GET: /ApplicantProfileWidgetAccesses/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantprofilewidgetaccessRepository.Find(id));
        }

        //
        // GET: /ApplicantProfileWidgetAccesses/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantProfileWidgetAccess applicantprofilewidgetaccess = new ApplicantProfileWidgetAccess();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleProfileAccessUsers = userRepository.All;
            return View(applicantprofilewidgetaccess);
        } 

        //
        // POST: /ApplicantProfileWidgetAccesses/Create
        [HttpPost]
        public ActionResult Create(ApplicantProfileWidgetAccess applicantprofilewidgetaccess)
        {
            if (ModelState.IsValid) {
                applicantprofilewidgetaccessRepository.InsertOrUpdate(applicantprofilewidgetaccess);
                applicantprofilewidgetaccessRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleProfileAccessUsers = userRepository.All;
				return View(applicantprofilewidgetaccess);
			}
        }
        
        //
        // GET: /ApplicantProfileWidgetAccesses/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleProfileAccessUsers = userRepository.All;
             return View(applicantprofilewidgetaccessRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileWidgetAccesses/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantProfileWidgetAccess applicantprofilewidgetaccess)
        {
            if (ModelState.IsValid) {
                applicantprofilewidgetaccessRepository.InsertOrUpdate(applicantprofilewidgetaccess);
                applicantprofilewidgetaccessRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleProfileAccessUsers = userRepository.All;
				return View(applicantprofilewidgetaccess);
			}
        }

        //
        // GET: /ApplicantProfileWidgetAccesses/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantprofilewidgetaccessRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileWidgetAccesses/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantprofilewidgetaccessRepository.Delete(id);
            applicantprofilewidgetaccessRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

