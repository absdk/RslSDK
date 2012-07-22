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
    public class ApplicantRecruitmentCostCategoryRepository : IApplicantRecruitmentCostCategoryRepository
    {
		private readonly RepositoryContext context;

        public ApplicantRecruitmentCostCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantRecruitmentCostCategory> All
        {
            get { return context.ApplicantRecruitmentCostCategory; }
        }

        public IQueryable<ApplicantRecruitmentCostCategory> AllIncluding(params Expression<Func<ApplicantRecruitmentCostCategory, object>>[] includeProperties)
        {
            IQueryable<ApplicantRecruitmentCostCategory> query = context.ApplicantRecruitmentCostCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantRecruitmentCostCategory Find(int id)
        {
            return context.ApplicantRecruitmentCostCategory.Find(id);
        }

        public void InsertOrUpdate(ApplicantRecruitmentCostCategory applicantrecruitmentcostcategory)
        {
            if (applicantrecruitmentcostcategory.ApplicantRecruitmentCostCategoryID == default(int)) {
                // New entity
                context.ApplicantRecruitmentCostCategory.Add(applicantrecruitmentcostcategory);
            } else {
                // Existing entity
                context.Entry(applicantrecruitmentcostcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantrecruitmentcostcategory = context.ApplicantRecruitmentCostCategory.Find(id);
            context.ApplicantRecruitmentCostCategory.Remove(applicantrecruitmentcostcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantRecruitmentCostCategoryRepository
    {
        IQueryable<ApplicantRecruitmentCostCategory> All { get; }
        IQueryable<ApplicantRecruitmentCostCategory> AllIncluding(params Expression<Func<ApplicantRecruitmentCostCategory, object>>[] includeProperties);
        ApplicantRecruitmentCostCategory Find(int id);
        void InsertOrUpdate(ApplicantRecruitmentCostCategory applicantrecruitmentcostcategory);
        void Delete(int id);
        void Save();
    }
}