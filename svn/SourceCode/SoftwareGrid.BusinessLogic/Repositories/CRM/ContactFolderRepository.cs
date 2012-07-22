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
    public class ContactFolderRepository : IContactFolderRepository
    {
		private readonly RepositoryContext context;

        public ContactFolderRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ContactFolder> All
        {
            get { return context.ContactFolder; }
        }

        public IQueryable<ContactFolder> AllIncluding(params Expression<Func<ContactFolder, object>>[] includeProperties)
        {
            IQueryable<ContactFolder> query = context.ContactFolder;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ContactFolder Find(int id)
        {
            return context.ContactFolder.Find(id);
        }

        public void InsertOrUpdate(ContactFolder contactfolder)
        {
            if (contactfolder.ContactFolderID == default(int)) {
                // New entity
                context.ContactFolder.Add(contactfolder);
            } else {
                // Existing entity
                context.Entry(contactfolder).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var contactfolder = context.ContactFolder.Find(id);
            context.ContactFolder.Remove(contactfolder);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IContactFolderRepository
    {
        IQueryable<ContactFolder> All { get; }
        IQueryable<ContactFolder> AllIncluding(params Expression<Func<ContactFolder, object>>[] includeProperties);
        ContactFolder Find(int id);
        void InsertOrUpdate(ContactFolder contactfolder);
        void Delete(int id);
        void Save();
    }
}