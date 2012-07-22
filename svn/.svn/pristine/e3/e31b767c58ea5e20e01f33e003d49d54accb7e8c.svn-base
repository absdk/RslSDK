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
    public class SalesCampaignRepository : ISalesCampaignRepository
    {
		private readonly RepositoryContext context;

        public SalesCampaignRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SalesCampaign> All
        {
            get { return context.SalesCampaign; }
        }

        public IQueryable<SalesCampaign> AllIncluding(params Expression<Func<SalesCampaign, object>>[] includeProperties)
        {
            IQueryable<SalesCampaign> query = context.SalesCampaign;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SalesCampaign Find(int id)
        {
            return context.SalesCampaign.Find(id);
        }

        public void InsertOrUpdate(SalesCampaign salescampaign)
        {
            if (salescampaign.SalesCampaignID == default(int)) {
                // New entity
                context.SalesCampaign.Add(salescampaign);
            } else {
                // Existing entity
                context.Entry(salescampaign).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var salescampaign = context.SalesCampaign.Find(id);
            context.SalesCampaign.Remove(salescampaign);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISalesCampaignRepository
    {
        IQueryable<SalesCampaign> All { get; }
        IQueryable<SalesCampaign> AllIncluding(params Expression<Func<SalesCampaign, object>>[] includeProperties);
        SalesCampaign Find(int id);
        void InsertOrUpdate(SalesCampaign salescampaign);
        void Delete(int id);
        void Save();
    }
}