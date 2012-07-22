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
    public class CompanyEmailsController : Controller
    {
		private readonly ICompanyRepository companyRepository;
		private readonly IContactRepository contactRepository;
		private readonly IUserRepository userRepository;
		private readonly ICompanyEmailRepository companyemailRepository;
        public CompanyEmailsController(ICompanyRepository companyRepository, IContactRepository contactRepository, IUserRepository userRepository, ICompanyEmailRepository companyemailRepository)
        {
			this.companyRepository = companyRepository;
			this.contactRepository = contactRepository;
			this.userRepository = userRepository;
			this.companyemailRepository = companyemailRepository;
        }

        //
        // GET: /CompanyEmails/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(companyemailRepository.AllIncluding(companyemail => companyemail.EmailSendToCompany, companyemail => companyemail.EmailSendToContact, companyemail => companyemail.EmailSendByUser));
        }
		
		public ViewResult Search(CompanyEmail searchCompanyEmail)
        {
			if(searchCompanyEmail!=null)
			{
							}
						return View("Index",companyemailRepository.AllIncluding(companyemail => companyemail.EmailSendToCompany, companyemail => companyemail.EmailSendToContact, companyemail => companyemail.EmailSendByUser));
		}

        //
        // GET: /CompanyEmails/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(companyemailRepository.Find(id));
        }

        //
        // GET: /CompanyEmails/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			CompanyEmail companyemail = new CompanyEmail();
			ViewBag.PossibleEmailSendToCompanies = companyRepository.All;
			ViewBag.PossibleEmailSendToContacts = contactRepository.All;
			ViewBag.PossibleEmailSendByUsers = userRepository.All;
            return View(companyemail);
        } 

        //
        // POST: /CompanyEmails/Create
        [HttpPost]
        public ActionResult Create(CompanyEmail companyemail)
        {
            if (ModelState.IsValid) {
                companyemailRepository.InsertOrUpdate(companyemail);
                companyemailRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleEmailSendToCompanies = companyRepository.All;
				ViewBag.PossibleEmailSendToContacts = contactRepository.All;
				ViewBag.PossibleEmailSendByUsers = userRepository.All;
				return View(companyemail);
			}
        }
        
        //
        // GET: /CompanyEmails/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleEmailSendToCompanies = companyRepository.All;
			ViewBag.PossibleEmailSendToContacts = contactRepository.All;
			ViewBag.PossibleEmailSendByUsers = userRepository.All;
             return View(companyemailRepository.Find(id));
        }

        //
        // POST: /CompanyEmails/Edit/5
        [HttpPost]
        public ActionResult Edit(CompanyEmail companyemail)
        {
            if (ModelState.IsValid) {
                companyemailRepository.InsertOrUpdate(companyemail);
                companyemailRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleEmailSendToCompanies = companyRepository.All;
				ViewBag.PossibleEmailSendToContacts = contactRepository.All;
				ViewBag.PossibleEmailSendByUsers = userRepository.All;
				return View(companyemail);
			}
        }

        //
        // GET: /CompanyEmails/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(companyemailRepository.Find(id));
        }

        //
        // POST: /CompanyEmails/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            companyemailRepository.Delete(id);
            companyemailRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

