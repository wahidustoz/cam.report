using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cam.report.Controllers
{
    public class AccountController : Controller
    {
        
        [HttpGet]
        public IActionResult Login()
        {
            //TODO: Implement Realistic Implementation
          return View();
        }
    }
}