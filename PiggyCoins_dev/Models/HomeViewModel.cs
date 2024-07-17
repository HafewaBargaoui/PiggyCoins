using PiggyCoins_dev.Data;
using PiggyCoins_dev.Models;

namespace PiggyCoins_dev.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public List<string> CategoryNames { get; set; }

        public HomeViewModel()
        {
            Products = new List<Product>();
            CategoryNames = new List<string>();

        }
    }
}
