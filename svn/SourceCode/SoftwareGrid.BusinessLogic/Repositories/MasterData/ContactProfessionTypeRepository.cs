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
    public class ContactProfessionTypeRepository : IContactProfessionTypeRepository
    {
		private readonly RepositoryContext context;

        public ContactProfessionTypeRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<ContactProfessionType> All
        {
            get { return context.ContactProfessionType; }
        }

        public IQueryable<ContactProfessionType> AllIncluding(params Expression<Func<ContactProfessionType, object>>[] includeProperties)
        {
            IQueryable<ContactProfessionType> query = context.ContactProfessionType;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public ContactProfessionType Find(int id)
        {
            return context.ContactProfessionType.Find(id);
        }

        public void InsertOrUpdate(ContactProfessionType contactprofessiontype)
        {
            if (contactprofessiontype.ContactProfessionTypeID == default(int)) {
                // New entity
                context.ContactProfessionType.Add(contactprofessiontype);
            } else {
                // Existing entity
                context.Entry(contactprofessiontype).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var contactprofessiontype = context.ContactProfessionType.Find(id);
            context.ContactProfessionType.Remove(contactprofessiontype);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IContactProfessionTypeRepository
    {
        IQueryable<ContactProfessionType> All { get; }
        IQueryable<ContactProfessionType> AllIncluding(params Expression<Func<ContactProfessionType, object>>[] includeProperties);
        ContactProfessionType Find(int id);
        void InsertOrUpdate(ContactProfessionType contactprofessiontype);
        void Delete(int id);
        void Save();
    }
}