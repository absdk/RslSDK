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
    public class VendorServiceCategoryRepository : IVendorServiceCategoryRepository
    {
		private readonly RepositoryContext context;

        public VendorServiceCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorServiceCategory> All
        {
            get { return context.VendorServiceCategory; }
        }

        public IQueryable<VendorServiceCategory> AllIncluding(params Expression<Func<VendorServiceCategory, object>>[] includeProperties)
        {
            IQueryable<VendorServiceCategory> query = context.VendorServiceCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VendorServiceCategory Find(int id)
        {
            return context.VendorServiceCategory.Find(id);
        }

        public void InsertOrUpdate(VendorServiceCategory vendorservicecategory)
        {
            if (vendorservicecategory.VendorServiceCategoryID == default(int)) {
                // New entity
                context.VendorServiceCategory.Add(vendorservicecategory);
            } else {
                // Existing entity
                context.Entry(vendorservicecategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorservicecategory = context.VendorServiceCategory.Find(id);
            context.VendorServiceCategory.Remove(vendorservicecategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorServiceCategoryRepository
    {
        IQueryable<VendorServiceCategory> All { get; }
        IQueryable<VendorServiceCategory> AllIncluding(params Expression<Func<VendorServiceCategory, object>>[] includeProperties);
        VendorServiceCategory Find(int id);
        void InsertOrUpdate(VendorServiceCategory vendorservicecategory);
        void Delete(int id);
        void Save();
    }
}