using System;
using System.Diagnostics;
using System.Web;
using System.Web.Security;
using EasySoft.Helper;
namespace SoftwareGrid.BusinessLogic.Helpers
{
	public sealed class CookieHelper
	{
		private HttpRequest _request;
		private HttpResponse _response;

        public CookieHelper(HttpRequest request, 
		HttpResponse response)
		{
			_request = request;
			_response = response;
		}

		public CookieHelper(HttpRequest request):this(request, null)
		{
		}

		public CookieHelper(HttpResponse response):this(null, response)
		{
		}

        public CookieHelper()
		{
			HttpContext context = HttpContext.Current;

			_request = context.Request;
			_response = context.Response;
		}

		[DebuggerStepThrough()]
		public void Set(string key,
		string value,
		DateTime expire)
		{
            SetValue(CryptographyHelper.Encrypt(BuildFullKey(key)), CryptographyHelper.Encrypt(value), expire);
		}

		[DebuggerStepThrough()]
		public void Set(string key,
		string value)
		{
            SetValue(CryptographyHelper.Encrypt(BuildFullKey(key)), CryptographyHelper.Encrypt(value));
		}

		[DebuggerStepThrough()]
		private void SetValue(string key,
		string value,
		DateTime expire)
		{
			HttpCookie cookie = new HttpCookie(HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(value));
			cookie.Expires = expire;

			SetCookie(cookie);
		}

		[DebuggerStepThrough()]
		private void SetValue(string key,
		string value)
		{
			SetCookie(new HttpCookie(HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(value)));
		}

		[DebuggerStepThrough()]
		private void SetCookie(HttpCookie cookie)
		{
			_response.Cookies.Set(cookie);
		}

        //[DebuggerStepThrough()]
        public void SetLoginCookie(string userName, string userData, bool isPermanentCookie)
        {
            if (_response != null)
            {
                if (isPermanentCookie)
                {
                    userData = CryptographyHelper.Encrypt(userData);
                    FormsAuthenticationTicket userAuthTicket = new FormsAuthenticationTicket(1, userName, DateTime.Now, DateTime.MaxValue, true, userData, FormsAuthentication.FormsCookiePath);
                    string encUserAuthTicket = FormsAuthentication.Encrypt(userAuthTicket);
                    HttpCookie userAuthCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encUserAuthTicket);
                    if (userAuthTicket.IsPersistent) userAuthCookie.Expires = userAuthTicket.Expiration;
                    userAuthCookie.Path = FormsAuthentication.FormsCookiePath;
                    _response.Cookies.Add(userAuthCookie);
                }
                else
                {
                    FormsAuthentication.SetAuthCookie(userName, false);
                }
            }
        }

        //[DebuggerStepThrough()]
        public string GetUserDataFromLoginCookie()
        {
            if (_response != null)
            {
                if (HttpContext.Current.User != null)
                {
                    if (HttpContext.Current.User.Identity.IsAuthenticated)
                    {
                        if (HttpContext.Current.User.Identity is FormsIdentity)
                        {
                            FormsIdentity formIdentity = (FormsIdentity)HttpContext.Current.User.Identity;
                            FormsAuthenticationTicket userAuthTicket = formIdentity.Ticket;
                            if (userAuthTicket.UserData.IsNotNullOrEmpty())
                            {
                                return CryptographyHelper.Decrypt(userAuthTicket.UserData);
                            }
                        }
                    }
                }
            }
            return string.Empty;
        }

		[DebuggerStepThrough()]
		public string Get(string key)
		{
			string value = GetValue(key);

			if (value != null)
			{
                return CryptographyHelper.Decrypt(value);
			}

			return null;
		}
		
		[DebuggerStepThrough()]
		private string GetValue(string key)
		{
            HttpCookie cookie = GetCookie(CryptographyHelper.Encrypt(BuildFullKey(key)));

			if (cookie == null)
			{
				return null;
			}

			if (cookie.Value.IsNullOrEmpty())
			{
				return null;
			}

			return HttpUtility.UrlDecode(cookie.Value);
		}
		
		[DebuggerStepThrough()]
		private HttpCookie GetCookie(string key)
		{
			return _request.Cookies[HttpUtility.UrlEncode(key)];
		}

		[DebuggerStepThrough()]
		public static string BuildFullKey(string localKey)
		{
			const string COOKIE_KEY = "Web.UI.Helper";

			if (localKey.IndexOf(COOKIE_KEY) > -1)
			{
				return localKey;
			}
			else
			{
				return COOKIE_KEY + localKey;
			}
		}
	}
}