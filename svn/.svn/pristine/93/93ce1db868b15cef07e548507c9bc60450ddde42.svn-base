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
    public class ApplicantWorkReferenceRecommendationRepository : IApplicantWorkReferenceRecommendationRepository
    {
		private readonly RepositoryContext context;

        public ApplicantWorkReferenceRecommendationRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantWorkReferenceRecommendation> All
        {
            get { return context.ApplicantWorkReferenceRecommendation; }
        }

        public IQueryable<ApplicantWorkReferenceRecommendation> AllIncluding(params Expression<Func<ApplicantWorkReferenceRecommendation, object>>[] includeProperties)
        {
            IQueryable<ApplicantWorkReferenceRecommendation> query = context.ApplicantWorkReferenceRecommendation;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantWorkReferenceRecommendation Find(int id)
        {
            return context.ApplicantWorkReferenceRecommendation.Find(id);
        }

        public void InsertOrUpdate(ApplicantWorkReferenceRecommendation applicantworkreferencerecommendation)
        {
            if (applicantworkreferencerecommendation.ApplicantWorkReferenceRecommendationID == default(int)) {
                // New entity
                context.ApplicantWorkReferenceRecommendation.Add(applicantworkreferencerecommendation);
            } else {
                // Existing entity
                context.Entry(applicantworkreferencerecommendation).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantworkreferencerecommendation = context.ApplicantWorkReferenceRecommendation.Find(id);
            context.ApplicantWorkReferenceRecommendation.Remove(applicantworkreferencerecommendation);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantWorkReferenceRecommendationRepository
    {
        IQueryable<ApplicantWorkReferenceRecommendation> All { get; }
        IQueryable<ApplicantWorkReferenceRecommendation> AllIncluding(params Expression<Func<ApplicantWorkReferenceRecommendation, object>>[] includeProperties);
        ApplicantWorkReferenceRecommendation Find(int id);
        void InsertOrUpdate(ApplicantWorkReferenceRecommendation applicantworkreferencerecommendation);
        void Delete(int id);
        void Save();
    }
}