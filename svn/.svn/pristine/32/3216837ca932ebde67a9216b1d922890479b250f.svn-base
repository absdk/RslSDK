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
    public class VisaController : Controller
    {
		private readonly IVisaRepository visaRepository;
        public VisaController(IVisaRepository visaRepository)
        {
			this.visaRepository = visaRepository;
        }

        //
        // GET: /Visa/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(visaRepository.All);
        }
		
		public ViewResult Search(Visa searchVisa)
        {
			if(searchVisa!=null)
			{
							}
						return View("Index",visaRepository.All);
		}

        //
        // GET: /Visa/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(visaRepository.Find(id));
        }

        //
        // GET: /Visa/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Visa/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(Visa visa)
        {
            if (ModelState.IsValid) {
                visaRepository.InsertOrUpdate(visa);
                visaRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /Visa/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(visaRepository.Find(id));
        }

        //
        // POST: /Visa/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(Visa visa)
        {
            if (ModelState.IsValid) {
                visaRepository.InsertOrUpdate(visa);
                visaRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /Visa/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(visaRepository.Find(id));
        }

        //
        // POST: /Visa/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            visaRepository.Delete(id);
            visaRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

