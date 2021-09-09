using Microsoft.AspNetCore.Mvc;
using MVCLab9_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCLab9_2.Controllers
{
    public class Players : Controller
    {
        //public IActionResult Index()
        //{
         //   return View();
        //}
        public IActionResult Teams()
        {
            ViewData["FirstName"] = "Lebron";
            ViewData["LastName"] = "James";
            return View();
        }
        
        public IActionResult AddPlayer()
        {
            ViewData["ErrorMessage"] = "";
            return View();
        }
        public IActionResult Success(Player baller)
        {

            
            
            if (baller.FirstName == null || baller.LastName == null || baller.Age == null || baller.Height == null || baller.Weight == null)
            {
                ViewData["ErrorMessage"] = "We need all the data!  Please fill in the fields completely!";
                return View("AddPlayer");
            }
            else if(baller.Age < 19 || baller.Age > 40)
            {
                ViewData["ErrorMessage"] = "This player does not meet the Age requirements for the NBA!";
                return View("AddPlayer");
            }
            else if(baller.Height < 68 || baller.Height > 96)
            {
                ViewData["ErrorMessage"] = "This player does meet the Height requirements for the NBA!";
                return View("AddPlayer");
            }
            else if(baller.Weight <140 || baller.Weight > 400)
            {
                ViewData["ErrorMessage"] = "This players does not meet the Weight requirements for the NBA!";
                return View("AddPlayer");
            }
            else
            {
                return View(baller);
            }
            
        }
    }
}
