using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FakeApi.Models
{
    public class Provider
    {
        /// <summary>
        /// 資料提供平台代號
        /// </summary>
        public string ProviderID { get; set; }
        /// <summary>
        /// 資料提供平台名稱
        /// </summary>
        public NameType ProviderName { get; set; }
        /// <summary>
        /// 資料提供平台連絡電話
        /// </summary>
        public string ProviderPhone { get; set; }
        /// <summary>
        /// 資料提供平台電子信箱
        /// </summary>
        public string ProviderEmail { get; set; }
        /// <summary>
        /// 資料提供平台網址鏈結
        /// </summary>
        public string ProviderUrl { get; set; }
        /// <summary>
        /// 資料更新日期時間(ISO8601格式:yyyy-MM-ddTHH:mm:sszzz)
        /// </summary>
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "yyyy-MM-ddTHH:mm:sszzz")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 平台代碼
        /// </summary>
        public string ProviderCode { get; set; }
        /// <summary>
        /// Api版本
        /// </summary>
        public string Version { get; set; }



        //        ProviderID(string): 資料提供平台代號 ,
        //ProviderName(NameType): 資料提供平台名稱 ,
        //ProviderPhone(string, optional): 資料提供平台連絡電話 ,
        //ProviderEmail(string, optional): 資料提供平台電子信箱 ,
        //ProviderUrl(string, optional): 資料提供平台網址鏈結 ,
        //UpdateTime(DateTime): 資料更新日期時間(ISO8601格式:yyyy-MM-ddTHH:mm:sszzz) ,
        //ProviderCode(string): 平台代碼
    }
}