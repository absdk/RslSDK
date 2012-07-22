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
    public class PositionRepository : IPositionRepository
    {
		private readonly RepositoryContext context;

        public PositionRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Position> All
        {
            get { return context.Position; }
        }

        public IQueryable<Position> AllIncluding(params Expression<Func<Position, object>>[] includeProperties)
        {
            IQueryable<Position> query = context.Position;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Position Find(int id)
        {
            return context.Position.Find(id);
        }

        public void InsertOrUpdate(Position position)
        {
            if (position.PositionID == default(int)) {
                // New entity
                context.Position.Add(position);
            } else {
                // Existing entity
                context.Entry(position).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var position = context.Position.Find(id);
            context.Position.Remove(position);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IPositionRepository
    {
        IQueryable<Position> All { get; }
        IQueryable<Position> AllIncluding(params Expression<Func<Position, object>>[] includeProperties);
        Position Find(int id);
        void InsertOrUpdate(Position position);
        void Delete(int id);
        void Save();
    }
}