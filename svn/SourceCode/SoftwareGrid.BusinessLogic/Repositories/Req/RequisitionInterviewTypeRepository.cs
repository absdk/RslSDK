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
    public class RequisitionInterviewTypeRepository : IRequisitionInterviewTypeRepository
    {
		private readonly RepositoryContext context;

        public RequisitionInterviewTypeRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionInterviewType> All
        {
            get { return context.RequisitionInterviewType; }
        }

        public IQueryable<RequisitionInterviewType> AllIncluding(params Expression<Func<RequisitionInterviewType, object>>[] includeProperties)
        {
            IQueryable<RequisitionInterviewType> query = context.RequisitionInterviewType;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionInterviewType Find(int id)
        {
            return context.RequisitionInterviewType.Find(id);
        }

        public void InsertOrUpdate(RequisitionInterviewType requisitioninterviewtype)
        {
            if (requisitioninterviewtype.RequisitionInterviewTypeID == default(int)) {
                // New entity
                context.RequisitionInterviewType.Add(requisitioninterviewtype);
            } else {
                // Existing entity
                context.Entry(requisitioninterviewtype).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitioninterviewtype = context.RequisitionInterviewType.Find(id);
            context.RequisitionInterviewType.Remove(requisitioninterviewtype);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionInterviewTypeRepository
    {
        IQueryable<RequisitionInterviewType> All { get; }
        IQueryable<RequisitionInterviewType> AllIncluding(params Expression<Func<RequisitionInterviewType, object>>[] includeProperties);
        RequisitionInterviewType Find(int id);
        void InsertOrUpdate(RequisitionInterviewType requisitioninterviewtype);
        void Delete(int id);
        void Save();
    }
}