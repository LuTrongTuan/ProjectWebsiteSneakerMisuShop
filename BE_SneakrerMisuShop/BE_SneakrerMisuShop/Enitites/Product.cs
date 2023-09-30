using BE_SneakrerMisuShop.Enitites;
using BE_SneakrerMisuShop.Enitites.EntitiBases;
using BE_SneakrerMisuShop.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BE_SneakrerMisuShop.Entities
{
    public class Product : FullAuditedAggregateRoot
    {
        [Required]
        public int BranchId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Origin { get; set; }
        public string? Material { get; set; }
        public string? Sole { get; set; }

        [ForeignKey(nameof(BranchId))]
        public Brand Brand { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public ICollection<ProductDetail> ProductDetails { get; set;}
        public ICollection<ProductImage> ProductImages { get; set; }
    }
}
