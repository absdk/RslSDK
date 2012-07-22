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
    public class SalaryRateTypeController : Controller
    {
		private readonly ISalaryRateTypeRepository salaryratetypeRepository;
        public SalaryRateTypeController(ISalaryRateTypeRepository salaryratetypeRepository)
        {
			this.salaryratetypeRepository = salaryratetypeRepository;
        }

        //
        // GET: /SalaryRateType/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(salaryratetypeRepository.All);
        }
		
		public ViewResult Search(SalaryRateType searchSalaryRateType)
        {
			if(searchSalaryRateType!=null)
			{
							}
						return View("Index",salaryratetypeRepository.All);
		}

        //
        // GET: /SalaryRateType/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(salaryratetypeRepository.Find(id));
        }

        //
        // GET: /SalaryRateType/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /SalaryRateType/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(SalaryRateType salaryratetype)
        {
            if (ModelState.IsValid) {
                salaryratetypeRepository.InsertOrUpdate(salaryratetype);
                salaryratetypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /SalaryRateType/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(salaryratetypeRepository.Find(id));
        }

        //
        // POST: /SalaryRateType/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(SalaryRateType salaryratetype)
        {
            if (ModelState.IsValid) {
                salaryratetypeRepository.InsertOrUpdate(salaryratetype);
                salaryratetypeRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /SalaryRateType/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(salaryratetypeRepository.Find(id));
        }

        //
        // POST: /SalaryRateType/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            salaryratetypeRepository.Delete(id);
            salaryratetypeRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

