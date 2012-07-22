using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class CityRepository : ICityRepository
    {
		private readonly RepositoryContext context;

        public CityRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<City> All
        {
            get { return context.City; }
        }

        public IQueryable<City> AllIncluding(params Expression<Func<City, object>>[] includeProperties)
        {
            IQueryable<City> query = context.City;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public City Find(int id)
        {
            return context.City.Find(id);
        }

        public void InsertOrUpdate(City city)
        {
            if (city.CityID == default(int)) {
                // New entity
                context.City.Add(city);
            } else {
                // Existing entity
                context.Entry(city).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var city = context.City.Find(id);
            context.City.Remove(city);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICityRepository
    {
        IQueryable<City> All { get; }
        IQueryable<City> AllIncluding(params Expression<Func<City, object>>[] includeProperties);
        City Find(int id);
        void InsertOrUpdate(City city);
        void Delete(int id);
        void Save();
    }
}