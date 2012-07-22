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
using SoftwareGrid.BusinessLogic.Helpers;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class CompanyRepository : ICompanyRepository
    {
		private readonly RepositoryContext context;

        public CompanyRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Company> All
        {
            get { return context.Company; }
        }

        public IQueryable<Company> AllIncluding(params Expression<Func<Company, object>>[] includeProperties)
        {
            IQueryable<Company> query = context.Company;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Company Find(int id)
        {
            return context.Company.Find(id);
        }

        public CompanyOverviewHeadViewModel FindOverviewHead(int id, Company company)
        {
            if (company == null)
            {
                company = Find(id);
            }
            if (company != null)
            {
                CompanyOverviewHeadViewModel newHead = new CompanyOverviewHeadViewModel();
                newHead.Address = company.Address1;
                newHead.CompanyDisplayId = company.CompanyDisplayId;
                newHead.CompanyEmailAddress = company.CompanyEmailAddress;
                newHead.CompanyID = company.CompanyID;
                newHead.CompanyName = company.CompanyName;
                newHead.CompanyRatingScaleIDForHeader = company.CompanyRatingScaleID;
                if (company.CompanyStatusCategory != null)
                {
                    newHead.CompanyStatusCategoryName = company.CompanyStatusCategory.Name;
                }
                newHead.EmployeeSize = company.EmployeeSize;
                newHead.FaxNumber = company.FaxNumber;
                if (company.Industry != null)
                {
                    newHead.IndustryName = company.Industry.Name;
                }
                newHead.Location = MiscUtility.GetLocation(company.City, company.State, company.Country);
                newHead.MainOfficePhone = company.MainOfficePhone;
                newHead.WebAddress = company.WebAddress;
                return newHead;
            }
            return null;
        }

        public void InsertOrUpdate(Company company)
        {
            if (company.CompanyID == default(int)) {
                // New entity
                context.Company.Add(company);
            } else {
                // Existing entity
                context.Entry(company).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var company = context.Company.Find(id);
            context.Company.Remove(company);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface ICompanyRepository
    {
        IQueryable<Company> All { get; }
        IQueryable<Company> AllIncluding(params Expression<Func<Company, object>>[] includeProperties);
        Company Find(int id);
        CompanyOverviewHeadViewModel FindOverviewHead(int id,Company company);
        void InsertOrUpdate(Company company);
        void Delete(int id);
        void Save();
    }
}