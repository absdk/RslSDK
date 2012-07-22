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
    public class VisaStatusController : Controller
    {
		private readonly IVisaStatusRepository visastatusRepository;
        public VisaStatusController(IVisaStatusRepository visastatusRepository)
        {
			this.visastatusRepository = visastatusRepository;
        }

        //
        // GET: /VisaStatus/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(visastatusRepository.All);
        }
		
		public ViewResult Search(VisaStatus searchVisaStatus)
        {
			if(searchVisaStatus!=null)
			{
							}
						return View("Index",visastatusRepository.All);
		}

        //
        // GET: /VisaStatus/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(visastatusRepository.Find(id));
        }

        //
        // GET: /VisaStatus/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /VisaStatus/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(VisaStatus visastatus)
        {
            if (ModelState.IsValid) {
                visastatusRepository.InsertOrUpdate(visastatus);
                visastatusRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /VisaStatus/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(visastatusRepository.Find(id));
        }

        //
        // POST: /VisaStatus/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(VisaStatus visastatus)
        {
            if (ModelState.IsValid) {
                visastatusRepository.InsertOrUpdate(visastatus);
                visastatusRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /VisaStatus/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(visastatusRepository.Find(id));
        }

        //
        // POST: /VisaStatus/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            visastatusRepository.Delete(id);
            visastatusRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

