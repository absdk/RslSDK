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
    public class SalesCampaignsController : Controller
    {
		private readonly ISalesCampaignRepository salescampaignRepository;
		private readonly ICurrencyRepository currencyRepository;
		private readonly IUserRepository userRepository;
		private readonly ISalesCampaignStatusCategoryRepository salescampaignstatuscategoryRepository;
        public SalesCampaignsController(ISalesCampaignRepository salescampaignRepository, ICurrencyRepository currencyRepository, IUserRepository userRepository, ISalesCampaignStatusCategoryRepository salescampaignstatuscategoryRepository)
        {
			this.salescampaignRepository = salescampaignRepository;
			this.currencyRepository = currencyRepository;
			this.userRepository = userRepository;
			this.salescampaignstatuscategoryRepository = salescampaignstatuscategoryRepository;
        }

        //
        // GET: /SalesCampaigns/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(salescampaignRepository.AllIncluding(salescampaign => salescampaign.ParentSalesCampaign, salescampaign => salescampaign.Currency, salescampaign => salescampaign.CreatedByUser, salescampaign => salescampaign.SalesCampaignStatusCategory));
        }
		
		public ViewResult Search(SalesCampaign searchSalesCampaign)
        {
			if(searchSalesCampaign!=null)
			{
							}
						return View("Index",salescampaignRepository.AllIncluding(salescampaign => salescampaign.ParentSalesCampaign, salescampaign => salescampaign.Currency, salescampaign => salescampaign.CreatedByUser, salescampaign => salescampaign.SalesCampaignStatusCategory));
		}

        //
        // GET: /SalesCampaigns/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(salescampaignRepository.Find(id));
        }

        //
        // GET: /SalesCampaigns/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			SalesCampaign salescampaign = new SalesCampaign();
			ViewBag.PossibleParentSalesCampaigns = salescampaignRepository.All;
			ViewBag.PossibleCurrencies = currencyRepository.All;
			ViewBag.PossibleCreatedByUsers = userRepository.All;
			ViewBag.PossibleSalesCampaignStatusCategories = salescampaignstatuscategoryRepository.All;
            return View(salescampaign);
        } 

        //
        // POST: /SalesCampaigns/Create
        [HttpPost]
        public ActionResult Create(SalesCampaign salescampaign)
        {
            if (ModelState.IsValid) {
                salescampaignRepository.InsertOrUpdate(salescampaign);
                salescampaignRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleParentSalesCampaigns = salescampaignRepository.All;
				ViewBag.PossibleCurrencies = currencyRepository.All;
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				ViewBag.PossibleSalesCampaignStatusCategories = salescampaignstatuscategoryRepository.All;
				return View(salescampaign);
			}
        }
        
        //
        // GET: /SalesCampaigns/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleParentSalesCampaigns = salescampaignRepository.All;
			ViewBag.PossibleCurrencies = currencyRepository.All;
			ViewBag.PossibleCreatedByUsers = userRepository.All;
			ViewBag.PossibleSalesCampaignStatusCategories = salescampaignstatuscategoryRepository.All;
             return View(salescampaignRepository.Find(id));
        }

        //
        // POST: /SalesCampaigns/Edit/5
        [HttpPost]
        public ActionResult Edit(SalesCampaign salescampaign)
        {
            if (ModelState.IsValid) {
                salescampaignRepository.InsertOrUpdate(salescampaign);
                salescampaignRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleParentSalesCampaigns = salescampaignRepository.All;
				ViewBag.PossibleCurrencies = currencyRepository.All;
				ViewBag.PossibleCreatedByUsers = userRepository.All;
				ViewBag.PossibleSalesCampaignStatusCategories = salescampaignstatuscategoryRepository.All;
				return View(salescampaign);
			}
        }

        //
        // GET: /SalesCampaigns/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(salescampaignRepository.Find(id));
        }

        //
        // POST: /SalesCampaigns/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            salescampaignRepository.Delete(id);
            salescampaignRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

