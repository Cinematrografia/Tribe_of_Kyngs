using System.Web;
using System.Web.Mvc;

namespace Tribe_of_Kyngs
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
