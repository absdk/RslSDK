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
    public class ApplicantProfileRequestListsController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IUserRepository userRepository;
		private readonly IApplicantProfileRequestListRepository applicantprofilerequestlistRepository;
        public ApplicantProfileRequestListsController(IApplicantRepository applicantRepository, IUserRepository userRepository, IApplicantProfileRequestListRepository applicantprofilerequestlistRepository)
        {
			this.applicantRepository = applicantRepository;
			this.userRepository = userRepository;
			this.applicantprofilerequestlistRepository = applicantprofilerequestlistRepository;
        }

        //
        // GET: /ApplicantProfileRequestLists/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantprofilerequestlistRepository.AllIncluding(applicantprofilerequestlist => applicantprofilerequestlist.Applicant, applicantprofilerequestlist => applicantprofilerequestlist.RequestedByUser));
        }
		
		public ViewResult Search(ApplicantProfileRequestList searchApplicantProfileRequestList)
        {
			if(searchApplicantProfileRequestList!=null)
			{
							}
						return View("Index",applicantprofilerequestlistRepository.AllIncluding(applicantprofilerequestlist => applicantprofilerequestlist.Applicant, applicantprofilerequestlist => applicantprofilerequestlist.RequestedByUser));
		}

        //
        // GET: /ApplicantProfileRequestLists/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantprofilerequestlistRepository.Find(id));
        }

        //
        // GET: /ApplicantProfileRequestLists/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantProfileRequestList applicantprofilerequestlist = new ApplicantProfileRequestList();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleRequestedByUsers = userRepository.All;
            return View(applicantprofilerequestlist);
        } 

        //
        // POST: /ApplicantProfileRequestLists/Create
        [HttpPost]
        public ActionResult Create(ApplicantProfileRequestList applicantprofilerequestlist)
        {
            if (ModelState.IsValid) {
                applicantprofilerequestlistRepository.InsertOrUpdate(applicantprofilerequestlist);
                applicantprofilerequestlistRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleRequestedByUsers = userRepository.All;
				return View(applicantprofilerequestlist);
			}
        }
        
        //
        // GET: /ApplicantProfileRequestLists/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleRequestedByUsers = userRepository.All;
             return View(applicantprofilerequestlistRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileRequestLists/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantProfileRequestList applicantprofilerequestlist)
        {
            if (ModelState.IsValid) {
                applicantprofilerequestlistRepository.InsertOrUpdate(applicantprofilerequestlist);
                applicantprofilerequestlistRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleRequestedByUsers = userRepository.All;
				return View(applicantprofilerequestlist);
			}
        }

        //
        // GET: /ApplicantProfileRequestLists/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantprofilerequestlistRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileRequestLists/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantprofilerequestlistRepository.Delete(id);
            applicantprofilerequestlistRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

