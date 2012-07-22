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
    public class ApplicantDriverLicenseRepository : IApplicantDriverLicenseRepository
    {
		private readonly RepositoryContext context;

        public ApplicantDriverLicenseRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantDriverLicense> All
        {
            get { return context.ApplicantDriverLicense; }
        }

        public IQueryable<ApplicantDriverLicense> AllIncluding(params Expression<Func<ApplicantDriverLicense, object>>[] includeProperties)
        {
            IQueryable<ApplicantDriverLicense> query = context.ApplicantDriverLicense;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantDriverLicense Find(int id)
        {
            return context.ApplicantDriverLicense.Find(id);
        }

        public void InsertOrUpdate(ApplicantDriverLicense applicantdriverlicense)
        {
            if (applicantdriverlicense.ApplicantDriverLicenseID == default(int)) {
                // New entity
                context.ApplicantDriverLicense.Add(applicantdriverlicense);
            } else {
                // Existing entity
                context.Entry(applicantdriverlicense).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantdriverlicense = context.ApplicantDriverLicense.Find(id);
            context.ApplicantDriverLicense.Remove(applicantdriverlicense);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantDriverLicenseRepository
    {
        IQueryable<ApplicantDriverLicense> All { get; }
        IQueryable<ApplicantDriverLicense> AllIncluding(params Expression<Func<ApplicantDriverLicense, object>>[] includeProperties);
        ApplicantDriverLicense Find(int id);
        void InsertOrUpdate(ApplicantDriverLicense applicantdriverlicense);
        void Delete(int id);
        void Save();
    }
}