using System.Web;
using System.Web.Mvc;

namespace eclerx.MVC_assignment.Gokul
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
