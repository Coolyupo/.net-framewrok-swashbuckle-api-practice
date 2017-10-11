using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeApi.Models
{
    public class Operator
    {
        /// <summary>
        /// 資料提供平台代碼
        /// </summary>
        public string ProviderID { get; set; }
        /// <summary>
        /// 營運業者代碼
        /// </summary>
        public string OperatorID { get; set; }
        /// <summary>
        /// 營運業者代碼
        /// </summary>
        public NameType OperatorName { get; set; }
        /// <summary>
        /// 營運業者連絡電話
        /// </summary>
        public string OperatorPhone { get; set; }
        /// <summary>
        /// 營運業者電子信箱
        /// </summary>
        public string OperatorEmail { get; set; }
        /// <summary>
        /// 營運業者網址鏈結
        /// </summary>
        public string OperatorUrl { get; set; }
        /// <summary>
        /// 平台代碼
        /// </summary>
        public string OperatorCode { get; set; }
        /// <summary>
        /// 資料更新日期時間
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "yyyy-MM-ddTHH:mm:sszzz")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// API版本
        /// </summary>
        public string Version { get; set; }
    }
}