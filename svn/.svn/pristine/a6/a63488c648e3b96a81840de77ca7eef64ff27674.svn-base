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
    public class SkillsExpEduCategoriesController : Controller
    {
		private readonly ISkillsExpEduCategoryRepository skillsexpeducategoryRepository;
        public SkillsExpEduCategoriesController(ISkillsExpEduCategoryRepository skillsexpeducategoryRepository)
        {
			this.skillsexpeducategoryRepository = skillsexpeducategoryRepository;
        }

        //
        // GET: /SkillsExpEduCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(skillsexpeducategoryRepository.AllIncluding(skillsexpeducategory => skillsexpeducategory.ParentSkillsExpEduCategory));
        }
		
		public ViewResult Search(SkillsExpEduCategory searchSkillsExpEduCategory)
        {
			if(searchSkillsExpEduCategory!=null)
			{
							}
						return View("Index",skillsexpeducategoryRepository.AllIncluding(skillsexpeducategory => skillsexpeducategory.ParentSkillsExpEduCategory));
		}

        //
        // GET: /SkillsExpEduCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(skillsexpeducategoryRepository.Find(id));
        }

        //
        // GET: /SkillsExpEduCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			SkillsExpEduCategory skillsexpeducategory = new SkillsExpEduCategory();
			ViewBag.PossibleParentSkillsExpEduCategories = skillsexpeducategoryRepository.All;
            return View(skillsexpeducategory);
        } 

        //
        // POST: /SkillsExpEduCategories/Create
        [HttpPost]
        public ActionResult Create(SkillsExpEduCategory skillsexpeducategory)
        {
            if (ModelState.IsValid) {
                skillsexpeducategoryRepository.InsertOrUpdate(skillsexpeducategory);
                skillsexpeducategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleParentSkillsExpEduCategories = skillsexpeducategoryRepository.All;
				return View(skillsexpeducategory);
			}
        }
        
        //
        // GET: /SkillsExpEduCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleParentSkillsExpEduCategories = skillsexpeducategoryRepository.All;
             return View(skillsexpeducategoryRepository.Find(id));
        }

        //
        // POST: /SkillsExpEduCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(SkillsExpEduCategory skillsexpeducategory)
        {
            if (ModelState.IsValid) {
                skillsexpeducategoryRepository.InsertOrUpdate(skillsexpeducategory);
                skillsexpeducategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleParentSkillsExpEduCategories = skillsexpeducategoryRepository.All;
				return View(skillsexpeducategory);
			}
        }

        //
        // GET: /SkillsExpEduCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(skillsexpeducategoryRepository.Find(id));
        }

        //
        // POST: /SkillsExpEduCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            skillsexpeducategoryRepository.Delete(id);
            skillsexpeducategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

