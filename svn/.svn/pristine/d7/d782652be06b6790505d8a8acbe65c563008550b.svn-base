using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class UserRoleRepository : IUserRoleRepository
    {
		private readonly RepositoryContext context;

        public UserRoleRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<UserRole> All
        {
            get { return context.UserRole; }
        }

        public IQueryable<UserRole> AllIncluding(params Expression<Func<UserRole, object>>[] includeProperties)
        {
            IQueryable<UserRole> query = context.UserRole;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public UserRole Find(int id)
        {
            return context.UserRole.Find(id);
        }

        public void InsertOrUpdate(UserRole userrole)
        {
            if (userrole.UserRoleID == default(int)) {
                // New entity
                context.UserRole.Add(userrole);
            } else {
                // Existing entity
                context.Entry(userrole).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var userrole = context.UserRole.Find(id);
            context.UserRole.Remove(userrole);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IUserRoleRepository
    {
        IQueryable<UserRole> All { get; }
        IQueryable<UserRole> AllIncluding(params Expression<Func<UserRole, object>>[] includeProperties);
        UserRole Find(int id);
        void InsertOrUpdate(UserRole userrole);
        void Delete(int id);
        void Save();
    }
}