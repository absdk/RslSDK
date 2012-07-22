using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.ExceptionLogging;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class UserRepository : IUserRepository
    {
		private readonly RepositoryContext context;

        public UserRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<User> All
        {
            get { return context.User; }
        }

        public IQueryable<User> AllIncluding(params Expression<Func<User, object>>[] includeProperties)
        {
            IQueryable<User> query = context.User;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public User Find(int id)
        {
            if (WebHelper.CurrentSession.Content.LoggedInUser != null && WebHelper.CurrentSession.Content.LoggedInUser.UserID == id)
            {
                return WebHelper.CurrentSession.Content.LoggedInUser;
            }
            return context.User.Find(id);
        }

        public User Find(string userName,string password)
        {
            return context.User.SingleOrDefault(u => u.UserLoginName == userName && u.Password==password);
        }

        public User Find(string userName)
        {
            return context.User.SingleOrDefault(u => u.UserLoginName == userName);
        }

        public void InsertOrUpdate(User user)
        {
            if (user != null && user.UserLoginName.IsNotNullOrEmpty())
            {
                if (user.Password.IsNotNullOrEmpty())
                {
                    User existingUser = context.User.SingleOrDefault(u => u.UserLoginName.ToLower() == user.UserLoginName.ToLower());
                    user.Password = CryptographyHelper.Encrypt(user.Password);
                    user.CreatedDate = DateTime.Now;
                    if(existingUser==null || (existingUser!=null && existingUser.UserID==user.UserID))
                    {
                        if (user.UserID == default(int))
                        {
                            // New entity
                            context.User.Add(user);
                        }
                        else
                        {
                            context.Entry(existingUser).State = EntityState.Detached;
                            // Existing entity
                            context.Entry(user).State = EntityState.Modified;
                        }
                    }
                    else
                    {
                        throw new CustomException(CustomExceptionType.CommonDuplicacy, "User is already there in the sytem with the provided user name");
                    }
                }
                else
                {
                    throw new CustomException(CustomExceptionType.CommonArgumentNullException, "[Password] is not provided while saving a user");
                }
            }
            else
            {
                throw new CustomException(CustomExceptionType.CommonArgumentNullException, "[UserLoginName] is not provided while saving a user");
            }
        }

        public void Delete(int id)
        {
            var user = context.User.Find(id);
            context.User.Remove(user);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IUserRepository
    {
        IQueryable<User> All { get; }
        IQueryable<User> AllIncluding(params Expression<Func<User, object>>[] includeProperties);
        User Find(int id);
        User Find(string userName, string password);
        User Find(string userName);
        void InsertOrUpdate(User user);
        void Delete(int id);
        void Save();
    }
}