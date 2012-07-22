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
namespace SoftwareGrid.Areas.CRM.Controllers
{   
    public class SalesCampaignStatusCategoriesController : Controller
    {
		private readonly ISalesCampaignStatusCategoryRepository salescampaignstatuscategoryRepository;
        public SalesCampaignStatusCategoriesController(ISalesCampaignStatusCategoryRepository salescampaignstatuscategoryRepository)
        {
			this.salescampaignstatuscategoryRepository = salescampaignstatuscategoryRepository;
        }

        //
        // GET: /SalesCampaignStatusCategories/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(salescampaignstatuscategoryRepository.All);
        }
		
		public ViewResult Search(SalesCampaignStatusCategory searchSalesCampaignStatusCategory)
        {
			if(searchSalesCampaignStatusCategory!=null)
			{
							}
						return View("Index",salescampaignstatuscategoryRepository.All);
		}

        //
        // GET: /SalesCampaignStatusCategories/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(salescampaignstatuscategoryRepository.Find(id));
        }

        //
        // GET: /SalesCampaignStatusCategories/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			SalesCampaignStatusCategory salescampaignstatuscategory = new SalesCampaignStatusCategory();
            return View(salescampaignstatuscategory);
        } 

        //
        // POST: /SalesCampaignStatusCategories/Create
        [HttpPost]
        public ActionResult Create(SalesCampaignStatusCategory salescampaignstatuscategory)
        {
            if (ModelState.IsValid) {
                salescampaignstatuscategoryRepository.InsertOrUpdate(salescampaignstatuscategory);
                salescampaignstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(salescampaignstatuscategory);
			}
        }
        
        //
        // GET: /SalesCampaignStatusCategories/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
             return View(salescampaignstatuscategoryRepository.Find(id));
        }

        //
        // POST: /SalesCampaignStatusCategories/Edit/5
        [HttpPost]
        public ActionResult Edit(SalesCampaignStatusCategory salescampaignstatuscategory)
        {
            if (ModelState.IsValid) {
                salescampaignstatuscategoryRepository.InsertOrUpdate(salescampaignstatuscategory);
                salescampaignstatuscategoryRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(salescampaignstatuscategory);
			}
        }

        //
        // GET: /SalesCampaignStatusCategories/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(salescampaignstatuscategoryRepository.Find(id));
        }

        //
        // POST: /SalesCampaignStatusCategories/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            salescampaignstatuscategoryRepository.Delete(id);
            salescampaignstatuscategoryRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

