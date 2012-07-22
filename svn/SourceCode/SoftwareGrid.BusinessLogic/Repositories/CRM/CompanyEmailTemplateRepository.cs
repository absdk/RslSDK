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
    public class CompanyEmailTemplateRepository : ICompanyEmailTemplateRepository
    {
		private readonly RepositoryContext context;

        public CompanyEmailTemplateRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<CompanyEmailTemplate> All
        {
            get { return context.CompanyEmailTemplate; }
        }

        public IQueryable<CompanyEmailTemplate> AllIncluding(params Expression<Func<CompanyEmailTemplate, object>>[] includeProperties)
        {
            IQueryable<CompanyEmailTemplate> query = context.CompanyEmailTemplate;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CompanyEmailTemplate Find(int id)
        {
            return context.CompanyEmailTemplate.Find(id);
        }

        public void InsertOrUpdate(CompanyEmailTemplate companyemailtemplate)
        {
            if (companyemailtemplate.CompanyEmailTemplateID == default(int)) {
                // New entity
                context.CompanyEmailTemplate.Add(companyemailtemplate);
            } else {
                // Existing entity
                context.Entry(companyemailtemplate).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var companyemailtemplate = context.CompanyEmailTemplate.Find(id);
            context.CompanyEmailTemplate.Remove(companyemailtemplate);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICompanyEmailTemplateRepository
    {
        IQueryable<CompanyEmailTemplate> All { get; }
        IQueryable<CompanyEmailTemplate> AllIncluding(params Expression<Func<CompanyEmailTemplate, object>>[] includeProperties);
        CompanyEmailTemplate Find(int id);
        void InsertOrUpdate(CompanyEmailTemplate companyemailtemplate);
        void Delete(int id);
        void Save();
    }
}