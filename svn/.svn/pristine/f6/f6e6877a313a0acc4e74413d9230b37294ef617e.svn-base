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
    public class SalesProductServiceCatelogRepository : ISalesProductServiceCatelogRepository
    {
		private readonly RepositoryContext context;

        public SalesProductServiceCatelogRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SalesProductServiceCatelog> All
        {
            get { return context.SalesProductServiceCatelog; }
        }

        public IQueryable<SalesProductServiceCatelog> AllIncluding(params Expression<Func<SalesProductServiceCatelog, object>>[] includeProperties)
        {
            IQueryable<SalesProductServiceCatelog> query = context.SalesProductServiceCatelog;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SalesProductServiceCatelog Find(int id)
        {
            return context.SalesProductServiceCatelog.Find(id);
        }

        public void InsertOrUpdate(SalesProductServiceCatelog salesproductservicecatelog)
        {
            if (salesproductservicecatelog.SalesProductServiceCatelogID == default(int)) {
                // New entity
                context.SalesProductServiceCatelog.Add(salesproductservicecatelog);
            } else {
                // Existing entity
                context.Entry(salesproductservicecatelog).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var salesproductservicecatelog = context.SalesProductServiceCatelog.Find(id);
            context.SalesProductServiceCatelog.Remove(salesproductservicecatelog);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISalesProductServiceCatelogRepository
    {
        IQueryable<SalesProductServiceCatelog> All { get; }
        IQueryable<SalesProductServiceCatelog> AllIncluding(params Expression<Func<SalesProductServiceCatelog, object>>[] includeProperties);
        SalesProductServiceCatelog Find(int id);
        void InsertOrUpdate(SalesProductServiceCatelog salesproductservicecatelog);
        void Delete(int id);
        void Save();
    }
}