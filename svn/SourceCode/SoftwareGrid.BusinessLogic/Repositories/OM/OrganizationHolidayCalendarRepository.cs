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
    public class OrganizationHolidayCalendarRepository : IOrganizationHolidayCalendarRepository
    {
		private readonly RepositoryContext context;

        public OrganizationHolidayCalendarRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationHolidayCalendar> All
        {
            get { return context.OrganizationHolidayCalendar; }
        }

		public IQueryable<OrganizationHolidayCalendar> AllIncluding(params Expression<Func<OrganizationHolidayCalendar, object>>[] includeProperties)
        {
            IQueryable<OrganizationHolidayCalendar> query = context.OrganizationHolidayCalendar;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<OrganizationHolidayCalendar> AllIncluding(int organizationId,params Expression<Func<OrganizationHolidayCalendar, object>>[] includeProperties)
        {
            IQueryable<OrganizationHolidayCalendar> query = context.OrganizationHolidayCalendar;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.OrganizationID==organizationId);
        }
		
        public OrganizationHolidayCalendar Find(int id)
        {
            return context.OrganizationHolidayCalendar.Find(id);
        }

        public void InsertOrUpdate(OrganizationHolidayCalendar organizationholidaycalendar)
        {
            if (organizationholidaycalendar.OrganizationHolidayCalendarID == default(int)) {
                // New entity
                context.OrganizationHolidayCalendar.Add(organizationholidaycalendar);
            } else {
                // Existing entity
                context.Entry(organizationholidaycalendar).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationholidaycalendar = context.OrganizationHolidayCalendar.Find(id);
            context.OrganizationHolidayCalendar.Remove(organizationholidaycalendar);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationHolidayCalendarRepository
    {
        IQueryable<OrganizationHolidayCalendar> All { get; }
        IQueryable<OrganizationHolidayCalendar> AllIncluding(params Expression<Func<OrganizationHolidayCalendar, object>>[] includeProperties);
		        IQueryable<OrganizationHolidayCalendar> AllIncluding(int organizationId,params Expression<Func<OrganizationHolidayCalendar, object>>[] includeProperties);
                OrganizationHolidayCalendar Find(int id);
        void InsertOrUpdate(OrganizationHolidayCalendar organizationholidaycalendar);
        void Delete(int id);
        void Save();
    }
}