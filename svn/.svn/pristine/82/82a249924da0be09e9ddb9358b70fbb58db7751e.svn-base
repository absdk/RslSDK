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
    public class ApplicantEmailRepository : IApplicantEmailRepository
    {
		private readonly RepositoryContext context;

        public ApplicantEmailRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantEmail> All
        {
            get { return context.ApplicantEmail; }
        }

        public IQueryable<ApplicantEmail> AllIncluding(params Expression<Func<ApplicantEmail, object>>[] includeProperties)
        {
            IQueryable<ApplicantEmail> query = context.ApplicantEmail;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantEmail Find(int id)
        {
            return context.ApplicantEmail.Find(id);
        }

        public void InsertOrUpdate(ApplicantEmail applicantemail)
        {
            if (applicantemail.AplicantEmailID == default(int)) {
                // New entity
                context.ApplicantEmail.Add(applicantemail);
            } else {
                // Existing entity
                context.Entry(applicantemail).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantemail = context.ApplicantEmail.Find(id);
            context.ApplicantEmail.Remove(applicantemail);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantEmailRepository
    {
        IQueryable<ApplicantEmail> All { get; }
        IQueryable<ApplicantEmail> AllIncluding(params Expression<Func<ApplicantEmail, object>>[] includeProperties);
        ApplicantEmail Find(int id);
        void InsertOrUpdate(ApplicantEmail applicantemail);
        void Delete(int id);
        void Save();
    }
}