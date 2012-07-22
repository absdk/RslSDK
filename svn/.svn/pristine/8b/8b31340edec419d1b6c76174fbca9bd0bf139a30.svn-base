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
    public class OrganizationPositionCompetencyRepository : IOrganizationPositionCompetencyRepository
    {
		private readonly RepositoryContext context;

        public OrganizationPositionCompetencyRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationPositionCompetency> All
        {
            get { return context.OrganizationPositionCompetency; }
        }

        public IQueryable<OrganizationPositionCompetency> AllIncluding(params Expression<Func<OrganizationPositionCompetency, object>>[] includeProperties)
        {
            IQueryable<OrganizationPositionCompetency> query = context.OrganizationPositionCompetency;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public OrganizationPositionCompetency Find(int id)
        {
            return context.OrganizationPositionCompetency.Find(id);
        }

        public void InsertOrUpdate(OrganizationPositionCompetency organizationpositioncompetency)
        {
            if (organizationpositioncompetency.OrganizationPositionCompetencyID == default(int)) {
                // New entity
                context.OrganizationPositionCompetency.Add(organizationpositioncompetency);
            } else {
                // Existing entity
                context.Entry(organizationpositioncompetency).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationpositioncompetency = context.OrganizationPositionCompetency.Find(id);
            context.OrganizationPositionCompetency.Remove(organizationpositioncompetency);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationPositionCompetencyRepository
    {
        IQueryable<OrganizationPositionCompetency> All { get; }
        IQueryable<OrganizationPositionCompetency> AllIncluding(params Expression<Func<OrganizationPositionCompetency, object>>[] includeProperties);
        OrganizationPositionCompetency Find(int id);
        void InsertOrUpdate(OrganizationPositionCompetency organizationpositioncompetency);
        void Delete(int id);
        void Save();
    }
}