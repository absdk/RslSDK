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
    public class CityController : Controller
    {
		private readonly ICountryRepository countryRepository;
		private readonly IStateRepository stateRepository;
		private readonly ICityRepository cityRepository;
        public CityController(ICountryRepository countryRepository, IStateRepository stateRepository, ICityRepository cityRepository)
        {
			this.countryRepository = countryRepository;
			this.stateRepository = stateRepository;
			this.cityRepository = cityRepository;
        }

        //
        // GET: /City/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(cityRepository.AllIncluding(city => city.Country, city => city.State));
        }
		
		public ViewResult Search(City searchCity)
        {
			if(searchCity!=null)
			{
							}
						return View("Index",cityRepository.AllIncluding(city => city.Country, city => city.State));
		}

        //
        // GET: /City/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(cityRepository.Find(id));
        }

        //
        // GET: /City/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			ViewBag.PossibleCountries = countryRepository.All;
			ViewBag.PossibleStates = stateRepository.All;
            return View();
        } 

        //
        // POST: /City/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(City city)
        {
            if (ModelState.IsValid) {
                cityRepository.InsertOrUpdate(city);
                cityRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCountries = countryRepository.All;
				ViewBag.PossibleStates = stateRepository.All;
				return View();
			}
        }
        
        //
        // GET: /City/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleCountries = countryRepository.All;
			ViewBag.PossibleStates = stateRepository.All;
             return View(cityRepository.Find(id));
        }

        //
        // POST: /City/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(City city)
        {
            if (ModelState.IsValid) {
                cityRepository.InsertOrUpdate(city);
                cityRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleCountries = countryRepository.All;
				ViewBag.PossibleStates = stateRepository.All;
				return View();
			}
        }

        //
        // GET: /City/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(cityRepository.Find(id));
        }

        //
        // POST: /City/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            cityRepository.Delete(id);
            cityRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

