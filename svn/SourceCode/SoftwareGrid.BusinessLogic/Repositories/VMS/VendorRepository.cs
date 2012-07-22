using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.DataLogic.ViewModels;

namespace SoftwareGrid.BusinessLogic.Repositories
{
    public class VendorRepository : IVendorRepository
    {
        private readonly RepositoryContext context;

        public VendorRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Vendor> All
        {
            get { return context.Vendor; }
        }

        public IQueryable<Vendor> AllIncluding(params Expression<Func<Vendor, object>>[] includeProperties)
        {
            IQueryable<Vendor> query = context.Vendor;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Vendor Find(int id)
        {
            return context.Vendor.Find(id);
        }

        public VendorOverviewHeadViewModel FindOverviewHead(int id, Vendor vendor)
        {
            if (vendor == null)
            {
                vendor = Find(id);
            }
            if (vendor != null)
            {
                VendorOverviewHeadViewModel newHead = new VendorOverviewHeadViewModel();
                newHead.Address = vendor.Address1;
                newHead.VendorDisplayId = vendor.VendorDisplayId;
                newHead.VendorEmailAddress = vendor.VendorEmailAddress;
                newHead.VendorID = vendor.VendorID;
                newHead.VendorName = vendor.VendorName;
                if (vendor.VendorLegalCompanyStructureCategory != null)
                {
                    newHead.VendorLegalCompanyStructureCategoryName = vendor.VendorLegalCompanyStructureCategory.Name;
                }
                if (vendor.VendorStatusCategory != null)
                {
                    newHead.VendorStatusCategoryName = vendor.VendorStatusCategory.Name;
                }
                newHead.EmployeeSize = vendor.EmployeeSize;
                newHead.FaxNumber = vendor.FaxNumber;
                if (vendor.Industry != null)
                {
                    newHead.IndustryName = vendor.Industry.Name;
                }
                newHead.Location = MiscUtility.GetLocation(vendor.City, vendor.State, vendor.Country);
                newHead.MainOfficePhone = vendor.MainOfficePhone;
                newHead.WebAddress = vendor.WebAddress;
                return newHead;
            }
            return null;
        }

        public void InsertOrUpdate(Vendor vendor)
        {
            if (vendor.VendorID == default(int))
            {
                // New entity
                context.Vendor.Add(vendor);
            }
            else
            {
                // Existing entity
                context.Entry(vendor).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendor = context.Vendor.Find(id);
            context.Vendor.Remove(vendor);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorRepository
    {
        IQueryable<Vendor> All { get; }
        IQueryable<Vendor> AllIncluding(params Expression<Func<Vendor, object>>[] includeProperties);
        VendorOverviewHeadViewModel FindOverviewHead(int id, Vendor vendor);
        Vendor Find(int id);
        void InsertOrUpdate(Vendor vendor);
        void Delete(int id);
        void Save();
    }
}