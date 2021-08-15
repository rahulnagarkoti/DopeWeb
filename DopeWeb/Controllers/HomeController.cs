using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DopeWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DopeWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ViewMerchandise()
        {
            return View();
        }

        public IActionResult ViewCart() 
        {
            return PartialView("ViewCart");
        }
        public  List<Products> GetProducts() 
        {
            var products =  _context.Products.ToList();
            return products;
        }

        public void AddToCart(int id, int quantity) 
        {
            //check if products are laready in cart and then add more
            var cartList = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cartList");
            if(cartList == null) { cartList = new List<Cart>(); }
            if (!cartList.Contains(new Cart { Id = id, Quantity = quantity })) 
            {
                cartList.Add(new Cart { Id = id, Quantity = quantity });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cartList", cartList);
            }
        }

        public List<Cart> GetCartProducts() 
        {
            var cartList = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cartList");
            var productList = new List<Cart>();
            var products= new List<Products>();
            foreach(var item in cartList??new List<Cart>()) 
            {
                var temp = _context.Products.Where(x => x.Id.Equals(item.Id)).FirstOrDefault();
                productList.Add(new Cart
                {
                    Id=temp.Id,
                    ImageURL = temp.ImageURL,
                    Name =temp.Name,
                    Price=temp.Price,
                    Quantity=item.Quantity,
                });
                products.Add(temp);
            }
            return productList;

        }

        public void RemoveFromCart(int id) 
        {
            var cartList = SessionHelper.GetObjectFromJson<List<Cart>>(HttpContext.Session, "cartList");
            if (cartList != null) 
            {
                var product = cartList.Where(x => x.Id.Equals(id)).FirstOrDefault();
                cartList.Remove(product);
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cartList", cartList);

            }
        }

        public void EmptyCart() 
        {
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cartList", null);

        }

        public void Subscribe(string email) 
        {
            //check if email exists
            var check = _context.Subscribers.Where(x => x.Email == email).FirstOrDefault();
            if (check == null) 
            {
                _context.Subscribers.Add(new Subscribers { Email = email });
                _context.SaveChanges();
            }
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Cart:Products {
        public int Quantity { get; set; }
    }
}
