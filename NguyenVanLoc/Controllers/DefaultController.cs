using Microsoft.AspNetCore.Mvc;

namespace NguyenVanLoc.Controllers
{
    public class DefaultController : Controller
    {
        public string Hi(string fname, string lname)
        {
            return $"Hello {fname} {lname}";
        }
    }
}
