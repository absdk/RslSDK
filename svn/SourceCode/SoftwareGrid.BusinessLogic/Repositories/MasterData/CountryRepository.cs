using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class CountryRepository : ICountryRepository
    {
		private readonly RepositoryContext context;

        public CountryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Country> All
        {
            get { return context.Country; }
        }

        public IQueryable<Country> AllIncluding(params Expression<Func<Country, object>>[] includeProperties)
        {
            IQueryable<Country> query = context.Country;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Country Find(int id)
        {
            return context.Country.Find(id);
        }

        public void InsertOrUpdate(Country country)
        {
            if (country.CountryID == default(int)) {
                // New entity
                context.Country.Add(country);
            } else {
                // Existing entity
                context.Entry(country).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var country = context.Country.Find(id);
            context.Country.Remove(country);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICountryRepository
    {
        IQueryable<Country> All { get; }
        IQueryable<Country> AllIncluding(params Expression<Func<Country, object>>[] includeProperties);
        Country Find(int id);
        void InsertOrUpdate(Country country);
        void Delete(int id);
        void Save();
    }
}