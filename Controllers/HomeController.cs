using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ChefsDishes.Models;

namespace ChefsDishes.Controllers 
{
    public class HomeController : Controller
    {
        private MyContext dbContext; 
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()

        {
           List<Chef> AllChefs = dbContext.Chefs.Include(c => c.CreatedDishes).ToList(); //might not need
           return View(AllChefs);
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View("NewChef"); 
        }
        
        [HttpPost("add")]
        public IActionResult AddChef(Chef newChef)
        {
            if(ModelState.IsValid)
            {
                DateTime today = DateTime.Now;
                DateTime birthday = newChef.DateOfBirth;
                int age = today.Year - birthday.Year;
                if (birthday > today.AddYears(-age))
                    age--;
                newChef.Age = age;
                dbContext.Chefs.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("NewChef");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = dbContext.Dishes.Include(d => d.Chef).ToList();
            return View(AllDishes);
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish()
        {
            ViewBag.AllChefs = dbContext.Chefs;
            return View("NewDish");
        }

        [HttpPost("/dishes/add")]
        public IActionResult AddDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Dishes.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            return View("NewDish");
        }

    }
}
