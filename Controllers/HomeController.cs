using Microsoft.AspNetCore.Mvc;
using OrtakGitCalismasi.Models;
using System.Diagnostics;

namespace OrtakGitCalismasi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
