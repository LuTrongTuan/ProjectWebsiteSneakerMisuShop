using BE_SneakrerMisuShop.Enitites.EntitiBases;
using BE_SneakrerMisuShop.Entities;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Models
{
    public class Brand: FullAuditedAggregateRoot
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
