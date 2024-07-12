using PiggyCoins_dev.Models;

namespace PiggyCoins_dev.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public HomeViewModel()
        {
            Products = new List<Product>();
        }
    }
}
