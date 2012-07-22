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
    public class VendorNoteCategoryRepository : IVendorNoteCategoryRepository
    {
		private readonly RepositoryContext context;

        public VendorNoteCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorNoteCategory> All
        {
            get { return context.VendorNoteCategory; }
        }

        public IQueryable<VendorNoteCategory> AllIncluding(params Expression<Func<VendorNoteCategory, object>>[] includeProperties)
        {
            IQueryable<VendorNoteCategory> query = context.VendorNoteCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VendorNoteCategory Find(int id)
        {
            return context.VendorNoteCategory.Find(id);
        }

        public void InsertOrUpdate(VendorNoteCategory vendornotecategory)
        {
            if (vendornotecategory.VendorNoteCategoryID == default(int)) {
                // New entity
                context.VendorNoteCategory.Add(vendornotecategory);
            } else {
                // Existing entity
                context.Entry(vendornotecategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendornotecategory = context.VendorNoteCategory.Find(id);
            context.VendorNoteCategory.Remove(vendornotecategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorNoteCategoryRepository
    {
        IQueryable<VendorNoteCategory> All { get; }
        IQueryable<VendorNoteCategory> AllIncluding(params Expression<Func<VendorNoteCategory, object>>[] includeProperties);
        VendorNoteCategory Find(int id);
        void InsertOrUpdate(VendorNoteCategory vendornotecategory);
        void Delete(int id);
        void Save();
    }
}