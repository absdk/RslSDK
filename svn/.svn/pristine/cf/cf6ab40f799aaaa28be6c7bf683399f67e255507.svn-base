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
    public class RequisitionDocumentRepository : IRequisitionDocumentRepository
    {
		private readonly RepositoryContext context;

        public RequisitionDocumentRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionDocument> All
        {
            get { return context.RequisitionDocument; }
        }

        public IQueryable<RequisitionDocument> AllIncluding(params Expression<Func<RequisitionDocument, object>>[] includeProperties)
        {
            IQueryable<RequisitionDocument> query = context.RequisitionDocument;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionDocument Find(int id)
        {
            return context.RequisitionDocument.Find(id);
        }

        public void InsertOrUpdate(RequisitionDocument requisitiondocument)
        {
            if (requisitiondocument.RequisitionDocumentID == default(int)) {
                // New entity
                context.RequisitionDocument.Add(requisitiondocument);
            } else {
                // Existing entity
                context.Entry(requisitiondocument).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitiondocument = context.RequisitionDocument.Find(id);
            context.RequisitionDocument.Remove(requisitiondocument);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionDocumentRepository
    {
        IQueryable<RequisitionDocument> All { get; }
        IQueryable<RequisitionDocument> AllIncluding(params Expression<Func<RequisitionDocument, object>>[] includeProperties);
        RequisitionDocument Find(int id);
        void InsertOrUpdate(RequisitionDocument requisitiondocument);
        void Delete(int id);
        void Save();
    }
}