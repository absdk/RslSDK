using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class CurrencyRepository : ICurrencyRepository
    {
		private readonly RepositoryContext context;

        public CurrencyRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Currency> All
        {
            get { return context.Currency; }
        }

        public IQueryable<Currency> AllIncluding(params Expression<Func<Currency, object>>[] includeProperties)
        {
            IQueryable<Currency> query = context.Currency;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Currency Find(int id)
        {
            return context.Currency.Find(id);
        }

        public void InsertOrUpdate(Currency currency)
        {
            if (currency.CurrencyID == default(int)) {
                // New entity
                context.Currency.Add(currency);
            } else {
                // Existing entity
                context.Entry(currency).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var currency = context.Currency.Find(id);
            context.Currency.Remove(currency);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICurrencyRepository
    {
        IQueryable<Currency> All { get; }
        IQueryable<Currency> AllIncluding(params Expression<Func<Currency, object>>[] includeProperties);
        Currency Find(int id);
        void InsertOrUpdate(Currency currency);
        void Delete(int id);
        void Save();
    }
}