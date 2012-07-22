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
    public class VendorInsuranceCategoryRepository : IVendorInsuranceCategoryRepository
    {
		private readonly RepositoryContext context;

        public VendorInsuranceCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorInsuranceCategory> All
        {
            get { return context.VendorInsuranceCategory; }
        }

        public IQueryable<VendorInsuranceCategory> AllIncluding(params Expression<Func<VendorInsuranceCategory, object>>[] includeProperties)
        {
            IQueryable<VendorInsuranceCategory> query = context.VendorInsuranceCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VendorInsuranceCategory Find(int id)
        {
            return context.VendorInsuranceCategory.Find(id);
        }

        public void InsertOrUpdate(VendorInsuranceCategory vendorinsurancecategory)
        {
            if (vendorinsurancecategory.VendorInsuranceCategoryID == default(int)) {
                // New entity
                context.VendorInsuranceCategory.Add(vendorinsurancecategory);
            } else {
                // Existing entity
                context.Entry(vendorinsurancecategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorinsurancecategory = context.VendorInsuranceCategory.Find(id);
            context.VendorInsuranceCategory.Remove(vendorinsurancecategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorInsuranceCategoryRepository
    {
        IQueryable<VendorInsuranceCategory> All { get; }
        IQueryable<VendorInsuranceCategory> AllIncluding(params Expression<Func<VendorInsuranceCategory, object>>[] includeProperties);
        VendorInsuranceCategory Find(int id);
        void InsertOrUpdate(VendorInsuranceCategory vendorinsurancecategory);
        void Delete(int id);
        void Save();
    }
}