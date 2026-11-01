using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameStore.Controllers
{
    public class GamesController : Controller
    {
        // // Displays all games
        public IActionResult Index()
        {
            return View();
        }

        // Displays PlayStation games
        public IActionResult PlayStation()
        {
            return View();
        }

        //Display Xbox games
        public IActionResult Xbox()
        {
            return View();
        }


        //Displays Nintendo games
        public IActionResult Nintendo()
        {
            return View();
        }

    }

}