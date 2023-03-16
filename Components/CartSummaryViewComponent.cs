using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        public Basket basket;
        public CartSummaryViewComponent(Basket cartservice)
        {
            basket = cartservice;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
        }

    public class Cart
    {
    }
}

