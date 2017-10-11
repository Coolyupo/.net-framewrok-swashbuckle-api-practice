using AutoMapper;
using FakeApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FakeApi.Controllers
{
    /// <summary>
    /// 測試
    /// </summary>
    public class V1_BasicApiController : ApiController
    {
        /// <summary>
        /// 取得所有業管機關資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/BasicApi/Authority/v1")]
        public List<Authority> Authority()
        {
            //組路徑
            var path = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory.ToString(), @"Data\v1\Authority.json");
            //反序列化(json.net)
            List<Authority> op = JsonConvert.DeserializeObject<List<Authority>>(File.ReadAllText(path));
            //automapper調整欄位(reflection)
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Authority, Authority>()
                                                    .ForMember(dest => dest.UpdateTime, opt => opt.MapFrom(src => DateTime.Now))
                                                    .ForMember(dest => dest.Version, opt => opt.MapFrom(src => "V1")));
            config.AssertConfigurationIsValid();
            var mapper = config.CreateMapper();
            var fin_op = mapper.Map<List<Authority>>(op);

            return fin_op;
            //List<Authority> result = new List<Authority>();
            //result.Add(new Authority
            //{
            //    AuthorityID = "007",
            //    AuthorityName = new NameType { Zh_tw = "臺中市政府交通局" },
            //    AuthorityPhone = "04-22289111",
            //    AuthorityUrl = "http://www.traffic.taichung.gov.tw/",
            //    UpdateTime = DateTime.Now,
            //    AuthorityCode = "TXG",
            //    Version = "V1"
            //});
            //result.Add(new Authority
            //{
            //    AuthorityID = "011",
            //    AuthorityName = new NameType { Zh_tw = "基隆市政府交通旅遊處" },
            //    AuthorityPhone = "(02)2425-8236",
            //    AuthorityUrl = "http://www.klcg.gov.tw/tourism/",
            //    UpdateTime = DateTime.Now,
            //    AuthorityCode = "KEE",
            //    Version = "V1"
            //});
            //result.Add(new Authority
            //{
            //    AuthorityID = "003",
            //    AuthorityName = new NameType { Zh_tw = "交通部民用航空局" },
            //    AuthorityPhone = "0800211798",
            //    AuthorityUrl = "http://www.caa.gov.tw/",
            //    UpdateTime = DateTime.Now,
            //    AuthorityCode = "CAA",
            //    Version = "V1"
            //});
            //return result;
        }
        /// <summary>
        /// 取得所有資料提供平台資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/BasicApi/Provider/v1")]
        public List<Provider> Provider()
        {
            //組路徑
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), @"Data\v1\Provider.json");
            //反序列化(json.net)
            List<Provider> op = JsonConvert.DeserializeObject<List<Provider>>(File.ReadAllText(path));
            //automapper調整欄位(reflection)
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Provider, Provider>()
                                                    .ForMember(dest => dest.UpdateTime, opt => opt.MapFrom(src => DateTime.Now))
                                                    .ForMember(dest => dest.Version, opt => opt.MapFrom(src => "V1")));
            config.AssertConfigurationIsValid();
            var mapper = config.CreateMapper();
            var fin_op = mapper.Map<List<Provider>>(op);

            return fin_op;


            //List<Provider> result = new List<Provider>();
            //result.Add(new Provider
            //{
            //    ProviderID = "010",
            //    ProviderCode = "web.taiwanbus.tw",
            //    ProviderPhone = "02-23070123",
            //    ProviderUrl = "http://www.thb.gov.tw/",
            //    UpdateTime = DateTime.Now,
            //    ProviderName = new NameType
            //    {
            //        Zh_tw = "公路總局公路汽車客運動態資訊中心"
            //    },
            //    Version = "V1"
            //});
            //result.Add(new Provider
            //{
            //    ProviderID = "004",
            //    ProviderCode = "5284",
            //    ProviderPhone = "(02)2727-4168",
            //    ProviderEmail = "gt_5284@mail.taipei.gov.tw",
            //    ProviderUrl = "http://www.thb.gov.tw/",
            //    UpdateTime = DateTime.Now,
            //    ProviderName = new NameType
            //    {
            //        Zh_tw = "臺北市交通局我愛巴士5284 資料庫"
            //    },
            //    Version = "V1"
            //});
            //result.Add(new Provider
            //{
            //    ProviderID = "010",
            //    ProviderCode = "web.taiwanbus.tw",
            //    ProviderPhone = "02-23070123",
            //    ProviderUrl = "http://www.thb.gov.tw/",
            //    UpdateTime = DateTime.Now,
            //    ProviderName = new NameType
            //    {
            //        Zh_tw = "公路總局公路汽車客運動態資訊中心"
            //    },
            //    Version = "V1"
            //});
            //result.Add(new Provider
            //{
            //    ProviderID = "005",
            //    ProviderCode = "e-bus.tpc.gov.tw",
            //    ProviderPhone = "02-29603456",
            //    ProviderUrl = "http://www.traffic.ntpc.gov.tw/",
            //    UpdateTime = DateTime.Now,
            //    ProviderName = new NameType
            //    {
            //        Zh_tw = "新北市政府公車動態資訊系統(立皓)"
            //    },
            //    Version = "V1"
            //});
            //return result;
        }

        /// <summary>
        /// 取得所有營運業者資料
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/BasicApi/Operator/v1")]
        public List<Operator> Operator()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), @"Data\v1\Operator.json");
            //反序列化(json.net)
            List<Operator> op = JsonConvert.DeserializeObject<List<Operator>>(File.ReadAllText(path));
            //automapper調整欄位(reflection)
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Operator, Operator>()
                                                    .ForMember(dest => dest.UpdateTime, opt => opt.MapFrom(src => DateTime.Now))
                                                    .ForMember(dest => dest.Version, opt => opt.MapFrom(src => "V1")));
            config.AssertConfigurationIsValid();
            var mapper = config.CreateMapper();
            var fin_op = mapper.Map<List<Operator>>(op);

            return fin_op;


            //List<Operator> result = new List<Operator>();
            //result.Add(new Operator
            //{
            //    OperatorCode = "RoyalBus",
            //    OperatorID = "16123",
            //    OperatorName = new NameType
            //    {
            //        Zh_tw = "皇家客運",
            //        En = "Royal Bus Co., Ltd."
            //    },
            //    OperatorPhone = "(02)8295-7022、0800-551-687",
            //    OperatorEmail = "royal.bus@msn.com",
            //    OperatorUrl = "http://www.royalbus.com.tw",
            //    ProviderID = "004",
            //    UpdateTime = DateTime.Now,
            //    Version = "V1"
            //});
            //result.Add(new Operator
            //{
            //    OperatorCode = "CapitalBus",
            //    OperatorID = "200",
            //    OperatorName = new NameType
            //    {
            //        Zh_tw = "首都客運",
            //        En = "Capital Bus Co., Ltd."
            //    },
            //    OperatorPhone = "0800-000-866",
            //    OperatorUrl = "http://www.capital-bus.com.tw",
            //    ProviderID = "004",
            //    UpdateTime = DateTime.Now,
            //    Version = "V1"
            //});
            //result.Add(new Operator
            //{
            //    OperatorCode = "ShinshinBus",
            //    OperatorID = "700",
            //    OperatorName = new NameType
            //    {
            //        Zh_tw = "欣欣客運",
            //        En = "Shin-Shin Bus Co., Ltd."
            //    },
            //    OperatorPhone = "(02) 2369-9696",
            //    OperatorUrl = "http://www.shinbus.com.tw/",
            //    ProviderID = "004",
            //    UpdateTime = DateTime.Now,
            //    Version = "V1"
            //});
            //return result;
        }


    }
}
