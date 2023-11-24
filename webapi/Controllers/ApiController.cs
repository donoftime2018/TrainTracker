using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;
using System.Collections;

namespace webapi.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        [Route("api/getStationData")]
        public async Task<ActionResult<ArrayList>> GetData()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage res = await client.GetAsync("https://lapi.transitchicago.com/api/1.0/ttarrivals.aspx?key=f3668ac334484bc88b6b2e7778a013bd&mapid=40380");

                if (res.IsSuccessStatusCode)
                {
                    string XMLData = await res.Content.ReadAsStringAsync();
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(XMLData);

                    XmlNodeList etaElems = xmlDoc.GetElementsByTagName("eta");
                    ArrayList etaData = new ArrayList();
                  

                    for (int i = 0; i < etaElems.Count; i++)
                    {
                        string stationArrival = etaElems[i].ChildNodes[2].InnerXml;
                        string stationDestination = etaElems[i].ChildNodes[7].InnerXml;
                        string stationArrDesc = etaElems[i].ChildNodes[3].InnerXml;

                        string[] infoArray = {stationArrDesc, stationArrival, stationDestination};
                        Console.WriteLine(etaElems[i].InnerXml);
                        etaData.Add(infoArray);
                    }

                    return Ok(etaData);
                }

                else
                {
                    return StatusCode((int)res.StatusCode, "Error fetching XML data");
                }
            }
                
            }


        }
}