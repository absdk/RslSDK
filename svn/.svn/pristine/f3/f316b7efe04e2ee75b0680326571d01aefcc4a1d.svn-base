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
    public class CompanyEmailTemplatesController : Controller
    {
		private readonly IUserRepository userRepository;
		private readonly ICompanyEmailTemplateRepository companyemailtemplateRepository;
        public CompanyEmailTemplatesController(IUserRepository userRepository, ICompanyEmailTemplateRepository companyemailtemplateRepository)
        {
			this.userRepository = userRepository;
			this.companyemailtemplateRepository = companyemailtemplateRepository;
        }

        //
        // GET: /CompanyEmailTemplates/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(companyemailtemplateRepository.AllIncluding(companyemailtemplate => companyemailtemplate.TemplateCreatedByUser));
        }
		
		public ViewResult Search(CompanyEmailTemplate searchCompanyEmailTemplate)
        {
			if(searchCompanyEmailTemplate!=null)
			{
							}
						return View("Index",companyemailtemplateRepository.AllIncluding(companyemailtemplate => companyemailtemplate.TemplateCreatedByUser));
		}

        //
        // GET: /CompanyEmailTemplates/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(companyemailtemplateRepository.Find(id));
        }

        //
        // GET: /CompanyEmailTemplates/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			CompanyEmailTemplate companyemailtemplate = new CompanyEmailTemplate();
			ViewBag.PossibleTemplateCreatedByUsers = userRepository.All;
            return View(companyemailtemplate);
        } 

        //
        // POST: /CompanyEmailTemplates/Create
        [HttpPost]
        public ActionResult Create(CompanyEmailTemplate companyemailtemplate)
        {
            if (ModelState.IsValid) {
                companyemailtemplateRepository.InsertOrUpdate(companyemailtemplate);
                companyemailtemplateRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleTemplateCreatedByUsers = userRepository.All;
				return View(companyemailtemplate);
			}
        }
        
        //
        // GET: /CompanyEmailTemplates/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleTemplateCreatedByUsers = userRepository.All;
             return View(companyemailtemplateRepository.Find(id));
        }

        //
        // POST: /CompanyEmailTemplates/Edit/5
        [HttpPost]
        public ActionResult Edit(CompanyEmailTemplate companyemailtemplate)
        {
            if (ModelState.IsValid) {
                companyemailtemplateRepository.InsertOrUpdate(companyemailtemplate);
                companyemailtemplateRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleTemplateCreatedByUsers = userRepository.All;
				return View(companyemailtemplate);
			}
        }

        //
        // GET: /CompanyEmailTemplates/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(companyemailtemplateRepository.Find(id));
        }

        //
        // POST: /CompanyEmailTemplates/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            companyemailtemplateRepository.Delete(id);
            companyemailtemplateRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

