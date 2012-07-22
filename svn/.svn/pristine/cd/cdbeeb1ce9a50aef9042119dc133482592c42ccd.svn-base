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
    public class OrganizationDocumentCategoryRepository : IOrganizationDocumentCategoryRepository
    {
		private readonly RepositoryContext context;

        public OrganizationDocumentCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationDocumentCategory> All
        {
            get { return context.OrganizationDocumentCategory; }
        }

        public IQueryable<OrganizationDocumentCategory> AllIncluding(params Expression<Func<OrganizationDocumentCategory, object>>[] includeProperties)
        {
            IQueryable<OrganizationDocumentCategory> query = context.OrganizationDocumentCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public OrganizationDocumentCategory Find(int id)
        {
            return context.OrganizationDocumentCategory.Find(id);
        }

        public void InsertOrUpdate(OrganizationDocumentCategory organizationdocumentcategory)
        {
            if (organizationdocumentcategory.OrganizationDocumentCategoryID == default(int)) {
                // New entity
                context.OrganizationDocumentCategory.Add(organizationdocumentcategory);
            } else {
                // Existing entity
                context.Entry(organizationdocumentcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationdocumentcategory = context.OrganizationDocumentCategory.Find(id);
            context.OrganizationDocumentCategory.Remove(organizationdocumentcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationDocumentCategoryRepository
    {
        IQueryable<OrganizationDocumentCategory> All { get; }
        IQueryable<OrganizationDocumentCategory> AllIncluding(params Expression<Func<OrganizationDocumentCategory, object>>[] includeProperties);
        OrganizationDocumentCategory Find(int id);
        void InsertOrUpdate(OrganizationDocumentCategory organizationdocumentcategory);
        void Delete(int id);
        void Save();
    }
}