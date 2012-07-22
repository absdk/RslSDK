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
    public class InterviewQuestionAnswersController : Controller
    {
		private readonly ISkillsExpEduRepository skillsexpeduRepository;
		private readonly IInterviewQuestionAnswerRepository interviewquestionanswerRepository;
        public InterviewQuestionAnswersController(ISkillsExpEduRepository skillsexpeduRepository, IInterviewQuestionAnswerRepository interviewquestionanswerRepository)
        {
			this.skillsexpeduRepository = skillsexpeduRepository;
			this.interviewquestionanswerRepository = interviewquestionanswerRepository;
        }

        //
        // GET: /InterviewQuestionAnswers/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(interviewquestionanswerRepository.AllIncluding(interviewquestionanswer => interviewquestionanswer.SkillsExpEdu));
        }
		
		public ViewResult Search(InterviewQuestionAnswer searchInterviewQuestionAnswer)
        {
			if(searchInterviewQuestionAnswer!=null)
			{
							}
						return View("Index",interviewquestionanswerRepository.AllIncluding(interviewquestionanswer => interviewquestionanswer.SkillsExpEdu));
		}

        //
        // GET: /InterviewQuestionAnswers/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(interviewquestionanswerRepository.Find(id));
        }

        //
        // GET: /InterviewQuestionAnswers/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			InterviewQuestionAnswer interviewquestionanswer = new InterviewQuestionAnswer();
			ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
            return View(interviewquestionanswer);
        } 

        //
        // POST: /InterviewQuestionAnswers/Create
        [HttpPost]
        public ActionResult Create(InterviewQuestionAnswer interviewquestionanswer)
        {
            if (ModelState.IsValid) {
                interviewquestionanswerRepository.InsertOrUpdate(interviewquestionanswer);
                interviewquestionanswerRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
				return View(interviewquestionanswer);
			}
        }
        
        //
        // GET: /InterviewQuestionAnswers/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
             return View(interviewquestionanswerRepository.Find(id));
        }

        //
        // POST: /InterviewQuestionAnswers/Edit/5
        [HttpPost]
        public ActionResult Edit(InterviewQuestionAnswer interviewquestionanswer)
        {
            if (ModelState.IsValid) {
                interviewquestionanswerRepository.InsertOrUpdate(interviewquestionanswer);
                interviewquestionanswerRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
				return View(interviewquestionanswer);
			}
        }

        //
        // GET: /InterviewQuestionAnswers/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(interviewquestionanswerRepository.Find(id));
        }

        //
        // POST: /InterviewQuestionAnswers/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            interviewquestionanswerRepository.Delete(id);
            interviewquestionanswerRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

