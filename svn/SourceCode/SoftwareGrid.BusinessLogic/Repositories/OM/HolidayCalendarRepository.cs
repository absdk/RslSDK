using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.BusinessLogic.Repositories.Context;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class HolidayCalendarRepository : IHolidayCalendarRepository
    {
		private readonly RepositoryContext context;

        public HolidayCalendarRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<HolidayCalendar> All
        {
            get { return context.HolidayCalendar; }
        }

		public IQueryable<HolidayCalendar> AllIncluding(params Expression<Func<HolidayCalendar, object>>[] includeProperties)
        {
            IQueryable<HolidayCalendar> query = context.HolidayCalendar;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		
        public HolidayCalendar Find(int id)
        {
            return context.HolidayCalendar.Find(id);
        }

        public void InsertOrUpdate(HolidayCalendar holidaycalendar)
        {
            if (holidaycalendar.HolidayCalendarID == default(int)) {
                // New entity
                context.HolidayCalendar.Add(holidaycalendar);
            } else {
                // Existing entity
                context.Entry(holidaycalendar).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var holidaycalendar = context.HolidayCalendar.Find(id);
            context.HolidayCalendar.Remove(holidaycalendar);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IHolidayCalendarRepository
    {
        IQueryable<HolidayCalendar> All { get; }
        IQueryable<HolidayCalendar> AllIncluding(params Expression<Func<HolidayCalendar, object>>[] includeProperties);
		        HolidayCalendar Find(int id);
        void InsertOrUpdate(HolidayCalendar holidaycalendar);
        void Delete(int id);
        void Save();
    }
}