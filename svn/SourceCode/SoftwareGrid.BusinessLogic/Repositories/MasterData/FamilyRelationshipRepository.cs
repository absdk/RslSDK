using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class FamilyRelationshipRepository : IFamilyRelationshipRepository
    {
		private readonly RepositoryContext context;

        public FamilyRelationshipRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<FamilyRelationship> All
        {
            get { return context.FamilyRelationship; }
        }

        public IQueryable<FamilyRelationship> AllIncluding(params Expression<Func<FamilyRelationship, object>>[] includeProperties)
        {
            IQueryable<FamilyRelationship> query = context.FamilyRelationship;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public FamilyRelationship Find(int id)
        {
            return context.FamilyRelationship.Find(id);
        }

        public void InsertOrUpdate(FamilyRelationship familyrelationship)
        {
            if (familyrelationship.FamilyRelationshipID == default(int)) {
                // New entity
                context.FamilyRelationship.Add(familyrelationship);
            } else {
                // Existing entity
                context.Entry(familyrelationship).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var familyrelationship = context.FamilyRelationship.Find(id);
            context.FamilyRelationship.Remove(familyrelationship);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IFamilyRelationshipRepository
    {
        IQueryable<FamilyRelationship> All { get; }
        IQueryable<FamilyRelationship> AllIncluding(params Expression<Func<FamilyRelationship, object>>[] includeProperties);
        FamilyRelationship Find(int id);
        void InsertOrUpdate(FamilyRelationship familyrelationship);
        void Delete(int id);
        void Save();
    }
}