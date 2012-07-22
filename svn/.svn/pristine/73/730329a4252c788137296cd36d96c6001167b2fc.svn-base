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
    public class VendorDocumentStatusCategoryRepository : IVendorDocumentStatusCategoryRepository
    {
		private readonly RepositoryContext context;

        public VendorDocumentStatusCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorDocumentStatusCategory> All
        {
            get { return context.VendorDocumentStatusCategory; }
        }

        public IQueryable<VendorDocumentStatusCategory> AllIncluding(params Expression<Func<VendorDocumentStatusCategory, object>>[] includeProperties)
        {
            IQueryable<VendorDocumentStatusCategory> query = context.VendorDocumentStatusCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VendorDocumentStatusCategory Find(int id)
        {
            return context.VendorDocumentStatusCategory.Find(id);
        }

        public void InsertOrUpdate(VendorDocumentStatusCategory vendordocumentstatuscategory)
        {
            if (vendordocumentstatuscategory.VendorDocumentStatusCategoryID == default(int)) {
                // New entity
                context.VendorDocumentStatusCategory.Add(vendordocumentstatuscategory);
            } else {
                // Existing entity
                context.Entry(vendordocumentstatuscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendordocumentstatuscategory = context.VendorDocumentStatusCategory.Find(id);
            context.VendorDocumentStatusCategory.Remove(vendordocumentstatuscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorDocumentStatusCategoryRepository
    {
        IQueryable<VendorDocumentStatusCategory> All { get; }
        IQueryable<VendorDocumentStatusCategory> AllIncluding(params Expression<Func<VendorDocumentStatusCategory, object>>[] includeProperties);
        VendorDocumentStatusCategory Find(int id);
        void InsertOrUpdate(VendorDocumentStatusCategory vendordocumentstatuscategory);
        void Delete(int id);
        void Save();
    }
}