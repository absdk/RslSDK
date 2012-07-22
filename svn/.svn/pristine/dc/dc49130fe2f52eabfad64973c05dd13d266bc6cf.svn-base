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
namespace SoftwareGrid.Areas.VMS.Controllers
{   
    public class VendorFinancialDataController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly ICurrencyRepository currencyRepository;
		private readonly IVendorFinancialDataRepository vendorfinancialdataRepository;
        public VendorFinancialDataController(IVendorRepository vendorRepository, ICurrencyRepository currencyRepository, IVendorFinancialDataRepository vendorfinancialdataRepository)
        {
			this.vendorRepository = vendorRepository;
			this.currencyRepository = currencyRepository;
			this.vendorfinancialdataRepository = vendorfinancialdataRepository;
        }

        //
        // GET: /VendorFinancialData/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendorfinancialdataRepository.AllIncluding(vendorId,vendorfinancialdata => vendorfinancialdata.Vendor, vendorfinancialdata => vendorfinancialdata.Currency));
        }
		
		public ViewResult Search(VendorFinancialData searchVendorFinancialData,int vendorId)
        {
			if(searchVendorFinancialData!=null)
			{
							}
						return View("Index",vendorfinancialdataRepository.AllIncluding(vendorId,vendorfinancialdata => vendorfinancialdata.Vendor, vendorfinancialdata => vendorfinancialdata.Currency));
		}

        //
        // GET: /VendorFinancialData/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendorfinancialdataRepository.Find(id));
        }

        //
        // GET: /VendorFinancialData/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorFinancialData vendorfinancialdata = new VendorFinancialData();
			vendorfinancialdata.VendorID = vendorId;
			ViewBag.PossibleCurrencies = currencyRepository.All;
            return View(vendorfinancialdata);
        } 

        //
        // POST: /VendorFinancialData/Create
        [HttpPost]
        public ActionResult Create(VendorFinancialData vendorfinancialdata,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorfinancialdataRepository.InsertOrUpdate(vendorfinancialdata);
                vendorfinancialdataRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				ViewBag.PossibleCurrencies = currencyRepository.All;
				return View(vendorfinancialdata);
			}
        }
        
        //
        // GET: /VendorFinancialData/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorFinancialData vendorfinancialdata = vendorfinancialdataRepository.Find(id);
						ViewBag.PossibleCurrencies = currencyRepository.All;
             return View(vendorfinancialdata);
        }

        //
        // POST: /VendorFinancialData/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorFinancialData vendorfinancialdata,int vendorId)
        {
            if (ModelState.IsValid) {
                vendorfinancialdataRepository.InsertOrUpdate(vendorfinancialdata);
                vendorfinancialdataRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
						ViewBag.PossibleCurrencies = currencyRepository.All;
				return View(vendorfinancialdata);
			}
        }

        //
        // GET: /VendorFinancialData/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendorfinancialdataRepository.Find(id));
        }

        //
        // POST: /VendorFinancialData/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendorfinancialdataRepository.Delete(id);
            vendorfinancialdataRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

