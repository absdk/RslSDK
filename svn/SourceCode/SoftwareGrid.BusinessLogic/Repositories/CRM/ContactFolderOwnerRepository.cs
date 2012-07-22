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
    public class ContactFolderOwnerRepository : IContactFolderOwnerRepository
    {
		private readonly RepositoryContext context;

        public ContactFolderOwnerRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ContactFolderOwner> All
        {
            get { return context.ContactFolderOwner; }
        }

        public IQueryable<ContactFolderOwner> AllIncluding(params Expression<Func<ContactFolderOwner, object>>[] includeProperties)
        {
            IQueryable<ContactFolderOwner> query = context.ContactFolderOwner;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ContactFolderOwner Find(int id)
        {
            return context.ContactFolderOwner.Find(id);
        }

        public void InsertOrUpdate(ContactFolderOwner contactfolderowner)
        {
            if (contactfolderowner.ContactFolderOwnerID == default(int)) {
                // New entity
                context.ContactFolderOwner.Add(contactfolderowner);
            } else {
                // Existing entity
                context.Entry(contactfolderowner).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var contactfolderowner = context.ContactFolderOwner.Find(id);
            context.ContactFolderOwner.Remove(contactfolderowner);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IContactFolderOwnerRepository
    {
        IQueryable<ContactFolderOwner> All { get; }
        IQueryable<ContactFolderOwner> AllIncluding(params Expression<Func<ContactFolderOwner, object>>[] includeProperties);
        ContactFolderOwner Find(int id);
        void InsertOrUpdate(ContactFolderOwner contactfolderowner);
        void Delete(int id);
        void Save();
    }
}