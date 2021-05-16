using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassFirst()
        {
            return View();
        }

        public IActionResult ResetPassFirst(ResetModel model, string action)
        {
            if (model.Code == null)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                if (action == "Send")
                {
                    model.Message = "Check your e-mail";
                    return View("ResetPassSecond", model);
                }
                else
                {
                    model.Message = "";
                    return View("ResetPassSecond", model);
                }
            }
            else { return View("ResetPassResult"); }
        }

        [HttpGet]
        public IActionResult SignUpFirst()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUpFirst(SignUpModel model)
        {

            if (string.IsNullOrEmpty(model.FirstName))
            {
                return View("SignUpFirst");
            }
            if (model.Email == null)
            {
                return View("SignUpSecond");
            }
            else
            {
                return !ModelState.IsValid ? View("SignUpSecond") : View("SignUpResult", model);
            }
        }
    }
}
