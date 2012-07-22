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
    public class BusinessDivisionRepository : IBusinessDivisionRepository
    {
		private readonly RepositoryContext context;

        public BusinessDivisionRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<BusinessDivision> All
        {
            get { return context.BusinessDivision; }
        }

        public IQueryable<BusinessDivision> AllIncluding(params Expression<Func<BusinessDivision, object>>[] includeProperties)
        {
            IQueryable<BusinessDivision> query = context.BusinessDivision;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public BusinessDivision Find(int id)
        {
            return context.BusinessDivision.Find(id);
        }

        public void InsertOrUpdate(BusinessDivision businessdivision)
        {
            if (businessdivision.BusinessDivisionID == default(int)) {
                // New entity
                context.BusinessDivision.Add(businessdivision);
            } else {
                // Existing entity
                context.Entry(businessdivision).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var businessdivision = context.BusinessDivision.Find(id);
            context.BusinessDivision.Remove(businessdivision);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IBusinessDivisionRepository
    {
        IQueryable<BusinessDivision> All { get; }
        IQueryable<BusinessDivision> AllIncluding(params Expression<Func<BusinessDivision, object>>[] includeProperties);
        BusinessDivision Find(int id);
        void InsertOrUpdate(BusinessDivision businessdivision);
        void Delete(int id);
        void Save();
    }
}