using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class CompanyOwnerRepository : ICompanyOwnerRepository
    {
		private readonly RepositoryContext context;

        public CompanyOwnerRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<CompanyOwner> All
        {
            get { return context.CompanyOwner; }
        }

        public IQueryable<CompanyOwner> AllIncluding(params Expression<Func<CompanyOwner, object>>[] includeProperties)
        {
            IQueryable<CompanyOwner> query = context.CompanyOwner;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public CompanyOwner Find(int id)
        {
            return context.CompanyOwner.Find(id);
        }

        public void InsertOrUpdate(CompanyOwner companyowner)
        {
            if (companyowner.CompanyOwnerID == default(int)) {
                // New entity
                context.CompanyOwner.Add(companyowner);
            } else {
                // Existing entity
                context.Entry(companyowner).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var companyowner = context.CompanyOwner.Find(id);
            context.CompanyOwner.Remove(companyowner);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICompanyOwnerRepository
    {
        IQueryable<CompanyOwner> All { get; }
        IQueryable<CompanyOwner> AllIncluding(params Expression<Func<CompanyOwner, object>>[] includeProperties);
        CompanyOwner Find(int id);
        void InsertOrUpdate(CompanyOwner companyowner);
        void Delete(int id);
        void Save();
    }
}