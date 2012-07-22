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
    public class RequisitionNoteRepository : IRequisitionNoteRepository
    {
		private readonly RepositoryContext context;

        public RequisitionNoteRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionNote> All
        {
            get { return context.RequisitionNote; }
        }

        public IQueryable<RequisitionNote> AllIncluding(params Expression<Func<RequisitionNote, object>>[] includeProperties)
        {
            IQueryable<RequisitionNote> query = context.RequisitionNote;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionNote Find(int id)
        {
            return context.RequisitionNote.Find(id);
        }

        public void InsertOrUpdate(RequisitionNote requisitionnote)
        {
            if (requisitionnote.ID == default(int)) {
                // New entity
                context.RequisitionNote.Add(requisitionnote);
            } else {
                // Existing entity
                context.Entry(requisitionnote).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionnote = context.RequisitionNote.Find(id);
            context.RequisitionNote.Remove(requisitionnote);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionNoteRepository
    {
        IQueryable<RequisitionNote> All { get; }
        IQueryable<RequisitionNote> AllIncluding(params Expression<Func<RequisitionNote, object>>[] includeProperties);
        RequisitionNote Find(int id);
        void InsertOrUpdate(RequisitionNote requisitionnote);
        void Delete(int id);
        void Save();
    }
}