using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace FakeApi.Models
{
    /// <summary>
    /// RRRR
    /// </summary>
    public class Account
    {
        /// <summary>
        /// 帳戶ID--預設:Admin
        /// </summary>
        [DefaultValue("Admin")]
        public string account { get; set; }
        /// <summary>
        /// 帳戶密碼--預設:Admin
        /// </summary>
        public string password { get; set; }
    }
}