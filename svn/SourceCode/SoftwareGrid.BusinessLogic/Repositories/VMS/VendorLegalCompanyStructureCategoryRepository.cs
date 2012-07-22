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
    public class VendorLegalCompanyStructureCategoryRepository : IVendorLegalCompanyStructureCategoryRepository
    {
		private readonly RepositoryContext context;

        public VendorLegalCompanyStructureCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorLegalCompanyStructureCategory> All
        {
            get { return context.VendorLegalCompanyStructureCategory; }
        }

        public IQueryable<VendorLegalCompanyStructureCategory> AllIncluding(params Expression<Func<VendorLegalCompanyStructureCategory, object>>[] includeProperties)
        {
            IQueryable<VendorLegalCompanyStructureCategory> query = context.VendorLegalCompanyStructureCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public VendorLegalCompanyStructureCategory Find(int id)
        {
            return context.VendorLegalCompanyStructureCategory.Find(id);
        }

        public void InsertOrUpdate(VendorLegalCompanyStructureCategory vendorlegalcompanystructurecategory)
        {
            if (vendorlegalcompanystructurecategory.VendorLegalCompanyStructureCategoryID == default(int)) {
                // New entity
                context.VendorLegalCompanyStructureCategory.Add(vendorlegalcompanystructurecategory);
            } else {
                // Existing entity
                context.Entry(vendorlegalcompanystructurecategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorlegalcompanystructurecategory = context.VendorLegalCompanyStructureCategory.Find(id);
            context.VendorLegalCompanyStructureCategory.Remove(vendorlegalcompanystructurecategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorLegalCompanyStructureCategoryRepository
    {
        IQueryable<VendorLegalCompanyStructureCategory> All { get; }
        IQueryable<VendorLegalCompanyStructureCategory> AllIncluding(params Expression<Func<VendorLegalCompanyStructureCategory, object>>[] includeProperties);
        VendorLegalCompanyStructureCategory Find(int id);
        void InsertOrUpdate(VendorLegalCompanyStructureCategory vendorlegalcompanystructurecategory);
        void Delete(int id);
        void Save();
    }
}