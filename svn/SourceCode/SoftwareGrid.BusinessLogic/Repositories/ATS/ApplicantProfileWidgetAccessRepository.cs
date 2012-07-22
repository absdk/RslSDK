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
    public class ApplicantProfileWidgetAccessRepository : IApplicantProfileWidgetAccessRepository
    {
		private readonly RepositoryContext context;

        public ApplicantProfileWidgetAccessRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantProfileWidgetAccess> All
        {
            get { return context.ApplicantProfileWidgetAccess; }
        }

        public IQueryable<ApplicantProfileWidgetAccess> AllIncluding(params Expression<Func<ApplicantProfileWidgetAccess, object>>[] includeProperties)
        {
            IQueryable<ApplicantProfileWidgetAccess> query = context.ApplicantProfileWidgetAccess;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantProfileWidgetAccess Find(int id)
        {
            return context.ApplicantProfileWidgetAccess.Find(id);
        }

        public void InsertOrUpdate(ApplicantProfileWidgetAccess applicantprofilewidgetaccess)
        {
            if (applicantprofilewidgetaccess.ApplicantProfileWidgetAccessID == default(int)) {
                // New entity
                context.ApplicantProfileWidgetAccess.Add(applicantprofilewidgetaccess);
            } else {
                // Existing entity
                context.Entry(applicantprofilewidgetaccess).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantprofilewidgetaccess = context.ApplicantProfileWidgetAccess.Find(id);
            context.ApplicantProfileWidgetAccess.Remove(applicantprofilewidgetaccess);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantProfileWidgetAccessRepository
    {
        IQueryable<ApplicantProfileWidgetAccess> All { get; }
        IQueryable<ApplicantProfileWidgetAccess> AllIncluding(params Expression<Func<ApplicantProfileWidgetAccess, object>>[] includeProperties);
        ApplicantProfileWidgetAccess Find(int id);
        void InsertOrUpdate(ApplicantProfileWidgetAccess applicantprofilewidgetaccess);
        void Delete(int id);
        void Save();
    }
}