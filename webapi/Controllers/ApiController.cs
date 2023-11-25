using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;
using System.Collections;
using System.Xml.Linq;
using NPOI.SS.Formula.Functions;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Data;
using Newtonsoft.Json.Linq;

namespace webapi.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        //private HttpResponseMessage res;

        [HttpGet]
        [Route("api/getStationData")]
        public IActionResult GetData()
        {
                XmlDocument doc = new XmlDocument();
                doc.Load("https://lapi.transitchicago.com/api/1.0/ttarrivals.aspx?key=f3668ac334484bc88b6b2e7778a013bd&mapid=40380");

                string jsonText = JsonConvert.SerializeXmlNode(doc);
                dynamic data = JObject.Parse(jsonText);

                return Ok(data);
           
                 
        }

    }


}