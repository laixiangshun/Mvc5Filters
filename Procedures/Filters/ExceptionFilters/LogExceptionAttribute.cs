using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procedures.Filters.ExceptionFilters
{
    /// <summary>
    /// 异常处理类，记录异常日志
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)] //指定该属性的用法：用在类上，该类的派生类和重写成员继承，AllowMultiple = false设置不允许多次执行，即仅在Controller级执行一次。
    public class LogExceptionAttribute:HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName =(string) filterContext.RouteData.Values["action"];
                string msgTemplate = "在执行[{0}]的action[{1}]时产生异常";
                LogManager.GetLogger("LogExceptionAttribute").Error(string.Format(msgTemplate, controllerName, actionName), filterContext.Exception);
            }
            if (filterContext.Result is JsonResult)
            {
                
                filterContext.ExceptionHandled = true;//异常也被处理
            }
            else
            {
                base.OnException(filterContext);//回到了系统默认的异常处理上，实现了向错误页面的跳转
            }
            
        }
    }
}