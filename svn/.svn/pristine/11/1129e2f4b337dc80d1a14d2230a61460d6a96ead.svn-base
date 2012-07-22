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
    public class VendorRatingRepository : IVendorRatingRepository
    {
		private readonly RepositoryContext context;

        public VendorRatingRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorRating> All
        {
            get { return context.VendorRating; }
        }

		public IQueryable<VendorRating> AllIncluding(params Expression<Func<VendorRating, object>>[] includeProperties)
        {
            IQueryable<VendorRating> query = context.VendorRating;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorRating> AllIncluding(int vendorId,params Expression<Func<VendorRating, object>>[] includeProperties)
        {
            IQueryable<VendorRating> query = context.VendorRating;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorRating Find(int id)
        {
            return context.VendorRating.Find(id);
        }

        public void InsertOrUpdate(VendorRating vendorrating)
        {
            if (vendorrating.VendorRatingID == default(int)) {
                // New entity
                context.VendorRating.Add(vendorrating);
            } else {
                // Existing entity
                context.Entry(vendorrating).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorrating = context.VendorRating.Find(id);
            context.VendorRating.Remove(vendorrating);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorRatingRepository
    {
        IQueryable<VendorRating> All { get; }
        IQueryable<VendorRating> AllIncluding(params Expression<Func<VendorRating, object>>[] includeProperties);
		        IQueryable<VendorRating> AllIncluding(int vendorId,params Expression<Func<VendorRating, object>>[] includeProperties);
                VendorRating Find(int id);
        void InsertOrUpdate(VendorRating vendorrating);
        void Delete(int id);
        void Save();
    }
}