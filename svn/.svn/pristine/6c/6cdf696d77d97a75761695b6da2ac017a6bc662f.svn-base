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
    public class CompanyStatusCategoryRepository : ICompanyStatusCategoryRepository
    {
		private readonly RepositoryContext context;

        public CompanyStatusCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<CompanyStatusCategory> All
        {
            get { return context.CompanyStatusCategory; }
        }

        public IQueryable<CompanyStatusCategory> AllIncluding(params Expression<Func<CompanyStatusCategory, object>>[] includeProperties)
        {
            IQueryable<CompanyStatusCategory> query = context.CompanyStatusCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CompanyStatusCategory Find(int id)
        {
            return context.CompanyStatusCategory.Find(id);
        }

        public void InsertOrUpdate(CompanyStatusCategory companystatuscategory)
        {
            if (companystatuscategory.CompanyStatusCategoryID == default(int)) {
                // New entity
                context.CompanyStatusCategory.Add(companystatuscategory);
            } else {
                // Existing entity
                context.Entry(companystatuscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var companystatuscategory = context.CompanyStatusCategory.Find(id);
            context.CompanyStatusCategory.Remove(companystatuscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICompanyStatusCategoryRepository
    {
        IQueryable<CompanyStatusCategory> All { get; }
        IQueryable<CompanyStatusCategory> AllIncluding(params Expression<Func<CompanyStatusCategory, object>>[] includeProperties);
        CompanyStatusCategory Find(int id);
        void InsertOrUpdate(CompanyStatusCategory companystatuscategory);
        void Delete(int id);
        void Save();
    }
}