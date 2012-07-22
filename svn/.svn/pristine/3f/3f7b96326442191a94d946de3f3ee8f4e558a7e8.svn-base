using System.Diagnostics;
using System.Web;

namespace SoftwareGrid.BusinessLogic.Helpers
{
    public sealed partial class WebHelper
    {
        /// <summary>
        /// Added By Fazlur Rahman On October 13,2011
        /// This is a wrapper class created on top of "HttpContext.Current.Application" class and used to control the Application objects.
        /// </summary>
        public static class CurrentApplication
        {
            /// <summary>
            /// Clear Application
            /// </summary>
            [DebuggerStepThrough()]
            public static void Clear()
            {
                if (HttpContext.Current != null && HttpContext.Current.Application != null)
                {
                    HttpContext.Current.Application.Clear();
                }
            }

            /// <summary>
            /// Get an item from the collection of objects stored in Application.
            /// </summary>
            /// <param name="key">key name of the item</param>
            /// <returns>object found by the supplied key</returns>
            [DebuggerStepThrough()]
            public static object Get(string key)
            {
                if (HttpContext.Current != null && HttpContext.Current.Application!=null)
                {
                    return HttpContext.Current.Application[BuildFullKey(key)];
                }
                else
                {
                    return null;
                }
            }
            /// <summary>
            /// Add a new item to the collection of objects stored in Application
            /// </summary>
            /// <param name="key">unique key name of the item</param>
            /// <param name="value">object to store in the Application</param>
            [DebuggerStepThrough()]
            public static void Set(string key,
            object value)
            {
                if (HttpContext.Current != null && HttpContext.Current.Application != null)
                {
                    if (value == null)
                    {
                        HttpContext.Current.Application.Remove(BuildFullKey(key));
                    }
                    else
                    {
                        HttpContext.Current.Application[BuildFullKey(key)] = value;
                    }
                }
            }
            /// <summary>
            /// Remove an item from the collection of the objects stored in Application.
            /// </summary>
            /// <param name="key">key name of the item</param>
            [DebuggerStepThrough()]
            public static void Remove(string key)
            {
                if (HttpContext.Current != null && HttpContext.Current.Application != null)
                {
                    HttpContext.Current.Application.Remove(BuildFullKey(key));
                }
            }
            /// <summary>
            /// Check if any item exists in the collection of the objects stored in Application
            /// </summary>
            /// <param name="key">key to search</param>
            /// <returns>found or not found</returns>
            [DebuggerStepThrough()]
            public static bool Contains(string key)
            {
                if (HttpContext.Current != null && HttpContext.Current.Application != null)
                {
                    if (HttpContext.Current.Application[BuildFullKey(key)] == null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }

            /// <summary>
            /// Build an unique key to store a item in Application
            /// </summary>
            /// <param name="localKey"></param>
            /// <returns></returns>
            [DebuggerStepThrough()]
            private static string BuildFullKey(string localKey)
            {
                const string Application_KEY = "Web.UI.";

                if (localKey.IndexOf(Application_KEY) > -1)
                {
                    return localKey;
                }
                else
                {
                    return Application_KEY + localKey;
                }
            }

            /// <summary>
            /// Search a string item in the collection of objects stored in Application by the supplied key name.
            /// </summary>
            /// <param name="key">key to search</param>
            /// <returns>string found</returns>
            [DebuggerStepThrough()]
            public static string GetString(string key)
            {
                string fullKey = BuildFullKey(key);
                if (HttpContext.Current != null && HttpContext.Current.Application != null && HttpContext.Current.Application[fullKey] != null)
                {
                    return HttpContext.Current.Application[fullKey].ToString();
                }
                else
                {
                    return string.Empty;
                }
            }

            public static class Content
            {
                
            }

            public static class ReportParameters
            {
                public static object LookupData
                {
                    get
                    {
                        return Get("LookupData");
                    }
                    set
                    {
                        Set("LookupData", value);
                    }
                }
            }
        }
    }
}