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
    public class ApplicantInResumeFolderRepository : IApplicantInResumeFolderRepository
    {
		private readonly RepositoryContext context;

        public ApplicantInResumeFolderRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantInResumeFolder> All
        {
            get { return context.ApplicantInResumeFolder; }
        }

        public IQueryable<ApplicantInResumeFolder> AllIncluding(params Expression<Func<ApplicantInResumeFolder, object>>[] includeProperties)
        {
            IQueryable<ApplicantInResumeFolder> query = context.ApplicantInResumeFolder;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantInResumeFolder Find(int id)
        {
            return context.ApplicantInResumeFolder.Find(id);
        }

        public void InsertOrUpdate(ApplicantInResumeFolder applicantinresumefolder)
        {
            if (applicantinresumefolder.ApplicantInResumeFolderID == default(int)) {
                // New entity
                context.ApplicantInResumeFolder.Add(applicantinresumefolder);
            } else {
                // Existing entity
                context.Entry(applicantinresumefolder).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantinresumefolder = context.ApplicantInResumeFolder.Find(id);
            context.ApplicantInResumeFolder.Remove(applicantinresumefolder);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantInResumeFolderRepository
    {
        IQueryable<ApplicantInResumeFolder> All { get; }
        IQueryable<ApplicantInResumeFolder> AllIncluding(params Expression<Func<ApplicantInResumeFolder, object>>[] includeProperties);
        ApplicantInResumeFolder Find(int id);
        void InsertOrUpdate(ApplicantInResumeFolder applicantinresumefolder);
        void Delete(int id);
        void Save();
    }
}