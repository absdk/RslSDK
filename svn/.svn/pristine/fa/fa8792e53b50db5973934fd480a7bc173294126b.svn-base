using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class EmploymentStatusRepository : IEmploymentStatusRepository
    {
		private readonly RepositoryContext context;

        public EmploymentStatusRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<EmploymentStatus> All
        {
            get { return context.EmploymentStatus; }
        }

        public IQueryable<EmploymentStatus> AllIncluding(params Expression<Func<EmploymentStatus, object>>[] includeProperties)
        {
            IQueryable<EmploymentStatus> query = context.EmploymentStatus;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public EmploymentStatus Find(int id)
        {
            return context.EmploymentStatus.Find(id);
        }

        public void InsertOrUpdate(EmploymentStatus employmentstatus)
        {
            if (employmentstatus.EmploymentStatusID == default(int)) {
                // New entity
                context.EmploymentStatus.Add(employmentstatus);
            } else {
                // Existing entity
                context.Entry(employmentstatus).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var employmentstatus = context.EmploymentStatus.Find(id);
            context.EmploymentStatus.Remove(employmentstatus);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IEmploymentStatusRepository
    {
        IQueryable<EmploymentStatus> All { get; }
        IQueryable<EmploymentStatus> AllIncluding(params Expression<Func<EmploymentStatus, object>>[] includeProperties);
        EmploymentStatus Find(int id);
        void InsertOrUpdate(EmploymentStatus employmentstatus);
        void Delete(int id);
        void Save();
    }
}