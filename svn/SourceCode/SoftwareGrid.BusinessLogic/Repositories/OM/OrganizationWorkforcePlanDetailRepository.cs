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
    public class OrganizationWorkforcePlanDetailRepository : IOrganizationWorkforcePlanDetailRepository
    {
		private readonly RepositoryContext context;

        public OrganizationWorkforcePlanDetailRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationWorkforcePlanDetail> All
        {
            get { return context.OrganizationWorkforcePlanDetail; }
        }

        public IQueryable<OrganizationWorkforcePlanDetail> AllIncluding(params Expression<Func<OrganizationWorkforcePlanDetail, object>>[] includeProperties)
        {
            IQueryable<OrganizationWorkforcePlanDetail> query = context.OrganizationWorkforcePlanDetail;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public OrganizationWorkforcePlanDetail Find(int id)
        {
            return context.OrganizationWorkforcePlanDetail.Find(id);
        }

        public void InsertOrUpdate(OrganizationWorkforcePlanDetail organizationworkforceplandetail)
        {
            if (organizationworkforceplandetail.OrganizationWorkforcePlanDetailID == default(int)) {
                // New entity
                context.OrganizationWorkforcePlanDetail.Add(organizationworkforceplandetail);
            } else {
                // Existing entity
                context.Entry(organizationworkforceplandetail).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationworkforceplandetail = context.OrganizationWorkforcePlanDetail.Find(id);
            context.OrganizationWorkforcePlanDetail.Remove(organizationworkforceplandetail);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationWorkforcePlanDetailRepository
    {
        IQueryable<OrganizationWorkforcePlanDetail> All { get; }
        IQueryable<OrganizationWorkforcePlanDetail> AllIncluding(params Expression<Func<OrganizationWorkforcePlanDetail, object>>[] includeProperties);
        OrganizationWorkforcePlanDetail Find(int id);
        void InsertOrUpdate(OrganizationWorkforcePlanDetail organizationworkforceplandetail);
        void Delete(int id);
        void Save();
    }
}