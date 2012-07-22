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
    public class ApplicantInterviewFeedbackCategoryRepository : IApplicantInterviewFeedbackCategoryRepository
    {
		private readonly RepositoryContext context;

        public ApplicantInterviewFeedbackCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantInterviewFeedbackCategory> All
        {
            get { return context.ApplicantInterviewFeedbackCategory; }
        }

        public IQueryable<ApplicantInterviewFeedbackCategory> AllIncluding(params Expression<Func<ApplicantInterviewFeedbackCategory, object>>[] includeProperties)
        {
            IQueryable<ApplicantInterviewFeedbackCategory> query = context.ApplicantInterviewFeedbackCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantInterviewFeedbackCategory Find(int id)
        {
            return context.ApplicantInterviewFeedbackCategory.Find(id);
        }

        public void InsertOrUpdate(ApplicantInterviewFeedbackCategory applicantinterviewfeedbackcategory)
        {
            if (applicantinterviewfeedbackcategory.ApplicantInterviewFeedbackCategoryID == default(int)) {
                // New entity
                context.ApplicantInterviewFeedbackCategory.Add(applicantinterviewfeedbackcategory);
            } else {
                // Existing entity
                context.Entry(applicantinterviewfeedbackcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantinterviewfeedbackcategory = context.ApplicantInterviewFeedbackCategory.Find(id);
            context.ApplicantInterviewFeedbackCategory.Remove(applicantinterviewfeedbackcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantInterviewFeedbackCategoryRepository
    {
        IQueryable<ApplicantInterviewFeedbackCategory> All { get; }
        IQueryable<ApplicantInterviewFeedbackCategory> AllIncluding(params Expression<Func<ApplicantInterviewFeedbackCategory, object>>[] includeProperties);
        ApplicantInterviewFeedbackCategory Find(int id);
        void InsertOrUpdate(ApplicantInterviewFeedbackCategory applicantinterviewfeedbackcategory);
        void Delete(int id);
        void Save();
    }
}