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
    public class DisabilityController : Controller
    {
		private readonly IDisabilityRepository disabilityRepository;
        public DisabilityController(IDisabilityRepository disabilityRepository)
        {
			this.disabilityRepository = disabilityRepository;
        }

        //
        // GET: /Disability/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(disabilityRepository.All);
        }
		
		public ViewResult Search(Disability searchDisability)
        {
			if(searchDisability!=null)
			{
							}
						return View("Index",disabilityRepository.All);
		}

        //
        // GET: /Disability/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(disabilityRepository.Find(id));
        }

        //
        // GET: /Disability/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Disability/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(Disability disability)
        {
            if (ModelState.IsValid) {
                disabilityRepository.InsertOrUpdate(disability);
                disabilityRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Disability/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(disabilityRepository.Find(id));
        }

        //
        // POST: /Disability/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Disability disability)
        {
            if (ModelState.IsValid) {
                disabilityRepository.InsertOrUpdate(disability);
                disabilityRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Disability/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(disabilityRepository.Find(id));
        }

        //
        // POST: /Disability/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            disabilityRepository.Delete(id);
            disabilityRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

