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
    public class RequisitionApprovalStatusCategoryRepository : IRequisitionApprovalStatusCategoryRepository
    {
		private readonly RepositoryContext context;

        public RequisitionApprovalStatusCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionApprovalStatusCategory> All
        {
            get { return context.RequisitionApprovalStatusCategory; }
        }

        public IQueryable<RequisitionApprovalStatusCategory> AllIncluding(params Expression<Func<RequisitionApprovalStatusCategory, object>>[] includeProperties)
        {
            IQueryable<RequisitionApprovalStatusCategory> query = context.RequisitionApprovalStatusCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionApprovalStatusCategory Find(int id)
        {
            return context.RequisitionApprovalStatusCategory.Find(id);
        }

        public void InsertOrUpdate(RequisitionApprovalStatusCategory requisitionapprovalstatuscategory)
        {
            if (requisitionapprovalstatuscategory.RequisitionApprovalStatusCategoryID == default(int)) {
                // New entity
                context.RequisitionApprovalStatusCategory.Add(requisitionapprovalstatuscategory);
            } else {
                // Existing entity
                context.Entry(requisitionapprovalstatuscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionapprovalstatuscategory = context.RequisitionApprovalStatusCategory.Find(id);
            context.RequisitionApprovalStatusCategory.Remove(requisitionapprovalstatuscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionApprovalStatusCategoryRepository
    {
        IQueryable<RequisitionApprovalStatusCategory> All { get; }
        IQueryable<RequisitionApprovalStatusCategory> AllIncluding(params Expression<Func<RequisitionApprovalStatusCategory, object>>[] includeProperties);
        RequisitionApprovalStatusCategory Find(int id);
        void InsertOrUpdate(RequisitionApprovalStatusCategory requisitionapprovalstatuscategory);
        void Delete(int id);
        void Save();
    }
}