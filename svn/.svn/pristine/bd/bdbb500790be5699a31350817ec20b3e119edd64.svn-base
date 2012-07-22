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
    public class SalaryTaxTypeController : Controller
    {
		private readonly ISalaryTaxTypeRepository salarytaxtypeRepository;
        public SalaryTaxTypeController(ISalaryTaxTypeRepository salarytaxtypeRepository)
        {
			this.salarytaxtypeRepository = salarytaxtypeRepository;
        }

        //
        // GET: /SalaryTaxType/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(salarytaxtypeRepository.All);
        }
		
		public ViewResult Search(SalaryTaxType searchSalaryTaxType)
        {
			if(searchSalaryTaxType!=null)
			{
							}
						return View("Index",salarytaxtypeRepository.All);
		}

        //
        // GET: /SalaryTaxType/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(salarytaxtypeRepository.Find(id));
        }

        //
        // GET: /SalaryTaxType/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /SalaryTaxType/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(SalaryTaxType salarytaxtype)
        {
            if (ModelState.IsValid) {
                salarytaxtypeRepository.InsertOrUpdate(salarytaxtype);
                salarytaxtypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /SalaryTaxType/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(salarytaxtypeRepository.Find(id));
        }

        //
        // POST: /SalaryTaxType/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(SalaryTaxType salarytaxtype)
        {
            if (ModelState.IsValid) {
                salarytaxtypeRepository.InsertOrUpdate(salarytaxtype);
                salarytaxtypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /SalaryTaxType/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(salarytaxtypeRepository.Find(id));
        }

        //
        // POST: /SalaryTaxType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            salarytaxtypeRepository.Delete(id);
            salarytaxtypeRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

