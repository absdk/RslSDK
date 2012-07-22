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
    public class ApplicantRepository : IApplicantRepository
    {
		private readonly RepositoryContext context;

        public ApplicantRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Applicant> All
        {
            get { return context.Applicant; }
        }

        public IQueryable<Applicant> AllIncluding(params Expression<Func<Applicant, object>>[] includeProperties)
        {
            IQueryable<Applicant> query = context.Applicant;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Applicant Find(int id)
        {
            return context.Applicant.Find(id);
        }

        public void InsertOrUpdate(Applicant applicant)
        {
            if (applicant.ApplicantID == default(int)) {
                // New entity
                context.Applicant.Add(applicant);
            } else {
                // Existing entity
                context.Entry(applicant).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicant = context.Applicant.Find(id);
            context.Applicant.Remove(applicant);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantRepository
    {
        IQueryable<Applicant> All { get; }
        IQueryable<Applicant> AllIncluding(params Expression<Func<Applicant, object>>[] includeProperties);
        Applicant Find(int id);
        void InsertOrUpdate(Applicant applicant);
        void Delete(int id);
        void Save();
    }
}