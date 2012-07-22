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
    public class RequisitionSkillsExpertiseEducationMatchingMatricesController : Controller
    {
		private readonly IRequisitionRepository requisitionRepository;
		private readonly ISkillsExpEduCategoryRepository skillsexpeducategoryRepository;
		private readonly ISkillsExpEduRepository skillsexpeduRepository;
		private readonly IRatingScaleRepository ratingscaleRepository;
		private readonly IRequisitionSkillsExpertiseEducationMatchingMatrixRepository requisitionskillsexpertiseeducationmatchingmatrixRepository;
        public RequisitionSkillsExpertiseEducationMatchingMatricesController(IRequisitionRepository requisitionRepository, ISkillsExpEduCategoryRepository skillsexpeducategoryRepository, ISkillsExpEduRepository skillsexpeduRepository, IRatingScaleRepository ratingscaleRepository, IRequisitionSkillsExpertiseEducationMatchingMatrixRepository requisitionskillsexpertiseeducationmatchingmatrixRepository)
        {
			this.requisitionRepository = requisitionRepository;
			this.skillsexpeducategoryRepository = skillsexpeducategoryRepository;
			this.skillsexpeduRepository = skillsexpeduRepository;
			this.ratingscaleRepository = ratingscaleRepository;
			this.requisitionskillsexpertiseeducationmatchingmatrixRepository = requisitionskillsexpertiseeducationmatchingmatrixRepository;
        }

        //
        // GET: /RequisitionSkillsExpertiseEducationMatchingMatrices/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(requisitionskillsexpertiseeducationmatchingmatrixRepository.AllIncluding(requisitionskillsexpertiseeducationmatchingmatrix => requisitionskillsexpertiseeducationmatchingmatrix.Requisition, requisitionskillsexpertiseeducationmatchingmatrix => requisitionskillsexpertiseeducationmatchingmatrix.SkillsExpEduCategory, requisitionskillsexpertiseeducationmatchingmatrix => requisitionskillsexpertiseeducationmatchingmatrix.SkillsExpEdu, requisitionskillsexpertiseeducationmatchingmatrix => requisitionskillsexpertiseeducationmatchingmatrix.RatingScale));
        }
		
		public ViewResult Search(RequisitionSkillsExpertiseEducationMatchingMatrix searchRequisitionSkillsExpertiseEducationMatchingMatrix)
        {
			if(searchRequisitionSkillsExpertiseEducationMatchingMatrix!=null)
			{
							}
						return View("Index",requisitionskillsexpertiseeducationmatchingmatrixRepository.AllIncluding(requisitionskillsexpertiseeducationmatchingmatrix => requisitionskillsexpertiseeducationmatchingmatrix.Requisition, requisitionskillsexpertiseeducationmatchingmatrix => requisitionskillsexpertiseeducationmatchingmatrix.SkillsExpEduCategory, requisitionskillsexpertiseeducationmatchingmatrix => requisitionskillsexpertiseeducationmatchingmatrix.SkillsExpEdu, requisitionskillsexpertiseeducationmatchingmatrix => requisitionskillsexpertiseeducationmatchingmatrix.RatingScale));
		}

        //
        // GET: /RequisitionSkillsExpertiseEducationMatchingMatrices/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(requisitionskillsexpertiseeducationmatchingmatrixRepository.Find(id));
        }

        //
        // GET: /RequisitionSkillsExpertiseEducationMatchingMatrices/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			RequisitionSkillsExpertiseEducationMatchingMatrix requisitionskillsexpertiseeducationmatchingmatrix = new RequisitionSkillsExpertiseEducationMatchingMatrix();
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
			ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
			ViewBag.PossibleRatingScales = ratingscaleRepository.All;
            return View(requisitionskillsexpertiseeducationmatchingmatrix);
        } 

        //
        // POST: /RequisitionSkillsExpertiseEducationMatchingMatrices/Create
        [HttpPost]
        public ActionResult Create(RequisitionSkillsExpertiseEducationMatchingMatrix requisitionskillsexpertiseeducationmatchingmatrix)
        {
            if (ModelState.IsValid) {
                requisitionskillsexpertiseeducationmatchingmatrixRepository.InsertOrUpdate(requisitionskillsexpertiseeducationmatchingmatrix);
                requisitionskillsexpertiseeducationmatchingmatrixRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
				ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
				ViewBag.PossibleRatingScales = ratingscaleRepository.All;
				return View(requisitionskillsexpertiseeducationmatchingmatrix);
			}
        }
        
        //
        // GET: /RequisitionSkillsExpertiseEducationMatchingMatrices/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleRequisitions = requisitionRepository.All;
			ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
			ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
			ViewBag.PossibleRatingScales = ratingscaleRepository.All;
             return View(requisitionskillsexpertiseeducationmatchingmatrixRepository.Find(id));
        }

        //
        // POST: /RequisitionSkillsExpertiseEducationMatchingMatrices/Edit/5
        [HttpPost]
        public ActionResult Edit(RequisitionSkillsExpertiseEducationMatchingMatrix requisitionskillsexpertiseeducationmatchingmatrix)
        {
            if (ModelState.IsValid) {
                requisitionskillsexpertiseeducationmatchingmatrixRepository.InsertOrUpdate(requisitionskillsexpertiseeducationmatchingmatrix);
                requisitionskillsexpertiseeducationmatchingmatrixRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleRequisitions = requisitionRepository.All;
				ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
				ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
				ViewBag.PossibleRatingScales = ratingscaleRepository.All;
				return View(requisitionskillsexpertiseeducationmatchingmatrix);
			}
        }

        //
        // GET: /RequisitionSkillsExpertiseEducationMatchingMatrices/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(requisitionskillsexpertiseeducationmatchingmatrixRepository.Find(id));
        }

        //
        // POST: /RequisitionSkillsExpertiseEducationMatchingMatrices/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            requisitionskillsexpertiseeducationmatchingmatrixRepository.Delete(id);
            requisitionskillsexpertiseeducationmatchingmatrixRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

