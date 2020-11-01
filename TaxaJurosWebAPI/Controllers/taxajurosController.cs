using Microsoft.AspNetCore.Mvc;
using TaxaJurosWebAPI.Models;

namespace TaxaJurosWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class taxajurosController : ControllerBase
    {
        [HttpGet("/taxaJuros")]
        public Taxa Get() 
        {
            Taxa n = new Taxa();
            n.GetTaxa();

            return n;
        }
    }
}
