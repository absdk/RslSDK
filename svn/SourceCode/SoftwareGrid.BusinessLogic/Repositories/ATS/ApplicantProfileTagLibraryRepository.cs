using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class ApplicantProfileTagLibraryRepository : IApplicantProfileTagLibraryRepository
    {
		private readonly RepositoryContext context;

        public ApplicantProfileTagLibraryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantProfileTagLibrary> All
        {
            get { return context.ApplicantProfileTagLibrary; }
        }

        public IQueryable<ApplicantProfileTagLibrary> AllIncluding(params Expression<Func<ApplicantProfileTagLibrary, object>>[] includeProperties)
        {
            IQueryable<ApplicantProfileTagLibrary> query = context.ApplicantProfileTagLibrary;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantProfileTagLibrary Find(int id)
        {
            return context.ApplicantProfileTagLibrary.Find(id);
        }

        public void InsertOrUpdate(ApplicantProfileTagLibrary applicantprofiletaglibrary)
        {
            if (applicantprofiletaglibrary.ApplicantProfileTagLibraryID == default(int)) {
                // New entity
                context.ApplicantProfileTagLibrary.Add(applicantprofiletaglibrary);
            } else {
                // Existing entity
                context.Entry(applicantprofiletaglibrary).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantprofiletaglibrary = context.ApplicantProfileTagLibrary.Find(id);
            context.ApplicantProfileTagLibrary.Remove(applicantprofiletaglibrary);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantProfileTagLibraryRepository
    {
        IQueryable<ApplicantProfileTagLibrary> All { get; }
        IQueryable<ApplicantProfileTagLibrary> AllIncluding(params Expression<Func<ApplicantProfileTagLibrary, object>>[] includeProperties);
        ApplicantProfileTagLibrary Find(int id);
        void InsertOrUpdate(ApplicantProfileTagLibrary applicantprofiletaglibrary);
        void Delete(int id);
        void Save();
    }
}