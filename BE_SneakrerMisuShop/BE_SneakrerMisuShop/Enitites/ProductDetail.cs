using BE_SneakrerMisuShop.Enitites.EntitiBases;
using BE_SneakrerMisuShop.Entities;
using BE_SneakrerMisuShop.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using Color = BE_SneakrerMisuShop.Models.Color;

namespace BE_SneakrerMisuShop.Enitites
{
    public class ProductDetail: FullAuditedAggregateRoot
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int SizeId { get; set; }
        [Required]
        public int ColorId { get; set; }
        [Required]
        public string Sku { get; set; }
        [Required]
        public decimal ImportPrice { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Amount { get; set; }
        public bool? isChecked { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        [ForeignKey(nameof(SizeId))]
        public Size Size { get; set; }

        [ForeignKey(nameof(ColorId))]
        public Color Color { get; set; }
        public ICollection<DetailSale> DetailSales { get; set; }
        
    }
}
