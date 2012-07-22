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
    public class ApplicantDocumentStatusCategoryController : Controller
    {
		private readonly IApplicantDocumentStatusCategoryRepository applicantdocumentstatuscategoryRepository;
        public ApplicantDocumentStatusCategoryController(IApplicantDocumentStatusCategoryRepository applicantdocumentstatuscategoryRepository)
        {
			this.applicantdocumentstatuscategoryRepository = applicantdocumentstatuscategoryRepository;
        }

        //
        // GET: /ApplicantDocumentStatusCategory/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantdocumentstatuscategoryRepository.All);
        }
		
		public ViewResult Search(ApplicantDocumentStatusCategory searchApplicantDocumentStatusCategory)
        {
			if(searchApplicantDocumentStatusCategory!=null)
			{
							}
						return View("Index",applicantdocumentstatuscategoryRepository.All);
		}

        //
        // GET: /ApplicantDocumentStatusCategory/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantdocumentstatuscategoryRepository.Find(id));
        }

        //
        // GET: /ApplicantDocumentStatusCategory/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ApplicantDocumentStatusCategory/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(ApplicantDocumentStatusCategory applicantdocumentstatuscategory)
        {
            if (ModelState.IsValid) {
                applicantdocumentstatuscategoryRepository.InsertOrUpdate(applicantdocumentstatuscategory);
                applicantdocumentstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /ApplicantDocumentStatusCategory/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(applicantdocumentstatuscategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantDocumentStatusCategory/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(ApplicantDocumentStatusCategory applicantdocumentstatuscategory)
        {
            if (ModelState.IsValid) {
                applicantdocumentstatuscategoryRepository.InsertOrUpdate(applicantdocumentstatuscategory);
                applicantdocumentstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /ApplicantDocumentStatusCategory/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantdocumentstatuscategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantDocumentStatusCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantdocumentstatuscategoryRepository.Delete(id);
            applicantdocumentstatuscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

