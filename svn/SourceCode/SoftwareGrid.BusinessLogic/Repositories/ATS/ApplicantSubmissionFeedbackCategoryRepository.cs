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
    public class ApplicantSubmissionFeedbackCategoryRepository : IApplicantSubmissionFeedbackCategoryRepository
    {
		private readonly RepositoryContext context;

        public ApplicantSubmissionFeedbackCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantSubmissionFeedbackCategory> All
        {
            get { return context.ApplicantSubmissionFeedbackCategory; }
        }

        public IQueryable<ApplicantSubmissionFeedbackCategory> AllIncluding(params Expression<Func<ApplicantSubmissionFeedbackCategory, object>>[] includeProperties)
        {
            IQueryable<ApplicantSubmissionFeedbackCategory> query = context.ApplicantSubmissionFeedbackCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantSubmissionFeedbackCategory Find(int id)
        {
            return context.ApplicantSubmissionFeedbackCategory.Find(id);
        }

        public void InsertOrUpdate(ApplicantSubmissionFeedbackCategory applicantsubmissionfeedbackcategory)
        {
            if (applicantsubmissionfeedbackcategory.ApplicantSubmissionFeedbackCategoryID == default(int)) {
                // New entity
                context.ApplicantSubmissionFeedbackCategory.Add(applicantsubmissionfeedbackcategory);
            } else {
                // Existing entity
                context.Entry(applicantsubmissionfeedbackcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantsubmissionfeedbackcategory = context.ApplicantSubmissionFeedbackCategory.Find(id);
            context.ApplicantSubmissionFeedbackCategory.Remove(applicantsubmissionfeedbackcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantSubmissionFeedbackCategoryRepository
    {
        IQueryable<ApplicantSubmissionFeedbackCategory> All { get; }
        IQueryable<ApplicantSubmissionFeedbackCategory> AllIncluding(params Expression<Func<ApplicantSubmissionFeedbackCategory, object>>[] includeProperties);
        ApplicantSubmissionFeedbackCategory Find(int id);
        void InsertOrUpdate(ApplicantSubmissionFeedbackCategory applicantsubmissionfeedbackcategory);
        void Delete(int id);
        void Save();
    }
}