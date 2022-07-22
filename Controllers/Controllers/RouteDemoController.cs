using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    public class RouteDemoController
    {
        [Route("RouteDemoTest")]
        public string Index()
        {
            return "Hello World!";
        }

        //public IActionResult Index()
        //{
            //WHen we add a new controller and has inherit Controller class, then Controller name is RouteDemo.
            //It means when we open a new windows, www.localhost5000.com/RouteDemo will be work. Index is normal
            //If you don't want inherit Controller class, then we need to use Route attribute like this
        //    return Content("Hello World!");
       // }
    }
}
