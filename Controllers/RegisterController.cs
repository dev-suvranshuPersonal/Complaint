using Complaint.Data;
using Complaint.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Complaint.Controllers
{
    public class RegisterController : Controller
    {
        public readonly EmployeeDBContext _employeeDBContext;
        public RegisterController(EmployeeDBContext employeeDBContext)
        {
            _employeeDBContext = employeeDBContext;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employee employee)
        {
            if (ModelState.IsValid)
            {
                bool emailExist = _employeeDBContext.Employees.Any(e => e.Email == employee.Email);
                bool phoneNoExist = _employeeDBContext.Employees.Any(e => e.Phone == employee.Phone);
                if (emailExist || phoneNoExist)
                {
                    ModelState.AddModelError("Email","Employee already exist in DataBase");
                    return View(employee);
                }
                _employeeDBContext.Employees.Add(employee);
                _employeeDBContext.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(employee);
        }
    }
}
