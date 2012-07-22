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
    public class CompanyAddressCategoryRepository : ICompanyAddressCategoryRepository
    {
		private readonly RepositoryContext context;

        public CompanyAddressCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<CompanyAddressCategory> All
        {
            get { return context.CompanyAddressCategory; }
        }

        public IQueryable<CompanyAddressCategory> AllIncluding(params Expression<Func<CompanyAddressCategory, object>>[] includeProperties)
        {
            IQueryable<CompanyAddressCategory> query = context.CompanyAddressCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CompanyAddressCategory Find(int id)
        {
            return context.CompanyAddressCategory.Find(id);
        }

        public void InsertOrUpdate(CompanyAddressCategory companyaddresscategory)
        {
            if (companyaddresscategory.CompanyAddressCategoryID == default(int)) {
                // New entity
                context.CompanyAddressCategory.Add(companyaddresscategory);
            } else {
                // Existing entity
                context.Entry(companyaddresscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var companyaddresscategory = context.CompanyAddressCategory.Find(id);
            context.CompanyAddressCategory.Remove(companyaddresscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICompanyAddressCategoryRepository
    {
        IQueryable<CompanyAddressCategory> All { get; }
        IQueryable<CompanyAddressCategory> AllIncluding(params Expression<Func<CompanyAddressCategory, object>>[] includeProperties);
        CompanyAddressCategory Find(int id);
        void InsertOrUpdate(CompanyAddressCategory companyaddresscategory);
        void Delete(int id);
        void Save();
    }
}