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
    public class OrganizationHolidayCalendarController : OrganizationBaseController
    {
		private readonly IOrganizationRepository organizationRepository;
		private readonly IHolidayCalendarRepository holidaycalendarRepository;
		private readonly IOrganizationHolidayCalendarRepository organizationholidaycalendarRepository;
        public OrganizationHolidayCalendarController(IOrganizationRepository organizationRepository, IHolidayCalendarRepository holidaycalendarRepository, IOrganizationHolidayCalendarRepository organizationholidaycalendarRepository)
        {
			this.organizationRepository = organizationRepository;
			this.holidaycalendarRepository = holidaycalendarRepository;
			this.organizationholidaycalendarRepository = organizationholidaycalendarRepository;
        }

        //
        // GET: /OrganizationHolidayCalendar/
		[UserAuthorize]
        public ViewResult Index(int organizationId)
        {
						            return View(organizationholidaycalendarRepository.AllIncluding(organizationId,organizationholidaycalendar => organizationholidaycalendar.Organization));
        }
		
		public ViewResult Search(OrganizationHolidayCalendar searchOrganizationHolidayCalendar,int organizationId)
        {
			if(searchOrganizationHolidayCalendar!=null)
			{
							}
						return View("Index",organizationholidaycalendarRepository.AllIncluding(organizationId,organizationholidaycalendar => organizationholidaycalendar.Organization));
		}

        //
        // GET: /OrganizationHolidayCalendar/Details/5
		[UserAuthorize]
        public ViewResult Details(int id,int organizationId)
        {
            return View(organizationholidaycalendarRepository.Find(id));
        }

        //
        // GET: /OrganizationHolidayCalendar/Create
		[UserAuthorize]
        public ActionResult Create(int organizationId)
        {
			OrganizationHolidayCalendar organizationholidaycalendar = new OrganizationHolidayCalendar();
			organizationholidaycalendar.OrganizationID = organizationId;
			ViewBag.PossibleHolidayCalendars = holidaycalendarRepository.All;
            return View(organizationholidaycalendar);
        } 

        //
        // POST: /OrganizationHolidayCalendar/Create
        [HttpPost]
        public ActionResult Create(OrganizationHolidayCalendar organizationholidaycalendar,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationholidaycalendarRepository.InsertOrUpdate(organizationholidaycalendar);
                organizationholidaycalendarRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
				ViewBag.PossibleHolidayCalendars = holidaycalendarRepository.All;
				return View(organizationholidaycalendar);
			}
        }
        
        //
        // GET: /OrganizationHolidayCalendar/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id,int organizationId)
        {
			OrganizationHolidayCalendar organizationholidaycalendar = organizationholidaycalendarRepository.Find(id);
						ViewBag.PossibleHolidayCalendars = holidaycalendarRepository.All;
             return View(organizationholidaycalendar);
        }

        //
        // POST: /OrganizationHolidayCalendar/Edit/5
        [HttpPost]
        public ActionResult Edit(OrganizationHolidayCalendar organizationholidaycalendar,int organizationId)
        {
            if (ModelState.IsValid) {
                organizationholidaycalendarRepository.InsertOrUpdate(organizationholidaycalendar);
                organizationholidaycalendarRepository.Save();
                return RedirectToAction("Index",new { organizationId=organizationId });
            } else {
						ViewBag.PossibleHolidayCalendars = holidaycalendarRepository.All;
				return View(organizationholidaycalendar);
			}
        }

        //
        // GET: /OrganizationHolidayCalendar/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id,int organizationId)
        {
            return View(organizationholidaycalendarRepository.Find(id));
        }

        //
        // POST: /OrganizationHolidayCalendar/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id,int organizationId)
        {
            organizationholidaycalendarRepository.Delete(id);
            organizationholidaycalendarRepository.Save();

            return RedirectToAction("Index",new { organizationId=organizationId });
        }
    }
}

