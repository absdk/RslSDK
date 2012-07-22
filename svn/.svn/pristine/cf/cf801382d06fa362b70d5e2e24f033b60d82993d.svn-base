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
    public class RequisitionOrganizationRepository : IRequisitionOrganizationRepository
    {
		private readonly RepositoryContext context;

        public RequisitionOrganizationRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionOrganization> All
        {
            get { return context.RequisitionOrganization; }
        }

        public IQueryable<RequisitionOrganization> AllIncluding(params Expression<Func<RequisitionOrganization, object>>[] includeProperties)
        {
            IQueryable<RequisitionOrganization> query = context.RequisitionOrganization;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionOrganization Find(int id)
        {
            return context.RequisitionOrganization.Find(id);
        }

        public void InsertOrUpdate(RequisitionOrganization requisitionorganization)
        {
            if (requisitionorganization.RequisitionOrganizationID == default(int)) {
                // New entity
                context.RequisitionOrganization.Add(requisitionorganization);
            } else {
                // Existing entity
                context.Entry(requisitionorganization).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionorganization = context.RequisitionOrganization.Find(id);
            context.RequisitionOrganization.Remove(requisitionorganization);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionOrganizationRepository
    {
        IQueryable<RequisitionOrganization> All { get; }
        IQueryable<RequisitionOrganization> AllIncluding(params Expression<Func<RequisitionOrganization, object>>[] includeProperties);
        RequisitionOrganization Find(int id);
        void InsertOrUpdate(RequisitionOrganization requisitionorganization);
        void Delete(int id);
        void Save();
    }
}