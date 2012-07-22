using System;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Security;
using EasySoft.Helper;
using SoftwareGrid.Common;

namespace SoftwareGrid.ExceptionLogging
{
    public static class ExceptionManager
    {
        public static string Manage(Exception exception)
        {
            CustomException rejException = null;
            if (exception.GetType() == typeof(CustomException))
            {
                rejException = (CustomException)exception;
            }
            else if (exception.InnerException != null && exception.InnerException.GetType() == typeof(CustomException))
            {
                rejException = (CustomException)exception.InnerException;
            }
            else
            {
                rejException = new CustomException(CustomExceptionType.CommonUnhandled, string.Empty, exception);
            }
            return Manage(rejException);
        }

        public static string Manage(CustomException rejException)
        {
            //This exception may occur if Response.Redirect method is called in a try-catch block. The solution is to catch that error and clear.
            if (rejException.GetType()==typeof(ThreadAbortException) || rejException.Message==string.Empty ||(rejException.InnerException != null && rejException.InnerException.GetType() == typeof(ThreadAbortException)))
            {
                if (HttpContext.Current != null)
                {
                    HttpContext.Current.ClearError();
                }
                return string.Empty;
            }
            //Login Denied Exception
            if (rejException.ExceptionType.ToString().StartsWith("LP"))
            {
                //WebHelper.CurrentSession.Restart();
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
                return string.Empty;
            }
            if (rejException.ExceptionPriority == CustomExceptionPriority.Low
                || rejException.ExceptionPriority == CustomExceptionPriority.AboveNormal
                || rejException.ExceptionPriority == CustomExceptionPriority.High
                || rejException.ExceptionPriority == CustomExceptionPriority.VeryHigh)
            {
                WriteLog(rejException);
            }
            if (rejException.ExceptionPriority == CustomExceptionPriority.High
                || rejException.ExceptionPriority == CustomExceptionPriority.VeryHigh
                || rejException.ExceptionPriority== CustomExceptionPriority.Critical)
            {
                SendEmail(rejException);
            }
            if (HttpContext.Current != null)
            {
                HttpContext.Current.ClearError();
            }
            return Constants.Messages.UnhandelledError;
        }

        private static void WriteLog(CustomException rejException)
        {
            string errorMessage = rejException.GetDefaultMessage(rejException.ExceptionType);
            errorMessage = Format(null, rejException.ExceptionType.ToValue(), errorMessage,rejException.UserDefinedMessage,rejException.SystemDefinedMessage, rejException.InnerException);
            Logger.LogError(errorMessage);
        }

        public static void WriteLog(string message)
        {
            Logger.LogError(message);
        }

        private static void SendEmail(CustomException rejException)
        {
            //EmailManager emailManager = new EmailManager();
            //emailManager.From = "admin@sambesoftware.com";
            //emailManager.Subject = "Application Error : Page Name : " + pageName.Request.Url.AbsoluteUri;
            //emailManager.Body = "Message : " + ex.Message + "</br>Inner Exception : " + ex.InnerException + "</br>";
            //emailManager.To.Add("probal@sambesoftware.com");
            //emailManager.Send();
        }

        private static void SendSMS(CustomException rejException)
        {

        }

        #region Format
        /// <summary>
        /// Formats message and builds stack trace
        /// </summary>
        /// <param name="oSource"></param>
        /// <param name="nCode"></param>
        /// <param name="sMessage"></param>
        /// <param name="oInnerException"></param>
        public static string Format(object oSource, string nCode, string sMessage,string messageToUser,string systemDefinedMessage, Exception oInnerException)
        {
            StringBuilder sNewMessage = new StringBuilder();
            string sErrorStack = null;
            sErrorStack = BuildErrorStack(oInnerException);
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append(DateTime.Now.ToString());
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append("Exception Summary :");
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append("Error Message :");
            sNewMessage.Append(sMessage);
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append("Message To User :");
            sNewMessage.Append(messageToUser);
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append("System Defined Message :");
            sNewMessage.Append(systemDefinedMessage);
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append("Machine Name :");
            sNewMessage.Append(Environment.MachineName);
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append("Domain Name :");
            sNewMessage.Append(System.AppDomain.CurrentDomain.FriendlyName.ToString());
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append("Host Name :");
            sNewMessage.Append(System.Net.Dns.GetHostName().ToString());
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append("OS Version :");
            sNewMessage.Append(Environment.OSVersion);
            sNewMessage.Append(Environment.NewLine);
            sNewMessage.Append(sErrorStack);
            return sNewMessage.ToString().Trim();
        }

        #endregion

        #region BuildErrorStack
        /// <summary>
        /// Takes a first nested exception object and builds a error
        /// stack from its chained contents
        /// </summary>
        /// <param name="oChainedException"></param>
        /// <returns></returns>
        public static string BuildErrorStack(Exception oChainedException)
        {
            string sErrorStack = null;
            StringBuilder sbErrorStack = new StringBuilder();
            int nErrStackNum = 1;
            System.Exception oInnerException = null;
            if (oChainedException != null)
            {
                sbErrorStack.Append("Error Stack ");
                //.Append("------------------------\n\n");
                oInnerException = oChainedException;
                while (oInnerException != null)
                {
                    sbErrorStack.Append(nErrStackNum)
                    .AppendLine(")\n ");
                    sbErrorStack.Append(oInnerException.Message)
                    .AppendLine("\n");
                    oInnerException =
                    oInnerException.InnerException;
                    nErrStackNum++;
                }
                sbErrorStack.Append("\n");
                sbErrorStack.AppendLine("Call Stack\n");
                sbErrorStack.Append(oChainedException.StackTrace);
                sErrorStack = sbErrorStack.ToString();
            }
            else
            {
                sErrorStack = "exception was not chained";
            }

            return sErrorStack;
        }

        #endregion
    }
}
