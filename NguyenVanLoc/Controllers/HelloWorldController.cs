using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace NguyenVanLoc.Controllers
{
    public class HelloWorldController : Controller
    {
        
            
            public string Index()
            {
                return "Hello Cô Phương.!!";
            }
            

            public string Welcome()
            {
                return "Welcome to website nvl";
            }

            public string Welcome1(string name, string ID="Nguyen Van Loc")
            {
            return HtmlEncoder.Default.Encode($"Hello {name}, My name is: {ID}");
            }
    }
    }

