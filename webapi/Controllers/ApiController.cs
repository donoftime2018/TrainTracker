using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api/getJsonData")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]      
        public async Task<ActionResult<String>> GetData()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage res = await client.GetAsync("https://lapi.transitchicago.com/api/1.0/ttarrivals.aspx?key=f3668ac334484bc88b6b2e7778a013bd&mapid=40380");

                if (res.IsSuccessStatusCode)
                {
                    string XMLData = await res.Content.ReadAsStringAsync();
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(XMLData);
                    string jsonData = JsonConvert.SerializeXmlNode(xmlDoc);
                    return Ok(jsonData);
                }

                else
                {
                    return StatusCode((int)res.StatusCode, "Error fetching XML data");
                }
            }
                
            }


        }
    }