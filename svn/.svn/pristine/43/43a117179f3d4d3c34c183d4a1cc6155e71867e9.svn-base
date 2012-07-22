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
    public class SkillsExpEdusController : Controller
    {
		private readonly ISkillsExpEduCategoryRepository skillsexpeducategoryRepository;
		private readonly ISkillsExpEduRepository skillsexpeduRepository;
        public SkillsExpEdusController(ISkillsExpEduCategoryRepository skillsexpeducategoryRepository, ISkillsExpEduRepository skillsexpeduRepository)
        {
			this.skillsexpeducategoryRepository = skillsexpeducategoryRepository;
			this.skillsexpeduRepository = skillsexpeduRepository;
        }

        //
        // GET: /SkillsExpEdus/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(skillsexpeduRepository.AllIncluding(skillsexpedu => skillsexpedu.SkillsExpEduCategory));
        }
		
		public ViewResult Search(SkillsExpEdu searchSkillsExpEdu)
        {
			if(searchSkillsExpEdu!=null)
			{
							}
						return View("Index",skillsexpeduRepository.AllIncluding(skillsexpedu => skillsexpedu.SkillsExpEduCategory));
		}

        //
        // GET: /SkillsExpEdus/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(skillsexpeduRepository.Find(id));
        }

        //
        // GET: /SkillsExpEdus/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			SkillsExpEdu skillsexpedu = new SkillsExpEdu();
			ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
            return View(skillsexpedu);
        } 

        //
        // POST: /SkillsExpEdus/Create
        [HttpPost]
        public ActionResult Create(SkillsExpEdu skillsexpedu)
        {
            if (ModelState.IsValid) {
                skillsexpeduRepository.InsertOrUpdate(skillsexpedu);
                skillsexpeduRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
				return View(skillsexpedu);
			}
        }
        
        //
        // GET: /SkillsExpEdus/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
             return View(skillsexpeduRepository.Find(id));
        }

        //
        // POST: /SkillsExpEdus/Edit/5
        [HttpPost]
        public ActionResult Edit(SkillsExpEdu skillsexpedu)
        {
            if (ModelState.IsValid) {
                skillsexpeduRepository.InsertOrUpdate(skillsexpedu);
                skillsexpeduRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSkillsExpEduCategories = skillsexpeducategoryRepository.All;
				return View(skillsexpedu);
			}
        }

        //
        // GET: /SkillsExpEdus/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(skillsexpeduRepository.Find(id));
        }

        //
        // POST: /SkillsExpEdus/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            skillsexpeduRepository.Delete(id);
            skillsexpeduRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

