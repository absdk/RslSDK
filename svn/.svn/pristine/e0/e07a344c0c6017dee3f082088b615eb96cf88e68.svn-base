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
    public class VendorFinancialDataRepository : IVendorFinancialDataRepository
    {
		private readonly RepositoryContext context;

        public VendorFinancialDataRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorFinancialData> All
        {
            get { return context.VendorFinancialData; }
        }

		public IQueryable<VendorFinancialData> AllIncluding(params Expression<Func<VendorFinancialData, object>>[] includeProperties)
        {
            IQueryable<VendorFinancialData> query = context.VendorFinancialData;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorFinancialData> AllIncluding(int vendorId,params Expression<Func<VendorFinancialData, object>>[] includeProperties)
        {
            IQueryable<VendorFinancialData> query = context.VendorFinancialData;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorFinancialData Find(int id)
        {
            return context.VendorFinancialData.Find(id);
        }

        public void InsertOrUpdate(VendorFinancialData vendorfinancialdata)
        {
            if (vendorfinancialdata.VendorFinancialDataID == default(int)) {
                // New entity
                context.VendorFinancialData.Add(vendorfinancialdata);
            } else {
                // Existing entity
                context.Entry(vendorfinancialdata).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorfinancialdata = context.VendorFinancialData.Find(id);
            context.VendorFinancialData.Remove(vendorfinancialdata);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorFinancialDataRepository
    {
        IQueryable<VendorFinancialData> All { get; }
        IQueryable<VendorFinancialData> AllIncluding(params Expression<Func<VendorFinancialData, object>>[] includeProperties);
		        IQueryable<VendorFinancialData> AllIncluding(int vendorId,params Expression<Func<VendorFinancialData, object>>[] includeProperties);
                VendorFinancialData Find(int id);
        void InsertOrUpdate(VendorFinancialData vendorfinancialdata);
        void Delete(int id);
        void Save();
    }
}