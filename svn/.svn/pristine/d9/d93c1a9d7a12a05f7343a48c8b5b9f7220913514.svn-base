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
    public class RequisitionStatusCategoryRepository : IRequisitionStatusCategoryRepository
    {
		private readonly RepositoryContext context;

        public RequisitionStatusCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionStatusCategory> All
        {
            get { return context.RequisitionStatusCategory; }
        }

        public IQueryable<RequisitionStatusCategory> AllIncluding(params Expression<Func<RequisitionStatusCategory, object>>[] includeProperties)
        {
            IQueryable<RequisitionStatusCategory> query = context.RequisitionStatusCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionStatusCategory Find(int id)
        {
            return context.RequisitionStatusCategory.Find(id);
        }

        public void InsertOrUpdate(RequisitionStatusCategory requisitionstatuscategory)
        {
            if (requisitionstatuscategory.RequisitionStatusCategoryID == default(int)) {
                // New entity
                context.RequisitionStatusCategory.Add(requisitionstatuscategory);
            } else {
                // Existing entity
                context.Entry(requisitionstatuscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionstatuscategory = context.RequisitionStatusCategory.Find(id);
            context.RequisitionStatusCategory.Remove(requisitionstatuscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionStatusCategoryRepository
    {
        IQueryable<RequisitionStatusCategory> All { get; }
        IQueryable<RequisitionStatusCategory> AllIncluding(params Expression<Func<RequisitionStatusCategory, object>>[] includeProperties);
        RequisitionStatusCategory Find(int id);
        void InsertOrUpdate(RequisitionStatusCategory requisitionstatuscategory);
        void Delete(int id);
        void Save();
    }
}