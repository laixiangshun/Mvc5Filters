using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procedures.Filters.ExceptionFilters
{
    /// <summary>
    /// 返回json数据的action异常处理类
    /// </summary>
    [AttributeUsage(AttributeTargets.Method,Inherited=true,AllowMultiple=false)]
    public class JsonExceptionAttribute:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                //返回Json异常
                filterContext.Result = new JsonResult()
                {
                    Data = new { Success = false, Message = filterContext.Exception.Message }
                };
            }
            // base.OnException(filterContext);//不能调用系统默认的异常处理，否则会跳过LogExceptionAttribute先执行HandleErrorAttribute的处理逻辑，
            //从而返回结果不再是JsonResult,而是ViewResult，客户端也就无法处理非JSON的结果了
        }
    }
}