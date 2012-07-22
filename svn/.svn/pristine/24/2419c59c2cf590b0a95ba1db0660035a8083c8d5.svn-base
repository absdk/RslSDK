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
    public class ApplicantDisabilityRepository : IApplicantDisabilityRepository
    {
		private readonly RepositoryContext context;

        public ApplicantDisabilityRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantDisability> All
        {
            get { return context.ApplicantDisability; }
        }

        public IQueryable<ApplicantDisability> AllIncluding(params Expression<Func<ApplicantDisability, object>>[] includeProperties)
        {
            IQueryable<ApplicantDisability> query = context.ApplicantDisability;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantDisability Find(int id)
        {
            return context.ApplicantDisability.Find(id);
        }

        public void InsertOrUpdate(ApplicantDisability applicantdisability)
        {
            if (applicantdisability.ApplicantDisabilityID == default(int)) {
                // New entity
                context.ApplicantDisability.Add(applicantdisability);
            } else {
                // Existing entity
                context.Entry(applicantdisability).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantdisability = context.ApplicantDisability.Find(id);
            context.ApplicantDisability.Remove(applicantdisability);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantDisabilityRepository
    {
        IQueryable<ApplicantDisability> All { get; }
        IQueryable<ApplicantDisability> AllIncluding(params Expression<Func<ApplicantDisability, object>>[] includeProperties);
        ApplicantDisability Find(int id);
        void InsertOrUpdate(ApplicantDisability applicantdisability);
        void Delete(int id);
        void Save();
    }
}