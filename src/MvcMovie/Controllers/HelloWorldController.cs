using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.HtmlEncode(
                "Hello " + name + ", NumTimes is: " + numTimes);
        }

        public string Welcome2(string name, int numTimes = 1, int ID = 1)
        {
            return HtmlEncoder.Default.HtmlEncode(
                "Hello " + name + ", ID: " + ID + ", NumTimes is: " + numTimes);
        }
    }
}