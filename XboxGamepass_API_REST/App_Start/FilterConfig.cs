using System.Web;
using System.Web.Mvc;

namespace XboxGamepass_API_REST
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
