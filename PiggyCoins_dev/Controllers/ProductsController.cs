using Microsoft.AspNetCore.Mvc;
using PiggyCoins_dev.Data;
using System;
using System.Drawing.Text;

namespace PiggyCoins_dev.Controllers
{
    public class ProductsController : Controller
    {
        private readonly PiggyCoinsContext _context;
        public ProductsController(PiggyCoinsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
        var data = _context.Products.ToList();
            return View(data);
        }
    }
}
