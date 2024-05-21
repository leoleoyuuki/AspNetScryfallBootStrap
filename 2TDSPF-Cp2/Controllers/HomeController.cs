using _2TDSPF_Cp2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace _2TDSPF_Cp2.Controllers
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

        public IActionResult Scryfall()
        {

            Scryfall card = new Scryfall();
            card.Image = "https://cards.scryfall.io/large/front/7/b/7baf9549-1869-4bd3-a52a-2f0b30ba0b16.jpg?1714487768";
            card.Name = "Herigast, Erupting Nullkite";
            card.Type = "Legendary Creature — Eldrazi Dragon";
            card.Description = "Emerge (You may cast this spell by sacrificing a creature and paying the emerge cost reduced by that creature’s mana value.)\r\n                    When you cast this spell, you may exile your hand. If you do, draw three cards.\r\n                    Flying\r\n                    Each creature spell you cast has emerge. The emerge cost is equal to its mana cost.";
            card.Stats = "6/6";
            card.News = " This card will be released on 2024-06-07, it is not legal in any format until its release date approaches.";
            card.Artist = "Illustrated by Lucas Graciano\r\n\r\n";
            return View(card);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
