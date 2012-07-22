using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class SalaryRateTypeRepository : ISalaryRateTypeRepository
    {
		private readonly RepositoryContext context;

        public SalaryRateTypeRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SalaryRateType> All
        {
            get { return context.SalaryRateType; }
        }

        public IQueryable<SalaryRateType> AllIncluding(params Expression<Func<SalaryRateType, object>>[] includeProperties)
        {
            IQueryable<SalaryRateType> query = context.SalaryRateType;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SalaryRateType Find(int id)
        {
            return context.SalaryRateType.Find(id);
        }

        public void InsertOrUpdate(SalaryRateType salaryratetype)
        {
            if (salaryratetype.SalaryRateTypeID == default(int)) {
                // New entity
                context.SalaryRateType.Add(salaryratetype);
            } else {
                // Existing entity
                context.Entry(salaryratetype).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var salaryratetype = context.SalaryRateType.Find(id);
            context.SalaryRateType.Remove(salaryratetype);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISalaryRateTypeRepository
    {
        IQueryable<SalaryRateType> All { get; }
        IQueryable<SalaryRateType> AllIncluding(params Expression<Func<SalaryRateType, object>>[] includeProperties);
        SalaryRateType Find(int id);
        void InsertOrUpdate(SalaryRateType salaryratetype);
        void Delete(int id);
        void Save();
    }
}