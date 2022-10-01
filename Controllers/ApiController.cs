using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using webStack.Models;

using System.Collections.Generic;

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
    [HttpGet("dataApi")]
    public Data1 Get2()
    {
        List<string> xAxis1 = new List<string>();
        
        List<int> data1=new List<int>();
        for(int i =0;i<100;i++)
        {
             xAxis1.Add(i.ToString()+"s"); data1.Add(i%10);
        }
       
       
        return new Data1{ xAxis=xAxis1, data=data1};
    }
}
