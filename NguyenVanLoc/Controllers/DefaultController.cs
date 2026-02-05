using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class DefaultController : Controller
    {
        public string Hi(string fname, string lname)
        {
            return $"Hello {fname} {lname}";
        }
    }
}
