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
    public class ApplicantPassportInfoRepository : IApplicantPassportInfoRepository
    {
		private readonly RepositoryContext context;

        public ApplicantPassportInfoRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantPassportInfo> All
        {
            get { return context.ApplicantPassportInfo; }
        }

        public IQueryable<ApplicantPassportInfo> AllIncluding(params Expression<Func<ApplicantPassportInfo, object>>[] includeProperties)
        {
            IQueryable<ApplicantPassportInfo> query = context.ApplicantPassportInfo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantPassportInfo Find(int id)
        {
            return context.ApplicantPassportInfo.Find(id);
        }

        public void InsertOrUpdate(ApplicantPassportInfo applicantpassportinfo)
        {
            if (applicantpassportinfo.ApplicantPassportInfoID == default(int)) {
                // New entity
                context.ApplicantPassportInfo.Add(applicantpassportinfo);
            } else {
                // Existing entity
                context.Entry(applicantpassportinfo).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantpassportinfo = context.ApplicantPassportInfo.Find(id);
            context.ApplicantPassportInfo.Remove(applicantpassportinfo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantPassportInfoRepository
    {
        IQueryable<ApplicantPassportInfo> All { get; }
        IQueryable<ApplicantPassportInfo> AllIncluding(params Expression<Func<ApplicantPassportInfo, object>>[] includeProperties);
        ApplicantPassportInfo Find(int id);
        void InsertOrUpdate(ApplicantPassportInfo applicantpassportinfo);
        void Delete(int id);
        void Save();
    }
}