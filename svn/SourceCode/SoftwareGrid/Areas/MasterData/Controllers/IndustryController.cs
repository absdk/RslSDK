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
    public class IndustryController : Controller
    {
		private readonly IIndustryRepository industryRepository;
        public IndustryController(IIndustryRepository industryRepository)
        {
			this.industryRepository = industryRepository;
        }

        //
        // GET: /Industry/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(industryRepository.All);
        }
		
		public ViewResult Search(Industry searchIndustry)
        {
			if(searchIndustry!=null)
			{
							}
						return View("Index",industryRepository.All);
		}

        //
        // GET: /Industry/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(industryRepository.Find(id));
        }

        //
        // GET: /Industry/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Industry/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(Industry industry)
        {
            if (ModelState.IsValid) {
                industryRepository.InsertOrUpdate(industry);
                industryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Industry/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(industryRepository.Find(id));
        }

        //
        // POST: /Industry/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Industry industry)
        {
            if (ModelState.IsValid) {
                industryRepository.InsertOrUpdate(industry);
                industryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Industry/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(industryRepository.Find(id));
        }

        //
        // POST: /Industry/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            industryRepository.Delete(id);
            industryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

