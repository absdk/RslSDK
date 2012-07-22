using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class EthnicBackgroundRepository : IEthnicBackgroundRepository
    {
		private readonly RepositoryContext context;

        public EthnicBackgroundRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<EthnicBackground> All
        {
            get { return context.EthnicBackground; }
        }

        public IQueryable<EthnicBackground> AllIncluding(params Expression<Func<EthnicBackground, object>>[] includeProperties)
        {
            IQueryable<EthnicBackground> query = context.EthnicBackground;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public EthnicBackground Find(int id)
        {
            return context.EthnicBackground.Find(id);
        }

        public void InsertOrUpdate(EthnicBackground ethnicbackground)
        {
            if (ethnicbackground.EthnicBackgroundID == default(int)) {
                // New entity
                context.EthnicBackground.Add(ethnicbackground);
            } else {
                // Existing entity
                context.Entry(ethnicbackground).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var ethnicbackground = context.EthnicBackground.Find(id);
            context.EthnicBackground.Remove(ethnicbackground);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IEthnicBackgroundRepository
    {
        IQueryable<EthnicBackground> All { get; }
        IQueryable<EthnicBackground> AllIncluding(params Expression<Func<EthnicBackground, object>>[] includeProperties);
        EthnicBackground Find(int id);
        void InsertOrUpdate(EthnicBackground ethnicbackground);
        void Delete(int id);
        void Save();
    }
}