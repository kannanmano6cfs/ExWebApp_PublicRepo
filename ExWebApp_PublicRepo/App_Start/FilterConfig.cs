using System.Web;
using System.Web.Mvc;

namespace ExWebApp_PublicRepo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
