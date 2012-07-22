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
    public class ApplicantDataPrivacyAcknowledgementRepository : IApplicantDataPrivacyAcknowledgementRepository
    {
		private readonly RepositoryContext context;

        public ApplicantDataPrivacyAcknowledgementRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantDataPrivacyAcknowledgement> All
        {
            get { return context.ApplicantDataPrivacyAcknowledgement; }
        }

        public IQueryable<ApplicantDataPrivacyAcknowledgement> AllIncluding(params Expression<Func<ApplicantDataPrivacyAcknowledgement, object>>[] includeProperties)
        {
            IQueryable<ApplicantDataPrivacyAcknowledgement> query = context.ApplicantDataPrivacyAcknowledgement;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantDataPrivacyAcknowledgement Find(int id)
        {
            return context.ApplicantDataPrivacyAcknowledgement.Find(id);
        }

        public void InsertOrUpdate(ApplicantDataPrivacyAcknowledgement applicantdataprivacyacknowledgement)
        {
            if (applicantdataprivacyacknowledgement.ApplicantDataPrivacyAcknowledgementID == default(int)) {
                // New entity
                context.ApplicantDataPrivacyAcknowledgement.Add(applicantdataprivacyacknowledgement);
            } else {
                // Existing entity
                context.Entry(applicantdataprivacyacknowledgement).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantdataprivacyacknowledgement = context.ApplicantDataPrivacyAcknowledgement.Find(id);
            context.ApplicantDataPrivacyAcknowledgement.Remove(applicantdataprivacyacknowledgement);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantDataPrivacyAcknowledgementRepository
    {
        IQueryable<ApplicantDataPrivacyAcknowledgement> All { get; }
        IQueryable<ApplicantDataPrivacyAcknowledgement> AllIncluding(params Expression<Func<ApplicantDataPrivacyAcknowledgement, object>>[] includeProperties);
        ApplicantDataPrivacyAcknowledgement Find(int id);
        void InsertOrUpdate(ApplicantDataPrivacyAcknowledgement applicantdataprivacyacknowledgement);
        void Delete(int id);
        void Save();
    }
}