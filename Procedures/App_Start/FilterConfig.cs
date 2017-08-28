using Procedures.Filters.ExceptionFilters;
using System.Web;
using System.Web.Mvc;

namespace Procedures
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());//系统默认的拦截器
            filters.Add(new LogExceptionAttribute());//自定义的记录异常日志的拦截器-全局性
        }
    }
}
