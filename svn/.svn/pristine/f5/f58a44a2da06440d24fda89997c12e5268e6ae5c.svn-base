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
    public class ApplicantResumeFolderRepository : IApplicantResumeFolderRepository
    {
		private readonly RepositoryContext context;

        public ApplicantResumeFolderRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantResumeFolder> All
        {
            get { return context.ApplicantResumeFolder; }
        }

        public IQueryable<ApplicantResumeFolder> AllIncluding(params Expression<Func<ApplicantResumeFolder, object>>[] includeProperties)
        {
            IQueryable<ApplicantResumeFolder> query = context.ApplicantResumeFolder;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantResumeFolder Find(int id)
        {
            return context.ApplicantResumeFolder.Find(id);
        }

        public void InsertOrUpdate(ApplicantResumeFolder applicantresumefolder)
        {
            if (applicantresumefolder.ApplicantResumeFolderID == default(int)) {
                // New entity
                context.ApplicantResumeFolder.Add(applicantresumefolder);
            } else {
                // Existing entity
                context.Entry(applicantresumefolder).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantresumefolder = context.ApplicantResumeFolder.Find(id);
            context.ApplicantResumeFolder.Remove(applicantresumefolder);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantResumeFolderRepository
    {
        IQueryable<ApplicantResumeFolder> All { get; }
        IQueryable<ApplicantResumeFolder> AllIncluding(params Expression<Func<ApplicantResumeFolder, object>>[] includeProperties);
        ApplicantResumeFolder Find(int id);
        void InsertOrUpdate(ApplicantResumeFolder applicantresumefolder);
        void Delete(int id);
        void Save();
    }
}