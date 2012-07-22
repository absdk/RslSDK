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
    public class ApplicantSkillsExpertiseRepository : IApplicantSkillsExpertiseRepository
    {
		private readonly RepositoryContext context;

        public ApplicantSkillsExpertiseRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantSkillsExpertise> All
        {
            get { return context.ApplicantSkillsExpertise; }
        }

        public IQueryable<ApplicantSkillsExpertise> AllIncluding(int applicantId,params Expression<Func<ApplicantSkillsExpertise, object>>[] includeProperties)
        {
            IQueryable<ApplicantSkillsExpertise> query = context.ApplicantSkillsExpertise;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.ApplicantID==applicantId);
        }

        public ApplicantSkillsExpertise Find(int id)
        {
            return context.ApplicantSkillsExpertise.Find(id);
        }

        public void InsertOrUpdate(ApplicantSkillsExpertise applicantskillsexpertise)
        {
            if (applicantskillsexpertise.ApplicantSkillsExpertiseID == default(int)) {
                // New entity
                context.ApplicantSkillsExpertise.Add(applicantskillsexpertise);
            } else {
                // Existing entity
                context.Entry(applicantskillsexpertise).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantskillsexpertise = context.ApplicantSkillsExpertise.Find(id);
            context.ApplicantSkillsExpertise.Remove(applicantskillsexpertise);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantSkillsExpertiseRepository
    {
        IQueryable<ApplicantSkillsExpertise> All { get; }
        IQueryable<ApplicantSkillsExpertise> AllIncluding(int applicantId,params Expression<Func<ApplicantSkillsExpertise, object>>[] includeProperties);
        ApplicantSkillsExpertise Find(int id);
        void InsertOrUpdate(ApplicantSkillsExpertise applicantskillsexpertise);
        void Delete(int id);
        void Save();
    }
}