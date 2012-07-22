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
    public class VendorSupplierDiversityCertificateInfoRepository : IVendorSupplierDiversityCertificateInfoRepository
    {
		private readonly RepositoryContext context;

        public VendorSupplierDiversityCertificateInfoRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<VendorSupplierDiversityCertificateInfo> All
        {
            get { return context.VendorSupplierDiversityCertificateInfo; }
        }

		public IQueryable<VendorSupplierDiversityCertificateInfo> AllIncluding(params Expression<Func<VendorSupplierDiversityCertificateInfo, object>>[] includeProperties)
        {
            IQueryable<VendorSupplierDiversityCertificateInfo> query = context.VendorSupplierDiversityCertificateInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<VendorSupplierDiversityCertificateInfo> AllIncluding(int vendorId,params Expression<Func<VendorSupplierDiversityCertificateInfo, object>>[] includeProperties)
        {
            IQueryable<VendorSupplierDiversityCertificateInfo> query = context.VendorSupplierDiversityCertificateInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.VendorID==vendorId);
        }
		
        public VendorSupplierDiversityCertificateInfo Find(int id)
        {
            return context.VendorSupplierDiversityCertificateInfo.Find(id);
        }

        public void InsertOrUpdate(VendorSupplierDiversityCertificateInfo vendorsupplierdiversitycertificateinfo)
        {
            if (vendorsupplierdiversitycertificateinfo.VendorSupplierDiversityCertificateInfoID == default(int)) {
                // New entity
                context.VendorSupplierDiversityCertificateInfo.Add(vendorsupplierdiversitycertificateinfo);
            } else {
                // Existing entity
                context.Entry(vendorsupplierdiversitycertificateinfo).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var vendorsupplierdiversitycertificateinfo = context.VendorSupplierDiversityCertificateInfo.Find(id);
            context.VendorSupplierDiversityCertificateInfo.Remove(vendorsupplierdiversitycertificateinfo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IVendorSupplierDiversityCertificateInfoRepository
    {
        IQueryable<VendorSupplierDiversityCertificateInfo> All { get; }
        IQueryable<VendorSupplierDiversityCertificateInfo> AllIncluding(params Expression<Func<VendorSupplierDiversityCertificateInfo, object>>[] includeProperties);
		        IQueryable<VendorSupplierDiversityCertificateInfo> AllIncluding(int vendorId,params Expression<Func<VendorSupplierDiversityCertificateInfo, object>>[] includeProperties);
                VendorSupplierDiversityCertificateInfo Find(int id);
        void InsertOrUpdate(VendorSupplierDiversityCertificateInfo vendorsupplierdiversitycertificateinfo);
        void Delete(int id);
        void Save();
    }
}