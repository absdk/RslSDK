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
    public class RequisitionJDLibraryCategoryRepository : IRequisitionJDLibraryCategoryRepository
    {
		private readonly RepositoryContext context;

        public RequisitionJDLibraryCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionJDLibraryCategory> All
        {
            get { return context.RequisitionJDLibraryCategory; }
        }

        public IQueryable<RequisitionJDLibraryCategory> AllIncluding(params Expression<Func<RequisitionJDLibraryCategory, object>>[] includeProperties)
        {
            IQueryable<RequisitionJDLibraryCategory> query = context.RequisitionJDLibraryCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionJDLibraryCategory Find(int id)
        {
            return context.RequisitionJDLibraryCategory.Find(id);
        }

        public void InsertOrUpdate(RequisitionJDLibraryCategory requisitionjdlibrarycategory)
        {
            if (requisitionjdlibrarycategory.RequisitionJDLibraryCategoryID == default(int)) {
                // New entity
                context.RequisitionJDLibraryCategory.Add(requisitionjdlibrarycategory);
            } else {
                // Existing entity
                context.Entry(requisitionjdlibrarycategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionjdlibrarycategory = context.RequisitionJDLibraryCategory.Find(id);
            context.RequisitionJDLibraryCategory.Remove(requisitionjdlibrarycategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionJDLibraryCategoryRepository
    {
        IQueryable<RequisitionJDLibraryCategory> All { get; }
        IQueryable<RequisitionJDLibraryCategory> AllIncluding(params Expression<Func<RequisitionJDLibraryCategory, object>>[] includeProperties);
        RequisitionJDLibraryCategory Find(int id);
        void InsertOrUpdate(RequisitionJDLibraryCategory requisitionjdlibrarycategory);
        void Delete(int id);
        void Save();
    }
}