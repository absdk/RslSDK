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
    public class RequisitionPublishInfoRepository : IRequisitionPublishInfoRepository
    {
		private readonly RepositoryContext context;

        public RequisitionPublishInfoRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionPublishInfo> All
        {
            get { return context.RequisitionPublishInfo; }
        }

        public IQueryable<RequisitionPublishInfo> AllIncluding(params Expression<Func<RequisitionPublishInfo, object>>[] includeProperties)
        {
            IQueryable<RequisitionPublishInfo> query = context.RequisitionPublishInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionPublishInfo Find(int id)
        {
            return context.RequisitionPublishInfo.Find(id);
        }

        public void InsertOrUpdate(RequisitionPublishInfo requisitionpublishinfo)
        {
            if (requisitionpublishinfo.RequisitionPublishInfoID == default(int)) {
                // New entity
                context.RequisitionPublishInfo.Add(requisitionpublishinfo);
            } else {
                // Existing entity
                context.Entry(requisitionpublishinfo).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionpublishinfo = context.RequisitionPublishInfo.Find(id);
            context.RequisitionPublishInfo.Remove(requisitionpublishinfo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionPublishInfoRepository
    {
        IQueryable<RequisitionPublishInfo> All { get; }
        IQueryable<RequisitionPublishInfo> AllIncluding(params Expression<Func<RequisitionPublishInfo, object>>[] includeProperties);
        RequisitionPublishInfo Find(int id);
        void InsertOrUpdate(RequisitionPublishInfo requisitionpublishinfo);
        void Delete(int id);
        void Save();
    }
}