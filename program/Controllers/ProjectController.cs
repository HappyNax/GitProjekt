using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace program.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult AddProject([FromForm] ProjectDto command)
        {
            // service to add project 
            return RedirectToAction("Contact", "Home");

        }
    }
}
