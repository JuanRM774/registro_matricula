using System.Web;
using System.Web.Mvc;

namespace Systema_Registro_Matricula
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
