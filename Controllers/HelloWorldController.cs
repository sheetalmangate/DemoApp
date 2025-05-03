using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //Get : /HelloWorld
        public String Index()
        {
            return "This is my default action";
        }

        //Get: /HelloWorld/Welcome/ 
        public String Welcome(String name, int numTimes )
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTime is: {numTimes} ");
        }
    }
}
