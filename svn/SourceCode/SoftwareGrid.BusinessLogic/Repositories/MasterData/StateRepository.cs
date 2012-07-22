using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class StateRepository : IStateRepository
    {
		private readonly RepositoryContext context;

        public StateRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<State> All
        {
            get { return context.State; }
        }

        public IQueryable<State> AllIncluding(params Expression<Func<State, object>>[] includeProperties)
        {
            IQueryable<State> query = context.State;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public IQueryable<State> FindAllByCountryID(int countryId)
        {
            return context.State.Where(item => item.CountryID == countryId);
        }

        public State Find(int id)
        {
            return context.State.Find(id);
        }

        public void InsertOrUpdate(State state)
        {
            if (state.StateID == default(int)) {
                // New entity
                context.State.Add(state);
            } else {
                // Existing entity
                context.Entry(state).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var state = context.State.Find(id);
            context.State.Remove(state);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IStateRepository
    {
        IQueryable<State> All { get; }
        IQueryable<State> AllIncluding(params Expression<Func<State, object>>[] includeProperties);
        State Find(int id);
        IQueryable<State> FindAllByCountryID(int countryId);
        void InsertOrUpdate(State state);
        void Delete(int id);
        void Save();
    }
}