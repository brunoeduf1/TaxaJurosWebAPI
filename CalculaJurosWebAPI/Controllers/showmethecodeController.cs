using CalculaJurosWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculaJurosWebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class showmethecodeController : ControllerBase
    {
        [HttpGet("/showmethecode")]
        public showmethecode Get()
        {
            showmethecode repgit = new showmethecode();
            repgit.UrlGet();

            return repgit;
        }
    }
}
