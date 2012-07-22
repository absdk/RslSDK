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
namespace SoftwareGrid.Areas.Req.Controllers
{   
    public class RequisitionApplicantInterviewQuestionAnswersController : Controller
    {
		private readonly IRequisitionRepository requisitionRepository;
		private readonly IInterviewQuestionCategoryRepository interviewquestioncategoryRepository;
		private readonly IInterviewQuestionAnswerRepository interviewquestionanswerRepository;
		private readonly IApplicantRepository applicantRepository;
		private readonly IRequisitionApplicantInterviewQuestionAnswerRepository requisitionapplicantinterviewquestionanswerRepository;
        public RequisitionApplicantInterviewQuestionAnswersController(IRequisitionRepository requisitionRepository, IInterviewQuestionCategoryRepository interviewquestioncategoryRepository, IInterviewQuestionAnswerRepository interviewquestionanswerRepository, IApplicantRepository applicantRepository, IRequisitionApplicantInterviewQuestionAnswerRepository requisitionapplicantinterviewquestionanswerRepository)
        {
			this.requisitionRepository = requisitionRepository;
			this.interviewquestioncategoryRepository = interviewquestioncategoryRepository;
			this.interviewquestionanswerRepository = interviewquestionanswerRepository;
			this.applicantRepository = applicantRepository;
			this.requisitionapplicantinterviewquestionanswerRepository = requisitionapplicantinterviewquestionanswerRepository;
        }

        //
        // GET: /RequisitionApplicantInterviewQuestionAnswers/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionapplicantinterviewquestionanswerRepository.AllIncluding(requisitionapplicantinterviewquestionanswer => requisitionapplicantinterviewquestionanswer.Requisition, requisitionapplicantinterviewquestionanswer => requisitionapplicantinterviewquestionanswer.InterviewQuestionCategory, requisitionapplicantinterviewquestionanswer => requisitionapplicantinterviewquestionanswer.InterviewQuestion, requisitionapplicantinterviewquestionanswer => requisitionapplicantinterviewquestionanswer.Applicant));
        }
		
		public ViewResult Search(RequisitionApplicantInterviewQuestionAnswer searchRequisitionApplicantInterviewQuestionAnswer)
        {
			if(searchRequisitionApplicantInterviewQuestionAnswer!=null)
			{
							}
						return View("Index",requisitionapplicantinterviewquestionanswerRepository.AllIncluding(requisitionapplicantinterviewquestionanswer => requisitionapplicantinterviewquestionanswer.Requisition, requisitionapplicantinterviewquestionanswer => requisitionapplicantinterviewquestionanswer.InterviewQuestionCategory, requisitionapplicantinterviewquestionanswer => requisitionapplicantinterviewquestionanswer.InterviewQuestion, requisitionapplicantinterviewquestionanswer => requisitionapplicantinterviewquestionanswer.Applicant));
		}

        //
        // GET: /RequisitionApplicantInterviewQuestionAnswers/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionapplicantinterviewquestionanswerRepository.Find(id));
        }

        //
        // GET: /RequisitionApplicantInterviewQuestionAnswers/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionApplicantInterviewQuestionAnswer requisitionapplicantinterviewquestionanswer = new RequisitionApplicantInterviewQuestionAnswer();
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleInterviewQuestionCategories = interviewquestioncategoryRepository.All;
			ViewBag.PossibleInterviewQuestions = interviewquestionanswerRepository.All;
			ViewBag.PossibleApplicants = applicantRepository.All;
            return View(requisitionapplicantinterviewquestionanswer);
        } 

        //
        // POST: /RequisitionApplicantInterviewQuestionAnswers/Create
        [HttpPost]
        public ActionResult Create(RequisitionApplicantInterviewQuestionAnswer requisitionapplicantinterviewquestionanswer)
        {
            if (ModelState.IsValid) {
                requisitionapplicantinterviewquestionanswerRepository.InsertOrUpdate(requisitionapplicantinterviewquestionanswer);
                requisitionapplicantinterviewquestionanswerRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleInterviewQuestionCategories = interviewquestioncategoryRepository.All;
				ViewBag.PossibleInterviewQuestions = interviewquestionanswerRepository.All;
				ViewBag.PossibleApplicants = applicantRepository.All;
				return View(requisitionapplicantinterviewquestionanswer);
			}
        }
        
        //
        // GET: /RequisitionApplicantInterviewQuestionAnswers/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleInterviewQuestionCategories = interviewquestioncategoryRepository.All;
			ViewBag.PossibleInterviewQuestions = interviewquestionanswerRepository.All;
			ViewBag.PossibleApplicants = applicantRepository.All;
             return View(requisitionapplicantinterviewquestionanswerRepository.Find(id));
        }

        //
        // POST: /RequisitionApplicantInterviewQuestionAnswers/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionApplicantInterviewQuestionAnswer requisitionapplicantinterviewquestionanswer)
        {
            if (ModelState.IsValid) {
                requisitionapplicantinterviewquestionanswerRepository.InsertOrUpdate(requisitionapplicantinterviewquestionanswer);
                requisitionapplicantinterviewquestionanswerRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleInterviewQuestionCategories = interviewquestioncategoryRepository.All;
				ViewBag.PossibleInterviewQuestions = interviewquestionanswerRepository.All;
				ViewBag.PossibleApplicants = applicantRepository.All;
				return View(requisitionapplicantinterviewquestionanswer);
			}
        }

        //
        // GET: /RequisitionApplicantInterviewQuestionAnswers/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionapplicantinterviewquestionanswerRepository.Find(id));
        }

        //
        // POST: /RequisitionApplicantInterviewQuestionAnswers/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionapplicantinterviewquestionanswerRepository.Delete(id);
            requisitionapplicantinterviewquestionanswerRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

