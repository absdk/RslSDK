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
    public class DepartmentRepository : IDepartmentRepository
    {
		private readonly RepositoryContext context;

        public DepartmentRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Department> All
        {
            get { return context.Department; }
        }

        public IQueryable<Department> AllIncluding(params Expression<Func<Department, object>>[] includeProperties)
        {
            IQueryable<Department> query = context.Department;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Department Find(int id)
        {
            return context.Department.Find(id);
        }

        public void InsertOrUpdate(Department department)
        {
            if (department.DepartmentID == default(int)) {
                // New entity
                context.Department.Add(department);
            } else {
                // Existing entity
                context.Entry(department).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var department = context.Department.Find(id);
            context.Department.Remove(department);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IDepartmentRepository
    {
        IQueryable<Department> All { get; }
        IQueryable<Department> AllIncluding(params Expression<Func<Department, object>>[] includeProperties);
        Department Find(int id);
        void InsertOrUpdate(Department department);
        void Delete(int id);
        void Save();
    }
}