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
    public class InterviewQuestionCategoryRepository : IInterviewQuestionCategoryRepository
    {
		private readonly RepositoryContext context;

        public InterviewQuestionCategoryRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<InterviewQuestionCategory> All
        {
            get { return context.InterviewQuestionCategory; }
        }

        public IQueryable<InterviewQuestionCategory> AllIncluding(params Expression<Func<InterviewQuestionCategory, object>>[] includeProperties)
        {
            IQueryable<InterviewQuestionCategory> query = context.InterviewQuestionCategory;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public InterviewQuestionCategory Find(int id)
        {
            return context.InterviewQuestionCategory.Find(id);
        }

        public void InsertOrUpdate(InterviewQuestionCategory interviewquestioncategory)
        {
            if (interviewquestioncategory.InterviewQuestionCategoryID == default(int)) {
                // New entity
                context.InterviewQuestionCategory.Add(interviewquestioncategory);
            } else {
                // Existing entity
                context.Entry(interviewquestioncategory).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var interviewquestioncategory = context.InterviewQuestionCategory.Find(id);
            context.InterviewQuestionCategory.Remove(interviewquestioncategory);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IInterviewQuestionCategoryRepository
    {
        IQueryable<InterviewQuestionCategory> All { get; }
        IQueryable<InterviewQuestionCategory> AllIncluding(params Expression<Func<InterviewQuestionCategory, object>>[] includeProperties);
        InterviewQuestionCategory Find(int id);
        void InsertOrUpdate(InterviewQuestionCategory interviewquestioncategory);
        void Delete(int id);
        void Save();
    }
}