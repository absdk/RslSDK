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
    public class VendorServiceCapabilityRatingRepository : IVendorServiceCapabilityRatingRepository
    {
		private readonly RepositoryContext context;

        public VendorServiceCapabilityRatingRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorServiceCapabilityRating> All
        {
            get { return context.VendorServiceCapabilityRating; }
        }

		public IQueryable<VendorServiceCapabilityRating> AllIncluding(params Expression<Func<VendorServiceCapabilityRating, object>>[] includeProperties)
        {
            IQueryable<VendorServiceCapabilityRating> query = context.VendorServiceCapabilityRating;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorServiceCapabilityRating> AllIncluding(int vendorId,params Expression<Func<VendorServiceCapabilityRating, object>>[] includeProperties)
        {
            IQueryable<VendorServiceCapabilityRating> query = context.VendorServiceCapabilityRating;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorServiceCapabilityRating Find(int id)
        {
            return context.VendorServiceCapabilityRating.Find(id);
        }

        public void InsertOrUpdate(VendorServiceCapabilityRating vendorservicecapabilityrating)
        {
            if (vendorservicecapabilityrating.VendorServiceCapabilityRatingID == default(int)) {
                // New entity
                context.VendorServiceCapabilityRating.Add(vendorservicecapabilityrating);
            } else {
                // Existing entity
                context.Entry(vendorservicecapabilityrating).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorservicecapabilityrating = context.VendorServiceCapabilityRating.Find(id);
            context.VendorServiceCapabilityRating.Remove(vendorservicecapabilityrating);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorServiceCapabilityRatingRepository
    {
        IQueryable<VendorServiceCapabilityRating> All { get; }
        IQueryable<VendorServiceCapabilityRating> AllIncluding(params Expression<Func<VendorServiceCapabilityRating, object>>[] includeProperties);
		        IQueryable<VendorServiceCapabilityRating> AllIncluding(int vendorId,params Expression<Func<VendorServiceCapabilityRating, object>>[] includeProperties);
                VendorServiceCapabilityRating Find(int id);
        void InsertOrUpdate(VendorServiceCapabilityRating vendorservicecapabilityrating);
        void Delete(int id);
        void Save();
    }
}