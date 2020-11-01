using Microsoft.AspNetCore.Mvc;
using TaxaJurosWebAPI.Models;

namespace TaxaJurosWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class showmethecodeController : ControllerBase
    {
        [HttpGet("/showmethecode")]
        public showmethecode Get()
        {
            showmethecode s = new showmethecode();
            s.urlGet();

            return s;
        }
    }
}
