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
    public class RequisitionSkillsExpertiseEducationMatchingMatrixRepository : IRequisitionSkillsExpertiseEducationMatchingMatrixRepository
    {
		private readonly RepositoryContext context;

        public RequisitionSkillsExpertiseEducationMatchingMatrixRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<RequisitionSkillsExpertiseEducationMatchingMatrix> All
        {
            get { return context.RequisitionSkillsExpertiseEducationMatchingMatrix; }
        }

        public IQueryable<RequisitionSkillsExpertiseEducationMatchingMatrix> AllIncluding(params Expression<Func<RequisitionSkillsExpertiseEducationMatchingMatrix, object>>[] includeProperties)
        {
            IQueryable<RequisitionSkillsExpertiseEducationMatchingMatrix> query = context.RequisitionSkillsExpertiseEducationMatchingMatrix;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public RequisitionSkillsExpertiseEducationMatchingMatrix Find(int id)
        {
            return context.RequisitionSkillsExpertiseEducationMatchingMatrix.Find(id);
        }

        public void InsertOrUpdate(RequisitionSkillsExpertiseEducationMatchingMatrix requisitionskillsexpertiseeducationmatchingmatrix)
        {
            if (requisitionskillsexpertiseeducationmatchingmatrix.RequisitionSkillsExpertiseEducationMatchingMatrixID == default(int)) {
                // New entity
                context.RequisitionSkillsExpertiseEducationMatchingMatrix.Add(requisitionskillsexpertiseeducationmatchingmatrix);
            } else {
                // Existing entity
                context.Entry(requisitionskillsexpertiseeducationmatchingmatrix).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var requisitionskillsexpertiseeducationmatchingmatrix = context.RequisitionSkillsExpertiseEducationMatchingMatrix.Find(id);
            context.RequisitionSkillsExpertiseEducationMatchingMatrix.Remove(requisitionskillsexpertiseeducationmatchingmatrix);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IRequisitionSkillsExpertiseEducationMatchingMatrixRepository
    {
        IQueryable<RequisitionSkillsExpertiseEducationMatchingMatrix> All { get; }
        IQueryable<RequisitionSkillsExpertiseEducationMatchingMatrix> AllIncluding(params Expression<Func<RequisitionSkillsExpertiseEducationMatchingMatrix, object>>[] includeProperties);
        RequisitionSkillsExpertiseEducationMatchingMatrix Find(int id);
        void InsertOrUpdate(RequisitionSkillsExpertiseEducationMatchingMatrix requisitionskillsexpertiseeducationmatchingmatrix);
        void Delete(int id);
        void Save();
    }
}