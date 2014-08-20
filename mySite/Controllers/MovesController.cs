using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace mySite.Controllers
{
    public class MovesController : ApiController
    {
        private string clientId = "AsIe08Xk7v0jVsnh81zJ3zeZN2Y4g230";
        private string clientSecret = "BO8Sg5mf039cAV57RYb3262K4o2fKZ0gVxH3CR2GRW3bu6j0eyQ9x_ws22efwawL";
        // GET: api/Moves
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Moves/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
