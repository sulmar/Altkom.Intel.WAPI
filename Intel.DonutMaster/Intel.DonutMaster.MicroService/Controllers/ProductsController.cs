using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Intel.DonutMaster.MicroService.Controllers
{
    public class ProductsController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok("Hello Micro Service");
        }
    }
}
