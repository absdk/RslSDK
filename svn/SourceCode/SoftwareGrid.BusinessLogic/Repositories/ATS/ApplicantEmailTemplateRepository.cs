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
    public class ApplicantEmailTemplateRepository : IApplicantEmailTemplateRepository
    {
		private readonly RepositoryContext context;

        public ApplicantEmailTemplateRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantEmailTemplate> All
        {
            get { return context.ApplicantEmailTemplate; }
        }

        public IQueryable<ApplicantEmailTemplate> AllIncluding(params Expression<Func<ApplicantEmailTemplate, object>>[] includeProperties)
        {
            IQueryable<ApplicantEmailTemplate> query = context.ApplicantEmailTemplate;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantEmailTemplate Find(int id)
        {
            return context.ApplicantEmailTemplate.Find(id);
        }

        public void InsertOrUpdate(ApplicantEmailTemplate applicantemailtemplate)
        {
            if (applicantemailtemplate.ApplicantEmailTemplateID == default(int)) {
                // New entity
                context.ApplicantEmailTemplate.Add(applicantemailtemplate);
            } else {
                // Existing entity
                context.Entry(applicantemailtemplate).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantemailtemplate = context.ApplicantEmailTemplate.Find(id);
            context.ApplicantEmailTemplate.Remove(applicantemailtemplate);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantEmailTemplateRepository
    {
        IQueryable<ApplicantEmailTemplate> All { get; }
        IQueryable<ApplicantEmailTemplate> AllIncluding(params Expression<Func<ApplicantEmailTemplate, object>>[] includeProperties);
        ApplicantEmailTemplate Find(int id);
        void InsertOrUpdate(ApplicantEmailTemplate applicantemailtemplate);
        void Delete(int id);
        void Save();
    }
}