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
    public class SalesProductServiceCategoryRepository : ISalesProductServiceCategoryRepository
    {
		private readonly RepositoryContext context;

        public SalesProductServiceCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SalesProductServiceCategory> All
        {
            get { return context.SalesProductServiceCategory; }
        }

        public IQueryable<SalesProductServiceCategory> AllIncluding(params Expression<Func<SalesProductServiceCategory, object>>[] includeProperties)
        {
            IQueryable<SalesProductServiceCategory> query = context.SalesProductServiceCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SalesProductServiceCategory Find(int id)
        {
            return context.SalesProductServiceCategory.Find(id);
        }

        public void InsertOrUpdate(SalesProductServiceCategory salesproductservicecategory)
        {
            if (salesproductservicecategory.SalesProductServiceCategoryID == default(int)) {
                // New entity
                context.SalesProductServiceCategory.Add(salesproductservicecategory);
            } else {
                // Existing entity
                context.Entry(salesproductservicecategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var salesproductservicecategory = context.SalesProductServiceCategory.Find(id);
            context.SalesProductServiceCategory.Remove(salesproductservicecategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISalesProductServiceCategoryRepository
    {
        IQueryable<SalesProductServiceCategory> All { get; }
        IQueryable<SalesProductServiceCategory> AllIncluding(params Expression<Func<SalesProductServiceCategory, object>>[] includeProperties);
        SalesProductServiceCategory Find(int id);
        void InsertOrUpdate(SalesProductServiceCategory salesproductservicecategory);
        void Delete(int id);
        void Save();
    }
}