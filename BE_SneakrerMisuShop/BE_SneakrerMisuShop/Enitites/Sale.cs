using BE_SneakrerMisuShop.Enitites.EntitiBases;
using System.ComponentModel.DataAnnotations;

namespace BE_SneakrerMisuShop.Enitites
{
    public class Sale: FullAuditedAggregateRoot
    {
        [Required]
        public string Code { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Value { get; set; }
        [Required]
        public DateTime EffectiveDate { get; set; }
        [Required]
        public DateTime ExpiredDate { get; set; }
        public ICollection<DetailSale> DetailSales { get; set; }
    }
}
