using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello from MVC";
        }
        public string yo()
        {
            return "hey hey!";
        }

        public ViewResult about()
        {
            return View();
        }
        public ViewResult contact()
        {
            string data = "ACME Corporation 2020";
            return View(data as object);
        }
        public ViewResult productinfo()
        {
            Product p = new Product();
            p.Name = "Kockkniv";
            p.Price = 100;

            return View(p);
        }
        public ViewResult productlist()
        {
            Product p = new Product();
            p.Name = "Kockkniv";
            p.Price = 100;

            List<Product> list = new List<Product>();
            list.Add(p);
            list.Add(p);
            list.Add(p);
            list.Add(new Product() { Price = 300, Name = "Förkläde" });

            return View(list);
        }
    }
}