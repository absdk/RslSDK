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
    public class VendorReferenceRepository : IVendorReferenceRepository
    {
		private readonly RepositoryContext context;

        public VendorReferenceRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorReference> All
        {
            get { return context.VendorReference; }
        }

		public IQueryable<VendorReference> AllIncluding(params Expression<Func<VendorReference, object>>[] includeProperties)
        {
            IQueryable<VendorReference> query = context.VendorReference;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorReference> AllIncluding(int vendorId,params Expression<Func<VendorReference, object>>[] includeProperties)
        {
            IQueryable<VendorReference> query = context.VendorReference;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorReference Find(int id)
        {
            return context.VendorReference.Find(id);
        }

        public void InsertOrUpdate(VendorReference vendorreference)
        {
            if (vendorreference.VendorReferenceID == default(int)) {
                // New entity
                context.VendorReference.Add(vendorreference);
            } else {
                // Existing entity
                context.Entry(vendorreference).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorreference = context.VendorReference.Find(id);
            context.VendorReference.Remove(vendorreference);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorReferenceRepository
    {
        IQueryable<VendorReference> All { get; }
        IQueryable<VendorReference> AllIncluding(params Expression<Func<VendorReference, object>>[] includeProperties);
		        IQueryable<VendorReference> AllIncluding(int vendorId,params Expression<Func<VendorReference, object>>[] includeProperties);
                VendorReference Find(int id);
        void InsertOrUpdate(VendorReference vendorreference);
        void Delete(int id);
        void Save();
    }
}