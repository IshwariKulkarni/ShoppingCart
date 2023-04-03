using CartDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CartDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        CartDBContext cd = new CartDBContext();
        public ActionResult Index()
        {
            // Category c = new Category()
            //{
              //  CategoryId = "C1",
                //CategoryName = "Abc"
            //};
            //cd.categories.Add(c);
            //return "Yes";
            return View(cd.customers.ToList());
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Customer customer)
        {
            if(ModelState.IsValid)
            {
                cd.customers.Add(customer);
                cd.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Some Error Occurred");
            }
            return View(customer);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

    public ActionResult Login(Customer customers)
        {
            if (ModelState.IsValid)
            {
                using(CartDBContext cd = new CartDBContext())
                {
                    var obj = cd.customers.Where(u => u.EmailId.Equals(customers.EmailId) && u.Password.Equals(customers.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserId"] = obj.UserId.ToString();
                        Session["EmailId"] = obj.EmailId.ToString();
                        return RedirectToAction("LoggedIn");
                    }
                }
            }
            return View(customers);
        }

        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            } 

            // return View(); 
        }



    }
}