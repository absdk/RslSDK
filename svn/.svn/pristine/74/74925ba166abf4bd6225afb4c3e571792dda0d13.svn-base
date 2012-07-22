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
    public class ApplicantAdditionalAddressRepository : IApplicantAdditionalAddressRepository
    {
		private readonly RepositoryContext context;

        public ApplicantAdditionalAddressRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantAdditionalAddress> All
        {
            get { return context.ApplicantAdditionalAddress; }
        }

        public IQueryable<ApplicantAdditionalAddress> AllIncluding(int applicantId,params Expression<Func<ApplicantAdditionalAddress, object>>[] includeProperties)
        {
            IQueryable<ApplicantAdditionalAddress> query = context.ApplicantAdditionalAddress;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.ApplicantID==applicantId);
        }

        public ApplicantAdditionalAddress Find(int id)
        {
            return context.ApplicantAdditionalAddress.Find(id);
        }

        public void InsertOrUpdate(ApplicantAdditionalAddress applicantadditionaladdress)
        {
            if (applicantadditionaladdress.ApplicantAdditionalAddressID == default(int)) {
                // New entity
                context.ApplicantAdditionalAddress.Add(applicantadditionaladdress);
            } else {
                // Existing entity
                context.Entry(applicantadditionaladdress).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantadditionaladdress = context.ApplicantAdditionalAddress.Find(id);
            context.ApplicantAdditionalAddress.Remove(applicantadditionaladdress);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantAdditionalAddressRepository
    {
        IQueryable<ApplicantAdditionalAddress> All { get; }
        IQueryable<ApplicantAdditionalAddress> AllIncluding(int applicantId,params Expression<Func<ApplicantAdditionalAddress, object>>[] includeProperties);
        ApplicantAdditionalAddress Find(int id);
        void InsertOrUpdate(ApplicantAdditionalAddress applicantadditionaladdress);
        void Delete(int id);
        void Save();
    }
}