using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.ViewModels;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class OrganizationRepository : IOrganizationRepository
    {
		private readonly RepositoryContext context;

        public OrganizationRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Organization> All
        {
            get { return context.Organization; }
        }

		public IQueryable<Organization> AllIncluding(params Expression<Func<Organization, object>>[] includeProperties)
        {
            IQueryable<Organization> query = context.Organization;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public OrganizationOverviewHeadViewModel FindOverviewHead(int id,Organization organization)
        {
            OrganizationOverviewHeadViewModel newOrganizationOverviewHeadViewModel = new OrganizationOverviewHeadViewModel();
            if (organization == null)
            {
                organization = Find(id);
            }
            newOrganizationOverviewHeadViewModel.LegalBusinessName = organization.LegalBusinessName;
            newOrganizationOverviewHeadViewModel.Name = organization.Name;
            newOrganizationOverviewHeadViewModel.NumberOfBusinessDivisions = 0;
            newOrganizationOverviewHeadViewModel.NumberOfDepartments = 0;
            newOrganizationOverviewHeadViewModel.NumberOfEmployees = 0;
            newOrganizationOverviewHeadViewModel.NumberOfPositions = 0;
            newOrganizationOverviewHeadViewModel.NumberOfProjects = 0;
            if (organization.OrganizationCategory != null)
            {
                newOrganizationOverviewHeadViewModel.OrganizationCategoryName = organization.OrganizationCategory.Name;
            }
            newOrganizationOverviewHeadViewModel.OrganizationCodeNumber = organization.OrganizationCodeNumber;
            newOrganizationOverviewHeadViewModel.OrganizationID = organization.OrganizationID;
            if (organization.ParentOrganization != null)
            {
                newOrganizationOverviewHeadViewModel.ParentOrganizationName = organization.ParentOrganization.Name;
            }
            return newOrganizationOverviewHeadViewModel;
        }
		
        public Organization Find(int id)
        {
            return context.Organization.Find(id);
        }

        public void InsertOrUpdate(Organization organization)
        {
            if (organization.OrganizationID == default(int)) {
                // New entity
                context.Organization.Add(organization);
            } else {
                // Existing entity
                context.Entry(organization).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organization = context.Organization.Find(id);
            context.Organization.Remove(organization);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationRepository
    {
        IQueryable<Organization> All { get; }
        IQueryable<Organization> AllIncluding(params Expression<Func<Organization, object>>[] includeProperties);
        Organization Find(int id);
        OrganizationOverviewHeadViewModel FindOverviewHead(int id, Organization organization);
        void InsertOrUpdate(Organization organization);
        void Delete(int id);
        void Save();
    }
}