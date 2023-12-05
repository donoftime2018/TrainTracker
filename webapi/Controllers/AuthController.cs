using Newtonsoft.Json;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.Web.Http;
using System.Web.Http.Results;

namespace webapi.Controllers
{
    [RoutePrefix("api/user")]
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("loginUser")]
        public HttpResponseMessage Login()
        {
            return new HttpResponseMessage();
        }

        [HttpPut]
        [Route("updatePassword")]

        public HttpResponseMessage ChangePassword()
        {
            return new HttpResponseMessage();
        }

        [HttpPost]
        [Route("registerUser")]

        public HttpResponseMessage RegisterUser()
        {
            return new HttpResponseMessage();
        }


    }
}
