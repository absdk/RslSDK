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
    public class OrganizationAddressRepository : IOrganizationAddressRepository
    {
		private readonly RepositoryContext context;

        public OrganizationAddressRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationAddress> All
        {
            get { return context.OrganizationAddress; }
        }

		public IQueryable<OrganizationAddress> AllIncluding(params Expression<Func<OrganizationAddress, object>>[] includeProperties)
        {
            IQueryable<OrganizationAddress> query = context.OrganizationAddress;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<OrganizationAddress> AllIncluding(int organizationId,params Expression<Func<OrganizationAddress, object>>[] includeProperties)
        {
            IQueryable<OrganizationAddress> query = context.OrganizationAddress;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.OrganizationID==organizationId);
        }
		
        public OrganizationAddress Find(int id)
        {
            return context.OrganizationAddress.Find(id);
        }

        public void InsertOrUpdate(OrganizationAddress organizationaddress)
        {
            if (organizationaddress.OrganizationAddressID == default(int)) {
                // New entity
                context.OrganizationAddress.Add(organizationaddress);
            } else {
                // Existing entity
                context.Entry(organizationaddress).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationaddress = context.OrganizationAddress.Find(id);
            context.OrganizationAddress.Remove(organizationaddress);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationAddressRepository
    {
        IQueryable<OrganizationAddress> All { get; }
        IQueryable<OrganizationAddress> AllIncluding(params Expression<Func<OrganizationAddress, object>>[] includeProperties);
		        IQueryable<OrganizationAddress> AllIncluding(int organizationId,params Expression<Func<OrganizationAddress, object>>[] includeProperties);
                OrganizationAddress Find(int id);
        void InsertOrUpdate(OrganizationAddress organizationaddress);
        void Delete(int id);
        void Save();
    }
}