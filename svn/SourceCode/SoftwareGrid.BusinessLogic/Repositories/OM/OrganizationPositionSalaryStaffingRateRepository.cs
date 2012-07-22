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
    public class OrganizationPositionSalaryStaffingRateRepository : IOrganizationPositionSalaryStaffingRateRepository
    {
		private readonly RepositoryContext context;

        public OrganizationPositionSalaryStaffingRateRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationPositionSalaryStaffingRate> All
        {
            get { return context.OrganizationPositionSalaryStaffingRate; }
        }

        public IQueryable<OrganizationPositionSalaryStaffingRate> AllIncluding(params Expression<Func<OrganizationPositionSalaryStaffingRate, object>>[] includeProperties)
        {
            IQueryable<OrganizationPositionSalaryStaffingRate> query = context.OrganizationPositionSalaryStaffingRate;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public OrganizationPositionSalaryStaffingRate Find(int id)
        {
            return context.OrganizationPositionSalaryStaffingRate.Find(id);
        }

        public void InsertOrUpdate(OrganizationPositionSalaryStaffingRate organizationpositionsalarystaffingrate)
        {
            if (organizationpositionsalarystaffingrate.OrganizationPositionSalaryStaffingRateID == default(int)) {
                // New entity
                context.OrganizationPositionSalaryStaffingRate.Add(organizationpositionsalarystaffingrate);
            } else {
                // Existing entity
                context.Entry(organizationpositionsalarystaffingrate).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationpositionsalarystaffingrate = context.OrganizationPositionSalaryStaffingRate.Find(id);
            context.OrganizationPositionSalaryStaffingRate.Remove(organizationpositionsalarystaffingrate);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationPositionSalaryStaffingRateRepository
    {
        IQueryable<OrganizationPositionSalaryStaffingRate> All { get; }
        IQueryable<OrganizationPositionSalaryStaffingRate> AllIncluding(params Expression<Func<OrganizationPositionSalaryStaffingRate, object>>[] includeProperties);
        OrganizationPositionSalaryStaffingRate Find(int id);
        void InsertOrUpdate(OrganizationPositionSalaryStaffingRate organizationpositionsalarystaffingrate);
        void Delete(int id);
        void Save();
    }
}