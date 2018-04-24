using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Models;
using DIData;
using Homes;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {





        public static double Average(int a, int b)
        {
            return (a + b) / 2;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Average(2, 1));
        }


        public void sort(int a, int b)
        {
            if (a>b)

        }

        public IActionResult Index()
        {





            SingleFamily sf = new SingleFamily();
            HomeFactory homeFactory = new Homes.HomeFactory(sf);
            Home singleFamily=homeFactory.BuildTheHome();


            Ranch ranch = new Ranch();
            homeFactory = new HomeFactory(ranch);
            Home ranchHome = homeFactory.BuildTheHome();

            //Logger l = new Logger();
            //LoggerFactory lf = new LoggerFactory(l);
            //lf.NotifyLog("");
            //l.Number = 5;
            //var test = l.total;
            //l.Number = 4;
            //var t = l.total;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
