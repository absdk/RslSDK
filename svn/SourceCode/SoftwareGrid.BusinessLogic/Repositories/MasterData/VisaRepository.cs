using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class VisaRepository : IVisaRepository
    {
		private readonly RepositoryContext context;

        public VisaRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Visa> All
        {
            get { return context.Visa; }
        }

        public IQueryable<Visa> AllIncluding(params Expression<Func<Visa, object>>[] includeProperties)
        {
            IQueryable<Visa> query = context.Visa;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Visa Find(int id)
        {
            return context.Visa.Find(id);
        }

        public void InsertOrUpdate(Visa visa)
        {
            if (visa.VisaID == default(int)) {
                // New entity
                context.Visa.Add(visa);
            } else {
                // Existing entity
                context.Entry(visa).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var visa = context.Visa.Find(id);
            context.Visa.Remove(visa);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVisaRepository
    {
        IQueryable<Visa> All { get; }
        IQueryable<Visa> AllIncluding(params Expression<Func<Visa, object>>[] includeProperties);
        Visa Find(int id);
        void InsertOrUpdate(Visa visa);
        void Delete(int id);
        void Save();
    }
}