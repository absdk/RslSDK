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
    public class VendorAddressCategoryRepository : IVendorAddressCategoryRepository
    {
		private readonly RepositoryContext context;

        public VendorAddressCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorAddressCategory> All
        {
            get { return context.VendorAddressCategory; }
        }

        public IQueryable<VendorAddressCategory> AllIncluding(params Expression<Func<VendorAddressCategory, object>>[] includeProperties)
        {
            IQueryable<VendorAddressCategory> query = context.VendorAddressCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VendorAddressCategory Find(int id)
        {
            return context.VendorAddressCategory.Find(id);
        }

        public void InsertOrUpdate(VendorAddressCategory vendoraddresscategory)
        {
            if (vendoraddresscategory.VendorAddressCategoryID == default(int)) {
                // New entity
                context.VendorAddressCategory.Add(vendoraddresscategory);
            } else {
                // Existing entity
                context.Entry(vendoraddresscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendoraddresscategory = context.VendorAddressCategory.Find(id);
            context.VendorAddressCategory.Remove(vendoraddresscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorAddressCategoryRepository
    {
        IQueryable<VendorAddressCategory> All { get; }
        IQueryable<VendorAddressCategory> AllIncluding(params Expression<Func<VendorAddressCategory, object>>[] includeProperties);
        VendorAddressCategory Find(int id);
        void InsertOrUpdate(VendorAddressCategory vendoraddresscategory);
        void Delete(int id);
        void Save();
    }
}