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
    public class VendorDocumentRepository : IVendorDocumentRepository
    {
		private readonly RepositoryContext context;

        public VendorDocumentRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorDocument> All
        {
            get { return context.VendorDocument; }
        }

		public IQueryable<VendorDocument> AllIncluding(params Expression<Func<VendorDocument, object>>[] includeProperties)
        {
            IQueryable<VendorDocument> query = context.VendorDocument;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorDocument> AllIncluding(int vendorId,params Expression<Func<VendorDocument, object>>[] includeProperties)
        {
            IQueryable<VendorDocument> query = context.VendorDocument;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorDocument Find(int id)
        {
            return context.VendorDocument.Find(id);
        }

        public void InsertOrUpdate(VendorDocument vendordocument)
        {
            if (vendordocument.VendorDocumentID == default(int)) {
                // New entity
                context.VendorDocument.Add(vendordocument);
            } else {
                // Existing entity
                context.Entry(vendordocument).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendordocument = context.VendorDocument.Find(id);
            context.VendorDocument.Remove(vendordocument);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorDocumentRepository
    {
        IQueryable<VendorDocument> All { get; }
        IQueryable<VendorDocument> AllIncluding(params Expression<Func<VendorDocument, object>>[] includeProperties);
		        IQueryable<VendorDocument> AllIncluding(int vendorId,params Expression<Func<VendorDocument, object>>[] includeProperties);
                VendorDocument Find(int id);
        void InsertOrUpdate(VendorDocument vendordocument);
        void Delete(int id);
        void Save();
    }
}