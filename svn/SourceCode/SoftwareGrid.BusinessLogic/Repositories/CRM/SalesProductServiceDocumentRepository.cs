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
    public class SalesProductServiceDocumentRepository : ISalesProductServiceDocumentRepository
    {
		private readonly RepositoryContext context;

        public SalesProductServiceDocumentRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SalesProductServiceDocument> All
        {
            get { return context.SalesProductServiceDocument; }
        }

        public IQueryable<SalesProductServiceDocument> AllIncluding(params Expression<Func<SalesProductServiceDocument, object>>[] includeProperties)
        {
            IQueryable<SalesProductServiceDocument> query = context.SalesProductServiceDocument;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SalesProductServiceDocument Find(int id)
        {
            return context.SalesProductServiceDocument.Find(id);
        }

        public void InsertOrUpdate(SalesProductServiceDocument salesproductservicedocument)
        {
            if (salesproductservicedocument.SalesProductServiceDocumentID == default(int)) {
                // New entity
                context.SalesProductServiceDocument.Add(salesproductservicedocument);
            } else {
                // Existing entity
                context.Entry(salesproductservicedocument).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var salesproductservicedocument = context.SalesProductServiceDocument.Find(id);
            context.SalesProductServiceDocument.Remove(salesproductservicedocument);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISalesProductServiceDocumentRepository
    {
        IQueryable<SalesProductServiceDocument> All { get; }
        IQueryable<SalesProductServiceDocument> AllIncluding(params Expression<Func<SalesProductServiceDocument, object>>[] includeProperties);
        SalesProductServiceDocument Find(int id);
        void InsertOrUpdate(SalesProductServiceDocument salesproductservicedocument);
        void Delete(int id);
        void Save();
    }
}