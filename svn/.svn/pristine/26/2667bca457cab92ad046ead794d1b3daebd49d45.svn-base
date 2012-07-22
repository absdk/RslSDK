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
    public class ApplicantSourceCategoryController : Controller
    {
		private readonly IApplicantSourceCategoryRepository applicantsourcecategoryRepository;
        public ApplicantSourceCategoryController(IApplicantSourceCategoryRepository applicantsourcecategoryRepository)
        {
			this.applicantsourcecategoryRepository = applicantsourcecategoryRepository;
        }

        //
        // GET: /ApplicantSourceCategory/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantsourcecategoryRepository.All);
        }
		
		public ViewResult Search(ApplicantSourceCategory searchApplicantSourceCategory)
        {
			if(searchApplicantSourceCategory!=null)
			{
							}
						return View("Index",applicantsourcecategoryRepository.All);
		}

        //
        // GET: /ApplicantSourceCategory/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantsourcecategoryRepository.Find(id));
        }

        //
        // GET: /ApplicantSourceCategory/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ApplicantSourceCategory/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(ApplicantSourceCategory applicantsourcecategory)
        {
            if (ModelState.IsValid) {
                applicantsourcecategoryRepository.InsertOrUpdate(applicantsourcecategory);
                applicantsourcecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /ApplicantSourceCategory/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(applicantsourcecategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantSourceCategory/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(ApplicantSourceCategory applicantsourcecategory)
        {
            if (ModelState.IsValid) {
                applicantsourcecategoryRepository.InsertOrUpdate(applicantsourcecategory);
                applicantsourcecategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /ApplicantSourceCategory/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantsourcecategoryRepository.Find(id));
        }

        //
        // POST: /ApplicantSourceCategory/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantsourcecategoryRepository.Delete(id);
            applicantsourcecategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

