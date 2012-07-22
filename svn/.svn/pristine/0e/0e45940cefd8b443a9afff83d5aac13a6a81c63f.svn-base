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
    public class RequisitionClientTeamRepository : IRequisitionClientTeamRepository
    {
		private readonly RepositoryContext context;

        public RequisitionClientTeamRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionClientTeam> All
        {
            get { return context.RequisitionClientTeam; }
        }

        public IQueryable<RequisitionClientTeam> AllIncluding(params Expression<Func<RequisitionClientTeam, object>>[] includeProperties)
        {
            IQueryable<RequisitionClientTeam> query = context.RequisitionClientTeam;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionClientTeam Find(int id)
        {
            return context.RequisitionClientTeam.Find(id);
        }

        public void InsertOrUpdate(RequisitionClientTeam requisitionclientteam)
        {
            if (requisitionclientteam.RequisitionClientTeamID == default(int)) {
                // New entity
                context.RequisitionClientTeam.Add(requisitionclientteam);
            } else {
                // Existing entity
                context.Entry(requisitionclientteam).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionclientteam = context.RequisitionClientTeam.Find(id);
            context.RequisitionClientTeam.Remove(requisitionclientteam);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionClientTeamRepository
    {
        IQueryable<RequisitionClientTeam> All { get; }
        IQueryable<RequisitionClientTeam> AllIncluding(params Expression<Func<RequisitionClientTeam, object>>[] includeProperties);
        RequisitionClientTeam Find(int id);
        void InsertOrUpdate(RequisitionClientTeam requisitionclientteam);
        void Delete(int id);
        void Save();
    }
}