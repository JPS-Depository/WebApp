using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class SiswaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Get: /HelloWorld/Welcome
        public IActionResult Mendatang()
        {
            return View();
        }
        public IActionResult Kelas()
        {
            return View();
        }
        
        public IActionResult Nilai()
        {
            return View();
        }
        public IActionResult Profil()
        {
            return View();
        }

    }
}
