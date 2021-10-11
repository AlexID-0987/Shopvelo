using Microsoft.AspNetCore.Mvc;
using Shopvelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Controllers
{
    public class HomeController : Controller
    {
        Bakecontext bakecontext;
        public HomeController(Bakecontext bakecontext)
        {
            this.bakecontext = bakecontext;
        }
        public IActionResult Index(string st=" ")
        {
            if (!string.IsNullOrEmpty(st))
                ViewBag.Thanks = st;
            var table = bakecontext.Bakes.ToList();
            return View(table);
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null)
                return RedirectToAction("Index");
            ViewBag.BakeId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Buy(Order order)
        {
            bakecontext.Orders.Add(order);
            bakecontext.SaveChanges();
            return RedirectToAction("Index", new { st="Thanks frends"});
        }
    }
}
