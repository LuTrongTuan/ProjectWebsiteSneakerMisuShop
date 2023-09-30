using BE_SneakrerMisuShop.Enitites.EntitiBases;
using BE_SneakrerMisuShop.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_SneakrerMisuShop.Models
{
    public class ProductImage: FullAuditedAggregateRoot
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
    }
}
