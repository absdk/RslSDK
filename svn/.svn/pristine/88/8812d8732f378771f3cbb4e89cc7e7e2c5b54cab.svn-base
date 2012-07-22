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
    public class OrganizationDepartmentRepository : IOrganizationDepartmentRepository
    {
		private readonly RepositoryContext context;

        public OrganizationDepartmentRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationDepartment> All
        {
            get { return context.OrganizationDepartment; }
        }

		public IQueryable<OrganizationDepartment> AllIncluding(params Expression<Func<OrganizationDepartment, object>>[] includeProperties)
        {
            IQueryable<OrganizationDepartment> query = context.OrganizationDepartment;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<OrganizationDepartment> AllIncluding(int organizationId,params Expression<Func<OrganizationDepartment, object>>[] includeProperties)
        {
            IQueryable<OrganizationDepartment> query = context.OrganizationDepartment;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.OrganizationID==organizationId);
        }
		
        public OrganizationDepartment Find(int id)
        {
            return context.OrganizationDepartment.Find(id);
        }

        public void InsertOrUpdate(OrganizationDepartment organizationdepartment)
        {
            if (organizationdepartment.OrganizationDepartmentID == default(int)) {
                // New entity
                context.OrganizationDepartment.Add(organizationdepartment);
            } else {
                // Existing entity
                context.Entry(organizationdepartment).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationdepartment = context.OrganizationDepartment.Find(id);
            context.OrganizationDepartment.Remove(organizationdepartment);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationDepartmentRepository
    {
        IQueryable<OrganizationDepartment> All { get; }
        IQueryable<OrganizationDepartment> AllIncluding(params Expression<Func<OrganizationDepartment, object>>[] includeProperties);
		        IQueryable<OrganizationDepartment> AllIncluding(int organizationId,params Expression<Func<OrganizationDepartment, object>>[] includeProperties);
                OrganizationDepartment Find(int id);
        void InsertOrUpdate(OrganizationDepartment organizationdepartment);
        void Delete(int id);
        void Save();
    }
}