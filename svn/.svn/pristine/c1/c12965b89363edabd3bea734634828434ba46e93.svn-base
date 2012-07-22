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
    public class ApplicantSubmissionInfoRepository : IApplicantSubmissionInfoRepository
    {
		private readonly RepositoryContext context;

        public ApplicantSubmissionInfoRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantSubmissionInfo> All
        {
            get { return context.ApplicantSubmissionInfo; }
        }

        public IQueryable<ApplicantSubmissionInfo> AllIncluding(params Expression<Func<ApplicantSubmissionInfo, object>>[] includeProperties)
        {
            IQueryable<ApplicantSubmissionInfo> query = context.ApplicantSubmissionInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantSubmissionInfo Find(int id)
        {
            return context.ApplicantSubmissionInfo.Find(id);
        }

        public void InsertOrUpdate(ApplicantSubmissionInfo applicantsubmissioninfo)
        {
            if (applicantsubmissioninfo.ApplicantSubmissionWithoutRequisitionID == default(int)) {
                // New entity
                context.ApplicantSubmissionInfo.Add(applicantsubmissioninfo);
            } else {
                // Existing entity
                context.Entry(applicantsubmissioninfo).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantsubmissioninfo = context.ApplicantSubmissionInfo.Find(id);
            context.ApplicantSubmissionInfo.Remove(applicantsubmissioninfo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantSubmissionInfoRepository
    {
        IQueryable<ApplicantSubmissionInfo> All { get; }
        IQueryable<ApplicantSubmissionInfo> AllIncluding(params Expression<Func<ApplicantSubmissionInfo, object>>[] includeProperties);
        ApplicantSubmissionInfo Find(int id);
        void InsertOrUpdate(ApplicantSubmissionInfo applicantsubmissioninfo);
        void Delete(int id);
        void Save();
    }
}