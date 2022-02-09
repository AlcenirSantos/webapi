using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<string>> listValues()
        {
            List<string> lista = new List<string>();
            lista.Add("carro");
            lista.Add("Moto");
            lista.Add("Bicicleta");
            return lista;
        }
    }
}
