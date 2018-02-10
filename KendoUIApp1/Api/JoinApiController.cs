using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KendoUIApp1.Api
{
    public class JoinApiController : ApiController
    {
        private SQLLabEntities DB = new SQLLabEntities();

        [HttpGet]
        public IEnumerable<test1> GetAll()
        {
            return DB.test1;
        }

        [HttpPost]
        public IEnumerable<test1> Create(string name,string dept)
        {
            var d1=DB.test1.Create();
            d1.name =name;
            d1.dept=dept;
            DB.test1.Add(d1);
            DB.SaveChanges();
            Console.WriteLine("創建完成");
            return DB.test1;
        }
        [HttpGet]
        public IEnumerable<test1> Delete(string name)
        {
            var deleteitem=( from x in DB.test1
                            where x.name==name
                            select x).Single();
            DB.test1.Remove(deleteitem);
            DB.SaveChanges();
            Console.WriteLine("刪除完成");
            return DB.test1;
        }
        [HttpGet]
        public IEnumerable<test1> Edit(string name)
        {
            var result = (from x in DB.test1
                          where x.name==name
                          select x).Single();
                        result.name = "Update01";
                        result.dept = "Update02";
                        DB.SaveChanges();
                        Console.WriteLine("更新完成");
            return DB.test1;
        }
        //把資料塞到Datasourceresult 才可以將data給kendo ,為了轉換kendo格式
        [HttpGet]
        public DataSourceResult Test_GetAll([System.Web.Http.ModelBinding.ModelBinder(typeof(WebApiDataSourceRequestModelBinder))]DataSourceRequest request) {
            return DB.test1.ToDataSourceResult(request);
        }
    }
}
