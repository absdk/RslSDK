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
    public class VendorStatusCategoryRepository : IVendorStatusCategoryRepository
    {
		private readonly RepositoryContext context;

        public VendorStatusCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorStatusCategory> All
        {
            get { return context.VendorStatusCategory; }
        }

        public IQueryable<VendorStatusCategory> AllIncluding(params Expression<Func<VendorStatusCategory, object>>[] includeProperties)
        {
            IQueryable<VendorStatusCategory> query = context.VendorStatusCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VendorStatusCategory Find(int id)
        {
            return context.VendorStatusCategory.Find(id);
        }

        public void InsertOrUpdate(VendorStatusCategory vendorstatuscategory)
        {
            if (vendorstatuscategory.VendorStatusCategoryID == default(int)) {
                // New entity
                context.VendorStatusCategory.Add(vendorstatuscategory);
            } else {
                // Existing entity
                context.Entry(vendorstatuscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorstatuscategory = context.VendorStatusCategory.Find(id);
            context.VendorStatusCategory.Remove(vendorstatuscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorStatusCategoryRepository
    {
        IQueryable<VendorStatusCategory> All { get; }
        IQueryable<VendorStatusCategory> AllIncluding(params Expression<Func<VendorStatusCategory, object>>[] includeProperties);
        VendorStatusCategory Find(int id);
        void InsertOrUpdate(VendorStatusCategory vendorstatuscategory);
        void Delete(int id);
        void Save();
    }
}