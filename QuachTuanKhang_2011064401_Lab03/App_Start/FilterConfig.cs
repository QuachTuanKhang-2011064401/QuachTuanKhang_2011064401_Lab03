using System.Web;
using System.Web.Mvc;

namespace QuachTuanKhang_2011064401_Lab03
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
