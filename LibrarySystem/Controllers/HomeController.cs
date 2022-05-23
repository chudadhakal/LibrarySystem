using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private LibraryDBContext _dbContext;

        public HomeController(ILogger<HomeController> logger, LibraryDBContext context)
        {
            _logger = logger;
            _dbContext = context;
        }


        public IActionResult Index()
        {
            var books = _dbContext.Book.ToList();
            return View(books);
        }
       
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Login()
        {
            ViewBag.LoginError = "";
            if (Request.Method.ToLower() == "post")
            {
                string username = Request.Form["uname"].ToString();
                string password = Request.Form["psw"].ToString();

                var user = _dbContext.User.Where(u => u.Email == username && u.Password == password);

                if (user.Count() > 0)
                { 
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.LoginError = "Login failed!";
                }
            }
            //

            return View();
        }


        public IActionResult SignUp()
        {
            ViewBag.SignUpError = "";
            if (Request.Method.ToLower() == "post")
            {
                string Email = Request.Form["email"].ToString();
                string FirstName = Request.Form["FirsName"].ToString();
                string Lastname = Request.Form["LastName"].ToString();
                string Password = Request.Form["psw"].ToString();




                //var user = _dbContext.User.Where(u => u.Email == username && u.Password == password);

              /*  if (user.Count() > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.LoginError = "Login failed!";
                }*/
                
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddBook()
        {
            if (Request.Method.ToLower() == "post")
            {
                string Title = Request.Form["BookTitle"].ToString();
                string Author= Request.Form["Author"].ToString();
                string Genre = Request.Form["Genre"].ToString();
                string SSBN = Request.Form["SSBN"].ToString();
                string Publisher = Request.Form["Publisher"].ToString();
                string Published = Request.Form["Published"].ToString();

            }

            return View();
        }
    }
    
}
