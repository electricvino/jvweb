using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mySite.Api
{
    public class SelfController : ApiController
    {
        //http://wrapbootstrap.com/preview/WB057FN0R
        // GET: api/Self
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Self/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Self
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Self/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Self/5
        public void Delete(int id)
        {
        }
    }
}
