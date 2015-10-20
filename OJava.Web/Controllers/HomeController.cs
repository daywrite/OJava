using System.Web.Mvc;

namespace OJava.Web.Controllers
{
    public class HomeController : OJavaControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}