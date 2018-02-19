using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyHobbies;

namespace OefMVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return $"Welkom!";
        }

        public ViewResult Lijst()
        {
            List<Band> bands = new List<Band>
            {
                new Band("one", 1956, new List<Lid>{
                    new Lid("bla", 50, "male", true),
                    new Lid("bleh", 24, "male", false)}),
                new Band("two", 2005, new List<Lid>{
                    new Lid("bloep", 45, "female", true),
                    new Lid("bliep", 56, "female", true)})
            };
            ViewBag.Bands = bands;
            return View();
        }

        public ViewResult Maak(string naam, int jaar)
        {
            Band band = new Band(naam, jaar);
            ViewBag.Band = band;
            return View();
        }
    }
}