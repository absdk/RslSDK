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
    public class VendorInsuranceRepository : IVendorInsuranceRepository
    {
		private readonly RepositoryContext context;

        public VendorInsuranceRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorInsurance> All
        {
            get { return context.VendorInsurance; }
        }

		public IQueryable<VendorInsurance> AllIncluding(params Expression<Func<VendorInsurance, object>>[] includeProperties)
        {
            IQueryable<VendorInsurance> query = context.VendorInsurance;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorInsurance> AllIncluding(int vendorId,params Expression<Func<VendorInsurance, object>>[] includeProperties)
        {
            IQueryable<VendorInsurance> query = context.VendorInsurance;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorInsurance Find(int id)
        {
            return context.VendorInsurance.Find(id);
        }

        public void InsertOrUpdate(VendorInsurance vendorinsurance)
        {
            if (vendorinsurance.VendorInsuranceID == default(int)) {
                // New entity
                context.VendorInsurance.Add(vendorinsurance);
            } else {
                // Existing entity
                context.Entry(vendorinsurance).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorinsurance = context.VendorInsurance.Find(id);
            context.VendorInsurance.Remove(vendorinsurance);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorInsuranceRepository
    {
        IQueryable<VendorInsurance> All { get; }
        IQueryable<VendorInsurance> AllIncluding(params Expression<Func<VendorInsurance, object>>[] includeProperties);
		        IQueryable<VendorInsurance> AllIncluding(int vendorId,params Expression<Func<VendorInsurance, object>>[] includeProperties);
                VendorInsurance Find(int id);
        void InsertOrUpdate(VendorInsurance vendorinsurance);
        void Delete(int id);
        void Save();
    }
}