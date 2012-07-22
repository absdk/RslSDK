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
    public class OrganizationNoteCategoryRepository : IOrganizationNoteCategoryRepository
    {
		private readonly RepositoryContext context;

        public OrganizationNoteCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationNoteCategory> All
        {
            get { return context.OrganizationNoteCategory; }
        }

        public IQueryable<OrganizationNoteCategory> AllIncluding(params Expression<Func<OrganizationNoteCategory, object>>[] includeProperties)
        {
            IQueryable<OrganizationNoteCategory> query = context.OrganizationNoteCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public OrganizationNoteCategory Find(int id)
        {
            return context.OrganizationNoteCategory.Find(id);
        }

        public void InsertOrUpdate(OrganizationNoteCategory organizationnotecategory)
        {
            if (organizationnotecategory.OrganizationNoteCategoryID == default(int)) {
                // New entity
                context.OrganizationNoteCategory.Add(organizationnotecategory);
            } else {
                // Existing entity
                context.Entry(organizationnotecategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationnotecategory = context.OrganizationNoteCategory.Find(id);
            context.OrganizationNoteCategory.Remove(organizationnotecategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationNoteCategoryRepository
    {
        IQueryable<OrganizationNoteCategory> All { get; }
        IQueryable<OrganizationNoteCategory> AllIncluding(params Expression<Func<OrganizationNoteCategory, object>>[] includeProperties);
        OrganizationNoteCategory Find(int id);
        void InsertOrUpdate(OrganizationNoteCategory organizationnotecategory);
        void Delete(int id);
        void Save();
    }
}