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
            var categoryNames = Enum.GetNames(typeof(ProductCategory)).ToList();
            var viewModel = new HomeViewModel
            {
                // Load products from the database
                Products = await _context.Products.Include(p => p.Images).ToListAsync(),
                CategoryNames = categoryNames
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> AllProducts()
        {
            // Récupérer les produits depuis la base de données
            var products = await _context.Products.Include(p => p.Images).ToListAsync();

            // Passer les produits à la vue
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
