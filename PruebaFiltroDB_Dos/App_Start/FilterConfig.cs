using System.Web;
using System.Web.Mvc;

namespace PruebaFiltroDB_Dos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
