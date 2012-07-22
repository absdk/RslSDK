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
    public class StateController : Controller
    {
		private readonly ICountryRepository countryRepository;
		private readonly IStateRepository stateRepository;
        public StateController(ICountryRepository countryRepository, IStateRepository stateRepository)
        {
			this.countryRepository = countryRepository;
			this.stateRepository = stateRepository;
        }

        //
        // GET: /State/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(stateRepository.AllIncluding(state => state.Country));
        }
		
		public ViewResult Search(State searchState)
        {
			if(searchState!=null)
			{
							}
						return View("Index",stateRepository.AllIncluding(state => state.Country));
		}

        //
        // GET: /State/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(stateRepository.Find(id));
        }

        //
        // GET: /State/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ViewBag.PossibleCountries = countryRepository.All;
            return View();
        } 

        //
        // POST: /State/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(State state)
        {
            if (ModelState.IsValid) {
                stateRepository.InsertOrUpdate(state);
                stateRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCountries = countryRepository.All;
				return View();
			}
        }
        
        //
        // GET: /State/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleCountries = countryRepository.All;
             return View(stateRepository.Find(id));
        }

        //
        // POST: /State/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(State state)
        {
            if (ModelState.IsValid) {
                stateRepository.InsertOrUpdate(state);
                stateRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCountries = countryRepository.All;
				return View();
			}
        }

        //
        // GET: /State/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(stateRepository.Find(id));
        }

        //
        // POST: /State/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            stateRepository.Delete(id);
            stateRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

