using System.Threading.Tasks;
using Csla.Server.Hosts;
using Microsoft.AspNetCore.Mvc;

namespace MB5.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataPortalController : HttpPortalController
    {
        public DataPortalController()
        {
            UseTextSerialization = true;
        }

        [HttpGet]
        public string Get()
        {
            return "Running";
        }

        public override Task PostAsync([FromQuery] string operation)
        {
            return base.PostAsync(operation);
        }
    }
}