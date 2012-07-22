using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class DriverLicenseRepository : IDriverLicenseRepository
    {
		private readonly RepositoryContext context;

        public DriverLicenseRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<DriverLicense> All
        {
            get { return context.DriverLicense; }
        }

        public IQueryable<DriverLicense> AllIncluding(params Expression<Func<DriverLicense, object>>[] includeProperties)
        {
            IQueryable<DriverLicense> query = context.DriverLicense;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public DriverLicense Find(int id)
        {
            return context.DriverLicense.Find(id);
        }

        public void InsertOrUpdate(DriverLicense driverlicense)
        {
            if (driverlicense.DriverLicenseID == default(int)) {
                // New entity
                context.DriverLicense.Add(driverlicense);
            } else {
                // Existing entity
                context.Entry(driverlicense).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var driverlicense = context.DriverLicense.Find(id);
            context.DriverLicense.Remove(driverlicense);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IDriverLicenseRepository
    {
        IQueryable<DriverLicense> All { get; }
        IQueryable<DriverLicense> AllIncluding(params Expression<Func<DriverLicense, object>>[] includeProperties);
        DriverLicense Find(int id);
        void InsertOrUpdate(DriverLicense driverlicense);
        void Delete(int id);
        void Save();
    }
}