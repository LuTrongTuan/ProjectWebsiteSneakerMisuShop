using BE_SneakrerMisuShop.Enitites;
using BE_SneakrerMisuShop.Enitites.EntitiBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Models
{
    public class Color: FullAuditedAggregateRoot
    {
        [Required]
        public string Name { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
