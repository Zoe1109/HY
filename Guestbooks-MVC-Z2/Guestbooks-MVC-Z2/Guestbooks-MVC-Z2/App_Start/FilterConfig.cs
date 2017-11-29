using System.Web;
using System.Web.Mvc;

namespace Guestbooks_MVC_Z2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
