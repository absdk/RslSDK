using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class ExperienceLevelCategoryRepository : IExperienceLevelCategoryRepository
    {
		private readonly RepositoryContext context;

        public ExperienceLevelCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ExperienceLevelCategory> All
        {
            get { return context.ExperienceLevelCategory; }
        }

        public IQueryable<ExperienceLevelCategory> AllIncluding(params Expression<Func<ExperienceLevelCategory, object>>[] includeProperties)
        {
            IQueryable<ExperienceLevelCategory> query = context.ExperienceLevelCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ExperienceLevelCategory Find(int id)
        {
            return context.ExperienceLevelCategory.Find(id);
        }

        public void InsertOrUpdate(ExperienceLevelCategory experiencelevelcategory)
        {
            if (experiencelevelcategory.ExperienceLevelCategoryID == default(int)) {
                // New entity
                context.ExperienceLevelCategory.Add(experiencelevelcategory);
            } else {
                // Existing entity
                context.Entry(experiencelevelcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var experiencelevelcategory = context.ExperienceLevelCategory.Find(id);
            context.ExperienceLevelCategory.Remove(experiencelevelcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IExperienceLevelCategoryRepository
    {
        IQueryable<ExperienceLevelCategory> All { get; }
        IQueryable<ExperienceLevelCategory> AllIncluding(params Expression<Func<ExperienceLevelCategory, object>>[] includeProperties);
        ExperienceLevelCategory Find(int id);
        void InsertOrUpdate(ExperienceLevelCategory experiencelevelcategory);
        void Delete(int id);
        void Save();
    }
}