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
    public class ApplicantDocumentCategoryController : Controller
    {
		private readonly IApplicantDocumentCategoryRepository applicantdocumentcategoryRepository;
        public ApplicantDocumentCategoryController(IApplicantDocumentCategoryRepository applicantdocumentcategoryRepository)
        {
			this.applicantdocumentcategoryRepository = applicantdocumentcategoryRepository;
        }

        //
        // GET: /ApplicantDocumentCategory/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantdocumentcategoryRepository.All);
        }
		
		public ViewResult Search(ApplicantDocumentCategory searchApplicantDocumentCategory)
        {
			if(searchApplicantDocumentCategory!=null)
			{
							}
						return View("Index",applicantdocumentcategoryRepository.All);
		}

        //
        // GET: /ApplicantDocumentCategory/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantdocumentcategoryRepository.Find(id));
        }

        //
        // GET: /ApplicantDocumentCategory/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ApplicantDocumentCategory/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(ApplicantDocumentCategory applicantdocumentcategory)
        {
            if (ModelState.IsValid) {
                applicantdocumentcategoryRepository.InsertOrUpdate(applicantdocumentcategory);
                applicantdocumentcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /ApplicantDocumentCategory/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(applicantdocumentcategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantDocumentCategory/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(ApplicantDocumentCategory applicantdocumentcategory)
        {
            if (ModelState.IsValid) {
                applicantdocumentcategoryRepository.InsertOrUpdate(applicantdocumentcategory);
                applicantdocumentcategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /ApplicantDocumentCategory/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantdocumentcategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantDocumentCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantdocumentcategoryRepository.Delete(id);
            applicantdocumentcategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

