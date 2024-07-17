using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PiggyCoins_dev.Models;
using System.Diagnostics;
using PiggyCoins_dev.ViewModels;
using PiggyCoins_dev.Data;


namespace PiggyCoins_dev.Controllers
{
    public class HomeController : Controller
    {
        private readonly PiggyCoinsContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, PiggyCoinsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new HomeViewModel
            {
                // Chargement des produits depuis la base de données
                //Products = await _context.Products.ToListAsync()

                 Products = await _context.Products.Include(p => p.Images).ToListAsync()
            };
            return View(viewModel);
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
