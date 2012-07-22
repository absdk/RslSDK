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
namespace SoftwareGrid.Areas.OM.Controllers
{   
    public class OrganizationController : UserBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IOrganizationCategoryRepository organizationcategoryRepository;
        public OrganizationController(IOrganizationRepository organizationRepository, IOrganizationCategoryRepository organizationcategoryRepository)
        {
			this.organizationRepository = organizationRepository;
			this.organizationcategoryRepository = organizationcategoryRepository;
        }

        //
        // GET: /Organization/
		[UserAuthorize]
        public ViewResult Index()
        {
									ViewBag.PossibleOrganizationCategories = organizationcategoryRepository.All;
			            return View(organizationRepository.AllIncluding(organization => organization.ParentOrganization, organization => organization.OrganizationCategory));
        }
		
		public ViewResult Search(Organization searchOrganization)
        {
			if(searchOrganization!=null)
			{
							ViewData["Name"]=searchOrganization.Name;
							ViewData["OrganizationCategoryID"]=searchOrganization.OrganizationCategoryID;
							}
						ViewBag.PossibleOrganizationCategories = organizationcategoryRepository.All;
						return View("Index",organizationRepository.AllIncluding(organization => organization.ParentOrganization, organization => organization.OrganizationCategory));
		}

        //
        // GET: /Organization/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(organizationRepository.Find(id));
        }

        //
        // GET: /Organization/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			Organization organization = new Organization();
			ViewBag.PossibleParentOrganizations = organizationRepository.All;
			ViewBag.PossibleOrganizationCategories = organizationcategoryRepository.All;
            return View(organization);
        } 

        //
        // POST: /Organization/Create
        [HttpPost]
        public ActionResult Create(Organization organization)
        {
            if (ModelState.IsValid) {
                organizationRepository.InsertOrUpdate(organization);
                organizationRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleParentOrganizations = organizationRepository.All;
				ViewBag.PossibleOrganizationCategories = organizationcategoryRepository.All;
				return View(organization);
			}
        }
        
        //
        // GET: /Organization/Edit/5
        [UserAuthorize]
        public ActionResult Edit(int organizationId)
        {
            Organization organization = organizationRepository.Find(organizationId);
            ViewBag.PossibleParentOrganizations = organizationRepository.All;
            ViewBag.PossibleOrganizationCategories = organizationcategoryRepository.All;
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.OrganizationLandingMenu = repository.GetOrganizationLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
            ViewBag.OrganizationOverviewHead = organizationRepository.FindOverviewHead(organizationId, organization);
            return View(organization);
        }

        //
        // POST: /Organization/Edit/5
        [HttpPost]
        public ActionResult Edit(Organization organization)
        {
            if (ModelState.IsValid) {
                organizationRepository.InsertOrUpdate(organization);
                organizationRepository.Save();
                return RedirectToAction("Index");
            } else {
						ViewBag.PossibleParentOrganizations = organizationRepository.All;
						ViewBag.PossibleOrganizationCategories = organizationcategoryRepository.All;
				return View(organization);
			}
        }

        //
        // GET: /Organization/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(organizationRepository.Find(id));
        }

        //
        // POST: /Organization/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            organizationRepository.Delete(id);
            organizationRepository.Save();

            return RedirectToAction("Index");
        }

        [UserAuthorize]
        public ViewResult Overview(int organizationId)
        {
            IAppMenuRepository repository = DependencyResolver.Current.GetService(typeof(IAppMenuRepository)) as IAppMenuRepository;
            if (repository != null)
            {
                ViewBag.OrganizationLandingMenu = repository.GetOrganizationLandingMenu(CurrentLoggedInUser.UserRoleID);
            }
            ViewBag.OrganizationId = organizationId;
            if (ViewBag.OrganizationOverviewHead == null)
            {
                ViewBag.OrganizationOverviewHead = organizationRepository.FindOverviewHead(organizationId, null);
            }
            return View(ViewBag.OrganizationOverviewHead);
        }
    }
}

