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
    public class VendorContactRepository : IVendorContactRepository
    {
		private readonly RepositoryContext context;

        public VendorContactRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorContact> All
        {
            get { return context.VendorContact; }
        }

		public IQueryable<VendorContact> AllIncluding(params Expression<Func<VendorContact, object>>[] includeProperties)
        {
            IQueryable<VendorContact> query = context.VendorContact;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorContact> AllIncluding(int vendorId,params Expression<Func<VendorContact, object>>[] includeProperties)
        {
            IQueryable<VendorContact> query = context.VendorContact;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorContact Find(int id)
        {
            return context.VendorContact.Find(id);
        }

        public void InsertOrUpdate(VendorContact vendorcontact)
        {
            if (vendorcontact.VendorContactID == default(int)) {
                // New entity
                context.VendorContact.Add(vendorcontact);
            } else {
                // Existing entity
                context.Entry(vendorcontact).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorcontact = context.VendorContact.Find(id);
            context.VendorContact.Remove(vendorcontact);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorContactRepository
    {
        IQueryable<VendorContact> All { get; }
        IQueryable<VendorContact> AllIncluding(params Expression<Func<VendorContact, object>>[] includeProperties);
		        IQueryable<VendorContact> AllIncluding(int vendorId,params Expression<Func<VendorContact, object>>[] includeProperties);
                VendorContact Find(int id);
        void InsertOrUpdate(VendorContact vendorcontact);
        void Delete(int id);
        void Save();
    }
}