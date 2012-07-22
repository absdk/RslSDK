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
    public class RequisitionTeamRepository : IRequisitionTeamRepository
    {
		private readonly RepositoryContext context;

        public RequisitionTeamRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionTeam> All
        {
            get { return context.RequisitionTeam; }
        }

        public IQueryable<RequisitionTeam> AllIncluding(params Expression<Func<RequisitionTeam, object>>[] includeProperties)
        {
            IQueryable<RequisitionTeam> query = context.RequisitionTeam;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionTeam Find(int id)
        {
            return context.RequisitionTeam.Find(id);
        }

        public void InsertOrUpdate(RequisitionTeam requisitionteam)
        {
            if (requisitionteam.RequisitionTeamID == default(int)) {
                // New entity
                context.RequisitionTeam.Add(requisitionteam);
            } else {
                // Existing entity
                context.Entry(requisitionteam).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionteam = context.RequisitionTeam.Find(id);
            context.RequisitionTeam.Remove(requisitionteam);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionTeamRepository
    {
        IQueryable<RequisitionTeam> All { get; }
        IQueryable<RequisitionTeam> AllIncluding(params Expression<Func<RequisitionTeam, object>>[] includeProperties);
        RequisitionTeam Find(int id);
        void InsertOrUpdate(RequisitionTeam requisitionteam);
        void Delete(int id);
        void Save();
    }
}