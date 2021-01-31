using System.Web;
using System.Web.Mvc;

namespace NguyenAnhQuan_1721050697
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
