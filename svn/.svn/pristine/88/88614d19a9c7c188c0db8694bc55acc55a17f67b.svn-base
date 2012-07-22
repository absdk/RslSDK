using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class DisabilityRepository : IDisabilityRepository
    {
		private readonly RepositoryContext context;

        public DisabilityRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Disability> All
        {
            get { return context.Disability; }
        }

        public IQueryable<Disability> AllIncluding(params Expression<Func<Disability, object>>[] includeProperties)
        {
            IQueryable<Disability> query = context.Disability;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Disability Find(int id)
        {
            return context.Disability.Find(id);
        }

        public void InsertOrUpdate(Disability disability)
        {
            if (disability.DisabilityID == default(int)) {
                // New entity
                context.Disability.Add(disability);
            } else {
                // Existing entity
                context.Entry(disability).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var disability = context.Disability.Find(id);
            context.Disability.Remove(disability);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IDisabilityRepository
    {
        IQueryable<Disability> All { get; }
        IQueryable<Disability> AllIncluding(params Expression<Func<Disability, object>>[] includeProperties);
        Disability Find(int id);
        void InsertOrUpdate(Disability disability);
        void Delete(int id);
        void Save();
    }
}