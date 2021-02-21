using Microsoft.AspNetCore.Mvc;
using System;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "good morning" : "good evening";
            return View("MyView");
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}
