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
    public class ApplicantAdditionalInfoRepository : IApplicantAdditionalInfoRepository
    {
		private readonly RepositoryContext context;

        public ApplicantAdditionalInfoRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantAdditionalInfo> All
        {
            get { return context.ApplicantAdditionalInfo; }
        }

        public IQueryable<ApplicantAdditionalInfo> AllIncluding(params Expression<Func<ApplicantAdditionalInfo, object>>[] includeProperties)
        {
            IQueryable<ApplicantAdditionalInfo> query = context.ApplicantAdditionalInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantAdditionalInfo Find(int id)
        {
            return context.ApplicantAdditionalInfo.Find(id);
        }

        public ApplicantAdditionalInfo FindByApplicantId(int applicantId)
        {
            return context.ApplicantAdditionalInfo.SingleOrDefault(applicant => applicant.ApplicantID == applicantId);
        }

        public void InsertOrUpdate(ApplicantAdditionalInfo applicantadditionalinfo)
        {
            if (applicantadditionalinfo.ApplicantAdditionalInfoID == default(int)) {
                // New entity
                context.ApplicantAdditionalInfo.Add(applicantadditionalinfo);
            } else {
                // Existing entity
                context.Entry(applicantadditionalinfo).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantadditionalinfo = context.ApplicantAdditionalInfo.Find(id);
            context.ApplicantAdditionalInfo.Remove(applicantadditionalinfo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantAdditionalInfoRepository
    {
        IQueryable<ApplicantAdditionalInfo> All { get; }
        IQueryable<ApplicantAdditionalInfo> AllIncluding(params Expression<Func<ApplicantAdditionalInfo, object>>[] includeProperties);
        ApplicantAdditionalInfo Find(int id);
        ApplicantAdditionalInfo FindByApplicantId(int id);
        void InsertOrUpdate(ApplicantAdditionalInfo applicantadditionalinfo);
        void Delete(int id);
        void Save();
    }
}