using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class VeteranCategoryRepository : IVeteranCategoryRepository
    {
		private readonly RepositoryContext context;

        public VeteranCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VeteranCategory> All
        {
            get { return context.VeteranCategory; }
        }

        public IQueryable<VeteranCategory> AllIncluding(params Expression<Func<VeteranCategory, object>>[] includeProperties)
        {
            IQueryable<VeteranCategory> query = context.VeteranCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VeteranCategory Find(int id)
        {
            return context.VeteranCategory.Find(id);
        }

        public void InsertOrUpdate(VeteranCategory veterancategory)
        {
            if (veterancategory.VeteranCategoryID == default(int)) {
                // New entity
                context.VeteranCategory.Add(veterancategory);
            } else {
                // Existing entity
                context.Entry(veterancategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var veterancategory = context.VeteranCategory.Find(id);
            context.VeteranCategory.Remove(veterancategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVeteranCategoryRepository
    {
        IQueryable<VeteranCategory> All { get; }
        IQueryable<VeteranCategory> AllIncluding(params Expression<Func<VeteranCategory, object>>[] includeProperties);
        VeteranCategory Find(int id);
        void InsertOrUpdate(VeteranCategory veterancategory);
        void Delete(int id);
        void Save();
    }
}