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
    public class AccountCategoryRepository : IAccountCategoryRepository
    {
		private readonly RepositoryContext context;

        public AccountCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<AccountCategory> All
        {
            get { return context.AccountCategory; }
        }

        public IQueryable<AccountCategory> AllIncluding(params Expression<Func<AccountCategory, object>>[] includeProperties)
        {
            IQueryable<AccountCategory> query = context.AccountCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public AccountCategory Find(int id)
        {
            return context.AccountCategory.Find(id);
        }

        public void InsertOrUpdate(AccountCategory accountcategory)
        {
            if (accountcategory.AccountCategoryID == default(int)) {
                // New entity
                context.AccountCategory.Add(accountcategory);
            } else {
                // Existing entity
                context.Entry(accountcategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var accountcategory = context.AccountCategory.Find(id);
            context.AccountCategory.Remove(accountcategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IAccountCategoryRepository
    {
        IQueryable<AccountCategory> All { get; }
        IQueryable<AccountCategory> AllIncluding(params Expression<Func<AccountCategory, object>>[] includeProperties);
        AccountCategory Find(int id);
        void InsertOrUpdate(AccountCategory accountcategory);
        void Delete(int id);
        void Save();
    }
}