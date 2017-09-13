using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace AngularJS_Learning
{
    public class ApplicationController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<CarType> Get()
        {
            List<CarType> list = new List<CarType>();
            CarType objorder1 = new CarType(1, "ABC");
            CarType objorder2 = new CarType(1, "XYZ");

            list.Add(objorder1);
            list.Add(objorder2);
            return list;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

        //[System.Web.Services.WebMethod()]
        //public static List<OrderList> GetGenderList()
        //{
        //    List<OrderList> list = new List<OrderList>();
        //    OrderList objorder1 = new OrderList(1, "ABC", "Karachi", 5.0);
        //    OrderList objorder2 = new OrderList(1, "XYZ", "Hyderabad", 6.0);

        //    list.Add(objorder1);
        //    list.Add(objorder2);
        //    return list;
        //}
    }

   
}