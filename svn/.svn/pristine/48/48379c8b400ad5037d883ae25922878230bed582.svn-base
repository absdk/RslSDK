using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class SecurityClearanceRepository : ISecurityClearanceRepository
    {
		private readonly RepositoryContext context;

        public SecurityClearanceRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SecurityClearance> All
        {
            get { return context.SecurityClearance; }
        }

        public IQueryable<SecurityClearance> AllIncluding(params Expression<Func<SecurityClearance, object>>[] includeProperties)
        {
            IQueryable<SecurityClearance> query = context.SecurityClearance;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SecurityClearance Find(int id)
        {
            return context.SecurityClearance.Find(id);
        }

        public void InsertOrUpdate(SecurityClearance securityclearance)
        {
            if (securityclearance.SecurityClearanceID == default(int)) {
                // New entity
                context.SecurityClearance.Add(securityclearance);
            } else {
                // Existing entity
                context.Entry(securityclearance).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var securityclearance = context.SecurityClearance.Find(id);
            context.SecurityClearance.Remove(securityclearance);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISecurityClearanceRepository
    {
        IQueryable<SecurityClearance> All { get; }
        IQueryable<SecurityClearance> AllIncluding(params Expression<Func<SecurityClearance, object>>[] includeProperties);
        SecurityClearance Find(int id);
        void InsertOrUpdate(SecurityClearance securityclearance);
        void Delete(int id);
        void Save();
    }
}