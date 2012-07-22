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
    public class HolidayCalendarController : UserBaseController
    {
		private readonly IHolidayCalendarRepository holidaycalendarRepository;
        public HolidayCalendarController(IHolidayCalendarRepository holidaycalendarRepository)
        {
			this.holidaycalendarRepository = holidaycalendarRepository;
        }

        //
        // GET: /HolidayCalendar/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(holidaycalendarRepository.All);
        }
		
		public ViewResult Search(HolidayCalendar searchHolidayCalendar)
        {
			if(searchHolidayCalendar!=null)
			{
							}
						return View("Index",holidaycalendarRepository.All);
		}

        //
        // GET: /HolidayCalendar/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(holidaycalendarRepository.Find(id));
        }

        //
        // GET: /HolidayCalendar/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			HolidayCalendar holidaycalendar = new HolidayCalendar();
            return View(holidaycalendar);
        } 

        //
        // POST: /HolidayCalendar/Create
        [HttpPost]
        public ActionResult Create(HolidayCalendar holidaycalendar)
        {
            if (ModelState.IsValid) {
                holidaycalendarRepository.InsertOrUpdate(holidaycalendar);
                holidaycalendarRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(holidaycalendar);
			}
        }
        
        //
        // GET: /HolidayCalendar/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
HolidayCalendar holidaycalendar = holidaycalendarRepository.Find(id);
             return View(holidaycalendar);
        }

        //
        // POST: /HolidayCalendar/Edit/5
        [HttpPost]
        public ActionResult Edit(HolidayCalendar holidaycalendar)
        {
            if (ModelState.IsValid) {
                holidaycalendarRepository.InsertOrUpdate(holidaycalendar);
                holidaycalendarRepository.Save();
                return RedirectToAction("Index");
            } else {
				return View(holidaycalendar);
			}
        }

        //
        // GET: /HolidayCalendar/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(holidaycalendarRepository.Find(id));
        }

        //
        // POST: /HolidayCalendar/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            holidaycalendarRepository.Delete(id);
            holidaycalendarRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

