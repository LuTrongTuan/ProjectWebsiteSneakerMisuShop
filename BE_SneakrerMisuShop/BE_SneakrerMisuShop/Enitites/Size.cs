using BE_SneakrerMisuShop.Enitites.EntitiBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Enitites
{
    public class Size: FullAuditedAggregateRoot
    {
        [Required]
        public string Name { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set; }
    }
}
