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
    public class VendorAddressRepository : IVendorAddressRepository
    {
        private readonly RepositoryContext context;

        public VendorAddressRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorAddress> All
        {
            get { return context.VendorAddress; }
        }

        public IQueryable<VendorAddress> AllIncluding(params Expression<Func<VendorAddress, object>>[] includeProperties)
        {
            IQueryable<VendorAddress> query = context.VendorAddress;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public IQueryable<VendorAddress> AllIncluding(int vendorId, params Expression<Func<VendorAddress, object>>[] includeProperties)
        {
            IQueryable<VendorAddress> query = context.VendorAddress;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query.Where(item => item.VendorID == vendorId);
        }

        public VendorAddress Find(int id)
        {
            return context.VendorAddress.Find(id);
        }

        public void InsertOrUpdate(VendorAddress vendoraddress)
        {
            if (vendoraddress.VendorAddressID == default(int))
            {
                // New entity
                context.VendorAddress.Add(vendoraddress);
            }
            else
            {
                // Existing entity
                context.Entry(vendoraddress).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendoraddress = context.VendorAddress.Find(id);
            context.VendorAddress.Remove(vendoraddress);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorAddressRepository
    {
        IQueryable<VendorAddress> All { get; }
        IQueryable<VendorAddress> AllIncluding(params Expression<Func<VendorAddress, object>>[] includeProperties);
        IQueryable<VendorAddress> AllIncluding(int vendorId, params Expression<Func<VendorAddress, object>>[] includeProperties);
        VendorAddress Find(int id);
        void InsertOrUpdate(VendorAddress vendoraddress);
        void Delete(int id);
        void Save();
    }
}