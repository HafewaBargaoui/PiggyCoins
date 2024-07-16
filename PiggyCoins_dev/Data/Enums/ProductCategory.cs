using System.ComponentModel.DataAnnotations;

namespace PiggyCoins_dev.Data
{
    public enum ProductCategory
    {
        [Display(Name = "Piggy")]
        Piggy =1,
        [Display(Name = "Kids")]
        Kids =2,
        [Display(Name = "Original")]
        Original =3
    }
}
