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
    public class ApplicantPhotoPortfolioRepository : IApplicantPhotoPortfolioRepository
    {
		private readonly RepositoryContext context;

        public ApplicantPhotoPortfolioRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantPhotoPortfolio> All
        {
            get { return context.ApplicantPhotoPortfolio; }
        }

        public IQueryable<ApplicantPhotoPortfolio> AllIncluding(params Expression<Func<ApplicantPhotoPortfolio, object>>[] includeProperties)
        {
            IQueryable<ApplicantPhotoPortfolio> query = context.ApplicantPhotoPortfolio;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantPhotoPortfolio Find(int id)
        {
            return context.ApplicantPhotoPortfolio.Find(id);
        }

        public void InsertOrUpdate(ApplicantPhotoPortfolio applicantphotoportfolio)
        {
            if (applicantphotoportfolio.ApplicantPhotoPortfolioID == default(int)) {
                // New entity
                context.ApplicantPhotoPortfolio.Add(applicantphotoportfolio);
            } else {
                // Existing entity
                context.Entry(applicantphotoportfolio).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantphotoportfolio = context.ApplicantPhotoPortfolio.Find(id);
            context.ApplicantPhotoPortfolio.Remove(applicantphotoportfolio);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantPhotoPortfolioRepository
    {
        IQueryable<ApplicantPhotoPortfolio> All { get; }
        IQueryable<ApplicantPhotoPortfolio> AllIncluding(params Expression<Func<ApplicantPhotoPortfolio, object>>[] includeProperties);
        ApplicantPhotoPortfolio Find(int id);
        void InsertOrUpdate(ApplicantPhotoPortfolio applicantphotoportfolio);
        void Delete(int id);
        void Save();
    }
}