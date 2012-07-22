using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class ApplicantDataPrivacyTemplateRepository : IApplicantDataPrivacyTemplateRepository
    {
		private readonly RepositoryContext context;

        public ApplicantDataPrivacyTemplateRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantDataPrivacyTemplate> All
        {
            get { return context.ApplicantDataPrivacyTemplate; }
        }

        public IQueryable<ApplicantDataPrivacyTemplate> AllIncluding(params Expression<Func<ApplicantDataPrivacyTemplate, object>>[] includeProperties)
        {
            IQueryable<ApplicantDataPrivacyTemplate> query = context.ApplicantDataPrivacyTemplate;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantDataPrivacyTemplate Find(int id)
        {
            return context.ApplicantDataPrivacyTemplate.Find(id);
        }

        public void InsertOrUpdate(ApplicantDataPrivacyTemplate applicantdataprivacytemplate)
        {
            if (applicantdataprivacytemplate.ApplicantDataPrivacyTemplateID == default(int)) {
                // New entity
                context.ApplicantDataPrivacyTemplate.Add(applicantdataprivacytemplate);
            } else {
                // Existing entity
                context.Entry(applicantdataprivacytemplate).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantdataprivacytemplate = context.ApplicantDataPrivacyTemplate.Find(id);
            context.ApplicantDataPrivacyTemplate.Remove(applicantdataprivacytemplate);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantDataPrivacyTemplateRepository
    {
        IQueryable<ApplicantDataPrivacyTemplate> All { get; }
        IQueryable<ApplicantDataPrivacyTemplate> AllIncluding(params Expression<Func<ApplicantDataPrivacyTemplate, object>>[] includeProperties);
        ApplicantDataPrivacyTemplate Find(int id);
        void InsertOrUpdate(ApplicantDataPrivacyTemplate applicantdataprivacytemplate);
        void Delete(int id);
        void Save();
    }
}