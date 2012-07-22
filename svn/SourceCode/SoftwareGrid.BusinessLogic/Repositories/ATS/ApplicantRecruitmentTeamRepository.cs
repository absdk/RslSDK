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
    public class ApplicantRecruitmentTeamRepository : IApplicantRecruitmentTeamRepository
    {
		private readonly RepositoryContext context;

        public ApplicantRecruitmentTeamRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantRecruitmentTeam> All
        {
            get { return context.ApplicantRecruitmentTeam; }
        }

        public IQueryable<ApplicantRecruitmentTeam> AllIncluding(params Expression<Func<ApplicantRecruitmentTeam, object>>[] includeProperties)
        {
            IQueryable<ApplicantRecruitmentTeam> query = context.ApplicantRecruitmentTeam;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantRecruitmentTeam Find(int id)
        {
            return context.ApplicantRecruitmentTeam.Find(id);
        }

        public void InsertOrUpdate(ApplicantRecruitmentTeam applicantrecruitmentteam)
        {
            if (applicantrecruitmentteam.ApplicantRecruitmentTeamID == default(int)) {
                // New entity
                context.ApplicantRecruitmentTeam.Add(applicantrecruitmentteam);
            } else {
                // Existing entity
                context.Entry(applicantrecruitmentteam).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantrecruitmentteam = context.ApplicantRecruitmentTeam.Find(id);
            context.ApplicantRecruitmentTeam.Remove(applicantrecruitmentteam);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantRecruitmentTeamRepository
    {
        IQueryable<ApplicantRecruitmentTeam> All { get; }
        IQueryable<ApplicantRecruitmentTeam> AllIncluding(params Expression<Func<ApplicantRecruitmentTeam, object>>[] includeProperties);
        ApplicantRecruitmentTeam Find(int id);
        void InsertOrUpdate(ApplicantRecruitmentTeam applicantrecruitmentteam);
        void Delete(int id);
        void Save();
    }
}