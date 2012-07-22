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
    public class ApplicantProfilePublishRepository : IApplicantProfilePublishRepository
    {
		private readonly RepositoryContext context;

        public ApplicantProfilePublishRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantProfilePublish> All
        {
            get { return context.ApplicantProfilePublish; }
        }

        public IQueryable<ApplicantProfilePublish> AllIncluding(params Expression<Func<ApplicantProfilePublish, object>>[] includeProperties)
        {
            IQueryable<ApplicantProfilePublish> query = context.ApplicantProfilePublish;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantProfilePublish Find(int id)
        {
            return context.ApplicantProfilePublish.Find(id);
        }

        public void InsertOrUpdate(ApplicantProfilePublish applicantprofilepublish)
        {
            if (applicantprofilepublish.ApplicantProfilePublishID == default(int)) {
                // New entity
                context.ApplicantProfilePublish.Add(applicantprofilepublish);
            } else {
                // Existing entity
                context.Entry(applicantprofilepublish).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantprofilepublish = context.ApplicantProfilePublish.Find(id);
            context.ApplicantProfilePublish.Remove(applicantprofilepublish);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantProfilePublishRepository
    {
        IQueryable<ApplicantProfilePublish> All { get; }
        IQueryable<ApplicantProfilePublish> AllIncluding(params Expression<Func<ApplicantProfilePublish, object>>[] includeProperties);
        ApplicantProfilePublish Find(int id);
        void InsertOrUpdate(ApplicantProfilePublish applicantprofilepublish);
        void Delete(int id);
        void Save();
    }
}