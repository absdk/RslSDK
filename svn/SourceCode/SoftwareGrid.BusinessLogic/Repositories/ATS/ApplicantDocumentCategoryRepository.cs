using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class ApplicantDocumentCategoryRepository : IApplicantDocumentCategoryRepository
    {
		private readonly RepositoryContext context;

        public ApplicantDocumentCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantDocumentCategory> All
        {
            get { return context.ApplicantDocumentCategory; }
        }

        public IQueryable<ApplicantDocumentCategory> AllIncluding(params Expression<Func<ApplicantDocumentCategory, object>>[] includeProperties)
        {
            IQueryable<ApplicantDocumentCategory> query = context.ApplicantDocumentCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantDocumentCategory Find(int id)
        {
            return context.ApplicantDocumentCategory.Find(id);
        }

        public void InsertOrUpdate(ApplicantDocumentCategory applicantdocumentcategory)
        {
            if (applicantdocumentcategory.ApplicantDocumentCategoryID == default(int)) {
                // New entity
                context.ApplicantDocumentCategory.Add(applicantdocumentcategory);
            } else {
                // Existing entity
                context.Entry(applicantdocumentcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantdocumentcategory = context.ApplicantDocumentCategory.Find(id);
            context.ApplicantDocumentCategory.Remove(applicantdocumentcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantDocumentCategoryRepository
    {
        IQueryable<ApplicantDocumentCategory> All { get; }
        IQueryable<ApplicantDocumentCategory> AllIncluding(params Expression<Func<ApplicantDocumentCategory, object>>[] includeProperties);
        ApplicantDocumentCategory Find(int id);
        void InsertOrUpdate(ApplicantDocumentCategory applicantdocumentcategory);
        void Delete(int id);
        void Save();
    }
}