using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestiónDeProyectos.Areas.Users.Controllers
{
    [Area("Users")] //especifico en que área se encuentra el controlador
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
