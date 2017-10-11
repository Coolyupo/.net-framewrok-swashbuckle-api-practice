using FakeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FakeApi.Controllers
{
    public class BasicApiController : ApiController
    {
        /// <summary>
        /// 取得所有業管機關資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Authority> Authority()
        {
            return null;
        }
        /// <summary>
        /// 取得所有資料提供平台資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Provider> Provider()
        {
            return null;
        }

        /// <summary>
        /// 取得所有營運業者資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Operator> Operator()
        {
            return null;
        }

    }
}
