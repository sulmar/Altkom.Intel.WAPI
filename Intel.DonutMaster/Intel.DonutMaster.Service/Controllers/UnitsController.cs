using Intel.DonutMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Intel.DonutMaster.Service.Controllers
{
    public class UnitsController : ApiController
    {
        [HttpGet]
        public IList<string> Pobierz()
        {
            return Enum.GetNames(typeof(Unit));
        }

        public IList<string> Get()
        {
            return Enum.GetNames(typeof(Unit));
        }
    }
}