using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class PayCycleRepository : IPayCycleRepository
    {
		private readonly RepositoryContext context;

        public PayCycleRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<PayCycle> All
        {
            get { return context.PayCycle; }
        }

        public IQueryable<PayCycle> AllIncluding(params Expression<Func<PayCycle, object>>[] includeProperties)
        {
            IQueryable<PayCycle> query = context.PayCycle;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public PayCycle Find(int id)
        {
            return context.PayCycle.Find(id);
        }

        public void InsertOrUpdate(PayCycle paycycle)
        {
            if (paycycle.PayCycleID == default(int)) {
                // New entity
                context.PayCycle.Add(paycycle);
            } else {
                // Existing entity
                context.Entry(paycycle).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var paycycle = context.PayCycle.Find(id);
            context.PayCycle.Remove(paycycle);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IPayCycleRepository
    {
        IQueryable<PayCycle> All { get; }
        IQueryable<PayCycle> AllIncluding(params Expression<Func<PayCycle, object>>[] includeProperties);
        PayCycle Find(int id);
        void InsertOrUpdate(PayCycle paycycle);
        void Delete(int id);
        void Save();
    }
}