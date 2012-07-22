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
    public class ApplicantDocumentTrackingRepository : IApplicantDocumentTrackingRepository
    {
		private readonly RepositoryContext context;

        public ApplicantDocumentTrackingRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantDocumentTracking> All
        {
            get { return context.ApplicantDocumentTracking; }
        }

        public IQueryable<ApplicantDocumentTracking> AllIncluding(params Expression<Func<ApplicantDocumentTracking, object>>[] includeProperties)
        {
            IQueryable<ApplicantDocumentTracking> query = context.ApplicantDocumentTracking;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantDocumentTracking Find(int id)
        {
            return context.ApplicantDocumentTracking.Find(id);
        }

        public void InsertOrUpdate(ApplicantDocumentTracking applicantdocumenttracking)
        {
            if (applicantdocumenttracking.ApplicantDocumentTrackingID == default(int)) {
                // New entity
                context.ApplicantDocumentTracking.Add(applicantdocumenttracking);
            } else {
                // Existing entity
                context.Entry(applicantdocumenttracking).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantdocumenttracking = context.ApplicantDocumentTracking.Find(id);
            context.ApplicantDocumentTracking.Remove(applicantdocumenttracking);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantDocumentTrackingRepository
    {
        IQueryable<ApplicantDocumentTracking> All { get; }
        IQueryable<ApplicantDocumentTracking> AllIncluding(params Expression<Func<ApplicantDocumentTracking, object>>[] includeProperties);
        ApplicantDocumentTracking Find(int id);
        void InsertOrUpdate(ApplicantDocumentTracking applicantdocumenttracking);
        void Delete(int id);
        void Save();
    }
}