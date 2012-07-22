using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class ApplicantSourceCategoryRepository : IApplicantSourceCategoryRepository
    {
		private readonly RepositoryContext context;

        public ApplicantSourceCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantSourceCategory> All
        {
            get { return context.ApplicantSourceCategory; }
        }

        public IQueryable<ApplicantSourceCategory> AllIncluding(params Expression<Func<ApplicantSourceCategory, object>>[] includeProperties)
        {
            IQueryable<ApplicantSourceCategory> query = context.ApplicantSourceCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantSourceCategory Find(int id)
        {
            return context.ApplicantSourceCategory.Find(id);
        }

        public void InsertOrUpdate(ApplicantSourceCategory applicantsourcecategory)
        {
            if (applicantsourcecategory.ApplicantSourceCategoryID == default(int)) {
                // New entity
                context.ApplicantSourceCategory.Add(applicantsourcecategory);
            } else {
                // Existing entity
                context.Entry(applicantsourcecategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantsourcecategory = context.ApplicantSourceCategory.Find(id);
            context.ApplicantSourceCategory.Remove(applicantsourcecategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantSourceCategoryRepository
    {
        IQueryable<ApplicantSourceCategory> All { get; }
        IQueryable<ApplicantSourceCategory> AllIncluding(params Expression<Func<ApplicantSourceCategory, object>>[] includeProperties);
        ApplicantSourceCategory Find(int id);
        void InsertOrUpdate(ApplicantSourceCategory applicantsourcecategory);
        void Delete(int id);
        void Save();
    }
}