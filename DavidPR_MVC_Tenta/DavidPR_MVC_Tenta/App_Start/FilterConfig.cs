using System.Web;
using System.Web.Mvc;

namespace DavidPR_MVC_Tenta
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
