using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberApi.Models.Filter
{
    public class ParameterFilter : ActionFilterAttribute
    {
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (filterContext.Result is JsonResult)
            {
                var result = filterContext.Result as JsonResult;
                var data = result.Data;
                JsonModel returnData = new JsonModel();
                returnData.code = (int)ApiStatus.status.success;
                returnData.message = "成功";
                returnData.data = data;
                result.Data = returnData;
            }

        }
    }
}