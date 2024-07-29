using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensRefactoringAndCleanCoding.MethodLevels.ExtensionMethods
{
    internal static class SeoExt
    {
        internal static string GetFriendlySeoUrl(this string url)
        {
            url = url.Replace('ç', 'c');
            return url.ToLower();
        }
    }


    public class Product
    {
        public void Method()
        {
            var url = "https://www.abc.com/products/çğdfdf";

            url.GetFriendlySeoUrl();

            url = SeoHelper.GetFriendlySeoUrl(url);
        }
    }


    internal class SeoHelper
    {
        public static string GetFriendlySeoUrl(string url)
        {
            url = url.Replace('ç', 'c');
            return url.ToLower();
        }
    }
}