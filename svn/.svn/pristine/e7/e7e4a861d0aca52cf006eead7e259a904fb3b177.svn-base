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
    public class RegionController : Controller
    {
		private readonly IRegionRepository regionRepository;
        public RegionController(IRegionRepository regionRepository)
        {
			this.regionRepository = regionRepository;
        }

        //
        // GET: /Region/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(regionRepository.All);
        }
		
		public ViewResult Search(Region searchRegion)
        {
			if(searchRegion!=null)
			{
							}
						return View("Index",regionRepository.All);
		}

        //
        // GET: /Region/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(regionRepository.Find(id));
        }

        //
        // GET: /Region/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Region/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(Region region)
        {
            if (ModelState.IsValid) {
                regionRepository.InsertOrUpdate(region);
                regionRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Region/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(regionRepository.Find(id));
        }

        //
        // POST: /Region/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Region region)
        {
            if (ModelState.IsValid) {
                regionRepository.InsertOrUpdate(region);
                regionRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Region/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(regionRepository.Find(id));
        }

        //
        // POST: /Region/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            regionRepository.Delete(id);
            regionRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

