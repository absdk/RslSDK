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
    public class OrganizationCategoryRepository : IOrganizationCategoryRepository
    {
		private readonly RepositoryContext context;

        public OrganizationCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationCategory> All
        {
            get { return context.OrganizationCategory; }
        }

        public IQueryable<OrganizationCategory> AllIncluding(params Expression<Func<OrganizationCategory, object>>[] includeProperties)
        {
            IQueryable<OrganizationCategory> query = context.OrganizationCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public OrganizationCategory Find(int id)
        {
            return context.OrganizationCategory.Find(id);
        }

        public void InsertOrUpdate(OrganizationCategory organizationcategory)
        {
            if (organizationcategory.OrganizationCategoryID == default(int)) {
                // New entity
                context.OrganizationCategory.Add(organizationcategory);
            } else {
                // Existing entity
                context.Entry(organizationcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationcategory = context.OrganizationCategory.Find(id);
            context.OrganizationCategory.Remove(organizationcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationCategoryRepository
    {
        IQueryable<OrganizationCategory> All { get; }
        IQueryable<OrganizationCategory> AllIncluding(params Expression<Func<OrganizationCategory, object>>[] includeProperties);
        OrganizationCategory Find(int id);
        void InsertOrUpdate(OrganizationCategory organizationcategory);
        void Delete(int id);
        void Save();
    }
}