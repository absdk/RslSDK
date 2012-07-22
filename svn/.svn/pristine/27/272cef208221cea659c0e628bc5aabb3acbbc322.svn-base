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
namespace SoftwareGrid.Areas.MasterData.Controllers
{   
    public class InterviewQuestionCategoriesController : Controller
    {
		private readonly IInterviewQuestionCategoryRepository interviewquestioncategoryRepository;
        public InterviewQuestionCategoriesController(IInterviewQuestionCategoryRepository interviewquestioncategoryRepository)
        {
			this.interviewquestioncategoryRepository = interviewquestioncategoryRepository;
        }

        //
        // GET: /InterviewQuestionCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(interviewquestioncategoryRepository.All);
        }
		
		public ViewResult Search(InterviewQuestionCategory searchInterviewQuestionCategory)
        {
			if(searchInterviewQuestionCategory!=null)
			{
							}
						return View("Index",interviewquestioncategoryRepository.All);
		}

        //
        // GET: /InterviewQuestionCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(interviewquestioncategoryRepository.Find(id));
        }

        //
        // GET: /InterviewQuestionCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			InterviewQuestionCategory interviewquestioncategory = new InterviewQuestionCategory();
            return View(interviewquestioncategory);
        } 

        //
        // POST: /InterviewQuestionCategories/Create
        [HttpPost]
        public ActionResult Create(InterviewQuestionCategory interviewquestioncategory)
        {
            if (ModelState.IsValid) {
                interviewquestioncategoryRepository.InsertOrUpdate(interviewquestioncategory);
                interviewquestioncategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(interviewquestioncategory);
			}
        }
        
        //
        // GET: /InterviewQuestionCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(interviewquestioncategoryRepository.Find(id));
        }

        //
        // POST: /InterviewQuestionCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(InterviewQuestionCategory interviewquestioncategory)
        {
            if (ModelState.IsValid) {
                interviewquestioncategoryRepository.InsertOrUpdate(interviewquestioncategory);
                interviewquestioncategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(interviewquestioncategory);
			}
        }

        //
        // GET: /InterviewQuestionCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(interviewquestioncategoryRepository.Find(id));
        }

        //
        // POST: /InterviewQuestionCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            interviewquestioncategoryRepository.Delete(id);
            interviewquestioncategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

