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
    public class InterviewQuestionAnswerRepository : IInterviewQuestionAnswerRepository
    {
		private readonly RepositoryContext context;

        public InterviewQuestionAnswerRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<InterviewQuestionAnswer> All
        {
            get { return context.InterviewQuestionAnswer; }
        }

        public IQueryable<InterviewQuestionAnswer> AllIncluding(params Expression<Func<InterviewQuestionAnswer, object>>[] includeProperties)
        {
            IQueryable<InterviewQuestionAnswer> query = context.InterviewQuestionAnswer;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public InterviewQuestionAnswer Find(int id)
        {
            return context.InterviewQuestionAnswer.Find(id);
        }

        public void InsertOrUpdate(InterviewQuestionAnswer interviewquestionanswer)
        {
            if (interviewquestionanswer.InterviewQuestionAnswerID == default(int)) {
                // New entity
                context.InterviewQuestionAnswer.Add(interviewquestionanswer);
            } else {
                // Existing entity
                context.Entry(interviewquestionanswer).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var interviewquestionanswer = context.InterviewQuestionAnswer.Find(id);
            context.InterviewQuestionAnswer.Remove(interviewquestionanswer);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IInterviewQuestionAnswerRepository
    {
        IQueryable<InterviewQuestionAnswer> All { get; }
        IQueryable<InterviewQuestionAnswer> AllIncluding(params Expression<Func<InterviewQuestionAnswer, object>>[] includeProperties);
        InterviewQuestionAnswer Find(int id);
        void InsertOrUpdate(InterviewQuestionAnswer interviewquestionanswer);
        void Delete(int id);
        void Save();
    }
}