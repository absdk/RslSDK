using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.BusinessLogic.Repositories.Context;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class SkillsExpEduCategoryRepository : ISkillsExpEduCategoryRepository
    {
		private readonly RepositoryContext context;

        public SkillsExpEduCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SkillsExpEduCategory> All
        {
            get { return context.SkillsExpEduCategory; }
        }

        public IQueryable<SkillsExpEduCategory> AllIncluding(params Expression<Func<SkillsExpEduCategory, object>>[] includeProperties)
        {
            IQueryable<SkillsExpEduCategory> query = context.SkillsExpEduCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SkillsExpEduCategory Find(int id)
        {
            return context.SkillsExpEduCategory.Find(id);
        }

        public void InsertOrUpdate(SkillsExpEduCategory skillsexpeducategory)
        {
            if (skillsexpeducategory.SkillsExpEduCategoryID == default(int)) {
                // New entity
                context.SkillsExpEduCategory.Add(skillsexpeducategory);
            } else {
                // Existing entity
                context.Entry(skillsexpeducategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var skillsexpeducategory = context.SkillsExpEduCategory.Find(id);
            context.SkillsExpEduCategory.Remove(skillsexpeducategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISkillsExpEduCategoryRepository
    {
        IQueryable<SkillsExpEduCategory> All { get; }
        IQueryable<SkillsExpEduCategory> AllIncluding(params Expression<Func<SkillsExpEduCategory, object>>[] includeProperties);
        SkillsExpEduCategory Find(int id);
        void InsertOrUpdate(SkillsExpEduCategory skillsexpeducategory);
        void Delete(int id);
        void Save();
    }
}