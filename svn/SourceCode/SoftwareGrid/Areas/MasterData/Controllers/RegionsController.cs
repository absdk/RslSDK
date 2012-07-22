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
    public class RegionsController : Controller
    {
		private readonly IRegionRepository regionRepository;
        public RegionsController(IRegionRepository regionRepository)
        {
			this.regionRepository = regionRepository;
        }

        //
        // GET: /Regions/
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
        // GET: /Regions/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(regionRepository.Find(id));
        }

        //
        // GET: /Regions/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			Region region = new Region();
            return View(region);
        } 

        //
        // POST: /Regions/Create
        [HttpPost]
        public ActionResult Create(Region region)
        {
            if (ModelState.IsValid) {
                regionRepository.InsertOrUpdate(region);
                regionRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(region);
			}
        }
        
        //
        // GET: /Regions/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(regionRepository.Find(id));
        }

        //
        // POST: /Regions/Edit/5
        [HttpPost]
        public ActionResult Edit(Region region)
        {
            if (ModelState.IsValid) {
                regionRepository.InsertOrUpdate(region);
                regionRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(region);
			}
        }

        //
        // GET: /Regions/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(regionRepository.Find(id));
        }

        //
        // POST: /Regions/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            regionRepository.Delete(id);
            regionRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

