using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class VisaStatusRepository : IVisaStatusRepository
    {
		private readonly RepositoryContext context;

        public VisaStatusRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VisaStatus> All
        {
            get { return context.VisaStatus; }
        }

        public IQueryable<VisaStatus> AllIncluding(params Expression<Func<VisaStatus, object>>[] includeProperties)
        {
            IQueryable<VisaStatus> query = context.VisaStatus;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VisaStatus Find(int id)
        {
            return context.VisaStatus.Find(id);
        }

        public void InsertOrUpdate(VisaStatus visastatus)
        {
            if (visastatus.VisaStatusID == default(int)) {
                // New entity
                context.VisaStatus.Add(visastatus);
            } else {
                // Existing entity
                context.Entry(visastatus).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var visastatus = context.VisaStatus.Find(id);
            context.VisaStatus.Remove(visastatus);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVisaStatusRepository
    {
        IQueryable<VisaStatus> All { get; }
        IQueryable<VisaStatus> AllIncluding(params Expression<Func<VisaStatus, object>>[] includeProperties);
        VisaStatus Find(int id);
        void InsertOrUpdate(VisaStatus visastatus);
        void Delete(int id);
        void Save();
    }
}