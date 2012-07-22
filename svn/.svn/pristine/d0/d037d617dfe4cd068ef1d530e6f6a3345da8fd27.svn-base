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
    public class SalutationController : Controller
    {
		private readonly ISalutationRepository salutationRepository;
        public SalutationController(ISalutationRepository salutationRepository)
        {
			this.salutationRepository = salutationRepository;
        }

        //
        // GET: /Salutation/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(salutationRepository.All);
        }
		
		public ViewResult Search(Salutation searchSalutation)
        {
			if(searchSalutation!=null)
			{
							}
						return View("Index",salutationRepository.All);
		}

        //
        // GET: /Salutation/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(salutationRepository.Find(id));
        }

        //
        // GET: /Salutation/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Salutation/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(Salutation salutation)
        {
            if (ModelState.IsValid) {
                salutationRepository.InsertOrUpdate(salutation);
                salutationRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Salutation/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(salutationRepository.Find(id));
        }

        //
        // POST: /Salutation/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Salutation salutation)
        {
            if (ModelState.IsValid) {
                salutationRepository.InsertOrUpdate(salutation);
                salutationRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Salutation/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(salutationRepository.Find(id));
        }

        //
        // POST: /Salutation/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            salutationRepository.Delete(id);
            salutationRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

