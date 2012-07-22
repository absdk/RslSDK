using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class MaritalStatusRepository : IMaritalStatusRepository
    {
		private readonly RepositoryContext context;

        public MaritalStatusRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<MaritalStatus> All
        {
            get { return context.MaritalStatus; }
        }

        public IQueryable<MaritalStatus> AllIncluding(params Expression<Func<MaritalStatus, object>>[] includeProperties)
        {
            IQueryable<MaritalStatus> query = context.MaritalStatus;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public MaritalStatus Find(int id)
        {
            return context.MaritalStatus.Find(id);
        }

        public void InsertOrUpdate(MaritalStatus maritalstatus)
        {
            if (maritalstatus.MaritalStatusID == default(int)) {
                // New entity
                context.MaritalStatus.Add(maritalstatus);
            } else {
                // Existing entity
                context.Entry(maritalstatus).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var maritalstatus = context.MaritalStatus.Find(id);
            context.MaritalStatus.Remove(maritalstatus);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IMaritalStatusRepository
    {
        IQueryable<MaritalStatus> All { get; }
        IQueryable<MaritalStatus> AllIncluding(params Expression<Func<MaritalStatus, object>>[] includeProperties);
        MaritalStatus Find(int id);
        void InsertOrUpdate(MaritalStatus maritalstatus);
        void Delete(int id);
        void Save();
    }
}