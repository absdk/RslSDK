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
    public class ApplicantPreferredWorkLocationRepository : IApplicantPreferredWorkLocationRepository
    {
		private readonly RepositoryContext context;

        public ApplicantPreferredWorkLocationRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantPreferredWorkLocation> All
        {
            get { return context.ApplicantPreferredWorkLocation; }
        }

        public IQueryable<ApplicantPreferredWorkLocation> AllIncluding(params Expression<Func<ApplicantPreferredWorkLocation, object>>[] includeProperties)
        {
            IQueryable<ApplicantPreferredWorkLocation> query = context.ApplicantPreferredWorkLocation;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantPreferredWorkLocation Find(int id)
        {
            return context.ApplicantPreferredWorkLocation.Find(id);
        }

        public void InsertOrUpdate(ApplicantPreferredWorkLocation applicantpreferredworklocation)
        {
            if (applicantpreferredworklocation.ApplicantPreferredWorkLocationID == default(int)) {
                // New entity
                context.ApplicantPreferredWorkLocation.Add(applicantpreferredworklocation);
            } else {
                // Existing entity
                context.Entry(applicantpreferredworklocation).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantpreferredworklocation = context.ApplicantPreferredWorkLocation.Find(id);
            context.ApplicantPreferredWorkLocation.Remove(applicantpreferredworklocation);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantPreferredWorkLocationRepository
    {
        IQueryable<ApplicantPreferredWorkLocation> All { get; }
        IQueryable<ApplicantPreferredWorkLocation> AllIncluding(params Expression<Func<ApplicantPreferredWorkLocation, object>>[] includeProperties);
        ApplicantPreferredWorkLocation Find(int id);
        void InsertOrUpdate(ApplicantPreferredWorkLocation applicantpreferredworklocation);
        void Delete(int id);
        void Save();
    }
}