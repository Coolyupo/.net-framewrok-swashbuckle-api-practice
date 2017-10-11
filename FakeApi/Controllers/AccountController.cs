using FakeApi.Models;
using FakeApi.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.ModelBinding;

namespace FakeApi.Controllers
{
    /// <summary>
    /// ddd
    /// </summary>
    public class AccountController : ApiController
    {
        /// <summary>
        /// 登入
        /// </summary>
        /// <remarks>
        /// (MS)SQL Inject Input Sample : 'or 1 = 1 -- 
        /// </remarks>
        /// <returns></returns>
        [HttpPost]
        //[Route("api/Login/Post")]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public ResultVM Login(Account UserData) {
            if(UserData == null)
                return new ResultVM { status = true, Msg = "登入失敗" };
            if (UserData.account!=null && UserData.account.Contains("'"))
            {
                string QueryString = UserData.account;
                QueryString = QueryString.Substring(QueryString.IndexOf("'") + 1);
                if (QueryString.Contains("--"))
                {
                    QueryString = QueryString.Substring(0, QueryString.IndexOf("--")).Trim();
                    if (QueryString.StartsWith("OR ")|| QueryString.StartsWith("or "))
                    {
                        QueryString = QueryString.Substring(2);
                        if (QueryString.Contains('='))
                        {
                            var QueryArray = QueryString.Split('=');
                            if(QueryArray.Length==2)
                            {
                                if(QueryArray[0].Trim()==QueryArray[1].Trim())
                                    return new ResultVM { status = true, Msg = "登入成功" };
                            }
                        }
                        
                    }
                }
                return new ResultVM { status = true, Msg = "登入失敗" };
            }
            else
            {
                if(UserData.account == "Admin" && UserData.password == "Admin")
                    return new ResultVM { status = true, Msg = "登入成功" };
                else
                    return new ResultVM { status = false, Msg = "登入失敗" };
            }

        }

        /// <summary>
        /// 登入
        /// </summary>
        /// <remarks>
        /// (MS)SQL Inject Input Sample : 'or 1 = 1 -- 
        /// </remarks>
        /// <returns></returns>
        [HttpGet]
        //[Route("api/Login/Get")]
        public ResultVM Login2([FromUri]Account UserData)
        {
            if (UserData == null)
                return new ResultVM { status = true, Msg = "登入失敗" };
            if (UserData.account != null && UserData.account.Contains("'"))
            {
                string QueryString = UserData.account;
                QueryString = QueryString.Substring(QueryString.IndexOf("'") + 1);
                if (QueryString.Contains("--"))
                {
                    QueryString = QueryString.Substring(0, QueryString.IndexOf("--")).Trim();
                    if (QueryString.StartsWith("OR ") || QueryString.StartsWith("or "))
                    {
                        QueryString = QueryString.Substring(2);
                        if (QueryString.Contains('='))
                        {
                            var QueryArray = QueryString.Split('=');
                            if (QueryArray.Length == 2)
                            {
                                if (QueryArray[0].Trim() == QueryArray[1].Trim())
                                    return new ResultVM { status = true, Msg = "登入成功" };
                            }
                        }

                    }
                }
                return new ResultVM { status = true, Msg = "登入失敗" };
            }
            else
            {
                if (UserData.account == "Admin" && UserData.password == "Admin")
                    return new ResultVM { status = true, Msg = "登入成功" };
                else
                    return new ResultVM { status = false, Msg = "登入失敗" };
            }

        }

    }
}
