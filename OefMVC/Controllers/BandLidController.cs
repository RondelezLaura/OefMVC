using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace OefMVC.Controllers
{
    public class BandLidController : Controller
    {
        public string Index()
        {
            return $"Welkom!";
        }

        public ViewResult Lijst()
        {
            List<Lid> leden = new List<Lid>{
                    new Lid("bla", 50, "male", true),
                    new Lid("bleh", 24, "male", false)
            };
            ViewBag.Leden = leden;
            return View();
        }

        public ViewResult Maak(string naam, string geslacht, Band band)
        {
            Lid lid = new Lid(naam, geslacht, band);
            ViewBag.Lid = lid;
            return View();
        }
    }
}