using Microsoft.AspNetCore.Mvc;
using Shopvelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Controllers
{
    public class AdminController : Controller
    {
        Bakecontext context;

        public AdminController(Bakecontext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Bakes.ToList());
        }
    }
}
