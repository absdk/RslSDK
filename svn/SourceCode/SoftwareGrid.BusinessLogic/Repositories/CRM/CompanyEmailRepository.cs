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
    public class CompanyEmailRepository : ICompanyEmailRepository
    {
		private readonly RepositoryContext context;

        public CompanyEmailRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<CompanyEmail> All
        {
            get { return context.CompanyEmail; }
        }

        public IQueryable<CompanyEmail> AllIncluding(params Expression<Func<CompanyEmail, object>>[] includeProperties)
        {
            IQueryable<CompanyEmail> query = context.CompanyEmail;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CompanyEmail Find(int id)
        {
            return context.CompanyEmail.Find(id);
        }

        public void InsertOrUpdate(CompanyEmail companyemail)
        {
            if (companyemail.CompanyEmailID == default(int)) {
                // New entity
                context.CompanyEmail.Add(companyemail);
            } else {
                // Existing entity
                context.Entry(companyemail).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var companyemail = context.CompanyEmail.Find(id);
            context.CompanyEmail.Remove(companyemail);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICompanyEmailRepository
    {
        IQueryable<CompanyEmail> All { get; }
        IQueryable<CompanyEmail> AllIncluding(params Expression<Func<CompanyEmail, object>>[] includeProperties);
        CompanyEmail Find(int id);
        void InsertOrUpdate(CompanyEmail companyemail);
        void Delete(int id);
        void Save();
    }
}