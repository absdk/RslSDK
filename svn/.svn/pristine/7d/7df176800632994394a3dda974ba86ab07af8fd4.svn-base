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
    public class VendorAccountManagerController : VMSBaseController
    {
		private readonly IVendorRepository vendorRepository;
		private readonly IUserRepository userRepository;
		private readonly IVendorAccountManagerRepository vendoraccountmanagerRepository;
        public VendorAccountManagerController(IVendorRepository vendorRepository, IUserRepository userRepository, IVendorAccountManagerRepository vendoraccountmanagerRepository)
        {
			this.vendorRepository = vendorRepository;
			this.userRepository = userRepository;
			this.vendoraccountmanagerRepository = vendoraccountmanagerRepository;
        }

        //
        // GET: /VendorAccountManager/
		[UserAuthorize]
        public ViewResult Index(int vendorId)
        {
						            return View(vendoraccountmanagerRepository.AllIncluding(vendorId,vendoraccountmanager => vendoraccountmanager.Vendor, vendoraccountmanager => vendoraccountmanager.VendorManagerUser));
        }
		
		public ViewResult Search(VendorAccountManager searchVendorAccountManager,int vendorId)
        {
			if(searchVendorAccountManager!=null)
			{
							}
						return View("Index",vendoraccountmanagerRepository.AllIncluding(vendorId,vendoraccountmanager => vendoraccountmanager.Vendor, vendoraccountmanager => vendoraccountmanager.VendorManagerUser));
		}

        //
        // GET: /VendorAccountManager/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int vendorId)
        {
            return View(vendoraccountmanagerRepository.Find(id));
        }

        //
        // GET: /VendorAccountManager/Create
		[UserAuthorize]
        public ActionResult Create(int vendorId)
        {
			VendorAccountManager vendoraccountmanager = new VendorAccountManager();
			vendoraccountmanager.VendorID = vendorId;
            return View(vendoraccountmanager);
        } 

        //
        // POST: /VendorAccountManager/Create
        [HttpPost]
        public ActionResult Create(VendorAccountManager vendoraccountmanager,int vendorId)
        {
            if (ModelState.IsValid) {
                vendoraccountmanagerRepository.InsertOrUpdate(vendoraccountmanager);
                vendoraccountmanagerRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				return View(vendoraccountmanager);
			}
        }
        
        //
        // GET: /VendorAccountManager/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int vendorId)
        {
			VendorAccountManager vendoraccountmanager = vendoraccountmanagerRepository.Find(id);
             return View(vendoraccountmanager);
        }

        //
        // POST: /VendorAccountManager/Edit/5
        [HttpPost]
        public ActionResult Edit(VendorAccountManager vendoraccountmanager,int vendorId)
        {
            if (ModelState.IsValid) {
                vendoraccountmanagerRepository.InsertOrUpdate(vendoraccountmanager);
                vendoraccountmanagerRepository.Save();
                return RedirectToAction("Index",new { vendorId=vendorId });
            } else {
				return View(vendoraccountmanager);
			}
        }

        //
        // GET: /VendorAccountManager/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int vendorId)
        {
            return View(vendoraccountmanagerRepository.Find(id));
        }

        //
        // POST: /VendorAccountManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int vendorId)
        {
            vendoraccountmanagerRepository.Delete(id);
            vendoraccountmanagerRepository.Save();

            return RedirectToAction("Index",new { vendorId=vendorId });
        }
    }
}

