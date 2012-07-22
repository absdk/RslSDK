using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class SalutationRepository : ISalutationRepository
    {
		private readonly RepositoryContext context;

        public SalutationRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Salutation> All
        {
            get { return context.Salutation; }
        }

        public IQueryable<Salutation> AllIncluding(params Expression<Func<Salutation, object>>[] includeProperties)
        {
            IQueryable<Salutation> query = context.Salutation;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Salutation Find(int id)
        {
            return context.Salutation.Find(id);
        }

        public void InsertOrUpdate(Salutation salutation)
        {
            if (salutation.SalutationID == default(int)) {
                // New entity
                context.Salutation.Add(salutation);
            } else {
                // Existing entity
                context.Entry(salutation).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var salutation = context.Salutation.Find(id);
            context.Salutation.Remove(salutation);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISalutationRepository
    {
        IQueryable<Salutation> All { get; }
        IQueryable<Salutation> AllIncluding(params Expression<Func<Salutation, object>>[] includeProperties);
        Salutation Find(int id);
        void InsertOrUpdate(Salutation salutation);
        void Delete(int id);
        void Save();
    }
}