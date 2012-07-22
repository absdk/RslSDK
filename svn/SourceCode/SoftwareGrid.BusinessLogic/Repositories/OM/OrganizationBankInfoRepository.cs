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
    public class OrganizationBankInfoRepository : IOrganizationBankInfoRepository
    {
		private readonly RepositoryContext context;

        public OrganizationBankInfoRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationBankInfo> All
        {
            get { return context.OrganizationBankInfo; }
        }

		public IQueryable<OrganizationBankInfo> AllIncluding(params Expression<Func<OrganizationBankInfo, object>>[] includeProperties)
        {
            IQueryable<OrganizationBankInfo> query = context.OrganizationBankInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<OrganizationBankInfo> AllIncluding(int organizationId,params Expression<Func<OrganizationBankInfo, object>>[] includeProperties)
        {
            IQueryable<OrganizationBankInfo> query = context.OrganizationBankInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.OrganizationID==organizationId);
        }
		
        public OrganizationBankInfo Find(int id)
        {
            return context.OrganizationBankInfo.Find(id);
        }

        public void InsertOrUpdate(OrganizationBankInfo organizationbankinfo)
        {
            if (organizationbankinfo.OrganizationBankInfoID == default(int)) {
                // New entity
                context.OrganizationBankInfo.Add(organizationbankinfo);
            } else {
                // Existing entity
                context.Entry(organizationbankinfo).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationbankinfo = context.OrganizationBankInfo.Find(id);
            context.OrganizationBankInfo.Remove(organizationbankinfo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationBankInfoRepository
    {
        IQueryable<OrganizationBankInfo> All { get; }
        IQueryable<OrganizationBankInfo> AllIncluding(params Expression<Func<OrganizationBankInfo, object>>[] includeProperties);
		        IQueryable<OrganizationBankInfo> AllIncluding(int organizationId,params Expression<Func<OrganizationBankInfo, object>>[] includeProperties);
                OrganizationBankInfo Find(int id);
        void InsertOrUpdate(OrganizationBankInfo organizationbankinfo);
        void Delete(int id);
        void Save();
    }
}