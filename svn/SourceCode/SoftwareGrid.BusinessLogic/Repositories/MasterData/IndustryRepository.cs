using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class IndustryRepository : IIndustryRepository
    {
		private readonly RepositoryContext context;

        public IndustryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Industry> All
        {
            get { return context.Industry; }
        }

        public IQueryable<Industry> AllIncluding(params Expression<Func<Industry, object>>[] includeProperties)
        {
            IQueryable<Industry> query = context.Industry;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Industry Find(int id)
        {
            return context.Industry.Find(id);
        }

        public void InsertOrUpdate(Industry industry)
        {
            if (industry.IndustryID == default(int)) {
                // New entity
                context.Industry.Add(industry);
            } else {
                // Existing entity
                context.Entry(industry).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var industry = context.Industry.Find(id);
            context.Industry.Remove(industry);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IIndustryRepository
    {
        IQueryable<Industry> All { get; }
        IQueryable<Industry> AllIncluding(params Expression<Func<Industry, object>>[] includeProperties);
        Industry Find(int id);
        void InsertOrUpdate(Industry industry);
        void Delete(int id);
        void Save();
    }
}