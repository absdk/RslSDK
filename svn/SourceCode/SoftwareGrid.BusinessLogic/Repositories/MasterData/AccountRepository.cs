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
    public class AccountRepository : IAccountRepository
    {
		private readonly RepositoryContext context;

        public AccountRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Account> All
        {
            get { return context.Account; }
        }

        public IQueryable<Account> AllIncluding(params Expression<Func<Account, object>>[] includeProperties)
        {
            IQueryable<Account> query = context.Account;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Account Find(int id)
        {
            return context.Account.Find(id);
        }

        public void InsertOrUpdate(Account account)
        {
            if (account.AccountID == default(int)) {
                // New entity
                context.Account.Add(account);
            } else {
                // Existing entity
                context.Entry(account).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var account = context.Account.Find(id);
            context.Account.Remove(account);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IAccountRepository
    {
        IQueryable<Account> All { get; }
        IQueryable<Account> AllIncluding(params Expression<Func<Account, object>>[] includeProperties);
        Account Find(int id);
        void InsertOrUpdate(Account account);
        void Delete(int id);
        void Save();
    }
}