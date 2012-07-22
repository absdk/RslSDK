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
    public class VendorDocumentCategoryRepository : IVendorDocumentCategoryRepository
    {
		private readonly RepositoryContext context;

        public VendorDocumentCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorDocumentCategory> All
        {
            get { return context.VendorDocumentCategory; }
        }

        public IQueryable<VendorDocumentCategory> AllIncluding(params Expression<Func<VendorDocumentCategory, object>>[] includeProperties)
        {
            IQueryable<VendorDocumentCategory> query = context.VendorDocumentCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VendorDocumentCategory Find(int id)
        {
            return context.VendorDocumentCategory.Find(id);
        }

        public void InsertOrUpdate(VendorDocumentCategory vendordocumentcategory)
        {
            if (vendordocumentcategory.VendorDocumentCategoryID == default(int)) {
                // New entity
                context.VendorDocumentCategory.Add(vendordocumentcategory);
            } else {
                // Existing entity
                context.Entry(vendordocumentcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendordocumentcategory = context.VendorDocumentCategory.Find(id);
            context.VendorDocumentCategory.Remove(vendordocumentcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorDocumentCategoryRepository
    {
        IQueryable<VendorDocumentCategory> All { get; }
        IQueryable<VendorDocumentCategory> AllIncluding(params Expression<Func<VendorDocumentCategory, object>>[] includeProperties);
        VendorDocumentCategory Find(int id);
        void InsertOrUpdate(VendorDocumentCategory vendordocumentcategory);
        void Delete(int id);
        void Save();
    }
}