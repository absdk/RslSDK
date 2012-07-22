using System.Diagnostics;
using System.Web;

namespace SoftwareGrid.BusinessLogic.Helpers
{
	public sealed partial class WebHelper
	{
		private HttpRequest _request;
        private HttpResponse _response;

		private CookieHelper _cookie;

		public CookieHelper Cookie
        {
            [DebuggerStepThrough()]
            get
            {
                if (_cookie == null)
                {
                    _cookie = new CookieHelper();
                }
                return _cookie;
            }
        }

		public HttpRequest Request
		{
            [DebuggerStepThrough()]
			get
			{
                if (_request == null)
                {
                    _request = HttpContext.Current.Request;
                }
                return _request;
			}
		}

		public HttpResponse Response
		{
            [DebuggerStepThrough()]
			get
			{
                if (_response == null)
                {
                    _response = HttpContext.Current.Response;
                }
                return _response;
			}
		}

        public WebHelper()
        {
            _cookie = new CookieHelper();
            _request = HttpContext.Current.Request;
            _response = HttpContext.Current.Response;
        }
	}
}