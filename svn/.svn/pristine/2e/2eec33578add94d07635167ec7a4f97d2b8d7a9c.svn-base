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
    public class OrganizationNoteRepository : IOrganizationNoteRepository
    {
		private readonly RepositoryContext context;

        public OrganizationNoteRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<OrganizationNote> All
        {
            get { return context.OrganizationNote; }
        }

		public IQueryable<OrganizationNote> AllIncluding(params Expression<Func<OrganizationNote, object>>[] includeProperties)
        {
            IQueryable<OrganizationNote> query = context.OrganizationNote;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

		        public IQueryable<OrganizationNote> AllIncluding(int organizationId,params Expression<Func<OrganizationNote, object>>[] includeProperties)
        {
            IQueryable<OrganizationNote> query = context.OrganizationNote;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query.Where(item=>item.OrganizationID==organizationId);
        }
		
        public OrganizationNote Find(int id)
        {
            return context.OrganizationNote.Find(id);
        }

        public void InsertOrUpdate(OrganizationNote organizationnote)
        {
            if (organizationnote.OrganizationNoteID == default(int)) {
                // New entity
                context.OrganizationNote.Add(organizationnote);
            } else {
                // Existing entity
                context.Entry(organizationnote).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var organizationnote = context.OrganizationNote.Find(id);
            context.OrganizationNote.Remove(organizationnote);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IOrganizationNoteRepository
    {
        IQueryable<OrganizationNote> All { get; }
        IQueryable<OrganizationNote> AllIncluding(params Expression<Func<OrganizationNote, object>>[] includeProperties);
		        IQueryable<OrganizationNote> AllIncluding(int organizationId,params Expression<Func<OrganizationNote, object>>[] includeProperties);
                OrganizationNote Find(int id);
        void InsertOrUpdate(OrganizationNote organizationnote);
        void Delete(int id);
        void Save();
    }
}