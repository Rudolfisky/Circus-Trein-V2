using Circus_Trein_V2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Logic;

namespace Circus_Trein_V2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AnimalForm(int CS, int CM, int CL, int HS, int HM, int HL)
        {
            int[] animals = { CS, CM, CL, HS, HM, HL };
            // Train train = Sort.SortAnimals(animals)
            //ViewBag.TotalAnimals = animals.Sum();
            //Train train = new Train(animals);

            Sort sorter = new Sort();
            //Train train = new Train(sorter.Start(animals));
            Train train = sorter.Start(animals);

            ViewBag.TotalAnimals = train.GetAllAnimals().Count();
            ViewBag.TotalWagons = train.GetAllWagons().Count();

            return View("Index");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
