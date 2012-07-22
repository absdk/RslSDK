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
    public class ApplicantNoteRepository : IApplicantNoteRepository
    {
		private readonly RepositoryContext context;

        public ApplicantNoteRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ApplicantNote> All
        {
            get { return context.ApplicantNote; }
        }

        public IQueryable<ApplicantNote> AllIncluding(params Expression<Func<ApplicantNote, object>>[] includeProperties)
        {
            IQueryable<ApplicantNote> query = context.ApplicantNote;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ApplicantNote Find(int id)
        {
            return context.ApplicantNote.Find(id);
        }

        public void InsertOrUpdate(ApplicantNote applicantnote)
        {
            if (applicantnote.ApplicantNoteID == default(int)) {
                // New entity
                context.ApplicantNote.Add(applicantnote);
            } else {
                // Existing entity
                context.Entry(applicantnote).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var applicantnote = context.ApplicantNote.Find(id);
            context.ApplicantNote.Remove(applicantnote);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IApplicantNoteRepository
    {
        IQueryable<ApplicantNote> All { get; }
        IQueryable<ApplicantNote> AllIncluding(params Expression<Func<ApplicantNote, object>>[] includeProperties);
        ApplicantNote Find(int id);
        void InsertOrUpdate(ApplicantNote applicantnote);
        void Delete(int id);
        void Save();
    }
}