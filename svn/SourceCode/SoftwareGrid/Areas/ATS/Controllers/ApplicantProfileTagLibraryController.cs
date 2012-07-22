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
    public class ApplicantProfileTagLibraryController : Controller
    {
		private readonly IApplicantProfileTagLibraryRepository applicantprofiletaglibraryRepository;
        public ApplicantProfileTagLibraryController(IApplicantProfileTagLibraryRepository applicantprofiletaglibraryRepository)
        {
			this.applicantprofiletaglibraryRepository = applicantprofiletaglibraryRepository;
        }

        //
        // GET: /ApplicantProfileTagLibrary/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantprofiletaglibraryRepository.All);
        }
		
		public ViewResult Search(ApplicantProfileTagLibrary searchApplicantProfileTagLibrary)
        {
			if(searchApplicantProfileTagLibrary!=null)
			{
							}
						return View("Index",applicantprofiletaglibraryRepository.All);
		}

        //
        // GET: /ApplicantProfileTagLibrary/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantprofiletaglibraryRepository.Find(id));
        }

        //
        // GET: /ApplicantProfileTagLibrary/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ApplicantProfileTagLibrary/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(ApplicantProfileTagLibrary applicantprofiletaglibrary)
        {
            if (ModelState.IsValid) {
                applicantprofiletaglibraryRepository.InsertOrUpdate(applicantprofiletaglibrary);
                applicantprofiletaglibraryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /ApplicantProfileTagLibrary/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(applicantprofiletaglibraryRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileTagLibrary/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(ApplicantProfileTagLibrary applicantprofiletaglibrary)
        {
            if (ModelState.IsValid) {
                applicantprofiletaglibraryRepository.InsertOrUpdate(applicantprofiletaglibrary);
                applicantprofiletaglibraryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /ApplicantProfileTagLibrary/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantprofiletaglibraryRepository.Find(id));
        }

        //
        // POST: /ApplicantProfileTagLibrary/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantprofiletaglibraryRepository.Delete(id);
            applicantprofiletaglibraryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

