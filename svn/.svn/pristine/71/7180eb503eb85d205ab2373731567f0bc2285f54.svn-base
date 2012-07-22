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
    public class ApplicantSecurityClearanceRepository : IApplicantSecurityClearanceRepository
    {
		private readonly RepositoryContext context;

        public ApplicantSecurityClearanceRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantSecurityClearance> All
        {
            get { return context.ApplicantSecurityClearance; }
        }

        public IQueryable<ApplicantSecurityClearance> AllIncluding(params Expression<Func<ApplicantSecurityClearance, object>>[] includeProperties)
        {
            IQueryable<ApplicantSecurityClearance> query = context.ApplicantSecurityClearance;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantSecurityClearance Find(int id)
        {
            return context.ApplicantSecurityClearance.Find(id);
        }

        public void InsertOrUpdate(ApplicantSecurityClearance applicantsecurityclearance)
        {
            if (applicantsecurityclearance.ApplicantSecurityClearanceID == default(int)) {
                // New entity
                context.ApplicantSecurityClearance.Add(applicantsecurityclearance);
            } else {
                // Existing entity
                context.Entry(applicantsecurityclearance).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantsecurityclearance = context.ApplicantSecurityClearance.Find(id);
            context.ApplicantSecurityClearance.Remove(applicantsecurityclearance);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantSecurityClearanceRepository
    {
        IQueryable<ApplicantSecurityClearance> All { get; }
        IQueryable<ApplicantSecurityClearance> AllIncluding(params Expression<Func<ApplicantSecurityClearance, object>>[] includeProperties);
        ApplicantSecurityClearance Find(int id);
        void InsertOrUpdate(ApplicantSecurityClearance applicantsecurityclearance);
        void Delete(int id);
        void Save();
    }
}