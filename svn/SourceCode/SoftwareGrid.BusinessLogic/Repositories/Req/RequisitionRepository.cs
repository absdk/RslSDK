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
    public class RequisitionRepository : IRequisitionRepository
    {
		private readonly RepositoryContext context;

        public RequisitionRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Requisition> All
        {
            get { return context.Requisition; }
        }

        public IQueryable<Requisition> AllIncluding(params Expression<Func<Requisition, object>>[] includeProperties)
        {
            IQueryable<Requisition> query = context.Requisition;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Requisition Find(int id)
        {
            return context.Requisition.Find(id);
        }

        public void InsertOrUpdate(Requisition requisition)
        {
            if (requisition.RequisitionID == default(int)) {
                // New entity
                context.Requisition.Add(requisition);
            } else {
                // Existing entity
                context.Entry(requisition).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisition = context.Requisition.Find(id);
            context.Requisition.Remove(requisition);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionRepository
    {
        IQueryable<Requisition> All { get; }
        IQueryable<Requisition> AllIncluding(params Expression<Func<Requisition, object>>[] includeProperties);
        Requisition Find(int id);
        void InsertOrUpdate(Requisition requisition);
        void Delete(int id);
        void Save();
    }
}