using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        private IFoxListService foxListService;
        //private FoxListService foxListService;

        public HomeController(IFoxListService foxListService)      // everytime homecontroller is called, empty foxlist will be initialized
        //public HomeController(FoxListService foxListService)      // everytime homecontroller is called, empty foxlist will be initialized
        {
            this.foxListService = foxListService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Login()
        {
            return View(foxListService);
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(string name)
        {
            if(String.IsNullOrEmpty(name))
            {
                return RedirectToAction("Login", "Home");           // use required instead of this
            }
            else
            {
                foreach (var oneFox in foxListService.ListOfFoxes)
                {
                    if (oneFox.Name == name)
                    {
                        return RedirectToAction("Index", new { name = name });   // is there a way without sending/receiving object? is it ok?
                    }
                }

                Fox selectedFox = new Fox(name);
                foxListService.ListOfFoxes.Add(selectedFox);
                return RedirectToAction("Index", new { name = name });

                //return RedirectToAction("Index", selectedFox);
                //return View("Index", selectedFox);
            }
        }

        [Route("info")]
        //public IActionResult Index(Fox selectedFox)
        public IActionResult Index(string name) 

        {
            return View(foxListService.GetFoxByName(name));
            //return View(selectedFox);
        }

        [HttpGet]
        [Route("nutritionstore")]
        public IActionResult NutritionStore(string name)
        //public IActionResult NutritionStore(Fox fox)

        {

            //return View(name as object);
            return View(foxListService.GetFoxByName(name));

        }

        [HttpPost]
        [Route("nutritionstore")]
        public IActionResult NutritionStore(string food, string drink, string name)
        {
            //string name = Request.Query["name"];
            Fox currentFox = foxListService.GetFoxByName(name);
            currentFox.Food = food;
            currentFox.Drink = drink;


            //return RedirectToAction("Index", currentFox);
            return RedirectToAction("Index", new { name = name });

        }

        [HttpGet]
        [Route("trickcenter")]
        public IActionResult TrickCenter(string name)
        //public IActionResult TrickCenter(Fox fox)

        {

            //return View(name as object);
            return View(foxListService.GetFoxByName(name));
        }

        [HttpPost]
        [Route("trickcenter")]
        public IActionResult TrickCenter(string trick, string name)
        {
            Fox currentFox = foxListService.GetFoxByName(name);
            currentFox.ListOfTricks.Add(trick);


            //return RedirectToAction("Index", currentFox);
            return RedirectToAction("Index", new { name = name });

        }

    }
}