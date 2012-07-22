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
    public class VendorAccountManagerRepository : IVendorAccountManagerRepository
    {
		private readonly RepositoryContext context;

        public VendorAccountManagerRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorAccountManager> All
        {
            get { return context.VendorAccountManager; }
        }

		public IQueryable<VendorAccountManager> AllIncluding(params Expression<Func<VendorAccountManager, object>>[] includeProperties)
        {
            IQueryable<VendorAccountManager> query = context.VendorAccountManager;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorAccountManager> AllIncluding(int vendorId,params Expression<Func<VendorAccountManager, object>>[] includeProperties)
        {
            IQueryable<VendorAccountManager> query = context.VendorAccountManager;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorAccountManager Find(int id)
        {
            return context.VendorAccountManager.Find(id);
        }

        public void InsertOrUpdate(VendorAccountManager vendoraccountmanager)
        {
            if (vendoraccountmanager.VendorAccountManagerID == default(int)) {
                // New entity
                context.VendorAccountManager.Add(vendoraccountmanager);
            } else {
                // Existing entity
                context.Entry(vendoraccountmanager).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendoraccountmanager = context.VendorAccountManager.Find(id);
            context.VendorAccountManager.Remove(vendoraccountmanager);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorAccountManagerRepository
    {
        IQueryable<VendorAccountManager> All { get; }
        IQueryable<VendorAccountManager> AllIncluding(params Expression<Func<VendorAccountManager, object>>[] includeProperties);
		        IQueryable<VendorAccountManager> AllIncluding(int vendorId,params Expression<Func<VendorAccountManager, object>>[] includeProperties);
                VendorAccountManager Find(int id);
        void InsertOrUpdate(VendorAccountManager vendoraccountmanager);
        void Delete(int id);
        void Save();
    }
}