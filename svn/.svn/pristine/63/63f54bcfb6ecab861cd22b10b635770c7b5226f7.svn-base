using System;
using EasySoft.Helper;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.Common;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.ExceptionLogging;

namespace SoftwareGrid.BusinessLogic.Helpers
{
    public static class UserAuthentication
    {
        public static bool AuthenticateUser(string userName, string password, bool rememberMe,IUserRepository userRepository)
        {
            try
            {
                string errorMessage = string.Empty;
                if (userRepository!=null)
                {
                    password = CryptographyHelper.Encrypt(password);
                    User loggedInUser = userRepository.Find(userName, password);
                    if (loggedInUser != null)
                    {
                        WebHelper.CurrentSession.Content.LoggedInUser = loggedInUser;
                        CookieHelper newCookieHelper = new CookieHelper();
                        newCookieHelper.SetLoginCookie(userName, loggedInUser.UserID.ToString(), rememberMe);
                        return true;
                    }
                }
                return false;
            }
            catch (CustomException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw new CustomException(CustomExceptionType.UserLoginUnknownError, Constants.Messages.UserLogin_UnknownError, ex);
            }
        }
    }
}
