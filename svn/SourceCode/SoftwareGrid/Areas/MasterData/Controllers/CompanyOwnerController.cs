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
    public class CompanyOwnerController : Controller
    {
		private readonly ICompanyOwnerRepository companyownerRepository;
        public CompanyOwnerController(ICompanyOwnerRepository companyownerRepository)
        {
			this.companyownerRepository = companyownerRepository;
        }

        //
        // GET: /CompanyOwner/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(companyownerRepository.All);
        }
		
		public ViewResult Search(CompanyOwner searchCompanyOwner)
        {
			if(searchCompanyOwner!=null)
			{
							}
						return View("Index",companyownerRepository.All);
		}

        //
        // GET: /CompanyOwner/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(companyownerRepository.Find(id));
        }

        //
        // GET: /CompanyOwner/Create
		[UserAuthorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /CompanyOwner/Create
		[UserAuthorize]
        [HttpPost]
        public ActionResult Create(CompanyOwner companyowner)
        {
            if (ModelState.IsValid) {
                companyownerRepository.InsertOrUpdate(companyowner);
                companyownerRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }
        
        //
        // GET: /CompanyOwner/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(companyownerRepository.Find(id));
        }

        //
        // POST: /CompanyOwner/Edit/5
		[UserAuthorize]
        [HttpPost]
        public ActionResult Edit(CompanyOwner companyowner)
        {
            if (ModelState.IsValid) {
                companyownerRepository.InsertOrUpdate(companyowner);
                companyownerRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View();
			}
        }

        //
        // GET: /CompanyOwner/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(companyownerRepository.Find(id));
        }

        //
        // POST: /CompanyOwner/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            companyownerRepository.Delete(id);
            companyownerRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

