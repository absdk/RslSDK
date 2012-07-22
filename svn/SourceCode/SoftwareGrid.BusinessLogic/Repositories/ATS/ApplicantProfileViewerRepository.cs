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
    public class ApplicantProfileViewerRepository : IApplicantProfileViewerRepository
    {
		private readonly RepositoryContext context;

        public ApplicantProfileViewerRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantProfileViewer> All
        {
            get { return context.ApplicantProfileViewer; }
        }

        public IQueryable<ApplicantProfileViewer> AllIncluding(params Expression<Func<ApplicantProfileViewer, object>>[] includeProperties)
        {
            IQueryable<ApplicantProfileViewer> query = context.ApplicantProfileViewer;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantProfileViewer Find(int id)
        {
            return context.ApplicantProfileViewer.Find(id);
        }

        public void InsertOrUpdate(ApplicantProfileViewer applicantprofileviewer)
        {
            if (applicantprofileviewer.ApplicantProfileViewerID == default(int)) {
                // New entity
                context.ApplicantProfileViewer.Add(applicantprofileviewer);
            } else {
                // Existing entity
                context.Entry(applicantprofileviewer).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantprofileviewer = context.ApplicantProfileViewer.Find(id);
            context.ApplicantProfileViewer.Remove(applicantprofileviewer);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantProfileViewerRepository
    {
        IQueryable<ApplicantProfileViewer> All { get; }
        IQueryable<ApplicantProfileViewer> AllIncluding(params Expression<Func<ApplicantProfileViewer, object>>[] includeProperties);
        ApplicantProfileViewer Find(int id);
        void InsertOrUpdate(ApplicantProfileViewer applicantprofileviewer);
        void Delete(int id);
        void Save();
    }
}