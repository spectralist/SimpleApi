using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ValueController : ControllerBase
{
   

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] {"value1" ,"value2"};
        
    }

     [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        return "koujal";
        
    }
}
