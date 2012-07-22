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
    public class VendorNoteRepository : IVendorNoteRepository
    {
		private readonly RepositoryContext context;

        public VendorNoteRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorNote> All
        {
            get { return context.VendorNote; }
        }

		public IQueryable<VendorNote> AllIncluding(params Expression<Func<VendorNote, object>>[] includeProperties)
        {
            IQueryable<VendorNote> query = context.VendorNote;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorNote> AllIncluding(int vendorId,params Expression<Func<VendorNote, object>>[] includeProperties)
        {
            IQueryable<VendorNote> query = context.VendorNote;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorNote Find(int id)
        {
            return context.VendorNote.Find(id);
        }

        public void InsertOrUpdate(VendorNote vendornote)
        {
            if (vendornote.VendorNoteID == default(int)) {
                // New entity
                context.VendorNote.Add(vendornote);
            } else {
                // Existing entity
                context.Entry(vendornote).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendornote = context.VendorNote.Find(id);
            context.VendorNote.Remove(vendornote);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorNoteRepository
    {
        IQueryable<VendorNote> All { get; }
        IQueryable<VendorNote> AllIncluding(params Expression<Func<VendorNote, object>>[] includeProperties);
		        IQueryable<VendorNote> AllIncluding(int vendorId,params Expression<Func<VendorNote, object>>[] includeProperties);
                VendorNote Find(int id);
        void InsertOrUpdate(VendorNote vendornote);
        void Delete(int id);
        void Save();
    }
}