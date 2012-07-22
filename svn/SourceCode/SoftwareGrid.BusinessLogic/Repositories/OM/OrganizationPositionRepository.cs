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
    public class OrganizationPositionRepository : IOrganizationPositionRepository
    {
		private readonly RepositoryContext context;

        public OrganizationPositionRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationPosition> All
        {
            get { return context.OrganizationPosition; }
        }

		public IQueryable<OrganizationPosition> AllIncluding(params Expression<Func<OrganizationPosition, object>>[] includeProperties)
        {
            IQueryable<OrganizationPosition> query = context.OrganizationPosition;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<OrganizationPosition> AllIncluding(int organizationId,params Expression<Func<OrganizationPosition, object>>[] includeProperties)
        {
            IQueryable<OrganizationPosition> query = context.OrganizationPosition;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.OrganizationID==organizationId);
        }
		
        public OrganizationPosition Find(int id)
        {
            return context.OrganizationPosition.Find(id);
        }

        public void InsertOrUpdate(OrganizationPosition organizationposition)
        {
            if (organizationposition.OrganizationPositionID == default(int)) {
                // New entity
                context.OrganizationPosition.Add(organizationposition);
            } else {
                // Existing entity
                context.Entry(organizationposition).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationposition = context.OrganizationPosition.Find(id);
            context.OrganizationPosition.Remove(organizationposition);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationPositionRepository
    {
        IQueryable<OrganizationPosition> All { get; }
        IQueryable<OrganizationPosition> AllIncluding(params Expression<Func<OrganizationPosition, object>>[] includeProperties);
		        IQueryable<OrganizationPosition> AllIncluding(int organizationId,params Expression<Func<OrganizationPosition, object>>[] includeProperties);
                OrganizationPosition Find(int id);
        void InsertOrUpdate(OrganizationPosition organizationposition);
        void Delete(int id);
        void Save();
    }
}