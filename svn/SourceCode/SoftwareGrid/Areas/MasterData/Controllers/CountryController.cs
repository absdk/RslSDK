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
    public class CountryController : Controller
    {
		private readonly ICountryRepository countryRepository;
        public CountryController(ICountryRepository countryRepository)
        {
			this.countryRepository = countryRepository;
        }

        //
        // GET: /Country/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(countryRepository.All);
        }
		
		public ViewResult Search(Country searchCountry)
        {
			if(searchCountry!=null)
			{
							}
						return View("Index",countryRepository.All);
		}

        //
        // GET: /Country/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(countryRepository.Find(id));
        }

        //
        // GET: /Country/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Country/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(Country country)
        {
            if (ModelState.IsValid) {
                countryRepository.InsertOrUpdate(country);
                countryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Country/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(countryRepository.Find(id));
        }

        //
        // POST: /Country/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Country country)
        {
            if (ModelState.IsValid) {
                countryRepository.InsertOrUpdate(country);
                countryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Country/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(countryRepository.Find(id));
        }

        //
        // POST: /Country/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            countryRepository.Delete(id);
            countryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

