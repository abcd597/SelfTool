using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class JsonModel
    {
        /// <summary>
        /// api傳輸 0:成功
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 回傳api是否成功訊息
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 回傳資料
        /// </summary>
        public object data { get; set; }
    }
    public class ApiStatus {
        /// <summary>
        /// code訊息(成功:0，失敗:-1)
        /// </summary>
        public enum status{ fail=-1,success=0}
    }
}