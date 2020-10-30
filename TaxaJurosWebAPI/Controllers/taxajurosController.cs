using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxaJurosWebAPI.Models;

namespace TaxaJurosWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class taxajurosController : ControllerBase
    {
        [HttpGet("/taxajuros")]
        public Taxa Get() 
        {
            Taxa n = new Taxa();
            n.GetTaxa();

            return n;
        }
        
    }
}
