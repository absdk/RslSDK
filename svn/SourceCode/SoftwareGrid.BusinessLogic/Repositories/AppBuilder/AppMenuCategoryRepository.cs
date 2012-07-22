using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class AppMenuCategoryRepository : IAppMenuCategoryRepository
    {
		private readonly RepositoryContext context;

        public AppMenuCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<AppMenuCategory> All
        {
            get { return context.AppMenuCategory; }
        }

        public IQueryable<AppMenuCategory> AllIncluding(params Expression<Func<AppMenuCategory, object>>[] includeProperties)
        {
            IQueryable<AppMenuCategory> query = context.AppMenuCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public AppMenuCategory Find(int id)
        {
            return context.AppMenuCategory.Find(id);
        }

        public void InsertOrUpdate(AppMenuCategory appmenucategory)
        {
            if (appmenucategory.AppMenuCategoryID == default(int)) {
                // New entity
                context.AppMenuCategory.Add(appmenucategory);
            } else {
                // Existing entity
                context.Entry(appmenucategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var appmenucategory = context.AppMenuCategory.Find(id);
            context.AppMenuCategory.Remove(appmenucategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IAppMenuCategoryRepository
    {
        IQueryable<AppMenuCategory> All { get; }
        IQueryable<AppMenuCategory> AllIncluding(params Expression<Func<AppMenuCategory, object>>[] includeProperties);
        AppMenuCategory Find(int id);
        void InsertOrUpdate(AppMenuCategory appmenucategory);
        void Delete(int id);
        void Save();
    }
}