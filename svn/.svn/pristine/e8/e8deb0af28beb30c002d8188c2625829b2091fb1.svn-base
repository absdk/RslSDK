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
    public class ApplicantDocumentRepository : IApplicantDocumentRepository
    {
		private readonly RepositoryContext context;

        public ApplicantDocumentRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantDocument> All
        {
            get { return context.ApplicantDocument; }
        }

        public IQueryable<ApplicantDocument> AllIncluding(params Expression<Func<ApplicantDocument, object>>[] includeProperties)
        {
            IQueryable<ApplicantDocument> query = context.ApplicantDocument;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantDocument Find(int id)
        {
            return context.ApplicantDocument.Find(id);
        }

        public void InsertOrUpdate(ApplicantDocument applicantdocument)
        {
            if (applicantdocument.ApplicantDocumentID == default(int)) {
                // New entity
                context.ApplicantDocument.Add(applicantdocument);
            } else {
                // Existing entity
                context.Entry(applicantdocument).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantdocument = context.ApplicantDocument.Find(id);
            context.ApplicantDocument.Remove(applicantdocument);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantDocumentRepository
    {
        IQueryable<ApplicantDocument> All { get; }
        IQueryable<ApplicantDocument> AllIncluding(params Expression<Func<ApplicantDocument, object>>[] includeProperties);
        ApplicantDocument Find(int id);
        void InsertOrUpdate(ApplicantDocument applicantdocument);
        void Delete(int id);
        void Save();
    }
}