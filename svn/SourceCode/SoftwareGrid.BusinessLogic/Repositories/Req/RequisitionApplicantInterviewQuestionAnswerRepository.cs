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
    public class RequisitionApplicantInterviewQuestionAnswerRepository : IRequisitionApplicantInterviewQuestionAnswerRepository
    {
		private readonly RepositoryContext context;

        public RequisitionApplicantInterviewQuestionAnswerRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionApplicantInterviewQuestionAnswer> All
        {
            get { return context.RequisitionApplicantInterviewQuestionAnswer; }
        }

        public IQueryable<RequisitionApplicantInterviewQuestionAnswer> AllIncluding(params Expression<Func<RequisitionApplicantInterviewQuestionAnswer, object>>[] includeProperties)
        {
            IQueryable<RequisitionApplicantInterviewQuestionAnswer> query = context.RequisitionApplicantInterviewQuestionAnswer;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionApplicantInterviewQuestionAnswer Find(int id)
        {
            return context.RequisitionApplicantInterviewQuestionAnswer.Find(id);
        }

        public void InsertOrUpdate(RequisitionApplicantInterviewQuestionAnswer requisitionapplicantinterviewquestionanswer)
        {
            if (requisitionapplicantinterviewquestionanswer.RequisitionApplicantInterviewQuestionAnswerID == default(int)) {
                // New entity
                context.RequisitionApplicantInterviewQuestionAnswer.Add(requisitionapplicantinterviewquestionanswer);
            } else {
                // Existing entity
                context.Entry(requisitionapplicantinterviewquestionanswer).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionapplicantinterviewquestionanswer = context.RequisitionApplicantInterviewQuestionAnswer.Find(id);
            context.RequisitionApplicantInterviewQuestionAnswer.Remove(requisitionapplicantinterviewquestionanswer);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionApplicantInterviewQuestionAnswerRepository
    {
        IQueryable<RequisitionApplicantInterviewQuestionAnswer> All { get; }
        IQueryable<RequisitionApplicantInterviewQuestionAnswer> AllIncluding(params Expression<Func<RequisitionApplicantInterviewQuestionAnswer, object>>[] includeProperties);
        RequisitionApplicantInterviewQuestionAnswer Find(int id);
        void InsertOrUpdate(RequisitionApplicantInterviewQuestionAnswer requisitionapplicantinterviewquestionanswer);
        void Delete(int id);
        void Save();
    }
}