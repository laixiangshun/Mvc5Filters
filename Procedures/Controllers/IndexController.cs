using Procedures.Filters.ExceptionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Procedures.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Index/
        public ActionResult Index()
        {
            //throw new ArgumentException("出错了");//验证异常抛出
            return View();
        }

        [HttpPost]
        [JsonException] //自定义json异常拦截器
        public JsonResult GetJson()
        {
           // throw new ArgumentException("出错了");
            return Json(new { Success = true, Message = "成功" }, JsonRequestBehavior.AllowGet);
        }
	}
}