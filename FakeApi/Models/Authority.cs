using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeApi.Models
{
    /// <summary>
    /// OUO
    /// </summary>
    public class Authority
    {
        /// <summary>
        /// 業管機關代號
        /// </summary>
        public string AuthorityID { get; set; }
        /// <summary>
        /// 業管機關名稱
        /// </summary>
        public NameType AuthorityName { get; set; }
        /// <summary>
        /// 業管機關連絡電話 
        /// </summary>
        public string AuthorityPhone { get; set; }
        /// <summary>
        /// 業管機關電子信箱
        /// </summary>
        public string AuthorityEmail { get; set; }
        /// <summary>
        /// 業管機關網址鏈結 
        /// </summary>
        public string AuthorityUrl { get; set; }
        /// <summary>
        /// 業管機關代碼
        /// </summary>
        public string AuthorityCode { get; set; }
        /// <summary>
        /// 資料更新日期時間(ISO8601格式:yyyy-MM-ddTHH:mm:sszzz)
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "yyyy-MM-ddTHH:mm:sszzz")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// API版本
        /// </summary>
        public string Version { get; set; }

    }
}