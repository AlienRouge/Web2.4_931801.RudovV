using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class ControlsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TextBox()
        {
            ViewBag.Visible = true;
            return View();
        }

        public IActionResult TextArea()
        {
            ViewBag.Visible = true;
            return View();
        }

        public IActionResult CheckBox()
        {
            ViewBag.Visible = true;
            return View();
        }

        public IActionResult Radio()
        {
            ViewBag.Visible = true;
            return View();
        }

        public IActionResult DropDownList()
        {
            ViewBag.Visible = true;
            return View();
        }

        public IActionResult ListBox()
        {
            ViewBag.Visible = true;
            return View();
        }

        public IActionResult ControlHandler(string type, string answer)
        {
            ViewBag.Visible = false;
            if (type != "CheckBox")
                ViewBag.Answer = answer;
            else
                ViewBag.Answer = answer == null ? "false" : "true";

            return View(type);
        }
    }
}