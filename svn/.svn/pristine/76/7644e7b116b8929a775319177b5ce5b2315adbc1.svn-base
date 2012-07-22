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
    public class ApplicantVideosController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IApplicantVideoRepository applicantvideoRepository;
        public ApplicantVideosController(IApplicantRepository applicantRepository, IApplicantVideoRepository applicantvideoRepository)
        {
			this.applicantRepository = applicantRepository;
			this.applicantvideoRepository = applicantvideoRepository;
        }

        //
        // GET: /ApplicantVideos/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantvideoRepository.AllIncluding(applicantvideo => applicantvideo.Applicant));
        }
		
		public ViewResult Search(ApplicantVideo searchApplicantVideo)
        {
			if(searchApplicantVideo!=null)
			{
							}
						return View("Index",applicantvideoRepository.AllIncluding(applicantvideo => applicantvideo.Applicant));
		}

        //
        // GET: /ApplicantVideos/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantvideoRepository.Find(id));
        }

        //
        // GET: /ApplicantVideos/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantVideo applicantvideo = new ApplicantVideo();
			ViewBag.PossibleApplicants = applicantRepository.All;
            return View(applicantvideo);
        } 

        //
        // POST: /ApplicantVideos/Create
        [HttpPost]
        public ActionResult Create(ApplicantVideo applicantvideo)
        {
            if (ModelState.IsValid) {
                applicantvideoRepository.InsertOrUpdate(applicantvideo);
                applicantvideoRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				return View(applicantvideo);
			}
        }
        
        //
        // GET: /ApplicantVideos/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
             return View(applicantvideoRepository.Find(id));
        }

        //
        // POST: /ApplicantVideos/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantVideo applicantvideo)
        {
            if (ModelState.IsValid) {
                applicantvideoRepository.InsertOrUpdate(applicantvideo);
                applicantvideoRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				return View(applicantvideo);
			}
        }

        //
        // GET: /ApplicantVideos/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantvideoRepository.Find(id));
        }

        //
        // POST: /ApplicantVideos/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantvideoRepository.Delete(id);
            applicantvideoRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

