using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class SalaryTaxTypeRepository : ISalaryTaxTypeRepository
    {
		private readonly RepositoryContext context;

        public SalaryTaxTypeRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SalaryTaxType> All
        {
            get { return context.SalaryTaxType; }
        }

        public IQueryable<SalaryTaxType> AllIncluding(params Expression<Func<SalaryTaxType, object>>[] includeProperties)
        {
            IQueryable<SalaryTaxType> query = context.SalaryTaxType;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SalaryTaxType Find(int id)
        {
            return context.SalaryTaxType.Find(id);
        }

        public void InsertOrUpdate(SalaryTaxType salarytaxtype)
        {
            if (salarytaxtype.SalaryTaxTypeID == default(int)) {
                // New entity
                context.SalaryTaxType.Add(salarytaxtype);
            } else {
                // Existing entity
                context.Entry(salarytaxtype).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var salarytaxtype = context.SalaryTaxType.Find(id);
            context.SalaryTaxType.Remove(salarytaxtype);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISalaryTaxTypeRepository
    {
        IQueryable<SalaryTaxType> All { get; }
        IQueryable<SalaryTaxType> AllIncluding(params Expression<Func<SalaryTaxType, object>>[] includeProperties);
        SalaryTaxType Find(int id);
        void InsertOrUpdate(SalaryTaxType salarytaxtype);
        void Delete(int id);
        void Save();
    }
}