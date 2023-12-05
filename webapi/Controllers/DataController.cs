using Newtonsoft.Json;
using System.Xml;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using System;

namespace webapi.Controllers
{
    [ApiController]
    public class DataController : ControllerBase
    {
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