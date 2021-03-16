using System.Web;
using System.Web.Mvc;

namespace NgoVanChien_5951071004
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
