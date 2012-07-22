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
    public class EmploymentLeaveReasonCategoryRepository : IEmploymentLeaveReasonCategoryRepository
    {
		private readonly RepositoryContext context;

        public EmploymentLeaveReasonCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<EmploymentLeaveReasonCategory> All
        {
            get { return context.EmploymentLeaveReasonCategory; }
        }

        public IQueryable<EmploymentLeaveReasonCategory> AllIncluding(params Expression<Func<EmploymentLeaveReasonCategory, object>>[] includeProperties)
        {
            IQueryable<EmploymentLeaveReasonCategory> query = context.EmploymentLeaveReasonCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public EmploymentLeaveReasonCategory Find(int id)
        {
            return context.EmploymentLeaveReasonCategory.Find(id);
        }

        public void InsertOrUpdate(EmploymentLeaveReasonCategory employmentleavereasoncategory)
        {
            if (employmentleavereasoncategory.EmploymentLeaveReasonCategoryID == default(int)) {
                // New entity
                context.EmploymentLeaveReasonCategory.Add(employmentleavereasoncategory);
            } else {
                // Existing entity
                context.Entry(employmentleavereasoncategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var employmentleavereasoncategory = context.EmploymentLeaveReasonCategory.Find(id);
            context.EmploymentLeaveReasonCategory.Remove(employmentleavereasoncategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IEmploymentLeaveReasonCategoryRepository
    {
        IQueryable<EmploymentLeaveReasonCategory> All { get; }
        IQueryable<EmploymentLeaveReasonCategory> AllIncluding(params Expression<Func<EmploymentLeaveReasonCategory, object>>[] includeProperties);
        EmploymentLeaveReasonCategory Find(int id);
        void InsertOrUpdate(EmploymentLeaveReasonCategory employmentleavereasoncategory);
        void Delete(int id);
        void Save();
    }
}