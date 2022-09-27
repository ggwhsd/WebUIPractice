using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webStack.Models;

namespace webStack.Controllers;

[ApiController]
[Route("demo/[controller]")]
public class ApiController : ControllerBase
{
    //demo/api
    [HttpPost]
    public string Post([FromBody] AddRequest req)
    {
        return DateTime.Now.ToString();
    }
//demo/api/api2
    [HttpPost("api2")]
    public string Post2([FromBody] AddRequest req)
    {
        return "{ \"result\":0 }";
    }

    [HttpPost("api3")]
    public RegisterUser Post3([FromForm] RegisterUser req)
    {
        return req;
    }
[HttpGet("questionApi")]
    public QuestionAnswer Get()
    {
        return new QuestionAnswer{ answer="yes",forced=true };
    }
}
