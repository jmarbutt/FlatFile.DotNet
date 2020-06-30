using FlatFile.WebHooksSample.Models;
using FlatFileIO.NET.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlatFile.WebHooksSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Post([FromBody] FlatFileRequest<MyModel> body)
        {
            return Ok();
        }
    }
}