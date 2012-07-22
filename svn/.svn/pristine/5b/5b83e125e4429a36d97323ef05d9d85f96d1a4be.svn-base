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
    public class ApplicantAvailabilityStatusCategoryRepository : IApplicantAvailabilityStatusCategoryRepository
    {
		private readonly RepositoryContext context;

        public ApplicantAvailabilityStatusCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantAvailabilityStatusCategory> All
        {
            get { return context.ApplicantAvailabilityStatusCategory; }
        }

        public IQueryable<ApplicantAvailabilityStatusCategory> AllIncluding(params Expression<Func<ApplicantAvailabilityStatusCategory, object>>[] includeProperties)
        {
            IQueryable<ApplicantAvailabilityStatusCategory> query = context.ApplicantAvailabilityStatusCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantAvailabilityStatusCategory Find(int id)
        {
            return context.ApplicantAvailabilityStatusCategory.Find(id);
        }

        public void InsertOrUpdate(ApplicantAvailabilityStatusCategory applicantavailabilitystatuscategory)
        {
            if (applicantavailabilitystatuscategory.ApplicantAvailabilityStatusCategoryID == default(int)) {
                // New entity
                context.ApplicantAvailabilityStatusCategory.Add(applicantavailabilitystatuscategory);
            } else {
                // Existing entity
                context.Entry(applicantavailabilitystatuscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantavailabilitystatuscategory = context.ApplicantAvailabilityStatusCategory.Find(id);
            context.ApplicantAvailabilityStatusCategory.Remove(applicantavailabilitystatuscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantAvailabilityStatusCategoryRepository
    {
        IQueryable<ApplicantAvailabilityStatusCategory> All { get; }
        IQueryable<ApplicantAvailabilityStatusCategory> AllIncluding(params Expression<Func<ApplicantAvailabilityStatusCategory, object>>[] includeProperties);
        ApplicantAvailabilityStatusCategory Find(int id);
        void InsertOrUpdate(ApplicantAvailabilityStatusCategory applicantavailabilitystatuscategory);
        void Delete(int id);
        void Save();
    }
}