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
    public class BloodGroupRepository : IBloodGroupRepository
    {
		private readonly RepositoryContext context;

        public BloodGroupRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<BloodGroup> All
        {
            get { return context.BloodGroup; }
        }

        public IQueryable<BloodGroup> AllIncluding(params Expression<Func<BloodGroup, object>>[] includeProperties)
        {
            IQueryable<BloodGroup> query = context.BloodGroup;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public BloodGroup Find(int id)
        {
            return context.BloodGroup.Find(id);
        }

        public void InsertOrUpdate(BloodGroup bloodgroup)
        {
            if (bloodgroup.BloodGroupID == default(int)) {
                // New entity
                context.BloodGroup.Add(bloodgroup);
            } else {
                // Existing entity
                context.Entry(bloodgroup).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var bloodgroup = context.BloodGroup.Find(id);
            context.BloodGroup.Remove(bloodgroup);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IBloodGroupRepository
    {
        IQueryable<BloodGroup> All { get; }
        IQueryable<BloodGroup> AllIncluding(params Expression<Func<BloodGroup, object>>[] includeProperties);
        BloodGroup Find(int id);
        void InsertOrUpdate(BloodGroup bloodgroup);
        void Delete(int id);
        void Save();
    }
}