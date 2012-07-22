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
    public class ContactsController : CRMBaseController
    {
        private readonly ICompanyRepository companyRepository;
        private readonly ICountryRepository countryRepository;
        private readonly IStateRepository stateRepository;
        private readonly IContactProfessionTypeRepository contactprofessiontypeRepository;
        private readonly IRatingScaleRepository ratingscaleRepository;
        private readonly IUserRepository userRepository;
        private readonly IContactRepository contactRepository;
        public ContactsController(ICompanyRepository companyRepository, ICountryRepository countryRepository, IStateRepository stateRepository, IContactProfessionTypeRepository contactprofessiontypeRepository, IRatingScaleRepository ratingscaleRepository, IUserRepository userRepository, IContactRepository contactRepository)
        {
            this.companyRepository = companyRepository;
            this.countryRepository = countryRepository;
            this.stateRepository = stateRepository;
            this.contactprofessiontypeRepository = contactprofessiontypeRepository;
            this.ratingscaleRepository = ratingscaleRepository;
            this.userRepository = userRepository;
            this.contactRepository = contactRepository;
        }

        //
        // GET: /Contacts/
        [UserAuthorize]
        public ViewResult Index(int companyId)
        {
            return View(contactRepository.AllIncluding(companyId, contact => contact.Company, contact => contact.Country, contact => contact.State, contact => contact.ContactProfessionType, contact => contact.ContactRatingScale, contact => contact.CreatedByUser, contact => contact.VerifiedByUser));
        }

        public ViewResult Search(Contact searchContact,int companyId)
        {
            if (searchContact != null)
            {
            }
            return View("Index", contactRepository.AllIncluding(companyId,contact => contact.Company, contact => contact.Country, contact => contact.State, contact => contact.ContactProfessionType, contact => contact.ContactRatingScale, contact => contact.CreatedByUser, contact => contact.VerifiedByUser));
        }

        //
        // GET: /Contacts/Details/5
        [UserAuthorize]
        public ViewResult Details(int id,int companyId)
        {
            return View(contactRepository.Find(id));
        }

        //
        // GET: /Contacts/Create
        [UserAuthorize]
        public ActionResult Create(int companyId)
        {
            Contact contact = new Contact();
            contact.CompanyID = companyId;
            contact.CreatedByUserID = CurrentLoggedInUser.UserID;
            contact.CreatedDate = DateTime.Now;
            ViewBag.PossibleCountries = countryRepository.All;
            ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
            ViewBag.PossibleContactRatingScales = ratingscaleRepository.All;
            return View(contact);
        }

        //
        // POST: /Contacts/Create
        [HttpPost]
        public ActionResult Create(Contact contact,int companyId)
        {
            if (ModelState.IsValid)
            {
                contact.CompanyID = companyId;
                contactRepository.InsertOrUpdate(contact);
                contactRepository.Save();
                return RedirectToAction("Index", new { companyId=companyId });
            }
            else
            {
                ViewBag.PossibleCountries = countryRepository.All;
                ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
                ViewBag.PossibleContactRatingScales = ratingscaleRepository.All;
                return View(contact);
            }
        }

        //
        // GET: /Contacts/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int id,int companyId)
        {
            Contact contact = contactRepository.Find(id);
            ViewBag.PossibleCountries = countryRepository.All;
            if (contact.CountryID.HasValue)
            {
                ViewBag.PossibleStates = stateRepository.FindAllByCountryID(contact.CountryID.Value);
            }
            ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
            ViewBag.PossibleContactRatingScales = ratingscaleRepository.All;
            return View(contact);
        }

        //
        // POST: /Contacts/Edit/5
        [HttpPost]
        public ActionResult Edit(Contact contact, int companyId)
        {
            if (ModelState.IsValid)
            {
                contactRepository.InsertOrUpdate(contact);
                contactRepository.Save();
                return RedirectToAction("Index", new { companyId = companyId });
            }
            else
            {
                ViewBag.PossibleCountries = countryRepository.All;
                if (contact.CountryID.HasValue)
                {
                    ViewBag.PossibleStates = stateRepository.FindAllByCountryID(contact.CountryID.Value);
                }
                ViewBag.PossibleContactProfessionTypes = contactprofessiontypeRepository.All;
                ViewBag.PossibleContactRatingScales = ratingscaleRepository.All;
                return View(contact);
            }
        }

        //
        // GET: /Contacts/Delete/5
        [UserAuthorize]
        public ActionResult Delete(int id, int companyId)
        {
            return View(contactRepository.Find(id));
        }

        //
        // POST: /Contacts/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id, int companyId)
        {
            contactRepository.Delete(id);
            contactRepository.Save();

            return RedirectToAction("Index", new { companyId = companyId });
        }
    }
}

