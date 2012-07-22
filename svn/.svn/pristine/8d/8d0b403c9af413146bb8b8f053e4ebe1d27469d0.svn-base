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
    public class RatingScaleController : Controller
    {
		private readonly IRatingScaleRepository ratingscaleRepository;
        public RatingScaleController(IRatingScaleRepository ratingscaleRepository)
        {
			this.ratingscaleRepository = ratingscaleRepository;
        }

        //
        // GET: /RatingScale/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(ratingscaleRepository.All);
        }
		
		public ViewResult Search(RatingScale searchRatingScale)
        {
			if(searchRatingScale!=null)
			{
							}
						return View("Index",ratingscaleRepository.All);
		}

        //
        // GET: /RatingScale/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(ratingscaleRepository.Find(id));
        }

        //
        // GET: /RatingScale/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /RatingScale/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(RatingScale ratingscale)
        {
            if (ModelState.IsValid) {
                ratingscaleRepository.InsertOrUpdate(ratingscale);
                ratingscaleRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /RatingScale/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(ratingscaleRepository.Find(id));
        }

        //
        // POST: /RatingScale/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(RatingScale ratingscale)
        {
            if (ModelState.IsValid) {
                ratingscaleRepository.InsertOrUpdate(ratingscale);
                ratingscaleRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /RatingScale/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(ratingscaleRepository.Find(id));
        }

        //
        // POST: /RatingScale/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ratingscaleRepository.Delete(id);
            ratingscaleRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

