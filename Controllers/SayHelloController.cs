using Microsoft.AspNetCore.Mvc;

namespace SpacekKMCSayHello.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        [HttpGet]
        [Route("SayHello/{name}")]
    public string SayHello(string name)
    {
        return $"Hi, {name}! It's nice to meet you!";
    }
    }
}