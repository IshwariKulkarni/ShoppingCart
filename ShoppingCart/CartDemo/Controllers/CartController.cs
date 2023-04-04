using CartDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CartDemo.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart

        private CartDBContext db = new CartDBContext();
        private string id;

        public ActionResult Index()
            {
                // Get the current cart from session, or create a new one if it doesn't exist
                var cart = Session["Cart"] as List<Cart> ?? new List<Cart>();

                return View(cart);
            }

            // GET: Cart/AddToCart/5
            public ActionResult AddToCart(Product pro)
        {
            // Find the product by id, or return a 404 error if not found
            if (db.products.Find(pro) != null)
            {
                // Get the current cart from session, or create a new one if it doesn't exist
                var cart = Session["Cart"] as List<Cart> ?? new List<Cart>();

                // Check if the product already exists in the cart
                
                

                // Update the cart in session
                Session["Cart"] = cart;

                return RedirectToAction("Index");
            }
            return HttpNotFound();
        }

        // GET: Cart/RemoveFromCart/5
        public ActionResult RemoveFromCart(Product pro)
            {
                // Get the current cart from session, or create a new one if it doesn't exist
                var cart = Session["Cart"] as List<Cart> ?? new List<Cart>();

                // Find the cart item by product id, or return a 404 error if not found
                var cartItem = cart.FirstOrDefault(x => x.ProductId ==pro.ProductId);
                if (cartItem == null)
                {
                    return HttpNotFound();
                }

                // Decrease the quantity of the cart item
               

            // If the quantity is now zero, remove the cart item from the cart
           

                // Update the cart in session
                Session["Cart"] = cart;

                return RedirectToAction("Index");
            }
        


    }
}