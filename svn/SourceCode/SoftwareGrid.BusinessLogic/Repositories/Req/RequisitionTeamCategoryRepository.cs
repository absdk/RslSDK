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
    public class RequisitionTeamCategoryRepository : IRequisitionTeamCategoryRepository
    {
		private readonly RepositoryContext context;

        public RequisitionTeamCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionTeamCategory> All
        {
            get { return context.RequisitionTeamCategory; }
        }

        public IQueryable<RequisitionTeamCategory> AllIncluding(params Expression<Func<RequisitionTeamCategory, object>>[] includeProperties)
        {
            IQueryable<RequisitionTeamCategory> query = context.RequisitionTeamCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionTeamCategory Find(int id)
        {
            return context.RequisitionTeamCategory.Find(id);
        }

        public void InsertOrUpdate(RequisitionTeamCategory requisitionteamcategory)
        {
            if (requisitionteamcategory.RequisitionTeamCategoryID == default(int)) {
                // New entity
                context.RequisitionTeamCategory.Add(requisitionteamcategory);
            } else {
                // Existing entity
                context.Entry(requisitionteamcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionteamcategory = context.RequisitionTeamCategory.Find(id);
            context.RequisitionTeamCategory.Remove(requisitionteamcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionTeamCategoryRepository
    {
        IQueryable<RequisitionTeamCategory> All { get; }
        IQueryable<RequisitionTeamCategory> AllIncluding(params Expression<Func<RequisitionTeamCategory, object>>[] includeProperties);
        RequisitionTeamCategory Find(int id);
        void InsertOrUpdate(RequisitionTeamCategory requisitionteamcategory);
        void Delete(int id);
        void Save();
    }
}