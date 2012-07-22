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
    public class ApplicantProfileThemeLibraryRepository : IApplicantProfileThemeLibraryRepository
    {
		private readonly RepositoryContext context;

        public ApplicantProfileThemeLibraryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantProfileThemeLibrary> All
        {
            get { return context.ApplicantProfileThemeLibrary; }
        }

        public IQueryable<ApplicantProfileThemeLibrary> AllIncluding(params Expression<Func<ApplicantProfileThemeLibrary, object>>[] includeProperties)
        {
            IQueryable<ApplicantProfileThemeLibrary> query = context.ApplicantProfileThemeLibrary;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantProfileThemeLibrary Find(int id)
        {
            return context.ApplicantProfileThemeLibrary.Find(id);
        }

        public void InsertOrUpdate(ApplicantProfileThemeLibrary applicantprofilethemelibrary)
        {
            if (applicantprofilethemelibrary.ApplicantProfileThemeLibraryID == default(int)) {
                // New entity
                context.ApplicantProfileThemeLibrary.Add(applicantprofilethemelibrary);
            } else {
                // Existing entity
                context.Entry(applicantprofilethemelibrary).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantprofilethemelibrary = context.ApplicantProfileThemeLibrary.Find(id);
            context.ApplicantProfileThemeLibrary.Remove(applicantprofilethemelibrary);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantProfileThemeLibraryRepository
    {
        IQueryable<ApplicantProfileThemeLibrary> All { get; }
        IQueryable<ApplicantProfileThemeLibrary> AllIncluding(params Expression<Func<ApplicantProfileThemeLibrary, object>>[] includeProperties);
        ApplicantProfileThemeLibrary Find(int id);
        void InsertOrUpdate(ApplicantProfileThemeLibrary applicantprofilethemelibrary);
        void Delete(int id);
        void Save();
    }
}