using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public string Index()
    {
        return "Hello from HomeController";
    }
}