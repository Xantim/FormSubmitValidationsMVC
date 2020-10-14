using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AS_FormSubmission.Models;

namespace AS_FormSubmission.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
        }

        [HttpPost("submit")]
        public IActionResult Submit(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");    
            }
            else
            {
                return View("index");
            }
            
        }
    }
}
