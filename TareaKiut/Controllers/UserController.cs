using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TareaKiut.Models;

namespace TareaKiut.Controllers
{
    public class UserController : Controller
    {
        // GET : /User/Index
        public ActionResult Index()
        {
            return View(new User());
        }


        public ActionResult Profile(User user)
        {
            return View(user);
        }

        [HttpPost]
        // GET : /User/Create
        public ActionResult Index(User user)
        {
            if(!ModelState.IsValid)
            {
                return View(user);
            }
            return View("Profile", user);
        }

    }
}
