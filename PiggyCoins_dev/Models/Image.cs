namespace PiggyCoins_dev.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public Product? Product { get; set; }
    }
}
