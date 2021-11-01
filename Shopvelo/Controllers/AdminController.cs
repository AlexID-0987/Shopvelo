using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shopvelo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Controllers
{
    [Authorize(Roles ="admin")]
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

        public IActionResult Create(int? bakeId)
        {
            if (bakeId == null)
            {
                return View();
            }
            else
            {
                return View(context.Bakes.FirstOrDefault(x => x.BakeId == bakeId));
            }
        }
        [HttpPost]
        public IActionResult Create(Bake bake)
        {
            if(bake.BakeId==0)
            {
                context.Bakes.Add(bake);
            }
            else
            {
                context.Update(bake);
            }
            
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int bakeid)
        {
            var bakeDelete = context.Bakes.Find(bakeid);
            context.Bakes.Remove(bakeDelete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
