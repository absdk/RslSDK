using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareGrid.Common
{
    public static class StringExtensions
        //this is for search content and resume

    {
        public static bool ContainsAny(this string str, params string[] values)
        {
            if (!string.IsNullOrEmpty(str) || values.Length > 0)
            {
                foreach (string value in values)
                {
                    if (str.Contains(value))
                        return true;
                }
            }

            return false;
        }

        public static bool ContainsAll(this string str, params string[] values)
        {
            if (!string.IsNullOrEmpty(str) || values.Length > 0)
            {
                foreach (string value in values)
                {
                    if (!str.Contains(value))
                        return false;
                }
            }

            return true;
        }
    }
}
