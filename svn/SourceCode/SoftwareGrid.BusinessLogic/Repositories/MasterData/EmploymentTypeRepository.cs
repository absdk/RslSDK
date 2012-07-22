using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class EmploymentTypeRepository : IEmploymentTypeRepository
    {
		private readonly RepositoryContext context;

        public EmploymentTypeRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<EmploymentType> All
        {
            get { return context.EmploymentType; }
        }

        public IQueryable<EmploymentType> AllIncluding(params Expression<Func<EmploymentType, object>>[] includeProperties)
        {
            IQueryable<EmploymentType> query = context.EmploymentType;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public EmploymentType Find(int id)
        {
            return context.EmploymentType.Find(id);
        }

        public void InsertOrUpdate(EmploymentType employmenttype)
        {
            if (employmenttype.EmploymentTypeID == default(int)) {
                // New entity
                context.EmploymentType.Add(employmenttype);
            } else {
                // Existing entity
                context.Entry(employmenttype).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var employmenttype = context.EmploymentType.Find(id);
            context.EmploymentType.Remove(employmenttype);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IEmploymentTypeRepository
    {
        IQueryable<EmploymentType> All { get; }
        IQueryable<EmploymentType> AllIncluding(params Expression<Func<EmploymentType, object>>[] includeProperties);
        EmploymentType Find(int id);
        void InsertOrUpdate(EmploymentType employmenttype);
        void Delete(int id);
        void Save();
    }
}