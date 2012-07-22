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
    public class RequisitionStatusForVendorCategoryRepository : IRequisitionStatusForVendorCategoryRepository
    {
		private readonly RepositoryContext context;

        public RequisitionStatusForVendorCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionStatusForVendorCategory> All
        {
            get { return context.RequisitionStatusForVendorCategory; }
        }

        public IQueryable<RequisitionStatusForVendorCategory> AllIncluding(params Expression<Func<RequisitionStatusForVendorCategory, object>>[] includeProperties)
        {
            IQueryable<RequisitionStatusForVendorCategory> query = context.RequisitionStatusForVendorCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionStatusForVendorCategory Find(int id)
        {
            return context.RequisitionStatusForVendorCategory.Find(id);
        }

        public void InsertOrUpdate(RequisitionStatusForVendorCategory requisitionstatusforvendorcategory)
        {
            if (requisitionstatusforvendorcategory.RequisitionStatusForVendorCategoryID == default(int)) {
                // New entity
                context.RequisitionStatusForVendorCategory.Add(requisitionstatusforvendorcategory);
            } else {
                // Existing entity
                context.Entry(requisitionstatusforvendorcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionstatusforvendorcategory = context.RequisitionStatusForVendorCategory.Find(id);
            context.RequisitionStatusForVendorCategory.Remove(requisitionstatusforvendorcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionStatusForVendorCategoryRepository
    {
        IQueryable<RequisitionStatusForVendorCategory> All { get; }
        IQueryable<RequisitionStatusForVendorCategory> AllIncluding(params Expression<Func<RequisitionStatusForVendorCategory, object>>[] includeProperties);
        RequisitionStatusForVendorCategory Find(int id);
        void InsertOrUpdate(RequisitionStatusForVendorCategory requisitionstatusforvendorcategory);
        void Delete(int id);
        void Save();
    }
}