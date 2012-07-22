using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Helpers;
using SoftwareGrid.BusinessLogic.Repositories.Context;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.BusinessLogic.Repositories
{ 
    public class UserRolePermissionRepository : IUserRolePermissionRepository
    {
		private readonly RepositoryContext context;

        public UserRolePermissionRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public IQueryable<UserRolePermission> All
        {
            get { return context.UserRolePermission; }
        }

        public IEnumerable<UserRolePermission> AllForEditor
        {

            get { return MiscUtility.GetAllActions(); }
        }

        public bool HasPermission(int userRoleId, string areaName, string controllerName, string actionName)
        {
            UserRolePermission permission = null;
            if (areaName.IsNotNullOrEmpty() && controllerName.IsNotNullOrEmpty() && actionName.IsNotNullOrEmpty())
            {
                permission = context.UserRolePermission.SingleOrDefault(item => item.AreaName.ToLower() == areaName && item.ControllerName.ToLower() == controllerName && item.ActionName.ToLower() == actionName && item.UserRoleID == userRoleId);
            }
            else if (controllerName.IsNotNullOrEmpty() && actionName.IsNotNullOrEmpty())
            {
                permission = context.UserRolePermission.SingleOrDefault(item => item.ControllerName.ToLower() == controllerName && item.ActionName.ToLower() == actionName && item.UserRoleID == userRoleId);
            }
            if (permission != null)
            {
                return true;
            }
            return false;
        }

        public IQueryable<UserRolePermission> AllIncluding(params Expression<Func<UserRolePermission, object>>[] includeProperties)
        {
            IQueryable<UserRolePermission> query = context.UserRolePermission;
            foreach (var includeProperty in includeProperties) {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public UserRolePermission Find(int id)
        {
            return context.UserRolePermission.Find(id);
        }

        public void InsertOrUpdate(UserRolePermission userrolepermission)
        {
            if (userrolepermission.UserRolePermissionId == default(int)) {
                // New entity
                context.UserRolePermission.Add(userrolepermission);
            } else {
                // Existing entity
                context.Entry(userrolepermission).State = EntityState.Modified;
            }
        }

        public void InsertOrUpdate(string userrolepermission,List<UserRole> userRoleList)
        {
            //2+AppBuilder+AppMenu+Index,3+AppBuilder+AppMenu+Index,4+AppBuilder+AppMenu+Index,2+AppBuilder+AppMenu+Search,1+OM+OrganizationAddressCategory+Create,2+OM+OrganizationAddressCategory+Create,3+OM+OrganizationAddressCategory+Create,4+OM+OrganizationAddressCategory+Create,5+OM+OrganizationAddressCategory+Create
            if (userRoleList != null && userrolepermission.IsNotNullOrEmpty())
            {
                string[] userRolePermissions = userrolepermission.ToStringArray(',');
                if (userRolePermissions != null)
                {
                    foreach (string currentUserRolePermission in userRolePermissions)
                    {
                        string[] userRolePermissionParams = currentUserRolePermission.ToStringArray('+');
                        if (userRolePermissionParams.Length == 4 && userRolePermissionParams[0].ToInteger() < userRoleList.Count)
                        {
                            UserRole userRole= userRoleList[userRolePermissionParams[0].ToInteger()];
                            string areaName = userRolePermissionParams[1];
                            string controllerName = userRolePermissionParams[2];
                            string actionName = userRolePermissionParams[3];
                            UserRolePermission permission = context.UserRolePermission.SingleOrDefault(item => item.AreaName.ToLower() == areaName && item.ControllerName.ToLower() == controllerName && item.ActionName.ToLower() == actionName && item.UserRoleID == userRole.UserRoleID);
                            if (permission == null)
                            {
                                permission = new UserRolePermission()
                                {
                                    AreaName = areaName,
                                    ControllerName = controllerName,
                                    ActionName = actionName,
                                    UserRoleID = userRole.UserRoleID
                                };
                                context.UserRolePermission.Add(permission);
                            }
                        }
                    }
                }
            }
        }

        public void Delete(int id)
        {
            var userrolepermission = context.UserRolePermission.Find(id);
            context.UserRolePermission.Remove(userrolepermission);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }

    public interface IUserRolePermissionRepository
    {
        IQueryable<UserRolePermission> All { get; }
        IEnumerable<UserRolePermission> AllForEditor { get; }
        IQueryable<UserRolePermission> AllIncluding(params Expression<Func<UserRolePermission, object>>[] includeProperties);
        UserRolePermission Find(int id);
        void InsertOrUpdate(UserRolePermission userrolepermission);
        void InsertOrUpdate(string userrolepermission, List<UserRole> userRoleList);
        void Delete(int id);
        void Save();
        bool HasPermission(int userRoleId, string areaName, string controllerName, string actionName);
    }
}