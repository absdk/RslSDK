using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class RatingScaleRepository : IRatingScaleRepository
    {
		private readonly RepositoryContext context;

        public RatingScaleRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RatingScale> All
        {
            get { return context.RatingScale; }
        }

        public IQueryable<RatingScale> AllIncluding(params Expression<Func<RatingScale, object>>[] includeProperties)
        {
            IQueryable<RatingScale> query = context.RatingScale;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RatingScale Find(int id)
        {
            return context.RatingScale.Find(id);
        }

        public void InsertOrUpdate(RatingScale ratingscale)
        {
            if (ratingscale.RatingScaleID == default(int)) {
                // New entity
                context.RatingScale.Add(ratingscale);
            } else {
                // Existing entity
                context.Entry(ratingscale).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var ratingscale = context.RatingScale.Find(id);
            context.RatingScale.Remove(ratingscale);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRatingScaleRepository
    {
        IQueryable<RatingScale> All { get; }
        IQueryable<RatingScale> AllIncluding(params Expression<Func<RatingScale, object>>[] includeProperties);
        RatingScale Find(int id);
        void InsertOrUpdate(RatingScale ratingscale);
        void Delete(int id);
        void Save();
    }
}