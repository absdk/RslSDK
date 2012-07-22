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
    public class SalesCampaignStatusCategoryRepository : ISalesCampaignStatusCategoryRepository
    {
		private readonly RepositoryContext context;

        public SalesCampaignStatusCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<SalesCampaignStatusCategory> All
        {
            get { return context.SalesCampaignStatusCategory; }
        }

        public IQueryable<SalesCampaignStatusCategory> AllIncluding(params Expression<Func<SalesCampaignStatusCategory, object>>[] includeProperties)
        {
            IQueryable<SalesCampaignStatusCategory> query = context.SalesCampaignStatusCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public SalesCampaignStatusCategory Find(int id)
        {
            return context.SalesCampaignStatusCategory.Find(id);
        }

        public void InsertOrUpdate(SalesCampaignStatusCategory salescampaignstatuscategory)
        {
            if (salescampaignstatuscategory.SalesCampaignStatusCategoryID == default(int)) {
                // New entity
                context.SalesCampaignStatusCategory.Add(salescampaignstatuscategory);
            } else {
                // Existing entity
                context.Entry(salescampaignstatuscategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var salescampaignstatuscategory = context.SalesCampaignStatusCategory.Find(id);
            context.SalesCampaignStatusCategory.Remove(salescampaignstatuscategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ISalesCampaignStatusCategoryRepository
    {
        IQueryable<SalesCampaignStatusCategory> All { get; }
        IQueryable<SalesCampaignStatusCategory> AllIncluding(params Expression<Func<SalesCampaignStatusCategory, object>>[] includeProperties);
        SalesCampaignStatusCategory Find(int id);
        void InsertOrUpdate(SalesCampaignStatusCategory salescampaignstatuscategory);
        void Delete(int id);
        void Save();
    }
}