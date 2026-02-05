using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class GreetController : Controller
    {
        [Route("")]
        public string Greet() { return $"Welcome to TuHocIct"; }
        [Route("Hi")]
        public string Hi() => $"Hi Chung";
        [Route("hello/{name}")]
        public string Hello(string name) => $"Hello, {name}";
    }
}
