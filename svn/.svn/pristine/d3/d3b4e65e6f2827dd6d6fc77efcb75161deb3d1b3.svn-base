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
    public class ApplicantProfileRequestListRepository : IApplicantProfileRequestListRepository
    {
		private readonly RepositoryContext context;

        public ApplicantProfileRequestListRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantProfileRequestList> All
        {
            get { return context.ApplicantProfileRequestList; }
        }

        public IQueryable<ApplicantProfileRequestList> AllIncluding(params Expression<Func<ApplicantProfileRequestList, object>>[] includeProperties)
        {
            IQueryable<ApplicantProfileRequestList> query = context.ApplicantProfileRequestList;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantProfileRequestList Find(int id)
        {
            return context.ApplicantProfileRequestList.Find(id);
        }

        public void InsertOrUpdate(ApplicantProfileRequestList applicantprofilerequestlist)
        {
            if (applicantprofilerequestlist.ApplicantProfileRequestListID == default(int)) {
                // New entity
                context.ApplicantProfileRequestList.Add(applicantprofilerequestlist);
            } else {
                // Existing entity
                context.Entry(applicantprofilerequestlist).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantprofilerequestlist = context.ApplicantProfileRequestList.Find(id);
            context.ApplicantProfileRequestList.Remove(applicantprofilerequestlist);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantProfileRequestListRepository
    {
        IQueryable<ApplicantProfileRequestList> All { get; }
        IQueryable<ApplicantProfileRequestList> AllIncluding(params Expression<Func<ApplicantProfileRequestList, object>>[] includeProperties);
        ApplicantProfileRequestList Find(int id);
        void InsertOrUpdate(ApplicantProfileRequestList applicantprofilerequestlist);
        void Delete(int id);
        void Save();
    }
}