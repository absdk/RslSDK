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
    public class ApplicantVideoRepository : IApplicantVideoRepository
    {
		private readonly RepositoryContext context;

        public ApplicantVideoRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantVideo> All
        {
            get { return context.ApplicantVideo; }
        }

        public IQueryable<ApplicantVideo> AllIncluding(params Expression<Func<ApplicantVideo, object>>[] includeProperties)
        {
            IQueryable<ApplicantVideo> query = context.ApplicantVideo;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantVideo Find(int id)
        {
            return context.ApplicantVideo.Find(id);
        }

        public void InsertOrUpdate(ApplicantVideo applicantvideo)
        {
            if (applicantvideo.ApplicantVideoID == default(int)) {
                // New entity
                context.ApplicantVideo.Add(applicantvideo);
            } else {
                // Existing entity
                context.Entry(applicantvideo).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantvideo = context.ApplicantVideo.Find(id);
            context.ApplicantVideo.Remove(applicantvideo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantVideoRepository
    {
        IQueryable<ApplicantVideo> All { get; }
        IQueryable<ApplicantVideo> AllIncluding(params Expression<Func<ApplicantVideo, object>>[] includeProperties);
        ApplicantVideo Find(int id);
        void InsertOrUpdate(ApplicantVideo applicantvideo);
        void Delete(int id);
        void Save();
    }
}