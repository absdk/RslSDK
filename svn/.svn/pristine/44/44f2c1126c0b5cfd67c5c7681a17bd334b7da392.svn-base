using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class ApplicantDocumentStatusCategoryRepository : IApplicantDocumentStatusCategoryRepository
    {
		private readonly RepositoryContext context;

        public ApplicantDocumentStatusCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantDocumentStatusCategory> All
        {
            get { return context.ApplicantDocumentStatusCategory; }
        }

        public IQueryable<ApplicantDocumentStatusCategory> AllIncluding(params Expression<Func<ApplicantDocumentStatusCategory, object>>[] includeProperties)
        {
            IQueryable<ApplicantDocumentStatusCategory> query = context.ApplicantDocumentStatusCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantDocumentStatusCategory Find(int id)
        {
            return context.ApplicantDocumentStatusCategory.Find(id);
        }

        public void InsertOrUpdate(ApplicantDocumentStatusCategory applicantdocumentstatuscategory)
        {
            if (applicantdocumentstatuscategory.ApplicantDocumentStatusCategoryID == default(int)) {
                // New entity
                context.ApplicantDocumentStatusCategory.Add(applicantdocumentstatuscategory);
            } else {
                // Existing entity
                context.Entry(applicantdocumentstatuscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantdocumentstatuscategory = context.ApplicantDocumentStatusCategory.Find(id);
            context.ApplicantDocumentStatusCategory.Remove(applicantdocumentstatuscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantDocumentStatusCategoryRepository
    {
        IQueryable<ApplicantDocumentStatusCategory> All { get; }
        IQueryable<ApplicantDocumentStatusCategory> AllIncluding(params Expression<Func<ApplicantDocumentStatusCategory, object>>[] includeProperties);
        ApplicantDocumentStatusCategory Find(int id);
        void InsertOrUpdate(ApplicantDocumentStatusCategory applicantdocumentstatuscategory);
        void Delete(int id);
        void Save();
    }
}