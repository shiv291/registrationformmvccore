using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using TestForm.BusinessLib;
using TestForm.Helper;
using TestForm.Models;

namespace TestForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        RegistrationFormOperation registration = new RegistrationFormOperation();
        ViewHelper helper = new ViewHelper();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.optionsList = helper.GetOptions();
            return View();
        }
             
        [HttpPost]
        public IActionResult Index(RegistrationViewModel reg)
        {
            ViewBag.optionsList = helper.GetOptions();
                          
                string options = string.Join(",", reg.Options);
                RegistrationForm form = new RegistrationForm();
                form.Industry = reg.Industry;
                form.Comment = reg.Comment;
                form.FirstName = reg.FirstName;
                form.LastName = reg.LastName;
                form.Options =options;
                form.Organisation = reg.Organisation;
                form.PhoneNumber = reg.PhoneNumber;
                form.WorkEmail = reg.WorkEmail;
                registration.SaveRegistration(form);
                return View("SuccessMessage");
           
        }

        public IActionResult SuccessMessage()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
