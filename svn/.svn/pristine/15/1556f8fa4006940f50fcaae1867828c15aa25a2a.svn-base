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
    public class SkillsExpEduRepository : ISkillsExpEduRepository
    {
		private readonly RepositoryContext context;

        public SkillsExpEduRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SkillsExpEdu> All
        {
            get { return context.SkillsExpEdu; }
        }

        public IQueryable<SkillsExpEdu> AllIncluding(params Expression<Func<SkillsExpEdu, object>>[] includeProperties)
        {
            IQueryable<SkillsExpEdu> query = context.SkillsExpEdu;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SkillsExpEdu Find(int id)
        {
            return context.SkillsExpEdu.Find(id);
        }

        public void InsertOrUpdate(SkillsExpEdu skillsexpedu)
        {
            if (skillsexpedu.SkillsExpEduID == default(int)) {
                // New entity
                context.SkillsExpEdu.Add(skillsexpedu);
            } else {
                // Existing entity
                context.Entry(skillsexpedu).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var skillsexpedu = context.SkillsExpEdu.Find(id);
            context.SkillsExpEdu.Remove(skillsexpedu);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISkillsExpEduRepository
    {
        IQueryable<SkillsExpEdu> All { get; }
        IQueryable<SkillsExpEdu> AllIncluding(params Expression<Func<SkillsExpEdu, object>>[] includeProperties);
        SkillsExpEdu Find(int id);
        void InsertOrUpdate(SkillsExpEdu skillsexpedu);
        void Delete(int id);
        void Save();
    }
}