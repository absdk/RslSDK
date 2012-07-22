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
    public class VendorSupplierDiversityCertificationCategoryRepository : IVendorSupplierDiversityCertificationCategoryRepository
    {
		private readonly RepositoryContext context;

        public VendorSupplierDiversityCertificationCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorSupplierDiversityCertificationCategory> All
        {
            get { return context.VendorSupplierDiversityCertificationCategory; }
        }

        public IQueryable<VendorSupplierDiversityCertificationCategory> AllIncluding(params Expression<Func<VendorSupplierDiversityCertificationCategory, object>>[] includeProperties)
        {
            IQueryable<VendorSupplierDiversityCertificationCategory> query = context.VendorSupplierDiversityCertificationCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VendorSupplierDiversityCertificationCategory Find(int id)
        {
            return context.VendorSupplierDiversityCertificationCategory.Find(id);
        }

        public void InsertOrUpdate(VendorSupplierDiversityCertificationCategory vendorsupplierdiversitycertificationcategory)
        {
            if (vendorsupplierdiversitycertificationcategory.VendorSupplierDiversityCertificationCategoryID == default(int)) {
                // New entity
                context.VendorSupplierDiversityCertificationCategory.Add(vendorsupplierdiversitycertificationcategory);
            } else {
                // Existing entity
                context.Entry(vendorsupplierdiversitycertificationcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorsupplierdiversitycertificationcategory = context.VendorSupplierDiversityCertificationCategory.Find(id);
            context.VendorSupplierDiversityCertificationCategory.Remove(vendorsupplierdiversitycertificationcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorSupplierDiversityCertificationCategoryRepository
    {
        IQueryable<VendorSupplierDiversityCertificationCategory> All { get; }
        IQueryable<VendorSupplierDiversityCertificationCategory> AllIncluding(params Expression<Func<VendorSupplierDiversityCertificationCategory, object>>[] includeProperties);
        VendorSupplierDiversityCertificationCategory Find(int id);
        void InsertOrUpdate(VendorSupplierDiversityCertificationCategory vendorsupplierdiversitycertificationcategory);
        void Delete(int id);
        void Save();
    }
}