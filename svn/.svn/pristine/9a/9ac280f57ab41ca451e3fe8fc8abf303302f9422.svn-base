using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class ReligionRepository : IReligionRepository
    {
		private readonly RepositoryContext context;

        public ReligionRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Religion> All
        {
            get { return context.Religion; }
        }

        public IQueryable<Religion> AllIncluding(params Expression<Func<Religion, object>>[] includeProperties)
        {
            IQueryable<Religion> query = context.Religion;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Religion Find(int id)
        {
            return context.Religion.Find(id);
        }

        public void InsertOrUpdate(Religion religion)
        {
            if (religion.ReligionID == default(int)) {
                // New entity
                context.Religion.Add(religion);
            } else {
                // Existing entity
                context.Entry(religion).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var religion = context.Religion.Find(id);
            context.Religion.Remove(religion);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IReligionRepository
    {
        IQueryable<Religion> All { get; }
        IQueryable<Religion> AllIncluding(params Expression<Func<Religion, object>>[] includeProperties);
        Religion Find(int id);
        void InsertOrUpdate(Religion religion);
        void Delete(int id);
        void Save();
    }
}