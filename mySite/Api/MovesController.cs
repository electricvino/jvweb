using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mySite.Api
{
    public class MovesController : ApiController
    {
        // auth code:81475607 
        // GET: api/Moves
        public IEnumerable<string> Get()
        {
            //UserCredential 

            return new string[] { "value1", "value2" };
        }

        // GET: api/Moves/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Moves
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Moves/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Moves/5
        public void Delete(int id)
        {
        }
    }
}
