using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using Connection;
using Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Services.Controllers
{
  //localhost:5001/api/providerorder
  [Route("api/[controller]")]
  [ApiController]
  public class ProviderOrderController : ControllerBase
  {
    // GET: api/providerorder/all
    // [EnableCors("Policy")]
    // [HttpGet("all")]
    // public JsonResult GetProviders()
    // {
    //   List<Provider> providers = Connection.ProviderConnection.GetEntities();
    //   var json = JsonConvert.SerializeObject(providers);
    //   return new JsonResult(providers);
    // }

    // GET: api/provider/
    [EnableCors("Policy")]
    [HttpPost]
    public JsonResult AddProviderOrder([FromBody]ProviderOrder providerOrder)
    {
      Console.WriteLine(Connection.ProviderOrderConnection.AddEntity(providerOrder));
      return new JsonResult(providerOrder);
    }
  }
}

