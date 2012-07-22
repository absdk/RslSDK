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

namespace SoftwareGrid.Areas.MasterData.Controllers
{   
    public class FamilyRelationshipController : Controller
    {
		private readonly IFamilyRelationshipRepository familyrelationshipRepository;
        public FamilyRelationshipController(IFamilyRelationshipRepository familyrelationshipRepository)
        {
			this.familyrelationshipRepository = familyrelationshipRepository;
        }

        //
        // GET: /FamilyRelationship/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(familyrelationshipRepository.All);
        }
		
		public ViewResult Search(FamilyRelationship searchFamilyRelationship)
        {
			if(searchFamilyRelationship!=null)
			{
							}
						return View("Index",familyrelationshipRepository.All);
		}

        //
        // GET: /FamilyRelationship/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(familyrelationshipRepository.Find(id));
        }

        //
        // GET: /FamilyRelationship/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /FamilyRelationship/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(FamilyRelationship familyrelationship)
        {
            if (ModelState.IsValid) {
                familyrelationshipRepository.InsertOrUpdate(familyrelationship);
                familyrelationshipRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /FamilyRelationship/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(familyrelationshipRepository.Find(id));
        }

        //
        // POST: /FamilyRelationship/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(FamilyRelationship familyrelationship)
        {
            if (ModelState.IsValid) {
                familyrelationshipRepository.InsertOrUpdate(familyrelationship);
                familyrelationshipRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /FamilyRelationship/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(familyrelationshipRepository.Find(id));
        }

        //
        // POST: /FamilyRelationship/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            familyrelationshipRepository.Delete(id);
            familyrelationshipRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

