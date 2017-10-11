using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FakeApi.ViewModels
{
    public class ResultVM
    {
        /// <summary>
        /// 回傳狀態
        /// </summary>
        public bool status { get; set; }

        /// <summary>
        /// 回傳訊息
        /// </summary>
        public string Msg { get; set; }
    }
}