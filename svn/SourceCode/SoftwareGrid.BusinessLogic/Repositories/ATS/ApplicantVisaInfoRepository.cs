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
    public class ApplicantVisaInfoRepository : IApplicantVisaInfoRepository
    {
		private readonly RepositoryContext context;

        public ApplicantVisaInfoRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantVisaInfo> All
        {
            get { return context.ApplicantVisaInfo; }
        }

        public IQueryable<ApplicantVisaInfo> AllIncluding(params Expression<Func<ApplicantVisaInfo, object>>[] includeProperties)
        {
            IQueryable<ApplicantVisaInfo> query = context.ApplicantVisaInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantVisaInfo Find(int id)
        {
            return context.ApplicantVisaInfo.Find(id);
        }

        public void InsertOrUpdate(ApplicantVisaInfo applicantvisainfo)
        {
            if (applicantvisainfo.AplicantVisaInfoID == default(int)) {
                // New entity
                context.ApplicantVisaInfo.Add(applicantvisainfo);
            } else {
                // Existing entity
                context.Entry(applicantvisainfo).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantvisainfo = context.ApplicantVisaInfo.Find(id);
            context.ApplicantVisaInfo.Remove(applicantvisainfo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantVisaInfoRepository
    {
        IQueryable<ApplicantVisaInfo> All { get; }
        IQueryable<ApplicantVisaInfo> AllIncluding(params Expression<Func<ApplicantVisaInfo, object>>[] includeProperties);
        ApplicantVisaInfo Find(int id);
        void InsertOrUpdate(ApplicantVisaInfo applicantvisainfo);
        void Delete(int id);
        void Save();
    }
}