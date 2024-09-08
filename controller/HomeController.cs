using Microsoft.AspNetCore.Mvc;

namespace mvc2.controller
{
    public class HomeController : Controller
    {

        //public string Index()
        //{


        //    return "this is index action";
        //}  


        //public ContentResult Index()
        //{

        //    ContentResult result = new ContentResult();
        //    result.Content = "hello from ContentResult";
        //    return result;
        //}

        public ActionResult Index()
        {

           
            return Content("hello from actionresult");
        }

        public string aboutus()
        {
            return "this is  about us";
        }
    }
}
