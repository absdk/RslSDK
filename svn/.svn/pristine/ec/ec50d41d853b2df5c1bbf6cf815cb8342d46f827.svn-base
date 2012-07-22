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
    public class ApplicantSubmissionInfoesController : Controller
    {
		private readonly IApplicantRepository applicantRepository;
		private readonly IUserRepository userRepository;
		private readonly IRequisitionRepository requisitionRepository;
		private readonly ICompanyRepository companyRepository;
		private readonly IContactRepository contactRepository;
		private readonly IApplicantSubmissionFeedbackCategoryRepository applicantsubmissionfeedbackcategoryRepository;
		private readonly IApplicantSubmissionInfoRepository applicantsubmissioninfoRepository;
        public ApplicantSubmissionInfoesController(IApplicantRepository applicantRepository, IUserRepository userRepository, IRequisitionRepository requisitionRepository, ICompanyRepository companyRepository, IContactRepository contactRepository, IApplicantSubmissionFeedbackCategoryRepository applicantsubmissionfeedbackcategoryRepository, IApplicantSubmissionInfoRepository applicantsubmissioninfoRepository)
        {
			this.applicantRepository = applicantRepository;
			this.userRepository = userRepository;
			this.requisitionRepository = requisitionRepository;
			this.companyRepository = companyRepository;
			this.contactRepository = contactRepository;
			this.applicantsubmissionfeedbackcategoryRepository = applicantsubmissionfeedbackcategoryRepository;
			this.applicantsubmissioninfoRepository = applicantsubmissioninfoRepository;
        }

        //
        // GET: /ApplicantSubmissionInfoes/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(applicantsubmissioninfoRepository.AllIncluding(applicantsubmissioninfo => applicantsubmissioninfo.Applicant, applicantsubmissioninfo => applicantsubmissioninfo.SubmittedByUser, applicantsubmissioninfo => applicantsubmissioninfo.Requisition, applicantsubmissioninfo => applicantsubmissioninfo.SubmitToCompany, applicantsubmissioninfo => applicantsubmissioninfo.SubmitToContact, applicantsubmissioninfo => applicantsubmissioninfo.SubmitToHiringManagerUser, applicantsubmissioninfo => applicantsubmissioninfo.ApplicantSubmissionFeedbackCategory));
        }
		
		public ViewResult Search(ApplicantSubmissionInfo searchApplicantSubmissionInfo)
        {
			if(searchApplicantSubmissionInfo!=null)
			{
							}
						return View("Index",applicantsubmissioninfoRepository.AllIncluding(applicantsubmissioninfo => applicantsubmissioninfo.Applicant, applicantsubmissioninfo => applicantsubmissioninfo.SubmittedByUser, applicantsubmissioninfo => applicantsubmissioninfo.Requisition, applicantsubmissioninfo => applicantsubmissioninfo.SubmitToCompany, applicantsubmissioninfo => applicantsubmissioninfo.SubmitToContact, applicantsubmissioninfo => applicantsubmissioninfo.SubmitToHiringManagerUser, applicantsubmissioninfo => applicantsubmissioninfo.ApplicantSubmissionFeedbackCategory));
		}

        //
        // GET: /ApplicantSubmissionInfoes/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(applicantsubmissioninfoRepository.Find(id));
        }

        //
        // GET: /ApplicantSubmissionInfoes/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ApplicantSubmissionInfo applicantsubmissioninfo = new ApplicantSubmissionInfo();
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleSubmittedByUsers = userRepository.All;
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleSubmitToCompanies = companyRepository.All;
			ViewBag.PossibleSubmitToContacts = contactRepository.All;
			ViewBag.PossibleSubmitToHiringManagerUsers = userRepository.All;
			ViewBag.PossibleApplicantSubmissionFeedbackCategories = applicantsubmissionfeedbackcategoryRepository.All;
            return View(applicantsubmissioninfo);
        } 

        //
        // POST: /ApplicantSubmissionInfoes/Create
        [HttpPost]
        public ActionResult Create(ApplicantSubmissionInfo applicantsubmissioninfo)
        {
            if (ModelState.IsValid) {
                applicantsubmissioninfoRepository.InsertOrUpdate(applicantsubmissioninfo);
                applicantsubmissioninfoRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleSubmittedByUsers = userRepository.All;
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleSubmitToCompanies = companyRepository.All;
				ViewBag.PossibleSubmitToContacts = contactRepository.All;
				ViewBag.PossibleSubmitToHiringManagerUsers = userRepository.All;
				ViewBag.PossibleApplicantSubmissionFeedbackCategories = applicantsubmissionfeedbackcategoryRepository.All;
				return View(applicantsubmissioninfo);
			}
        }
        
        //
        // GET: /ApplicantSubmissionInfoes/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleApplicants = applicantRepository.All;
			ViewBag.PossibleSubmittedByUsers = userRepository.All;
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleSubmitToCompanies = companyRepository.All;
			ViewBag.PossibleSubmitToContacts = contactRepository.All;
			ViewBag.PossibleSubmitToHiringManagerUsers = userRepository.All;
			ViewBag.PossibleApplicantSubmissionFeedbackCategories = applicantsubmissionfeedbackcategoryRepository.All;
             return View(applicantsubmissioninfoRepository.Find(id));
        }

        //
        // POST: /ApplicantSubmissionInfoes/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicantSubmissionInfo applicantsubmissioninfo)
        {
            if (ModelState.IsValid) {
                applicantsubmissioninfoRepository.InsertOrUpdate(applicantsubmissioninfo);
                applicantsubmissioninfoRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleApplicants = applicantRepository.All;
				ViewBag.PossibleSubmittedByUsers = userRepository.All;
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleSubmitToCompanies = companyRepository.All;
				ViewBag.PossibleSubmitToContacts = contactRepository.All;
				ViewBag.PossibleSubmitToHiringManagerUsers = userRepository.All;
				ViewBag.PossibleApplicantSubmissionFeedbackCategories = applicantsubmissionfeedbackcategoryRepository.All;
				return View(applicantsubmissioninfo);
			}
        }

        //
        // GET: /ApplicantSubmissionInfoes/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(applicantsubmissioninfoRepository.Find(id));
        }

        //
        // POST: /ApplicantSubmissionInfoes/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            applicantsubmissioninfoRepository.Delete(id);
            applicantsubmissioninfoRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

