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
    public class RequisitionClientInfoRepository : IRequisitionClientInfoRepository
    {
		private readonly RepositoryContext context;

        public RequisitionClientInfoRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionClientInfo> All
        {
            get { return context.RequisitionClientInfo; }
        }

        public IQueryable<RequisitionClientInfo> AllIncluding(params Expression<Func<RequisitionClientInfo, object>>[] includeProperties)
        {
            IQueryable<RequisitionClientInfo> query = context.RequisitionClientInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionClientInfo Find(int id)
        {
            return context.RequisitionClientInfo.Find(id);
        }

        public void InsertOrUpdate(RequisitionClientInfo requisitionclientinfo)
        {
            if (requisitionclientinfo.RequisitionClientInfoID == default(int)) {
                // New entity
                context.RequisitionClientInfo.Add(requisitionclientinfo);
            } else {
                // Existing entity
                context.Entry(requisitionclientinfo).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionclientinfo = context.RequisitionClientInfo.Find(id);
            context.RequisitionClientInfo.Remove(requisitionclientinfo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionClientInfoRepository
    {
        IQueryable<RequisitionClientInfo> All { get; }
        IQueryable<RequisitionClientInfo> AllIncluding(params Expression<Func<RequisitionClientInfo, object>>[] includeProperties);
        RequisitionClientInfo Find(int id);
        void InsertOrUpdate(RequisitionClientInfo requisitionclientinfo);
        void Delete(int id);
        void Save();
    }
}