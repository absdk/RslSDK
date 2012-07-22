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
    public class OrganizationProjectRepository : IOrganizationProjectRepository
    {
		private readonly RepositoryContext context;

        public OrganizationProjectRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationProject> All
        {
            get { return context.OrganizationProject; }
        }

		public IQueryable<OrganizationProject> AllIncluding(params Expression<Func<OrganizationProject, object>>[] includeProperties)
        {
            IQueryable<OrganizationProject> query = context.OrganizationProject;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<OrganizationProject> AllIncluding(int organizationId,params Expression<Func<OrganizationProject, object>>[] includeProperties)
        {
            IQueryable<OrganizationProject> query = context.OrganizationProject;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.OrganizationID==organizationId);
        }
		
        public OrganizationProject Find(int id)
        {
            return context.OrganizationProject.Find(id);
        }

        public void InsertOrUpdate(OrganizationProject organizationproject)
        {
            if (organizationproject.OrganizationProjectID == default(int)) {
                // New entity
                context.OrganizationProject.Add(organizationproject);
            } else {
                // Existing entity
                context.Entry(organizationproject).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationproject = context.OrganizationProject.Find(id);
            context.OrganizationProject.Remove(organizationproject);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationProjectRepository
    {
        IQueryable<OrganizationProject> All { get; }
        IQueryable<OrganizationProject> AllIncluding(params Expression<Func<OrganizationProject, object>>[] includeProperties);
		        IQueryable<OrganizationProject> AllIncluding(int organizationId,params Expression<Func<OrganizationProject, object>>[] includeProperties);
                OrganizationProject Find(int id);
        void InsertOrUpdate(OrganizationProject organizationproject);
        void Delete(int id);
        void Save();
    }
}