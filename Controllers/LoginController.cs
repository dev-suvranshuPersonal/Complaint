using Microsoft.AspNetCore.Mvc;

namespace Complaint.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
