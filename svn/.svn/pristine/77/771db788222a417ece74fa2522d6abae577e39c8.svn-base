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
    public class OrganizationAddressCategoryRepository : IOrganizationAddressCategoryRepository
    {
		private readonly RepositoryContext context;

        public OrganizationAddressCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationAddressCategory> All
        {
            get { return context.OrganizationAddressCategory; }
        }

        public IQueryable<OrganizationAddressCategory> AllIncluding(params Expression<Func<OrganizationAddressCategory, object>>[] includeProperties)
        {
            IQueryable<OrganizationAddressCategory> query = context.OrganizationAddressCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public OrganizationAddressCategory Find(int id)
        {
            return context.OrganizationAddressCategory.Find(id);
        }

        public void InsertOrUpdate(OrganizationAddressCategory organizationaddresscategory)
        {
            if (organizationaddresscategory.OrganizationAddressCategoryID == default(int)) {
                // New entity
                context.OrganizationAddressCategory.Add(organizationaddresscategory);
            } else {
                // Existing entity
                context.Entry(organizationaddresscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationaddresscategory = context.OrganizationAddressCategory.Find(id);
            context.OrganizationAddressCategory.Remove(organizationaddresscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationAddressCategoryRepository
    {
        IQueryable<OrganizationAddressCategory> All { get; }
        IQueryable<OrganizationAddressCategory> AllIncluding(params Expression<Func<OrganizationAddressCategory, object>>[] includeProperties);
        OrganizationAddressCategory Find(int id);
        void InsertOrUpdate(OrganizationAddressCategory organizationaddresscategory);
        void Delete(int id);
        void Save();
    }
}