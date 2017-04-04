using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TSIMSServer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value: " + id;
        }


        public string MyGet(int id)
        {
            return "my value is" + id;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost]
        public String Login([FromBody]string userId, [FromBody]string password)
        {
            if (userId.Equals("13110033140") && password.Equals("123456"))
            {
                return "登陆成功";
            }
            else
            {
                return "登陆失败";
            }
        }


        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
