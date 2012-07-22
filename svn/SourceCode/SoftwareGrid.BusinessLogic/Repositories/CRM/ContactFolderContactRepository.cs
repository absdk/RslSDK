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
    public class ContactFolderContactRepository : IContactFolderContactRepository
    {
		private readonly RepositoryContext context;

        public ContactFolderContactRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ContactFolderContact> All
        {
            get { return context.ContactFolderContact; }
        }

        public IQueryable<ContactFolderContact> AllIncluding(params Expression<Func<ContactFolderContact, object>>[] includeProperties)
        {
            IQueryable<ContactFolderContact> query = context.ContactFolderContact;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ContactFolderContact Find(int id)
        {
            return context.ContactFolderContact.Find(id);
        }

        public void InsertOrUpdate(ContactFolderContact contactfoldercontact)
        {
            if (contactfoldercontact.ContactFolderContactID == default(int)) {
                // New entity
                context.ContactFolderContact.Add(contactfoldercontact);
            } else {
                // Existing entity
                context.Entry(contactfoldercontact).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var contactfoldercontact = context.ContactFolderContact.Find(id);
            context.ContactFolderContact.Remove(contactfoldercontact);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IContactFolderContactRepository
    {
        IQueryable<ContactFolderContact> All { get; }
        IQueryable<ContactFolderContact> AllIncluding(params Expression<Func<ContactFolderContact, object>>[] includeProperties);
        ContactFolderContact Find(int id);
        void InsertOrUpdate(ContactFolderContact contactfoldercontact);
        void Delete(int id);
        void Save();
    }
}