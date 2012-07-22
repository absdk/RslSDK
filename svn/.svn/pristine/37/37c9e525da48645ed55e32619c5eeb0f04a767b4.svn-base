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
    public class OrganizationWorkforcePlanRepository : IOrganizationWorkforcePlanRepository
    {
		private readonly RepositoryContext context;

        public OrganizationWorkforcePlanRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationWorkforcePlan> All
        {
            get { return context.OrganizationWorkforcePlan; }
        }

		public IQueryable<OrganizationWorkforcePlan> AllIncluding(params Expression<Func<OrganizationWorkforcePlan, object>>[] includeProperties)
        {
            IQueryable<OrganizationWorkforcePlan> query = context.OrganizationWorkforcePlan;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<OrganizationWorkforcePlan> AllIncluding(int organizationId,params Expression<Func<OrganizationWorkforcePlan, object>>[] includeProperties)
        {
            IQueryable<OrganizationWorkforcePlan> query = context.OrganizationWorkforcePlan;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.OrganizationID==organizationId);
        }
		
        public OrganizationWorkforcePlan Find(int id)
        {
            return context.OrganizationWorkforcePlan.Find(id);
        }

        public void InsertOrUpdate(OrganizationWorkforcePlan organizationworkforceplan)
        {
            if (organizationworkforceplan.OrganizationWorkforcePlanID == default(int)) {
                // New entity
                context.OrganizationWorkforcePlan.Add(organizationworkforceplan);
            } else {
                // Existing entity
                context.Entry(organizationworkforceplan).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationworkforceplan = context.OrganizationWorkforcePlan.Find(id);
            context.OrganizationWorkforcePlan.Remove(organizationworkforceplan);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationWorkforcePlanRepository
    {
        IQueryable<OrganizationWorkforcePlan> All { get; }
        IQueryable<OrganizationWorkforcePlan> AllIncluding(params Expression<Func<OrganizationWorkforcePlan, object>>[] includeProperties);
		        IQueryable<OrganizationWorkforcePlan> AllIncluding(int organizationId,params Expression<Func<OrganizationWorkforcePlan, object>>[] includeProperties);
                OrganizationWorkforcePlan Find(int id);
        void InsertOrUpdate(OrganizationWorkforcePlan organizationworkforceplan);
        void Delete(int id);
        void Save();
    }
}