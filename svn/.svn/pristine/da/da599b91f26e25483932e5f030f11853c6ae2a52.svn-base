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
    public class SkillsExpEduSynonymRepository : ISkillsExpEduSynonymRepository
    {
		private readonly RepositoryContext context;

        public SkillsExpEduSynonymRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SkillsExpEduSynonym> All
        {
            get { return context.SkillsExpEduSynonym; }
        }

        public IQueryable<SkillsExpEduSynonym> AllIncluding(params Expression<Func<SkillsExpEduSynonym, object>>[] includeProperties)
        {
            IQueryable<SkillsExpEduSynonym> query = context.SkillsExpEduSynonym;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SkillsExpEduSynonym Find(int id)
        {
            return context.SkillsExpEduSynonym.Find(id);
        }

        public void InsertOrUpdate(SkillsExpEduSynonym skillsexpedusynonym)
        {
            if (skillsexpedusynonym.SkillsExpEduSynonymID == default(int)) {
                // New entity
                context.SkillsExpEduSynonym.Add(skillsexpedusynonym);
            } else {
                // Existing entity
                context.Entry(skillsexpedusynonym).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var skillsexpedusynonym = context.SkillsExpEduSynonym.Find(id);
            context.SkillsExpEduSynonym.Remove(skillsexpedusynonym);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISkillsExpEduSynonymRepository
    {
        IQueryable<SkillsExpEduSynonym> All { get; }
        IQueryable<SkillsExpEduSynonym> AllIncluding(params Expression<Func<SkillsExpEduSynonym, object>>[] includeProperties);
        SkillsExpEduSynonym Find(int id);
        void InsertOrUpdate(SkillsExpEduSynonym skillsexpedusynonym);
        void Delete(int id);
        void Save();
    }
}