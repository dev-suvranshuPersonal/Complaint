using Microsoft.AspNetCore.Mvc;

namespace Complaint.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            Console.WriteLine("LoginController Index action called");
            return View();
            //
        }
    }
}
