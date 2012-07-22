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
    public class SkillsExpEduSynonymsController : Controller
    {
		private readonly ISkillsExpEduRepository skillsexpeduRepository;
		private readonly ISkillsExpEduSynonymRepository skillsexpedusynonymRepository;
        public SkillsExpEduSynonymsController(ISkillsExpEduRepository skillsexpeduRepository, ISkillsExpEduSynonymRepository skillsexpedusynonymRepository)
        {
			this.skillsexpeduRepository = skillsexpeduRepository;
			this.skillsexpedusynonymRepository = skillsexpedusynonymRepository;
        }

        //
        // GET: /SkillsExpEduSynonyms/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(skillsexpedusynonymRepository.AllIncluding(skillsexpedusynonym => skillsexpedusynonym.SkillsExpEdu));
        }
		
		public ViewResult Search(SkillsExpEduSynonym searchSkillsExpEduSynonym)
        {
			if(searchSkillsExpEduSynonym!=null)
			{
							}
						return View("Index",skillsexpedusynonymRepository.AllIncluding(skillsexpedusynonym => skillsexpedusynonym.SkillsExpEdu));
		}

        //
        // GET: /SkillsExpEduSynonyms/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(skillsexpedusynonymRepository.Find(id));
        }

        //
        // GET: /SkillsExpEduSynonyms/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			SkillsExpEduSynonym skillsexpedusynonym = new SkillsExpEduSynonym();
			ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
            return View(skillsexpedusynonym);
        } 

        //
        // POST: /SkillsExpEduSynonyms/Create
        [HttpPost]
        public ActionResult Create(SkillsExpEduSynonym skillsexpedusynonym)
        {
            if (ModelState.IsValid) {
                skillsexpedusynonymRepository.InsertOrUpdate(skillsexpedusynonym);
                skillsexpedusynonymRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
				return View(skillsexpedusynonym);
			}
        }
        
        //
        // GET: /SkillsExpEduSynonyms/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
             return View(skillsexpedusynonymRepository.Find(id));
        }

        //
        // POST: /SkillsExpEduSynonyms/Edit/5
        [HttpPost]
        public ActionResult Edit(SkillsExpEduSynonym skillsexpedusynonym)
        {
            if (ModelState.IsValid) {
                skillsexpedusynonymRepository.InsertOrUpdate(skillsexpedusynonym);
                skillsexpedusynonymRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleSkillsExpEdus = skillsexpeduRepository.All;
				return View(skillsexpedusynonym);
			}
        }

        //
        // GET: /SkillsExpEduSynonyms/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(skillsexpedusynonymRepository.Find(id));
        }

        //
        // POST: /SkillsExpEduSynonyms/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            skillsexpedusynonymRepository.Delete(id);
            skillsexpedusynonymRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

