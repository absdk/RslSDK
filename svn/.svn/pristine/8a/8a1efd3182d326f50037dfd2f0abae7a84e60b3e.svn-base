using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class GenderRepository : IGenderRepository
    {
		private readonly RepositoryContext context;

        public GenderRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Gender> All
        {
            get { return context.Gender; }
        }

        public IQueryable<Gender> AllIncluding(params Expression<Func<Gender, object>>[] includeProperties)
        {
            IQueryable<Gender> query = context.Gender;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Gender Find(int id)
        {
            return context.Gender.Find(id);
        }

        public void InsertOrUpdate(Gender gender)
        {
            if (gender.GenderID == default(int)) {
                // New entity
                context.Gender.Add(gender);
            } else {
                // Existing entity
                context.Entry(gender).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var gender = context.Gender.Find(id);
            context.Gender.Remove(gender);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IGenderRepository
    {
        IQueryable<Gender> All { get; }
        IQueryable<Gender> AllIncluding(params Expression<Func<Gender, object>>[] includeProperties);
        Gender Find(int id);
        void InsertOrUpdate(Gender gender);
        void Delete(int id);
        void Save();
    }
}