﻿using System.ComponentModel.DataAnnotations;
using PiggyCoins_dev.Data;
namespace PiggyCoins_dev.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal Weight { get; set; }
        public int Capacity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Color? Color { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public DateTime AddedDate { get; set; }
        public ICollection<Image>? Images { get; set; }
    }
}
