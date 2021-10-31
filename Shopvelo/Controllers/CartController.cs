using Microsoft.AspNetCore.Mvc;
using Shopvelo.Extensh;
using Shopvelo.Models;
using Shopvelo.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopvelo.Controllers
{
    public class CartController : Controller
    {
        Bakecontext context;

        public CartController(Bakecontext context)
        {
            this.context = context;
        }

        public IActionResult Index(string returnUrl)
        {
            var cart = GetCart();
            return View(new CartIndexViewModel
            { 
              Cart=cart,
              ReturnUrl=returnUrl
            });
        }
        public IActionResult AddToCart(int bakeId, string returnUrl)
        {
            Bake bake = context.Bakes.FirstOrDefault(x => x.BakeId == bakeId);
            if(bake!=null)
            {
                var cart = GetCart();
                cart.AddItem(bake, 1);
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public IActionResult RemoveFromCart(int bakeId, string returnUrl)
        {
            Bake bake = context.Bakes.FirstOrDefault(x => x.BakeId == bakeId);
            if(bake!=null)
            {
                var cart = GetCart();
                cart.RemoveLine(bake);
                HttpContext.Session.SetObjectAsJson("Cart", cart);

            }
            return RedirectToAction("Index",new {returnUrl});
        }
        private Cart GetCart()
        {
            Cart cart = HttpContext.Session.GetObjectFromJson<Cart>("Cart");
            if (cart==null)
            {
                cart = new Cart();
                HttpContext.Session.SetObjectAsJson("Cart", cart);
            }
            return cart;
        }
    }
}
